namespace AdvancedHMICS
{
    partial class MainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pilotLight5 = new AdvancedHMIControls.PilotLight();
            this.modbusRTUCom1 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.pilotLight4 = new AdvancedHMIControls.PilotLight();
            this.pilotLight3 = new AdvancedHMIControls.PilotLight();
            this.pilotLight2 = new AdvancedHMIControls.PilotLight();
            this.digitalPanelMeter3 = new AdvancedHMIControls.DigitalPanelMeter();
            this.pilotLight1 = new AdvancedHMIControls.PilotLight();
            this.digitalPanelMeter5 = new AdvancedHMIControls.DigitalPanelMeter();
            this.digitalPanelMeter4 = new AdvancedHMIControls.DigitalPanelMeter();
            this.digitalPanelMeter1 = new AdvancedHMIControls.DigitalPanelMeter();
            this.digitalPanelMeter2 = new AdvancedHMIControls.DigitalPanelMeter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.txtPollingTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 215);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 48);
            this.button4.TabIndex = 50;
            this.button4.Text = "Export Backup";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 217);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 48);
            this.button3.TabIndex = 49;
            this.button3.Text = "Analysis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 48);
            this.button2.TabIndex = 48;
            this.button2.Text = "Import Backup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 47;
            this.button1.Text = "ExportData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(430, 365);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(412, 139);
            this.richTextBox1.TabIndex = 63;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pilotLight5);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.pilotLight4);
            this.panel1.Controls.Add(this.pilotLight3);
            this.panel1.Controls.Add(this.pilotLight2);
            this.panel1.Controls.Add(this.digitalPanelMeter3);
            this.panel1.Controls.Add(this.pilotLight1);
            this.panel1.Controls.Add(this.digitalPanelMeter5);
            this.panel1.Controls.Add(this.digitalPanelMeter4);
            this.panel1.Controls.Add(this.digitalPanelMeter1);
            this.panel1.Controls.Add(this.digitalPanelMeter2);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 547);
            this.panel1.TabIndex = 64;
            // 
            // pilotLight5
            // 
            this.pilotLight5.Blink = true;
            this.pilotLight5.ComComponent = this.modbusRTUCom1;
            this.pilotLight5.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight5.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight5.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotLight5.Location = new System.Drawing.Point(767, 211);
            this.pilotLight5.Name = "pilotLight5";
            this.pilotLight5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight5.PLCAddressClick = "";
            this.pilotLight5.PLCAddressText = "";
            this.pilotLight5.PLCAddressValue = "00005";
            this.pilotLight5.PLCAddressVisible = "";
            this.pilotLight5.Size = new System.Drawing.Size(75, 110);
            this.pilotLight5.TabIndex = 61;
            this.pilotLight5.Text = "Trạm 5";
            this.pilotLight5.Value = false;
            this.pilotLight5.ValueToWrite = 0;
            // 
            // modbusRTUCom1
            // 
            this.modbusRTUCom1.BaudRate = 38400;
            this.modbusRTUCom1.DataBits = 8;
            this.modbusRTUCom1.DisableSubscriptions = false;
            this.modbusRTUCom1.EnableLogging = false;
            this.modbusRTUCom1.IniFileName = "";
            this.modbusRTUCom1.IniFileSection = null;
            this.modbusRTUCom1.MaxReadGroupSize = 20;
            this.modbusRTUCom1.Parity = System.IO.Ports.Parity.None;
            this.modbusRTUCom1.PollRateOverride = 100;
            this.modbusRTUCom1.PortName = "COM17";
            this.modbusRTUCom1.StationAddress = ((byte)(1));
            this.modbusRTUCom1.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom1.SwapBytes = true;
            this.modbusRTUCom1.SwapWords = false;
            this.modbusRTUCom1.TimeOut = 3000;
            this.modbusRTUCom1.DataReceived += new System.EventHandler<MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs>(this.modbusRTUCom1_DataReceived);
            // 
            // pilotLight4
            // 
            this.pilotLight4.Blink = true;
            this.pilotLight4.ComComponent = this.modbusRTUCom1;
            this.pilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotLight4.Location = new System.Drawing.Point(767, 30);
            this.pilotLight4.Name = "pilotLight4";
            this.pilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight4.PLCAddressClick = "";
            this.pilotLight4.PLCAddressText = "";
            this.pilotLight4.PLCAddressValue = "00004";
            this.pilotLight4.PLCAddressVisible = "";
            this.pilotLight4.Size = new System.Drawing.Size(75, 110);
            this.pilotLight4.TabIndex = 60;
            this.pilotLight4.Text = "Trạm 4";
            this.pilotLight4.Value = false;
            this.pilotLight4.ValueToWrite = 0;
            // 
            // pilotLight3
            // 
            this.pilotLight3.Blink = true;
            this.pilotLight3.ComComponent = this.modbusRTUCom1;
            this.pilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotLight3.Location = new System.Drawing.Point(324, 394);
            this.pilotLight3.Name = "pilotLight3";
            this.pilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight3.PLCAddressClick = "";
            this.pilotLight3.PLCAddressText = "";
            this.pilotLight3.PLCAddressValue = "00003";
            this.pilotLight3.PLCAddressVisible = "";
            this.pilotLight3.Size = new System.Drawing.Size(75, 110);
            this.pilotLight3.TabIndex = 59;
            this.pilotLight3.Text = "Trạm 3";
            this.pilotLight3.Value = false;
            this.pilotLight3.ValueToWrite = 0;
            // 
            // pilotLight2
            // 
            this.pilotLight2.Blink = true;
            this.pilotLight2.ComComponent = this.modbusRTUCom1;
            this.pilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotLight2.Location = new System.Drawing.Point(324, 214);
            this.pilotLight2.Name = "pilotLight2";
            this.pilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight2.PLCAddressClick = "";
            this.pilotLight2.PLCAddressText = "";
            this.pilotLight2.PLCAddressValue = "00002";
            this.pilotLight2.PLCAddressVisible = "";
            this.pilotLight2.Size = new System.Drawing.Size(75, 110);
            this.pilotLight2.TabIndex = 58;
            this.pilotLight2.Text = "Trạm 2";
            this.pilotLight2.Value = false;
            this.pilotLight2.ValueToWrite = 0;
            // 
            // digitalPanelMeter3
            // 
            this.digitalPanelMeter3.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter3.ComComponent = this.modbusRTUCom1;
            this.digitalPanelMeter3.DecimalPosition = 0;
            this.digitalPanelMeter3.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter3.KeypadMaxValue = 0D;
            this.digitalPanelMeter3.KeypadMinValue = 0D;
            this.digitalPanelMeter3.KeypadScaleFactor = 1D;
            this.digitalPanelMeter3.KeypadText = null;
            this.digitalPanelMeter3.KeypadWidth = 300;
            this.digitalPanelMeter3.Location = new System.Drawing.Point(20, 375);
            this.digitalPanelMeter3.Name = "digitalPanelMeter3";
            this.digitalPanelMeter3.NumberOfDigits = 5;
            this.digitalPanelMeter3.PLCAddressKeypad = "";
            this.digitalPanelMeter3.PLCAddressValue = "U40003";
            this.digitalPanelMeter3.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter3.Size = new System.Drawing.Size(298, 129);
            this.digitalPanelMeter3.TabIndex = 54;
            this.digitalPanelMeter3.Text = "Trạm 3";
            this.digitalPanelMeter3.Value = 0D;
            this.digitalPanelMeter3.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter3.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.digitalPanelMeter3.Click += new System.EventHandler(this.digitalPanelMeter3_Click);
            // 
            // pilotLight1
            // 
            this.pilotLight1.Blink = true;
            this.pilotLight1.ComComponent = this.modbusRTUCom1;
            this.pilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotLight1.Location = new System.Drawing.Point(324, 30);
            this.pilotLight1.Name = "pilotLight1";
            this.pilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight1.PLCAddressClick = "";
            this.pilotLight1.PLCAddressText = "";
            this.pilotLight1.PLCAddressValue = "00001";
            this.pilotLight1.PLCAddressVisible = "";
            this.pilotLight1.Size = new System.Drawing.Size(75, 110);
            this.pilotLight1.TabIndex = 57;
            this.pilotLight1.Text = "Trạm 1";
            this.pilotLight1.Value = false;
            this.pilotLight1.ValueToWrite = 0;
            // 
            // digitalPanelMeter5
            // 
            this.digitalPanelMeter5.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter5.ComComponent = this.modbusRTUCom1;
            this.digitalPanelMeter5.DecimalPosition = 0;
            this.digitalPanelMeter5.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter5.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter5.KeypadMaxValue = 0D;
            this.digitalPanelMeter5.KeypadMinValue = 0D;
            this.digitalPanelMeter5.KeypadScaleFactor = 1D;
            this.digitalPanelMeter5.KeypadText = null;
            this.digitalPanelMeter5.KeypadWidth = 300;
            this.digitalPanelMeter5.Location = new System.Drawing.Point(447, 200);
            this.digitalPanelMeter5.Name = "digitalPanelMeter5";
            this.digitalPanelMeter5.NumberOfDigits = 5;
            this.digitalPanelMeter5.PLCAddressKeypad = "";
            this.digitalPanelMeter5.PLCAddressValue = "U40005";
            this.digitalPanelMeter5.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter5.Size = new System.Drawing.Size(279, 121);
            this.digitalPanelMeter5.TabIndex = 56;
            this.digitalPanelMeter5.Text = "Trạm 5";
            this.digitalPanelMeter5.Value = 0D;
            this.digitalPanelMeter5.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter5.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.digitalPanelMeter5.Click += new System.EventHandler(this.digitalPanelMeter5_Click);
            // 
            // digitalPanelMeter4
            // 
            this.digitalPanelMeter4.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter4.ComComponent = this.modbusRTUCom1;
            this.digitalPanelMeter4.DecimalPosition = 0;
            this.digitalPanelMeter4.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter4.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter4.KeypadMaxValue = 0D;
            this.digitalPanelMeter4.KeypadMinValue = 0D;
            this.digitalPanelMeter4.KeypadScaleFactor = 1D;
            this.digitalPanelMeter4.KeypadText = null;
            this.digitalPanelMeter4.KeypadWidth = 300;
            this.digitalPanelMeter4.Location = new System.Drawing.Point(447, 19);
            this.digitalPanelMeter4.Name = "digitalPanelMeter4";
            this.digitalPanelMeter4.NumberOfDigits = 5;
            this.digitalPanelMeter4.PLCAddressKeypad = "";
            this.digitalPanelMeter4.PLCAddressValue = "U40004";
            this.digitalPanelMeter4.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter4.Size = new System.Drawing.Size(279, 121);
            this.digitalPanelMeter4.TabIndex = 55;
            this.digitalPanelMeter4.Text = "Trạm 4";
            this.digitalPanelMeter4.Value = 0D;
            this.digitalPanelMeter4.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter4.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.digitalPanelMeter4.Click += new System.EventHandler(this.digitalPanelMeter4_Click);
            // 
            // digitalPanelMeter1
            // 
            this.digitalPanelMeter1.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter1.ComComponent = this.modbusRTUCom1;
            this.digitalPanelMeter1.DecimalPosition = 0;
            this.digitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter1.KeypadMaxValue = 0D;
            this.digitalPanelMeter1.KeypadMinValue = 0D;
            this.digitalPanelMeter1.KeypadScaleFactor = 1D;
            this.digitalPanelMeter1.KeypadText = null;
            this.digitalPanelMeter1.KeypadWidth = 300;
            this.digitalPanelMeter1.Location = new System.Drawing.Point(24, 19);
            this.digitalPanelMeter1.Name = "digitalPanelMeter1";
            this.digitalPanelMeter1.NumberOfDigits = 5;
            this.digitalPanelMeter1.PLCAddressKeypad = "";
            this.digitalPanelMeter1.PLCAddressValue = "U40001";
            this.digitalPanelMeter1.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.Size = new System.Drawing.Size(279, 121);
            this.digitalPanelMeter1.TabIndex = 51;
            this.digitalPanelMeter1.Text = "Trạm 1";
            this.digitalPanelMeter1.Value = 0D;
            this.digitalPanelMeter1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.digitalPanelMeter1.Click += new System.EventHandler(this.digitalPanelMeter1_Click);
            // 
            // digitalPanelMeter2
            // 
            this.digitalPanelMeter2.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter2.ComComponent = this.modbusRTUCom1;
            this.digitalPanelMeter2.DecimalPosition = 0;
            this.digitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter2.KeypadMaxValue = 0D;
            this.digitalPanelMeter2.KeypadMinValue = 0D;
            this.digitalPanelMeter2.KeypadScaleFactor = 1D;
            this.digitalPanelMeter2.KeypadText = null;
            this.digitalPanelMeter2.KeypadWidth = 300;
            this.digitalPanelMeter2.Location = new System.Drawing.Point(24, 199);
            this.digitalPanelMeter2.Name = "digitalPanelMeter2";
            this.digitalPanelMeter2.NumberOfDigits = 5;
            this.digitalPanelMeter2.PLCAddressKeypad = "";
            this.digitalPanelMeter2.PLCAddressValue = "U40002";
            this.digitalPanelMeter2.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.Size = new System.Drawing.Size(288, 125);
            this.digitalPanelMeter2.TabIndex = 52;
            this.digitalPanelMeter2.Text = "Tram 2";
            this.digitalPanelMeter2.Value = 0D;
            this.digitalPanelMeter2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.digitalPanelMeter2.Click += new System.EventHandler(this.digitalPanelMeter2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 97);
            this.panel2.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(280, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATION STATUS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(899, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 369);
            this.panel3.TabIndex = 66;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.txtTimeOut);
            this.panel5.Controls.Add(this.txtPollingTime);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtBaudRate);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtPortName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(15, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 334);
            this.panel5.TabIndex = 51;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(315, 114);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(77, 22);
            this.txtTimeOut.TabIndex = 71;
            this.txtTimeOut.Text = "3000";
            // 
            // txtPollingTime
            // 
            this.txtPollingTime.Location = new System.Drawing.Point(315, 82);
            this.txtPollingTime.Name = "txtPollingTime";
            this.txtPollingTime.Size = new System.Drawing.Size(77, 22);
            this.txtPollingTime.TabIndex = 70;
            this.txtPollingTime.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(206, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(206, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "POLLINGTIME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "BAUDRATE";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(118, 111);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(58, 22);
            this.txtBaudRate.TabIndex = 66;
            this.txtBaudRate.Text = "38400";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "PORT NAME";
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(118, 82);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(58, 22);
            this.txtPortName.TabIndex = 64;
            this.txtPortName.Text = "COM3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(81, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTROLLER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(899, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 275);
            this.panel4.TabIndex = 67;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedHMI V3.99x";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom1;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter1;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter3;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter4;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter5;
        private AdvancedHMIControls.PilotLight pilotLight1;
        private AdvancedHMIControls.PilotLight pilotLight2;
        private AdvancedHMIControls.PilotLight pilotLight3;
        private AdvancedHMIControls.PilotLight pilotLight4;
        private AdvancedHMIControls.PilotLight pilotLight5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.TextBox txtPollingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

