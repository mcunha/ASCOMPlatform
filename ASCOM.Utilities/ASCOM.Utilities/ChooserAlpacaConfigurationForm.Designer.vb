﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooserAlpacaConfigurationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooserAlpacaConfigurationForm))
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.NumDiscoveryIpPort = New System.Windows.Forms.NumericUpDown()
        Me.ChkDNSResolution = New System.Windows.Forms.CheckBox()
        Me.NumDiscoveryBroadcasts = New System.Windows.Forms.NumericUpDown()
        Me.NumDiscoveryDuration = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChkListAllDiscoveredDevices = New System.Windows.Forms.CheckBox()
        Me.ChkShowDeviceDetails = New System.Windows.Forms.CheckBox()
        Me.NumExtraChooserWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.NumDiscoveryIpPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDiscoveryBroadcasts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDiscoveryDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumExtraChooserWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(491, 283)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 5
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(572, 283)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'NumDiscoveryIpPort
        '
        Me.NumDiscoveryIpPort.Location = New System.Drawing.Point(165, 73)
        Me.NumDiscoveryIpPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.NumDiscoveryIpPort.Minimum = New Decimal(New Integer() {32227, 0, 0, 0})
        Me.NumDiscoveryIpPort.Name = "NumDiscoveryIpPort"
        Me.NumDiscoveryIpPort.Size = New System.Drawing.Size(120, 20)
        Me.NumDiscoveryIpPort.TabIndex = 1
        Me.NumDiscoveryIpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumDiscoveryIpPort.Value = New Decimal(New Integer() {32227, 0, 0, 0})
        '
        'ChkDNSResolution
        '
        Me.ChkDNSResolution.AutoSize = True
        Me.ChkDNSResolution.Location = New System.Drawing.Point(269, 193)
        Me.ChkDNSResolution.Name = "ChkDNSResolution"
        Me.ChkDNSResolution.Size = New System.Drawing.Size(233, 17)
        Me.ChkDNSResolution.TabIndex = 4
        Me.ChkDNSResolution.Text = "Attempt DNS name resolution (Default false)"
        Me.ChkDNSResolution.UseVisualStyleBackColor = True
        '
        'NumDiscoveryBroadcasts
        '
        Me.NumDiscoveryBroadcasts.Location = New System.Drawing.Point(165, 99)
        Me.NumDiscoveryBroadcasts.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumDiscoveryBroadcasts.Name = "NumDiscoveryBroadcasts"
        Me.NumDiscoveryBroadcasts.Size = New System.Drawing.Size(120, 20)
        Me.NumDiscoveryBroadcasts.TabIndex = 2
        Me.NumDiscoveryBroadcasts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumDiscoveryBroadcasts.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumDiscoveryDuration
        '
        Me.NumDiscoveryDuration.Location = New System.Drawing.Point(165, 125)
        Me.NumDiscoveryDuration.Maximum = New Decimal(New Integer() {10000, 0, 0, 65536})
        Me.NumDiscoveryDuration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumDiscoveryDuration.Name = "NumDiscoveryDuration"
        Me.NumDiscoveryDuration.Size = New System.Drawing.Size(120, 20)
        Me.NumDiscoveryDuration.TabIndex = 3
        Me.NumDiscoveryDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumDiscoveryDuration.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Discovery IP Port Number (Default 32227)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number of Discovery Broadcasts (Default 1)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Discovery Duration (Default 2.0 seconds)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ASCOM.Utilities.My.Resources.Resources.ASCOMAlpacaMidRes
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ChkListAllDiscoveredDevices
        '
        Me.ChkListAllDiscoveredDevices.AutoSize = True
        Me.ChkListAllDiscoveredDevices.Location = New System.Drawing.Point(269, 216)
        Me.ChkListAllDiscoveredDevices.Name = "ChkListAllDiscoveredDevices"
        Me.ChkListAllDiscoveredDevices.Size = New System.Drawing.Size(218, 17)
        Me.ChkListAllDiscoveredDevices.TabIndex = 10
        Me.ChkListAllDiscoveredDevices.Text = "List all discovered devices (Default false)"
        Me.ChkListAllDiscoveredDevices.UseVisualStyleBackColor = True
        '
        'ChkShowDeviceDetails
        '
        Me.ChkShowDeviceDetails.AutoSize = True
        Me.ChkShowDeviceDetails.Location = New System.Drawing.Point(269, 239)
        Me.ChkShowDeviceDetails.Name = "ChkShowDeviceDetails"
        Me.ChkShowDeviceDetails.Size = New System.Drawing.Size(189, 17)
        Me.ChkShowDeviceDetails.TabIndex = 11
        Me.ChkShowDeviceDetails.Text = "Show device details (Default false)"
        Me.ChkShowDeviceDetails.UseVisualStyleBackColor = True
        '
        'NumExtraChooserWidth
        '
        Me.NumExtraChooserWidth.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumExtraChooserWidth.Location = New System.Drawing.Point(165, 151)
        Me.NumExtraChooserWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumExtraChooserWidth.Name = "NumExtraChooserWidth"
        Me.NumExtraChooserWidth.Size = New System.Drawing.Size(120, 20)
        Me.NumExtraChooserWidth.TabIndex = 12
        Me.NumExtraChooserWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Additional Chooser width (Default 0)"
        '
        'ChooserAlpacaConfigurationForm
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(659, 318)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumExtraChooserWidth)
        Me.Controls.Add(Me.ChkShowDeviceDetails)
        Me.Controls.Add(Me.ChkListAllDiscoveredDevices)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumDiscoveryDuration)
        Me.Controls.Add(Me.NumDiscoveryBroadcasts)
        Me.Controls.Add(Me.ChkDNSResolution)
        Me.Controls.Add(Me.NumDiscoveryIpPort)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChooserAlpacaConfigurationForm"
        Me.Text = "Alpaca Discovery Configuration"
        CType(Me.NumDiscoveryIpPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDiscoveryBroadcasts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDiscoveryDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumExtraChooserWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents NumDiscoveryIpPort As NumericUpDown
    Friend WithEvents ChkDNSResolution As CheckBox
    Friend WithEvents NumDiscoveryBroadcasts As NumericUpDown
    Friend WithEvents NumDiscoveryDuration As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChkListAllDiscoveredDevices As CheckBox
    Friend WithEvents ChkShowDeviceDetails As CheckBox
    Friend WithEvents NumExtraChooserWidth As NumericUpDown
    Friend WithEvents Label4 As Label
End Class