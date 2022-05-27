
namespace AtividadeN1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pilotoCom = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.btnFechar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnDesconectar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnConectar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxPortCom = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbxContrExa = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbxContrMot = new System.Windows.Forms.ComboBox();
            this.pilotoLEM = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.btnEmer = new MfgControl.AdvancedHMI.Controls.MushroomButton();
            this.pilotoSistOn = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.btnDN = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnEn = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fan5 = new MfgControl.AdvancedHMI.Controls.Fan();
            this.fan4 = new MfgControl.AdvancedHMI.Controls.Fan();
            this.fan3 = new MfgControl.AdvancedHMI.Controls.Fan();
            this.fan2 = new MfgControl.AdvancedHMI.Controls.Fan();
            this.fan1 = new MfgControl.AdvancedHMI.Controls.Fan();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.motor5 = new MfgControl.AdvancedHMI.Controls.Motor();
            this.motor4 = new MfgControl.AdvancedHMI.Controls.Motor();
            this.motor3 = new MfgControl.AdvancedHMI.Controls.Motor();
            this.motor2 = new MfgControl.AdvancedHMI.Controls.Motor();
            this.motor1 = new MfgControl.AdvancedHMI.Controls.Motor();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txbRxData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pilotoCom);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão Serial";
            // 
            // pilotoCom
            // 
            this.pilotoCom.Blink = false;
            this.pilotoCom.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotoCom.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotoCom.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotoCom.Location = new System.Drawing.Point(12, 298);
            this.pilotoCom.Name = "pilotoCom";
            this.pilotoCom.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotoCom.Size = new System.Drawing.Size(75, 110);
            this.pilotoCom.TabIndex = 5;
            this.pilotoCom.Text = "Sinaliza";
            this.pilotoCom.Value = false;
            // 
            // btnFechar
            // 
            this.btnFechar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red;
            this.btnFechar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnFechar.Location = new System.Drawing.Point(93, 298);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnFechar.Size = new System.Drawing.Size(75, 110);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fecha";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue;
            this.btnDesconectar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnDesconectar.Location = new System.Drawing.Point(93, 182);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnDesconectar.Size = new System.Drawing.Size(75, 110);
            this.btnDesconectar.TabIndex = 3;
            this.btnDesconectar.Text = "Desconecta";
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click_1);
            // 
            // btnConectar
            // 
            this.btnConectar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.btnConectar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnConectar.Location = new System.Drawing.Point(12, 182);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnConectar.Size = new System.Drawing.Size(75, 110);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conecta";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxBaudRate);
            this.groupBox3.Location = new System.Drawing.Point(6, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baud Rate";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(6, 24);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(156, 23);
            this.cbxBaudRate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxPortCom);
            this.groupBox2.Location = new System.Drawing.Point(6, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Porta Com";
            // 
            // cbxPortCom
            // 
            this.cbxPortCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPortCom.FormattingEnabled = true;
            this.cbxPortCom.Location = new System.Drawing.Point(6, 24);
            this.cbxPortCom.Name = "cbxPortCom";
            this.cbxPortCom.Size = new System.Drawing.Size(156, 23);
            this.cbxPortCom.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.pilotoLEM);
            this.groupBox4.Controls.Add(this.btnEmer);
            this.groupBox4.Controls.Add(this.pilotoSistOn);
            this.groupBox4.Controls.Add(this.btnDN);
            this.groupBox4.Controls.Add(this.btnEn);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(202, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(655, 426);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quadro de Comando";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbxContrExa);
            this.groupBox8.Location = new System.Drawing.Point(458, 369);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(190, 45);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Controle Exaustores";
            // 
            // cbxContrExa
            // 
            this.cbxContrExa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContrExa.FormattingEnabled = true;
            this.cbxContrExa.Items.AddRange(new object[] {
            "EXAUSTOR1ON",
            "EXAUSTOR2ON",
            "EXAUSTOR3ON",
            "EXAUSTOR4ON",
            "EXAUSTOR5ON",
            "EXAUSTOR1OFF",
            "EXAUSTOR2OFF",
            "EXAUSTOR3OFF",
            "EXAUSTOR4OFF",
            "EXAUSTOR5OFF"});
            this.cbxContrExa.Location = new System.Drawing.Point(16, 16);
            this.cbxContrExa.Name = "cbxContrExa";
            this.cbxContrExa.Size = new System.Drawing.Size(156, 23);
            this.cbxContrExa.TabIndex = 1;
            this.cbxContrExa.SelectedIndexChanged += new System.EventHandler(this.cbxContrExa_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbxContrMot);
            this.groupBox7.Location = new System.Drawing.Point(458, 318);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(190, 45);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Controle Motores";
            // 
            // cbxContrMot
            // 
            this.cbxContrMot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContrMot.FormattingEnabled = true;
            this.cbxContrMot.Items.AddRange(new object[] {
            "MOTOR1ON",
            "MOTOR2ON",
            "MOTOR3ON",
            "MOTOR4ON",
            "MOTOR5ON",
            "MOTOR1OFF",
            "MOTOR2OFF",
            "MOTOR3OFF",
            "MOTOR4OFF",
            "MOTOR5OFF"});
            this.cbxContrMot.Location = new System.Drawing.Point(16, 16);
            this.cbxContrMot.Name = "cbxContrMot";
            this.cbxContrMot.Size = new System.Drawing.Size(156, 23);
            this.cbxContrMot.TabIndex = 1;
            this.cbxContrMot.SelectedIndexChanged += new System.EventHandler(this.cbxContrMot_SelectedIndexChanged);
            // 
            // pilotoLEM
            // 
            this.pilotoLEM.Blink = false;
            this.pilotoLEM.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotoLEM.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotoLEM.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotoLEM.Location = new System.Drawing.Point(321, 331);
            this.pilotoLEM.Name = "pilotoLEM";
            this.pilotoLEM.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotoLEM.Size = new System.Drawing.Size(61, 89);
            this.pilotoLEM.TabIndex = 9;
            this.pilotoLEM.Text = "L EM";
            this.pilotoLEM.Value = false;
            // 
            // btnEmer
            // 
            this.btnEmer.LegendPlate = MfgControl.AdvancedHMI.Controls.MushroomButton.LegendPlates.Large;
            this.btnEmer.Location = new System.Drawing.Point(245, 331);
            this.btnEmer.Name = "btnEmer";
            this.btnEmer.OutputType = MfgControl.AdvancedHMI.Controls.MushroomButton.OutputTypes.MomentarySet;
            this.btnEmer.Size = new System.Drawing.Size(61, 89);
            this.btnEmer.TabIndex = 8;
            this.btnEmer.Text = "EMERG";
            this.btnEmer.Click += new System.EventHandler(this.btnEmer_Click);
            // 
            // pilotoSistOn
            // 
            this.pilotoSistOn.Blink = false;
            this.pilotoSistOn.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotoSistOn.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotoSistOn.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotoSistOn.Location = new System.Drawing.Point(168, 331);
            this.pilotoSistOn.Name = "pilotoSistOn";
            this.pilotoSistOn.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotoSistOn.Size = new System.Drawing.Size(61, 89);
            this.pilotoSistOn.TabIndex = 6;
            this.pilotoSistOn.Text = "SIST ON";
            this.pilotoSistOn.Value = false;
            // 
            // btnDN
            // 
            this.btnDN.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red;
            this.btnDN.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnDN.Location = new System.Drawing.Point(90, 331);
            this.btnDN.Name = "btnDN";
            this.btnDN.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnDN.Size = new System.Drawing.Size(61, 89);
            this.btnDN.TabIndex = 7;
            this.btnDN.Text = "DN";
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnEn
            // 
            this.btnEn.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.btnEn.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnEn.Location = new System.Drawing.Point(13, 331);
            this.btnEn.Name = "btnEn";
            this.btnEn.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnEn.Size = new System.Drawing.Size(61, 89);
            this.btnEn.TabIndex = 6;
            this.btnEn.Text = "EN";
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.fan5);
            this.groupBox6.Controls.Add(this.fan4);
            this.groupBox6.Controls.Add(this.fan3);
            this.groupBox6.Controls.Add(this.fan2);
            this.groupBox6.Controls.Add(this.fan1);
            this.groupBox6.Location = new System.Drawing.Point(13, 196);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(635, 116);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exaustores";
            // 
            // fan5
            // 
            this.fan5.Direction = false;
            this.fan5.Location = new System.Drawing.Point(524, 35);
            this.fan5.Name = "fan5";
            this.fan5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.fan5.Size = new System.Drawing.Size(75, 75);
            this.fan5.TabIndex = 4;
            this.fan5.Text = "fan5";
            this.fan5.TextPosition = System.Drawing.StringAlignment.Near;
            this.fan5.Value = false;
            // 
            // fan4
            // 
            this.fan4.Direction = false;
            this.fan4.Location = new System.Drawing.Point(403, 35);
            this.fan4.Name = "fan4";
            this.fan4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.fan4.Size = new System.Drawing.Size(75, 75);
            this.fan4.TabIndex = 3;
            this.fan4.Text = "fan4";
            this.fan4.TextPosition = System.Drawing.StringAlignment.Near;
            this.fan4.Value = false;
            // 
            // fan3
            // 
            this.fan3.Direction = false;
            this.fan3.Location = new System.Drawing.Point(272, 35);
            this.fan3.Name = "fan3";
            this.fan3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.fan3.Size = new System.Drawing.Size(75, 75);
            this.fan3.TabIndex = 2;
            this.fan3.Text = "fan3";
            this.fan3.TextPosition = System.Drawing.StringAlignment.Near;
            this.fan3.Value = false;
            // 
            // fan2
            // 
            this.fan2.Direction = false;
            this.fan2.Location = new System.Drawing.Point(141, 35);
            this.fan2.Name = "fan2";
            this.fan2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.fan2.Size = new System.Drawing.Size(75, 75);
            this.fan2.TabIndex = 1;
            this.fan2.Text = "fan2";
            this.fan2.TextPosition = System.Drawing.StringAlignment.Near;
            this.fan2.Value = false;
            // 
            // fan1
            // 
            this.fan1.Direction = false;
            this.fan1.Location = new System.Drawing.Point(20, 35);
            this.fan1.Name = "fan1";
            this.fan1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.fan1.Size = new System.Drawing.Size(75, 75);
            this.fan1.TabIndex = 0;
            this.fan1.Text = "fan1";
            this.fan1.TextPosition = System.Drawing.StringAlignment.Near;
            this.fan1.Value = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.motor5);
            this.groupBox5.Controls.Add(this.motor4);
            this.groupBox5.Controls.Add(this.motor3);
            this.groupBox5.Controls.Add(this.motor2);
            this.groupBox5.Controls.Add(this.motor1);
            this.groupBox5.Location = new System.Drawing.Point(12, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(637, 166);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motores";
            // 
            // motor5
            // 
            this.motor5.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor5.Location = new System.Drawing.Point(512, 53);
            this.motor5.Name = "motor5";
            this.motor5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor5.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor5.Size = new System.Drawing.Size(106, 72);
            this.motor5.TabIndex = 4;
            this.motor5.Text = "motor5";
            this.motor5.Value = false;
            // 
            // motor4
            // 
            this.motor4.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor4.Location = new System.Drawing.Point(385, 53);
            this.motor4.Name = "motor4";
            this.motor4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor4.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor4.Size = new System.Drawing.Size(106, 72);
            this.motor4.TabIndex = 3;
            this.motor4.Text = "motor4";
            this.motor4.Value = false;
            // 
            // motor3
            // 
            this.motor3.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor3.Location = new System.Drawing.Point(264, 53);
            this.motor3.Name = "motor3";
            this.motor3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor3.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor3.Size = new System.Drawing.Size(106, 72);
            this.motor3.TabIndex = 2;
            this.motor3.Text = "motor3";
            this.motor3.Value = false;
            // 
            // motor2
            // 
            this.motor2.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor2.Location = new System.Drawing.Point(142, 53);
            this.motor2.Name = "motor2";
            this.motor2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor2.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor2.Size = new System.Drawing.Size(106, 72);
            this.motor2.TabIndex = 1;
            this.motor2.Text = "motor2";
            this.motor2.Value = false;
            // 
            // motor1
            // 
            this.motor1.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green;
            this.motor1.Location = new System.Drawing.Point(21, 53);
            this.motor1.Name = "motor1";
            this.motor1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.motor1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.motor1.Size = new System.Drawing.Size(106, 72);
            this.motor1.TabIndex = 0;
            this.motor1.Text = "motor1";
            this.motor1.Value = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(877, 15);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(118, 206);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Destravar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtSenha);
            this.groupBox11.Location = new System.Drawing.Point(6, 106);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(106, 58);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 31);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(94, 21);
            this.txtSenha.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtUsuario);
            this.groupBox10.Location = new System.Drawing.Point(6, 21);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(106, 58);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(94, 21);
            this.txtUsuario.TabIndex = 0;
            // 
            // txbRxData
            // 
            this.txbRxData.Enabled = false;
            this.txbRxData.Location = new System.Drawing.Point(889, 243);
            this.txbRxData.Name = "txbRxData";
            this.txbRxData.Size = new System.Drawing.Size(94, 20);
            this.txbRxData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 474);
            this.ControlBox = false;
            this.Controls.Add(this.txbRxData);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IHM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MfgControl.AdvancedHMI.Controls.PilotLight pilotoCom;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnFechar;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnDesconectar;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnConectar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxPortCom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private MfgControl.AdvancedHMI.Controls.Motor motor5;
        private MfgControl.AdvancedHMI.Controls.Motor motor4;
        private MfgControl.AdvancedHMI.Controls.Motor motor3;
        private MfgControl.AdvancedHMI.Controls.Motor motor2;
        private MfgControl.AdvancedHMI.Controls.Motor motor1;
        private System.Windows.Forms.GroupBox groupBox6;
        private MfgControl.AdvancedHMI.Controls.Fan fan5;
        private MfgControl.AdvancedHMI.Controls.Fan fan4;
        private MfgControl.AdvancedHMI.Controls.Fan fan3;
        private MfgControl.AdvancedHMI.Controls.Fan fan2;
        private MfgControl.AdvancedHMI.Controls.Fan fan1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbxContrMot;
        private MfgControl.AdvancedHMI.Controls.PilotLight pilotoLEM;
        private MfgControl.AdvancedHMI.Controls.MushroomButton btnEmer;
        private MfgControl.AdvancedHMI.Controls.PilotLight pilotoSistOn;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnDN;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnEn;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbxContrExa;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbRxData;
    }
}

