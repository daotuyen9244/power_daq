<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LicenseNote = New System.Windows.Forms.Label()
        Me.ModbusRTUCom1 = New AdvancedHMIDrivers.ModbusRTUCom(Me.components)
        Me.MomentaryButton2 = New AdvancedHMIControls.MomentaryButton()
        Me.MomentaryButton1 = New AdvancedHMIControls.MomentaryButton()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModbusRTUCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(450, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'LicenseNote
        '
        Me.LicenseNote.AutoSize = True
        Me.LicenseNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseNote.ForeColor = System.Drawing.Color.White
        Me.LicenseNote.Location = New System.Drawing.Point(-2, 480)
        Me.LicenseNote.Name = "LicenseNote"
        Me.LicenseNote.Size = New System.Drawing.Size(746, 32)
        Me.LicenseNote.TabIndex = 54
        Me.LicenseNote.Text = "By Using This Software You Agree to the UsageAndLicense.txt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AdvancedHMI is licen" &
    "sed under a GPL model which means you must pass on the full source to the end us" &
    "er."
        Me.LicenseNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LicenseNote.Visible = False
        '
        'ModbusRTUCom1
        '
        Me.ModbusRTUCom1.BaudRate = 38400
        Me.ModbusRTUCom1.DataBits = 8
        Me.ModbusRTUCom1.DisableSubscriptions = False
        Me.ModbusRTUCom1.EnableLogging = False
        Me.ModbusRTUCom1.IniFileName = ""
        Me.ModbusRTUCom1.IniFileSection = Nothing
        Me.ModbusRTUCom1.MaxReadGroupSize = 20
        Me.ModbusRTUCom1.Parity = System.IO.Ports.Parity.None
        Me.ModbusRTUCom1.PollRateOverride = 500
        Me.ModbusRTUCom1.PortName = "COM3"
        Me.ModbusRTUCom1.StationAddress = CType(1, Byte)
        Me.ModbusRTUCom1.StopBits = System.IO.Ports.StopBits.One
        Me.ModbusRTUCom1.SwapBytes = True
        Me.ModbusRTUCom1.SwapWords = False
        Me.ModbusRTUCom1.TimeOut = 3000
        '
        'MomentaryButton2
        '
        Me.MomentaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red
        Me.MomentaryButton2.ComComponent = Me.ModbusRTUCom1
        Me.MomentaryButton2.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton2.Location = New System.Drawing.Point(126, 120)
        Me.MomentaryButton2.MaximumHoldTime = 3000
        Me.MomentaryButton2.MinimumHoldTime = 500
        Me.MomentaryButton2.Name = "MomentaryButton2"
        Me.MomentaryButton2.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton2.PLCAddressClick = "00002"
        Me.MomentaryButton2.PLCAddressVisible = ""
        Me.MomentaryButton2.Size = New System.Drawing.Size(75, 110)
        Me.MomentaryButton2.TabIndex = 59
        Me.MomentaryButton2.Text = "Stop"
        '
        'MomentaryButton1
        '
        Me.MomentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MomentaryButton1.ComComponent = Me.ModbusRTUCom1
        Me.MomentaryButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large
        Me.MomentaryButton1.Location = New System.Drawing.Point(35, 120)
        Me.MomentaryButton1.MaximumHoldTime = 3000
        Me.MomentaryButton1.MinimumHoldTime = 500
        Me.MomentaryButton1.Name = "MomentaryButton1"
        Me.MomentaryButton1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MomentaryButton1.PLCAddressClick = "00001"
        Me.MomentaryButton1.PLCAddressVisible = ""
        Me.MomentaryButton1.Size = New System.Drawing.Size(75, 110)
        Me.MomentaryButton1.TabIndex = 57
        Me.MomentaryButton1.Text = "Start"
        '
        'PilotLight4
        '
        Me.PilotLight4.Blink = False
        Me.PilotLight4.ComComponent = Me.ModbusRTUCom1
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(321, 120)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "00004"
        Me.PilotLight4.PLCAddressVisible = ""
        Me.PilotLight4.Size = New System.Drawing.Size(75, 110)
        Me.PilotLight4.TabIndex = 64
        Me.PilotLight4.Text = "Not Started"
        Me.PilotLight4.Value = False
        Me.PilotLight4.ValueToWrite = 0
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.ModbusRTUCom1
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(224, 120)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "00003"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(75, 110)
        Me.PilotLight1.TabIndex = 58
        Me.PilotLight1.Text = "Started"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.MomentaryButton2)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.MomentaryButton1)
        Me.Controls.Add(Me.LicenseNote)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModbusRTUCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents LicenseNote As Label
    Friend WithEvents ModbusRTUCom1 As AdvancedHMIDrivers.ModbusRTUCom
    Friend WithEvents MomentaryButton1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents MomentaryButton2 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
End Class
