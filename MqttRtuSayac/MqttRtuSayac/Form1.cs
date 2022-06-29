using Modbus.Device;
using System.IO.Ports;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MqttRtuSayac
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = null;
        private string temp;
        private int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //form ilk ekrana geldiðinde gerekli kontrollerin yapýlmasý için 
            //butonlarýn enable özellikleri ve checkhboxýn görünürlüðü false deðeri verilerek butonlara basýlmasý engellenir. 
            holdingRegOku.Enabled = false;
            inputRegister.Enabled = false;
            baglantiKes.Enabled = false;
            //Baðlý olan seri portlarý getirir.
            portGetir();
        }

        private void portGetir()
        {
            string[] portlar = SerialPort.GetPortNames();
            foreach (string portAdi in portlar)
            {
                portNum.Items.Add(portAdi);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                serialPort = new SerialPort(Convert.ToString(portNum.SelectedItem), Convert.ToInt32(baudRate.SelectedItem), Parity.None, 8, StopBits.One);
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
            holdingRegOku.Enabled = true;
            inputRegister.Enabled = true;
            baglan.Enabled = false;
            baglantiKes.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //---------------------------------------
            //timer canli veri check olduðunda holding registerlarýný okuyan butonu çalýþtýrýr.
            //Bu þekilde buton döngü þeklinde çalýþmýþ olur.
            //---------------------------------------
            // holdingRegOku_Click(sender, e);
            publishMqtt_Click(sender, e);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Select(textBox1.TextLength, 0);
            textBox1.ScrollToCaret();
        }

        private void receiveMqtt_Click_1(object sender, EventArgs e)
        {
            MqttClient mqttClientRecieve = new MqttClient("broker.hivemq.com");
            mqttClientRecieve.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            string clientId = Guid.NewGuid().ToString();

            mqttClientRecieve.Connect(clientId);
            mqttClientRecieve.Subscribe(new string[] { "test/deneme" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            //birden fazla topic varsa hata veiyormuþ
        }
        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            IModbusMaster masterRtuTogg = ModbusSerialMaster.CreateRtu(serialPort);
            var message = Encoding.Default.GetString(e.Message);
            switch (message)
            {
                case "1":
                    masterRtuTogg.WriteSingleCoil(1, 0, true);
                    break;
                case "0":
                    masterRtuTogg.WriteSingleCoil(1, 0, false);
                    break;
                case "ledAc":
                    masterRtuTogg.WriteSingleCoil(1, 1, true);
                    break;
                case "ledKapa":
                    masterRtuTogg.WriteSingleCoil(1, 1, false);
                    break;
                default:
                    MessageBox.Show("Geçersiz Ýstek");
                    break;
            }
        }
        private void baglantiKes_Click_1(object sender, EventArgs e)
        {
            serialPort.Close();
            baglan.Enabled = true;
            holdingRegOku.Enabled = false;
            inputRegister.Enabled = false;
            timer1.Stop();
            degerSifirlama();
            textBoxTemizleme();
            modbusAdresi.Clear();
            textBox1.Clear();
            portNum.SelectedIndex = -1;
            baudRate.SelectedIndex = -1;
        }

        private void textBoxTemizleme()
        {
            wattSaat_yuksekGerilim.Text = Convert.ToString("0");
            watSaat_dusukGerilim.Text = Convert.ToString("0");
            gerilim.Text = Convert.ToString("0");
            akim.Text = Convert.ToString("0");
            powerFactor.Text = Convert.ToString("0");
            frekans.Text = Convert.ToString("0");
            aktifGuc.Text = Convert.ToString("0");
            reaktifGuc.Text = Convert.ToString("0");
            gorunurGuc.Text = Convert.ToString("0");
        }

        private void degerSifirlama()
        {
            watsaatYuksek.Value = 0;
            watsaatAlcak.Value = 0;
            gerilimProgressbar.Value = 0;
            akimProgressbar.Value = 0;
            frekansProgressbar.Value = 0;
            powerfactorProgressbar.Value = 0;
            aktifgucProgressbar.Value = 0;
            reaktifgucProgressbar.Value = 0;
            gorunurgucProgressbar.Value = 0;
        }

        private void publishMqtt_Click(object sender, EventArgs e)
        {
            //Düzenlenicek
            holdingRegOku_Click_1(sender, e);
        }

        private static void publishMqttFunc(string message)
        {
            MqttClient mqttClient = new MqttClient("broker.hivemq.com");
            string clientId = Guid.NewGuid().ToString();
            mqttClient.Connect(clientId);
            string topic = "test/deneme";
            mqttClient.Publish(topic, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void holdRegisterOku()
        {
            byte slaveAdres = 95;
            ushort baslamaAdres = 1;
            ushort boyut = 12;
            try
            {
                IModbusMaster masterRtu = ModbusSerialMaster.CreateRtu(serialPort);
                ushort[] cikti = masterRtu.ReadHoldingRegisters(slaveAdres, baslamaAdres, boyut);
                //----------------------------------------------------------------------
                //ProgressBar deðer atamalarý Rtu sayaç üzerinden çekilen veriler dahilinde.
                //----------------------------------------------------------------------
                watsaatYuksek.Value = cikti[3];
                watsaatAlcak.Value = cikti[4];
                gerilimProgressbar.Value = Convert.ToInt32(cikti[5]) / 100;
                akimProgressbar.Value = cikti[6];
                frekansProgressbar.Value = cikti[7];
                powerfactorProgressbar.Value = cikti[8];
                aktifgucProgressbar.Value = cikti[9];
                reaktifgucProgressbar.Value = (int)cikti[10];
                gorunurgucProgressbar.Value = cikti[11];
                //----------------------------------------------------------------------
                //ProgressBar içerisindeki textlere rtu sayaç üzerinden çekilen verilen atýlmasý.
                //----------------------------------------------------------------------
                wattSaat_yuksekGerilim.Text = Convert.ToString(cikti[3]);
                watSaat_dusukGerilim.Text = String.Format("{0} ", cikti[4]);
                gerilim.Text = String.Format("{0} ", Convert.ToInt32(cikti[5]) / 100);
                akim.Text = String.Format("{0} ", cikti[6]);
                frekans.Text = String.Format("{0} ", Convert.ToInt32(cikti[7]) / 100);
                powerFactor.Text = String.Format("{0} ", Convert.ToInt32(cikti[8]) / 1000);
                aktifGuc.Text = String.Format("{0} ", Convert.ToInt32(cikti[9]) / 100);
                reaktifGuc.Text = String.Format("{0} ", Convert.ToInt32(cikti[10]) / 100);
                //----------------------------------------------------------------------
                //Modbus Adresini Textboxa yazdýrma iþlemi
                //----------------------------------------------------------------------
                foreach (ushort veri in cikti)
                {
                    textBox1.Text += String.Format("{0}/ ", veri);
                    sayac++;
                }
                if (sayac % 12 == 0)
                {
                    temp = textBox1.Text;
                    FileStream fs = new FileStream(@"C:\Users\ykarakaya\Desktop\Holding Register.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(temp);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
                modbusAdresi.Text = Convert.ToString(cikti[0], 16);
                string pubEdilecek = "";
                pubEdilecek = "Akým :"+akim.Text + "/" + "Gerilim : "+ gerilim.Text + "/" +"Frekans :"+ frekans.Text;
                publishMqttFunc(pubEdilecek);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void inputRegister_Click(object sender, EventArgs e)
        {
            IModbusMaster masterRtuInput = ModbusSerialMaster.CreateRtu(serialPort);
            ushort[] ciktiInput = masterRtuInput.ReadInputRegisters(1, 0, 6);
            foreach (ushort veri in ciktiInput)
            {
                textBox1.Text += String.Format("{0}/ ", veri);
                sayac++;
            }
            if (sayac % 6 == 0)
            {
                temp = textBox1.Text;

                FileStream fs = new FileStream(@"C:\Users\ykarakaya\Desktop\Input Register.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(temp);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void holdingRegOku_Click_1(object sender, EventArgs e)
        {
            holdRegisterOku();
        }

    }
}