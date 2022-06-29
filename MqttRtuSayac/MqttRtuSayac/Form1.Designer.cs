namespace MqttRtuSayac
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.receiveMqtt = new System.Windows.Forms.Button();
            this.publishMqtt = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.inputRegister = new System.Windows.Forms.Button();
            this.baglantiKes = new System.Windows.Forms.Button();
            this.baglan = new System.Windows.Forms.Button();
            this.baudRate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portNum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.portNo = new System.Windows.Forms.Label();
            this.gerilimProgressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gerilim = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gorunurgucProgressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.gorunurGuc = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.powerfactorProgressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.powerFactor = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.reaktifgucProgressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.reaktifGuc = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.aktifgucProgressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.aktifGuc = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.frekansProgressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.frekans = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.akimProgressbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.akim = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.watsaatAlcak = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.watSaat_dusukGerilim = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.watsaatYuksek = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.wattSaat_yuksekGerilim = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.modbusAdresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.holdingRegOku = new System.Windows.Forms.Button();
            this.gerilimProgressbar.SuspendLayout();
            this.gorunurgucProgressbar.SuspendLayout();
            this.powerfactorProgressbar.SuspendLayout();
            this.reaktifgucProgressbar.SuspendLayout();
            this.aktifgucProgressbar.SuspendLayout();
            this.frekansProgressbar.SuspendLayout();
            this.akimProgressbar.SuspendLayout();
            this.watsaatAlcak.SuspendLayout();
            this.watsaatYuksek.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // receiveMqtt
            // 
            this.receiveMqtt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiveMqtt.Location = new System.Drawing.Point(1014, 225);
            this.receiveMqtt.Name = "receiveMqtt";
            this.receiveMqtt.Size = new System.Drawing.Size(117, 47);
            this.receiveMqtt.TabIndex = 100;
            this.receiveMqtt.Text = "ReceiveMqtt";
            this.receiveMqtt.UseVisualStyleBackColor = true;
            this.receiveMqtt.UseWaitCursor = true;
            this.receiveMqtt.Click += new System.EventHandler(this.receiveMqtt_Click_1);
            // 
            // publishMqtt
            // 
            this.publishMqtt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publishMqtt.Location = new System.Drawing.Point(851, 225);
            this.publishMqtt.Name = "publishMqtt";
            this.publishMqtt.Size = new System.Drawing.Size(117, 47);
            this.publishMqtt.TabIndex = 99;
            this.publishMqtt.Text = "PublishMqtt";
            this.publishMqtt.UseVisualStyleBackColor = true;
            this.publishMqtt.UseWaitCursor = true;
            this.publishMqtt.Click += new System.EventHandler(this.publishMqtt_Click);
            // 
            // temizle
            // 
            this.temizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temizle.Location = new System.Drawing.Point(28, 374);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(93, 47);
            this.temizle.TabIndex = 98;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.UseWaitCursor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // inputRegister
            // 
            this.inputRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputRegister.Location = new System.Drawing.Point(139, 436);
            this.inputRegister.Name = "inputRegister";
            this.inputRegister.Size = new System.Drawing.Size(209, 53);
            this.inputRegister.TabIndex = 95;
            this.inputRegister.Text = "Input Registerlarını Oku";
            this.inputRegister.UseVisualStyleBackColor = true;
            this.inputRegister.UseWaitCursor = true;
            this.inputRegister.Click += new System.EventHandler(this.inputRegister_Click);
            // 
            // baglantiKes
            // 
            this.baglantiKes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.baglantiKes.Location = new System.Drawing.Point(851, 145);
            this.baglantiKes.Name = "baglantiKes";
            this.baglantiKes.Size = new System.Drawing.Size(117, 47);
            this.baglantiKes.TabIndex = 91;
            this.baglantiKes.Text = "Bağlantıyı Kes";
            this.baglantiKes.UseVisualStyleBackColor = true;
            this.baglantiKes.UseWaitCursor = true;
            this.baglantiKes.Click += new System.EventHandler(this.baglantiKes_Click_1);
            // 
            // baglan
            // 
            this.baglan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.baglan.Location = new System.Drawing.Point(997, 145);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(93, 47);
            this.baglan.TabIndex = 90;
            this.baglan.Text = "Bağlan";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.UseWaitCursor = true;
            this.baglan.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // baudRate
            // 
            this.baudRate.BackColor = System.Drawing.Color.Transparent;
            this.baudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baudRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baudRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.baudRate.ItemHeight = 30;
            this.baudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.baudRate.Location = new System.Drawing.Point(955, 85);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(135, 36);
            this.baudRate.TabIndex = 89;
            this.baudRate.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(851, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Baud Rate :";
            this.label3.UseWaitCursor = true;
            // 
            // portNum
            // 
            this.portNum.BackColor = System.Drawing.Color.Transparent;
            this.portNum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.portNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portNum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.portNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.portNum.ItemHeight = 30;
            this.portNum.Location = new System.Drawing.Point(955, 37);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(135, 36);
            this.portNum.TabIndex = 87;
            this.portNum.UseWaitCursor = true;
            // 
            // portNo
            // 
            this.portNo.AutoSize = true;
            this.portNo.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portNo.Location = new System.Drawing.Point(851, 47);
            this.portNo.Name = "portNo";
            this.portNo.Size = new System.Drawing.Size(98, 17);
            this.portNo.TabIndex = 86;
            this.portNo.Text = "Port Num :";
            this.portNo.UseWaitCursor = true;
            // 
            // gerilimProgressbar
            // 
            this.gerilimProgressbar.Controls.Add(this.gerilim);
            this.gerilimProgressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gerilimProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gerilimProgressbar.ForeColor = System.Drawing.Color.White;
            this.gerilimProgressbar.Location = new System.Drawing.Point(695, 61);
            this.gerilimProgressbar.Maximum = 655;
            this.gerilimProgressbar.Minimum = 0;
            this.gerilimProgressbar.Name = "gerilimProgressbar";
            this.gerilimProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gerilimProgressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gerilimProgressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gerilimProgressbar.Size = new System.Drawing.Size(119, 119);
            this.gerilimProgressbar.TabIndex = 85;
            this.gerilimProgressbar.UseWaitCursor = true;
            // 
            // gerilim
            // 
            this.gerilim.AutoSize = true;
            this.gerilim.BackColor = System.Drawing.SystemColors.Control;
            this.gerilim.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gerilim.ForeColor = System.Drawing.Color.Black;
            this.gerilim.Location = new System.Drawing.Point(46, 47);
            this.gerilim.Margin = new System.Windows.Forms.Padding(0);
            this.gerilim.Name = "gerilim";
            this.gerilim.Size = new System.Drawing.Size(26, 27);
            this.gerilim.TabIndex = 1;
            this.gerilim.Text = "0";
            this.gerilim.UseWaitCursor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(698, 191);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 17);
            this.label19.TabIndex = 81;
            this.label19.Text = "Power Factor";
            this.label19.UseWaitCursor = true;
            // 
            // gorunurgucProgressbar
            // 
            this.gorunurgucProgressbar.Controls.Add(this.gorunurGuc);
            this.gorunurgucProgressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gorunurgucProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gorunurgucProgressbar.ForeColor = System.Drawing.Color.White;
            this.gorunurgucProgressbar.Location = new System.Drawing.Point(695, 371);
            this.gorunurgucProgressbar.Maximum = 15258;
            this.gorunurgucProgressbar.Minimum = 0;
            this.gorunurgucProgressbar.Name = "gorunurgucProgressbar";
            this.gorunurgucProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gorunurgucProgressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gorunurgucProgressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gorunurgucProgressbar.Size = new System.Drawing.Size(119, 119);
            this.gorunurgucProgressbar.TabIndex = 84;
            this.gorunurgucProgressbar.UseWaitCursor = true;
            // 
            // gorunurGuc
            // 
            this.gorunurGuc.AutoSize = true;
            this.gorunurGuc.BackColor = System.Drawing.SystemColors.Control;
            this.gorunurGuc.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gorunurGuc.ForeColor = System.Drawing.Color.Black;
            this.gorunurGuc.Location = new System.Drawing.Point(46, 47);
            this.gorunurGuc.Name = "gorunurGuc";
            this.gorunurGuc.Size = new System.Drawing.Size(26, 27);
            this.gorunurGuc.TabIndex = 7;
            this.gorunurGuc.Text = "0";
            this.gorunurGuc.UseWaitCursor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(704, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 17);
            this.label17.TabIndex = 83;
            this.label17.Text = "Görünür Güç";
            this.label17.UseWaitCursor = true;
            // 
            // powerfactorProgressbar
            // 
            this.powerfactorProgressbar.Controls.Add(this.powerFactor);
            this.powerfactorProgressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.powerfactorProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.powerfactorProgressbar.ForeColor = System.Drawing.Color.White;
            this.powerfactorProgressbar.Location = new System.Drawing.Point(695, 213);
            this.powerfactorProgressbar.Maximum = 15258;
            this.powerfactorProgressbar.Minimum = 0;
            this.powerfactorProgressbar.Name = "powerfactorProgressbar";
            this.powerfactorProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.powerfactorProgressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.powerfactorProgressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.powerfactorProgressbar.Size = new System.Drawing.Size(119, 119);
            this.powerfactorProgressbar.TabIndex = 82;
            this.powerfactorProgressbar.UseWaitCursor = true;
            // 
            // powerFactor
            // 
            this.powerFactor.AutoSize = true;
            this.powerFactor.BackColor = System.Drawing.SystemColors.Control;
            this.powerFactor.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.powerFactor.ForeColor = System.Drawing.Color.Black;
            this.powerFactor.Location = new System.Drawing.Point(46, 47);
            this.powerFactor.Name = "powerFactor";
            this.powerFactor.Size = new System.Drawing.Size(26, 27);
            this.powerFactor.TabIndex = 6;
            this.powerFactor.Text = "0";
            this.powerFactor.UseWaitCursor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(718, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 17);
            this.label21.TabIndex = 80;
            this.label21.Text = "Gerilim";
            this.label21.UseWaitCursor = true;
            // 
            // reaktifgucProgressbar
            // 
            this.reaktifgucProgressbar.Controls.Add(this.reaktifGuc);
            this.reaktifgucProgressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.reaktifgucProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reaktifgucProgressbar.ForeColor = System.Drawing.Color.White;
            this.reaktifgucProgressbar.Location = new System.Drawing.Point(543, 371);
            this.reaktifgucProgressbar.Maximum = 15258;
            this.reaktifgucProgressbar.Minimum = 0;
            this.reaktifgucProgressbar.Name = "reaktifgucProgressbar";
            this.reaktifgucProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reaktifgucProgressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reaktifgucProgressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.reaktifgucProgressbar.Size = new System.Drawing.Size(119, 119);
            this.reaktifgucProgressbar.TabIndex = 79;
            this.reaktifgucProgressbar.UseWaitCursor = true;
            // 
            // reaktifGuc
            // 
            this.reaktifGuc.AutoSize = true;
            this.reaktifGuc.BackColor = System.Drawing.SystemColors.Control;
            this.reaktifGuc.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reaktifGuc.ForeColor = System.Drawing.Color.Black;
            this.reaktifGuc.Location = new System.Drawing.Point(45, 47);
            this.reaktifGuc.Name = "reaktifGuc";
            this.reaktifGuc.Size = new System.Drawing.Size(26, 27);
            this.reaktifGuc.TabIndex = 6;
            this.reaktifGuc.Text = "0";
            this.reaktifGuc.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(549, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "Reaktif Güç";
            this.label14.UseWaitCursor = true;
            // 
            // aktifgucProgressbar
            // 
            this.aktifgucProgressbar.Controls.Add(this.aktifGuc);
            this.aktifgucProgressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.aktifgucProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aktifgucProgressbar.ForeColor = System.Drawing.Color.White;
            this.aktifgucProgressbar.Location = new System.Drawing.Point(399, 371);
            this.aktifgucProgressbar.Maximum = 15258;
            this.aktifgucProgressbar.Minimum = 0;
            this.aktifgucProgressbar.Name = "aktifgucProgressbar";
            this.aktifgucProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aktifgucProgressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aktifgucProgressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.aktifgucProgressbar.Size = new System.Drawing.Size(119, 119);
            this.aktifgucProgressbar.TabIndex = 77;
            this.aktifgucProgressbar.UseWaitCursor = true;
            // 
            // aktifGuc
            // 
            this.aktifGuc.AutoSize = true;
            this.aktifGuc.BackColor = System.Drawing.SystemColors.Control;
            this.aktifGuc.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aktifGuc.ForeColor = System.Drawing.Color.Black;
            this.aktifGuc.Location = new System.Drawing.Point(46, 47);
            this.aktifGuc.Name = "aktifGuc";
            this.aktifGuc.Size = new System.Drawing.Size(26, 27);
            this.aktifGuc.TabIndex = 5;
            this.aktifGuc.Text = "0";
            this.aktifGuc.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(414, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 76;
            this.label15.Text = "Aktif Güç";
            this.label15.UseWaitCursor = true;
            // 
            // frekansProgressbar
            // 
            this.frekansProgressbar.Controls.Add(this.frekans);
            this.frekansProgressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.frekansProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frekansProgressbar.ForeColor = System.Drawing.Color.White;
            this.frekansProgressbar.Location = new System.Drawing.Point(543, 213);
            this.frekansProgressbar.Maximum = 15258;
            this.frekansProgressbar.Minimum = 0;
            this.frekansProgressbar.Name = "frekansProgressbar";
            this.frekansProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.frekansProgressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.frekansProgressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.frekansProgressbar.Size = new System.Drawing.Size(119, 119);
            this.frekansProgressbar.TabIndex = 75;
            this.frekansProgressbar.UseWaitCursor = true;
            // 
            // frekans
            // 
            this.frekans.AutoSize = true;
            this.frekans.BackColor = System.Drawing.SystemColors.Control;
            this.frekans.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frekans.ForeColor = System.Drawing.Color.Black;
            this.frekans.Location = new System.Drawing.Point(45, 48);
            this.frekans.Name = "frekans";
            this.frekans.Size = new System.Drawing.Size(26, 27);
            this.frekans.TabIndex = 5;
            this.frekans.Text = "0";
            this.frekans.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(567, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 74;
            this.label12.Text = "Frekans";
            this.label12.UseWaitCursor = true;
            // 
            // akimProgressbar
            // 
            this.akimProgressbar.Controls.Add(this.akim);
            this.akimProgressbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.akimProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.akimProgressbar.ForeColor = System.Drawing.Color.White;
            this.akimProgressbar.Location = new System.Drawing.Point(399, 213);
            this.akimProgressbar.Maximum = 15258;
            this.akimProgressbar.Minimum = 0;
            this.akimProgressbar.Name = "akimProgressbar";
            this.akimProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.akimProgressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.akimProgressbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.akimProgressbar.Size = new System.Drawing.Size(119, 119);
            this.akimProgressbar.TabIndex = 73;
            this.akimProgressbar.UseWaitCursor = true;
            // 
            // akim
            // 
            this.akim.AutoSize = true;
            this.akim.BackColor = System.Drawing.SystemColors.Control;
            this.akim.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.akim.ForeColor = System.Drawing.Color.Black;
            this.akim.Location = new System.Drawing.Point(46, 48);
            this.akim.Name = "akim";
            this.akim.Size = new System.Drawing.Size(26, 27);
            this.akim.TabIndex = 4;
            this.akim.Text = "0";
            this.akim.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(434, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 72;
            this.label13.Text = "Akım";
            this.label13.UseWaitCursor = true;
            // 
            // watsaatAlcak
            // 
            this.watsaatAlcak.Controls.Add(this.watSaat_dusukGerilim);
            this.watsaatAlcak.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.watsaatAlcak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.watsaatAlcak.ForeColor = System.Drawing.Color.White;
            this.watsaatAlcak.Location = new System.Drawing.Point(543, 61);
            this.watsaatAlcak.Maximum = 65535;
            this.watsaatAlcak.Minimum = 0;
            this.watsaatAlcak.Name = "watsaatAlcak";
            this.watsaatAlcak.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.watsaatAlcak.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.watsaatAlcak.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.watsaatAlcak.Size = new System.Drawing.Size(119, 119);
            this.watsaatAlcak.TabIndex = 71;
            this.watsaatAlcak.UseWaitCursor = true;
            // 
            // watSaat_dusukGerilim
            // 
            this.watSaat_dusukGerilim.AutoSize = true;
            this.watSaat_dusukGerilim.BackColor = System.Drawing.SystemColors.Control;
            this.watSaat_dusukGerilim.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.watSaat_dusukGerilim.ForeColor = System.Drawing.Color.Black;
            this.watSaat_dusukGerilim.Location = new System.Drawing.Point(45, 47);
            this.watSaat_dusukGerilim.Name = "watSaat_dusukGerilim";
            this.watSaat_dusukGerilim.Size = new System.Drawing.Size(26, 27);
            this.watSaat_dusukGerilim.TabIndex = 2;
            this.watSaat_dusukGerilim.Text = "0";
            this.watSaat_dusukGerilim.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(544, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "Watt/Saat Düşük";
            this.label11.UseWaitCursor = true;
            // 
            // watsaatYuksek
            // 
            this.watsaatYuksek.Controls.Add(this.wattSaat_yuksekGerilim);
            this.watsaatYuksek.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.watsaatYuksek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.watsaatYuksek.ForeColor = System.Drawing.Color.White;
            this.watsaatYuksek.Location = new System.Drawing.Point(399, 61);
            this.watsaatYuksek.Maximum = 15258;
            this.watsaatYuksek.Minimum = 0;
            this.watsaatYuksek.Name = "watsaatYuksek";
            this.watsaatYuksek.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.watsaatYuksek.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.watsaatYuksek.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.watsaatYuksek.Size = new System.Drawing.Size(119, 119);
            this.watsaatYuksek.TabIndex = 69;
            this.watsaatYuksek.UseWaitCursor = true;
            // 
            // wattSaat_yuksekGerilim
            // 
            this.wattSaat_yuksekGerilim.AutoSize = true;
            this.wattSaat_yuksekGerilim.BackColor = System.Drawing.SystemColors.Control;
            this.wattSaat_yuksekGerilim.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wattSaat_yuksekGerilim.ForeColor = System.Drawing.Color.Black;
            this.wattSaat_yuksekGerilim.Location = new System.Drawing.Point(46, 47);
            this.wattSaat_yuksekGerilim.Name = "wattSaat_yuksekGerilim";
            this.wattSaat_yuksekGerilim.Size = new System.Drawing.Size(26, 27);
            this.wattSaat_yuksekGerilim.TabIndex = 3;
            this.wattSaat_yuksekGerilim.Text = "0";
            this.wattSaat_yuksekGerilim.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Modbus Adresi :";
            this.label10.UseWaitCursor = true;
            // 
            // modbusAdresi
            // 
            this.modbusAdresi.Location = new System.Drawing.Point(41, 325);
            this.modbusAdresi.Name = "modbusAdresi";
            this.modbusAdresi.Size = new System.Drawing.Size(308, 27);
            this.modbusAdresi.TabIndex = 67;
            this.modbusAdresi.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial monospaced for SAP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(386, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Watt/Saat Yüksek";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 35);
            this.label1.TabIndex = 65;
            this.label1.Text = "Modbus Register Adresleri";
            this.label1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(41, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 233);
            this.textBox1.TabIndex = 64;
            this.textBox1.UseWaitCursor = true;
            // 
            // holdingRegOku
            // 
            this.holdingRegOku.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.holdingRegOku.Location = new System.Drawing.Point(139, 371);
            this.holdingRegOku.Name = "holdingRegOku";
            this.holdingRegOku.Size = new System.Drawing.Size(209, 53);
            this.holdingRegOku.TabIndex = 63;
            this.holdingRegOku.Text = "Holding Registerlarını Oku";
            this.holdingRegOku.UseVisualStyleBackColor = true;
            this.holdingRegOku.UseWaitCursor = true;
            this.holdingRegOku.Click += new System.EventHandler(this.holdingRegOku_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 540);
            this.Controls.Add(this.receiveMqtt);
            this.Controls.Add(this.publishMqtt);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.inputRegister);
            this.Controls.Add(this.baglantiKes);
            this.Controls.Add(this.baglan);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portNum);
            this.Controls.Add(this.portNo);
            this.Controls.Add(this.gerilimProgressbar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.gorunurgucProgressbar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.powerfactorProgressbar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.reaktifgucProgressbar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.aktifgucProgressbar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.frekansProgressbar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.akimProgressbar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.watsaatAlcak);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.watsaatYuksek);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.modbusAdresi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.holdingRegOku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gerilimProgressbar.ResumeLayout(false);
            this.gerilimProgressbar.PerformLayout();
            this.gorunurgucProgressbar.ResumeLayout(false);
            this.gorunurgucProgressbar.PerformLayout();
            this.powerfactorProgressbar.ResumeLayout(false);
            this.powerfactorProgressbar.PerformLayout();
            this.reaktifgucProgressbar.ResumeLayout(false);
            this.reaktifgucProgressbar.PerformLayout();
            this.aktifgucProgressbar.ResumeLayout(false);
            this.aktifgucProgressbar.PerformLayout();
            this.frekansProgressbar.ResumeLayout(false);
            this.frekansProgressbar.PerformLayout();
            this.akimProgressbar.ResumeLayout(false);
            this.akimProgressbar.PerformLayout();
            this.watsaatAlcak.ResumeLayout(false);
            this.watsaatAlcak.PerformLayout();
            this.watsaatYuksek.ResumeLayout(false);
            this.watsaatYuksek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button receiveMqtt;
        private Button publishMqtt;
        private Button temizle;
        private Button inputRegister;
        private Button baglantiKes;
        private Button baglan;
        private Guna.UI2.WinForms.Guna2ComboBox baudRate;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox portNum;
        private Label portNo;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gerilimProgressbar;
        private Label gerilim;
        private Label label19;
        private Guna.UI2.WinForms.Guna2CircleProgressBar gorunurgucProgressbar;
        private Label gorunurGuc;
        private Label label17;
        private Guna.UI2.WinForms.Guna2CircleProgressBar powerfactorProgressbar;
        private Label powerFactor;
        private Label label21;
        private Guna.UI2.WinForms.Guna2CircleProgressBar reaktifgucProgressbar;
        private Label reaktifGuc;
        private Label label14;
        private Guna.UI2.WinForms.Guna2CircleProgressBar aktifgucProgressbar;
        private Label aktifGuc;
        private Label label15;
        private Guna.UI2.WinForms.Guna2CircleProgressBar frekansProgressbar;
        private Label frekans;
        private Label label12;
        private Guna.UI2.WinForms.Guna2CircleProgressBar akimProgressbar;
        private Label akim;
        private Label label13;
        private Guna.UI2.WinForms.Guna2CircleProgressBar watsaatAlcak;
        private Label watSaat_dusukGerilim;
        private Label label11;
        private Guna.UI2.WinForms.Guna2CircleProgressBar watsaatYuksek;
        private Label wattSaat_yuksekGerilim;
        private Label label10;
        private TextBox modbusAdresi;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button holdingRegOku;
    }
}