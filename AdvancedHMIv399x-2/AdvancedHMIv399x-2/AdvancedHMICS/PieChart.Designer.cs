namespace AdvancedHMICS
{
    partial class PieChart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkStaAll = new AdvancedHMIControls.CheckBox();
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.chkSta5 = new AdvancedHMIControls.CheckBox();
            this.chkSta4 = new AdvancedHMIControls.CheckBox();
            this.chkSta3 = new AdvancedHMIControls.CheckBox();
            this.chkSta2 = new System.Windows.Forms.CheckBox();
            this.chkSta1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ChkByYear = new AdvancedHMIControls.CheckBox();
            this.chkByMonth = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chkChartCollum = new System.Windows.Forms.CheckBox();
            this.chkChartPie = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Controls.Add(this.pieChart1);
            this.panel1.Location = new System.Drawing.Point(348, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 613);
            this.panel1.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.ForeColor = System.Drawing.Color.Maroon;
            this.cartesianChart1.Location = new System.Drawing.Point(-1, -9);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(989, 619);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 0);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(4);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(988, 613);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(16, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 270);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.chkStaAll);
            this.panel4.Controls.Add(this.chkSta5);
            this.panel4.Controls.Add(this.chkSta4);
            this.panel4.Controls.Add(this.chkSta3);
            this.panel4.Controls.Add(this.chkSta2);
            this.panel4.Controls.Add(this.chkSta1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(10, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 240);
            this.panel4.TabIndex = 0;
            // 
            // chkStaAll
            // 
            this.chkStaAll.AutoSize = true;
            this.chkStaAll.Checked = true;
            this.chkStaAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStaAll.ComComponent = this.ethernetIPforCLXCom1;
            this.chkStaAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStaAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkStaAll.Location = new System.Drawing.Point(162, 167);
            this.chkStaAll.Name = "chkStaAll";
            this.chkStaAll.PLCAddressCheckChanged = "";
            this.chkStaAll.PLCAddressChecked = "";
            this.chkStaAll.PLCAddressText = "";
            this.chkStaAll.PLCAddressVisible = "";
            this.chkStaAll.Size = new System.Drawing.Size(59, 29);
            this.chkStaAll.TabIndex = 10;
            this.chkStaAll.Text = "All";
            this.chkStaAll.UseVisualStyleBackColor = true;
            this.chkStaAll.Click += new System.EventHandler(this.chkStaAll_Click);
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.0.10";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // chkSta5
            // 
            this.chkSta5.AutoSize = true;
            this.chkSta5.ComComponent = this.ethernetIPforCLXCom1;
            this.chkSta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSta5.ForeColor = System.Drawing.Color.Yellow;
            this.chkSta5.Location = new System.Drawing.Point(162, 128);
            this.chkSta5.Name = "chkSta5";
            this.chkSta5.PLCAddressCheckChanged = "";
            this.chkSta5.PLCAddressChecked = "";
            this.chkSta5.PLCAddressText = "";
            this.chkSta5.PLCAddressVisible = "";
            this.chkSta5.Size = new System.Drawing.Size(114, 29);
            this.chkSta5.TabIndex = 9;
            this.chkSta5.Text = "Station5";
            this.chkSta5.UseVisualStyleBackColor = true;
            this.chkSta5.Click += new System.EventHandler(this.chkSta5_Click);
            // 
            // chkSta4
            // 
            this.chkSta4.AutoSize = true;
            this.chkSta4.ComComponent = this.ethernetIPforCLXCom1;
            this.chkSta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSta4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkSta4.Location = new System.Drawing.Point(162, 89);
            this.chkSta4.Name = "chkSta4";
            this.chkSta4.PLCAddressCheckChanged = "";
            this.chkSta4.PLCAddressChecked = "";
            this.chkSta4.PLCAddressText = "";
            this.chkSta4.PLCAddressVisible = "";
            this.chkSta4.Size = new System.Drawing.Size(114, 29);
            this.chkSta4.TabIndex = 8;
            this.chkSta4.Text = "Station4";
            this.chkSta4.UseVisualStyleBackColor = true;
            this.chkSta4.Click += new System.EventHandler(this.chkSta4_Click);
            // 
            // chkSta3
            // 
            this.chkSta3.AutoSize = true;
            this.chkSta3.ComComponent = this.ethernetIPforCLXCom1;
            this.chkSta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkSta3.Location = new System.Drawing.Point(16, 167);
            this.chkSta3.Name = "chkSta3";
            this.chkSta3.PLCAddressCheckChanged = "";
            this.chkSta3.PLCAddressChecked = "";
            this.chkSta3.PLCAddressText = "";
            this.chkSta3.PLCAddressVisible = "";
            this.chkSta3.Size = new System.Drawing.Size(114, 29);
            this.chkSta3.TabIndex = 7;
            this.chkSta3.Text = "Station3";
            this.chkSta3.UseVisualStyleBackColor = true;
            this.chkSta3.Click += new System.EventHandler(this.chkSta3_Click);
            // 
            // chkSta2
            // 
            this.chkSta2.AutoSize = true;
            this.chkSta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSta2.ForeColor = System.Drawing.Color.Magenta;
            this.chkSta2.Location = new System.Drawing.Point(16, 128);
            this.chkSta2.Name = "chkSta2";
            this.chkSta2.Size = new System.Drawing.Size(114, 29);
            this.chkSta2.TabIndex = 6;
            this.chkSta2.Text = "Station2";
            this.chkSta2.UseVisualStyleBackColor = true;
            this.chkSta2.Click += new System.EventHandler(this.chkSta2_Click);
            // 
            // chkSta1
            // 
            this.chkSta1.AutoSize = true;
            this.chkSta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSta1.ForeColor = System.Drawing.Color.Red;
            this.chkSta1.Location = new System.Drawing.Point(16, 89);
            this.chkSta1.Name = "chkSta1";
            this.chkSta1.Size = new System.Drawing.Size(114, 29);
            this.chkSta1.TabIndex = 5;
            this.chkSta1.Text = "Station1";
            this.chkSta1.UseVisualStyleBackColor = true;
            this.chkSta1.Click += new System.EventHandler(this.chkSta1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By Station";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(348, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 71);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(16, 479);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 230);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.ChkByYear);
            this.panel6.Controls.Add(this.chkByMonth);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(10, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(305, 182);
            this.panel6.TabIndex = 0;
            // 
            // ChkByYear
            // 
            this.ChkByYear.AutoSize = true;
            this.ChkByYear.Checked = true;
            this.ChkByYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkByYear.ComComponent = this.ethernetIPforCLXCom1;
            this.ChkByYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkByYear.ForeColor = System.Drawing.Color.DarkViolet;
            this.ChkByYear.Location = new System.Drawing.Point(28, 121);
            this.ChkByYear.Name = "ChkByYear";
            this.ChkByYear.PLCAddressCheckChanged = "";
            this.ChkByYear.PLCAddressChecked = "";
            this.ChkByYear.PLCAddressText = "";
            this.ChkByYear.PLCAddressVisible = "";
            this.ChkByYear.Size = new System.Drawing.Size(126, 33);
            this.ChkByYear.TabIndex = 7;
            this.ChkByYear.Text = "By Year";
            this.ChkByYear.UseVisualStyleBackColor = true;
            this.ChkByYear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChkByYear_MouseClick);
            // 
            // chkByMonth
            // 
            this.chkByMonth.AutoSize = true;
            this.chkByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkByMonth.ForeColor = System.Drawing.Color.Indigo;
            this.chkByMonth.Location = new System.Drawing.Point(28, 77);
            this.chkByMonth.Name = "chkByMonth";
            this.chkByMonth.Size = new System.Drawing.Size(142, 33);
            this.chkByMonth.TabIndex = 6;
            this.chkByMonth.Text = "By Month";
            this.chkByMonth.UseVisualStyleBackColor = true;
            this.chkByMonth.Click += new System.EventHandler(this.chkByMonth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fillter By Data";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(15, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(326, 163);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Controls.Add(this.chkChartCollum);
            this.panel8.Controls.Add(this.chkChartPie);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(11, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(304, 144);
            this.panel8.TabIndex = 0;
            // 
            // chkChartCollum
            // 
            this.chkChartCollum.AutoSize = true;
            this.chkChartCollum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChartCollum.ForeColor = System.Drawing.Color.Blue;
            this.chkChartCollum.Location = new System.Drawing.Point(28, 97);
            this.chkChartCollum.Name = "chkChartCollum";
            this.chkChartCollum.Size = new System.Drawing.Size(117, 33);
            this.chkChartCollum.TabIndex = 12;
            this.chkChartCollum.Text = "Collum";
            this.chkChartCollum.UseVisualStyleBackColor = true;
            this.chkChartCollum.CheckedChanged += new System.EventHandler(this.chkChartCollum_CheckedChanged);
            this.chkChartCollum.Click += new System.EventHandler(this.chkChartCollum_Click);
            // 
            // chkChartPie
            // 
            this.chkChartPie.AutoSize = true;
            this.chkChartPie.Checked = true;
            this.chkChartPie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChartPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChartPie.ForeColor = System.Drawing.Color.Red;
            this.chkChartPie.Location = new System.Drawing.Point(28, 58);
            this.chkChartPie.Name = "chkChartPie";
            this.chkChartPie.Size = new System.Drawing.Size(136, 33);
            this.chkChartPie.TabIndex = 11;
            this.chkChartPie.Text = "PieChart";
            this.chkChartPie.UseVisualStyleBackColor = true;
            this.chkChartPie.CheckedChanged += new System.EventHandler(this.chkChartPie_CheckedChanged);
            this.chkChartPie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkChartPie_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chart Layout";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(368, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PieChart";
            this.Text = "PowerDAQ Analysis";
            this.Load += new System.EventHandler(this.PieChart_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private AdvancedHMIControls.CheckBox chkSta4;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.CheckBox chkSta3;
        private System.Windows.Forms.CheckBox chkSta2;
        private System.Windows.Forms.CheckBox chkSta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private AdvancedHMIControls.CheckBox ChkByYear;
        private System.Windows.Forms.CheckBox chkByMonth;
        private System.Windows.Forms.Label label2;
        private AdvancedHMIControls.CheckBox chkStaAll;
        private AdvancedHMIControls.CheckBox chkSta5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox chkChartCollum;
        private System.Windows.Forms.CheckBox chkChartPie;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}