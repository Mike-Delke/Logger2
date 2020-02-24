<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.btnMobilePost = New System.Windows.Forms.Button()
        Me.btnLogIt = New System.Windows.Forms.Button()
        Me.btnSpot = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbMyState = New System.Windows.Forms.ComboBox()
        Me.cmbMyCounty = New System.Windows.Forms.ComboBox()
        Me.cmbContactState = New System.Windows.Forms.ComboBox()
        Me.cmbContactCounty = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbBand = New System.Windows.Forms.ComboBox()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.GroupBoxMyParameters = New System.Windows.Forms.GroupBox()
        Me.chkBigRig = New System.Windows.Forms.CheckBox()
        Me.cmbSubMode = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBoxTeamMembers = New System.Windows.Forms.GroupBox()
        Me.chkSecondaryTeamMember = New System.Windows.Forms.CheckBox()
        Me.ckbPrimaryTeamMember = New System.Windows.Forms.CheckBox()
        Me.chkQrp = New System.Windows.Forms.CheckBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.LabelMyCounty = New System.Windows.Forms.Label()
        Me.cmbMyCountyLine = New System.Windows.Forms.ComboBox()
        Me.LabelContactCountyLine = New System.Windows.Forms.Label()
        Me.cmbMyOperation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.chkRunningClock = New System.Windows.Forms.CheckBox()
        Me.cmbFrequency = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.qsoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currentCall = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactCountyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactCounty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.myCountyId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.myCounty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hisRst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.myRst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.band = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frequency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subNode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hisOp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.myOp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ButtonEditNext = New System.Windows.Forms.Button()
        Me.ButtonEditPrevious = New System.Windows.Forms.Button()
        Me.ButtonSaveEdit = New System.Windows.Forms.Button()
        Me.cmbContactOperation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbContactCountyLine = New System.Windows.Forms.ComboBox()
        Me.txtContactCall = New System.Windows.Forms.TextBox()
        Me.txtMyRST = New System.Windows.Forms.TextBox()
        Me.txtHisRST = New System.Windows.Forms.TextBox()
        Me.lblContactState = New System.Windows.Forms.Label()
        Me.lblContactCounty = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblContactCountyLine = New System.Windows.Forms.Label()
        Me.lblMyRST = New System.Windows.Forms.Label()
        Me.lblHisRST = New System.Windows.Forms.Label()
        Me.GroupBoxMobileParameters = New System.Windows.Forms.GroupBox()
        Me.txtContactHomeCounty = New System.Windows.Forms.TextBox()
        Me.lblContactHomeCounty = New System.Windows.Forms.Label()
        Me.txtContactInfo = New System.Windows.Forms.Label()
        Me.txtContactNames = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBoxMyParameters.SuspendLayout()
        Me.GroupBoxTeamMembers.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripLog.SuspendLayout()
        Me.GroupBoxMobileParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExit.Location = New System.Drawing.Point(1708, 904)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(182, 48)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Main Menu"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TimerClock
        '
        Me.TimerClock.Enabled = True
        Me.TimerClock.Interval = 5000
        '
        'btnMobilePost
        '
        Me.btnMobilePost.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMobilePost.Location = New System.Drawing.Point(1444, 904)
        Me.btnMobilePost.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMobilePost.Name = "btnMobilePost"
        Me.btnMobilePost.Size = New System.Drawing.Size(198, 48)
        Me.btnMobilePost.TabIndex = 22
        Me.btnMobilePost.Text = "Post to Log"
        Me.btnMobilePost.UseVisualStyleBackColor = False
        '
        'btnLogIt
        '
        Me.btnLogIt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogIt.Location = New System.Drawing.Point(1722, 448)
        Me.btnLogIt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogIt.Name = "btnLogIt"
        Me.btnLogIt.Size = New System.Drawing.Size(152, 66)
        Me.btnLogIt.TabIndex = 30
        Me.btnLogIt.Text = "Post"
        Me.btnLogIt.UseVisualStyleBackColor = False
        '
        'btnSpot
        '
        Me.btnSpot.BackColor = System.Drawing.Color.Yellow
        Me.btnSpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpot.Location = New System.Drawing.Point(444, 310)
        Me.btnSpot.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSpot.Name = "btnSpot"
        Me.btnSpot.Size = New System.Drawing.Size(92, 30)
        Me.btnSpot.TabIndex = 32
        Me.btnSpot.Text = "Spot"
        Me.btnSpot.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1722, 360)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 52)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Log It"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 1000
        '
        'cmbMyState
        '
        Me.cmbMyState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMyState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMyState.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyState.FormattingEnabled = True
        Me.cmbMyState.Location = New System.Drawing.Point(208, 24)
        Me.cmbMyState.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMyState.Name = "cmbMyState"
        Me.cmbMyState.Size = New System.Drawing.Size(48, 21)
        Me.cmbMyState.TabIndex = 44
        Me.cmbMyState.TabStop = False
        Me.ToolTip.SetToolTip(Me.cmbMyState, "Click on the arrow, and select the state you are in. You can enter the first lett" &
        "er to get close.")
        '
        'cmbMyCounty
        '
        Me.cmbMyCounty.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMyCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMyCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyCounty.FormattingEnabled = True
        Me.cmbMyCounty.Location = New System.Drawing.Point(326, 24)
        Me.cmbMyCounty.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMyCounty.Name = "cmbMyCounty"
        Me.cmbMyCounty.Size = New System.Drawing.Size(160, 21)
        Me.cmbMyCounty.TabIndex = 45
        Me.ToolTip.SetToolTip(Me.cmbMyCounty, "Click on the arrow and select a county. You can enter the first letter of the cou" &
        "nty to get close.")
        '
        'cmbContactState
        '
        Me.cmbContactState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbContactState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContactState.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactState.FormattingEnabled = True
        Me.cmbContactState.Location = New System.Drawing.Point(288, 24)
        Me.cmbContactState.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbContactState.Name = "cmbContactState"
        Me.cmbContactState.Size = New System.Drawing.Size(48, 21)
        Me.cmbContactState.TabIndex = 30
        Me.ToolTip.SetToolTip(Me.cmbContactState, "Click on the arrow, and select the state  You can enter the first letter to get c" &
        "lose.")
        '
        'cmbContactCounty
        '
        Me.cmbContactCounty.BackColor = System.Drawing.SystemColors.Window
        Me.cmbContactCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContactCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactCounty.FormattingEnabled = True
        Me.cmbContactCounty.Location = New System.Drawing.Point(420, 24)
        Me.cmbContactCounty.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbContactCounty.Name = "cmbContactCounty"
        Me.cmbContactCounty.Size = New System.Drawing.Size(160, 21)
        Me.cmbContactCounty.TabIndex = 31
        Me.ToolTip.SetToolTip(Me.cmbContactCounty, "Click on the arrow and select a county. You can enter the first letter of the cou" &
        "nty to get close.")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 88)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Info"
        Me.ToolTip.SetToolTip(Me.Label13, "Click here to display detail detailed data on the Contact Call(s)")
        '
        'cmbBand
        '
        Me.cmbBand.BackColor = System.Drawing.SystemColors.Window
        Me.cmbBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBand.FormattingEnabled = True
        Me.cmbBand.Items.AddRange(New Object() {"20", "30", "40", "80", "2", "6", "10", "12", "15", "17", "60", "160", "70 cm", "1.25"})
        Me.cmbBand.Location = New System.Drawing.Point(574, 88)
        Me.cmbBand.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBand.Name = "cmbBand"
        Me.cmbBand.Size = New System.Drawing.Size(120, 21)
        Me.cmbBand.TabIndex = 54
        Me.ToolTip.SetToolTip(Me.cmbBand, "Use F5->PSK F6->SSB f7->CW")
        '
        'cmbMode
        '
        Me.cmbMode.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"SSB", "CW", "AM", "AMTOR", "ATV", "CHIP", "CLOVER", "CONTESTIA", "DOMINO", "DSSTV", "DV", "FM", "FSK31", "FT8", "GTOR", "HAMDRM", "HELL", "HFSK", "JT65", "JT9", "MFSK", "MT63", "OLIVIA", "PACKET", "PAX", "PSK", "Q15", "ROS", "RTTY", "SSTV", "THOR", "THROB"})
        Me.cmbMode.Location = New System.Drawing.Point(574, 24)
        Me.cmbMode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(120, 21)
        Me.cmbMode.TabIndex = 53
        Me.ToolTip.SetToolTip(Me.cmbMode, "Use F1->20m F2->30m F3->40m")
        '
        'GroupBoxMyParameters
        '
        Me.GroupBoxMyParameters.AutoSize = True
        Me.GroupBoxMyParameters.Controls.Add(Me.chkBigRig)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbSubMode)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label12)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label14)
        Me.GroupBoxMyParameters.Controls.Add(Me.GroupBoxTeamMembers)
        Me.GroupBoxMyParameters.Controls.Add(Me.chkQrp)
        Me.GroupBoxMyParameters.Controls.Add(Me.txtTime)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label2)
        Me.GroupBoxMyParameters.Controls.Add(Me.txtDate)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyCounty)
        Me.GroupBoxMyParameters.Controls.Add(Me.LabelMyCounty)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyCountyLine)
        Me.GroupBoxMyParameters.Controls.Add(Me.LabelContactCountyLine)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyOperation)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyState)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label1)
        Me.GroupBoxMyParameters.Controls.Add(Me.lblDate)
        Me.GroupBoxMyParameters.Controls.Add(Me.chkRunningClock)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbFrequency)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbBand)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMode)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label8)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label9)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label7)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label4)
        Me.GroupBoxMyParameters.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxMyParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMyParameters.Location = New System.Drawing.Point(12, 8)
        Me.GroupBoxMyParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxMyParameters.Name = "GroupBoxMyParameters"
        Me.GroupBoxMyParameters.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxMyParameters.Size = New System.Drawing.Size(710, 196)
        Me.GroupBoxMyParameters.TabIndex = 44
        Me.GroupBoxMyParameters.TabStop = False
        Me.GroupBoxMyParameters.Text = "Station Data: K8EMS"
        '
        'chkBigRig
        '
        Me.chkBigRig.AutoSize = True
        Me.chkBigRig.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBigRig.Location = New System.Drawing.Point(188, 88)
        Me.chkBigRig.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBigRig.Name = "chkBigRig"
        Me.chkBigRig.Size = New System.Drawing.Size(67, 17)
        Me.chkBigRig.TabIndex = 69
        Me.chkBigRig.Text = "Big Rig"
        Me.chkBigRig.UseVisualStyleBackColor = True
        '
        'cmbSubMode
        '
        Me.cmbSubMode.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSubMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubMode.FormattingEnabled = True
        Me.cmbSubMode.Items.AddRange(New Object() {"SSB", "CW", "AM", "AMTOR", "ATV", "CHIP", "CLOVER", "CONTESTIA", "DOMINO", "DSSTV", "DV", "FM", "FSK31", "FT8", "GTOR", "HAMDRM", "HELL", "HFSK", "JT65", "JT9", "MFSK", "MT63", "OLIVIA", "PACKET", "PAX", "PSK", "Q15", "ROS", "RTTY", "SSTV", "THOR", "THROB"})
        Me.cmbSubMode.Location = New System.Drawing.Point(574, 56)
        Me.cmbSubMode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSubMode.Name = "cmbSubMode"
        Me.cmbSubMode.Size = New System.Drawing.Size(120, 21)
        Me.cmbSubMode.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(498, 60)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "SubMode"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(96, 92)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "UTC"
        '
        'GroupBoxTeamMembers
        '
        Me.GroupBoxTeamMembers.Controls.Add(Me.chkSecondaryTeamMember)
        Me.GroupBoxTeamMembers.Controls.Add(Me.ckbPrimaryTeamMember)
        Me.GroupBoxTeamMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTeamMembers.Location = New System.Drawing.Point(310, 88)
        Me.GroupBoxTeamMembers.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxTeamMembers.Name = "GroupBoxTeamMembers"
        Me.GroupBoxTeamMembers.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxTeamMembers.Size = New System.Drawing.Size(186, 52)
        Me.GroupBoxTeamMembers.TabIndex = 64
        Me.GroupBoxTeamMembers.TabStop = False
        Me.GroupBoxTeamMembers.Text = "Active Team Members"
        '
        'chkSecondaryTeamMember
        '
        Me.chkSecondaryTeamMember.AutoSize = True
        Me.chkSecondaryTeamMember.Location = New System.Drawing.Point(100, 28)
        Me.chkSecondaryTeamMember.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSecondaryTeamMember.Name = "chkSecondaryTeamMember"
        Me.chkSecondaryTeamMember.Size = New System.Drawing.Size(65, 17)
        Me.chkSecondaryTeamMember.TabIndex = 1
        Me.chkSecondaryTeamMember.Text = "N0XYL"
        Me.chkSecondaryTeamMember.UseVisualStyleBackColor = True
        '
        'ckbPrimaryTeamMember
        '
        Me.ckbPrimaryTeamMember.AutoSize = True
        Me.ckbPrimaryTeamMember.Checked = True
        Me.ckbPrimaryTeamMember.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbPrimaryTeamMember.Location = New System.Drawing.Point(12, 28)
        Me.ckbPrimaryTeamMember.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbPrimaryTeamMember.Name = "ckbPrimaryTeamMember"
        Me.ckbPrimaryTeamMember.Size = New System.Drawing.Size(65, 17)
        Me.ckbPrimaryTeamMember.TabIndex = 0
        Me.ckbPrimaryTeamMember.Text = "KB0BA"
        Me.ckbPrimaryTeamMember.UseVisualStyleBackColor = True
        '
        'chkQrp
        '
        Me.chkQrp.AutoSize = True
        Me.chkQrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQrp.Location = New System.Drawing.Point(188, 120)
        Me.chkQrp.Margin = New System.Windows.Forms.Padding(4)
        Me.chkQrp.Name = "chkQrp"
        Me.chkQrp.Size = New System.Drawing.Size(52, 17)
        Me.chkQrp.TabIndex = 63
        Me.chkQrp.Text = "QRP"
        Me.chkQrp.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(52, 88)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(40, 19)
        Me.txtTime.TabIndex = 62
        Me.txtTime.Text = "9999"
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "State"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(52, 56)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(80, 19)
        Me.txtDate.TabIndex = 60
        Me.txtDate.Text = "12/25/2020"
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMyCounty
        '
        Me.LabelMyCounty.AutoSize = True
        Me.LabelMyCounty.BackColor = System.Drawing.Color.Transparent
        Me.LabelMyCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMyCounty.Location = New System.Drawing.Point(262, 28)
        Me.LabelMyCounty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMyCounty.Name = "LabelMyCounty"
        Me.LabelMyCounty.Size = New System.Drawing.Size(46, 13)
        Me.LabelMyCounty.TabIndex = 50
        Me.LabelMyCounty.Text = "County"
        '
        'cmbMyCountyLine
        '
        Me.cmbMyCountyLine.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMyCountyLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMyCountyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyCountyLine.FormattingEnabled = True
        Me.cmbMyCountyLine.Items.AddRange(New Object() {"Menomonee", "Schoolcraft", "Marquette"})
        Me.cmbMyCountyLine.Location = New System.Drawing.Point(252, 56)
        Me.cmbMyCountyLine.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMyCountyLine.Name = "cmbMyCountyLine"
        Me.cmbMyCountyLine.Size = New System.Drawing.Size(232, 21)
        Me.cmbMyCountyLine.TabIndex = 46
        '
        'LabelContactCountyLine
        '
        Me.LabelContactCountyLine.AutoSize = True
        Me.LabelContactCountyLine.BackColor = System.Drawing.Color.Transparent
        Me.LabelContactCountyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContactCountyLine.Location = New System.Drawing.Point(152, 60)
        Me.LabelContactCountyLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContactCountyLine.Name = "LabelContactCountyLine"
        Me.LabelContactCountyLine.Size = New System.Drawing.Size(74, 13)
        Me.LabelContactCountyLine.TabIndex = 51
        Me.LabelContactCountyLine.Text = "County Line"
        '
        'cmbMyOperation
        '
        Me.cmbMyOperation.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMyOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMyOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyOperation.FormattingEnabled = True
        Me.cmbMyOperation.Location = New System.Drawing.Point(52, 24)
        Me.cmbMyOperation.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMyOperation.Name = "cmbMyOperation"
        Me.cmbMyOperation.Size = New System.Drawing.Size(80, 21)
        Me.cmbMyOperation.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "OP"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(0, 60)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 13)
        Me.lblDate.TabIndex = 55
        Me.lblDate.Text = "Date"
        '
        'chkRunningClock
        '
        Me.chkRunningClock.AutoSize = True
        Me.chkRunningClock.Checked = True
        Me.chkRunningClock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRunningClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRunningClock.Location = New System.Drawing.Point(24, 120)
        Me.chkRunningClock.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRunningClock.Name = "chkRunningClock"
        Me.chkRunningClock.Size = New System.Drawing.Size(119, 19)
        Me.chkRunningClock.TabIndex = 61
        Me.chkRunningClock.Text = "Running Clock"
        Me.chkRunningClock.UseVisualStyleBackColor = True
        '
        'cmbFrequency
        '
        Me.cmbFrequency.BackColor = System.Drawing.SystemColors.Window
        Me.cmbFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrequency.FormattingEnabled = True
        Me.cmbFrequency.Items.AddRange(New Object() {"14.336", "7.188", "52.525", "28.336", "24.950", "21.338", "18.136", "3.901", "1.950"})
        Me.cmbFrequency.Location = New System.Drawing.Point(574, 118)
        Me.cmbFrequency.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFrequency.Name = "cmbFrequency"
        Me.cmbFrequency.Size = New System.Drawing.Size(120, 21)
        Me.cmbFrequency.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(524, 92)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Band"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(528, 122)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Freq"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(520, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Time"
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.ForeColor = System.Drawing.Color.White
        Me.btnPost.Location = New System.Drawing.Point(72, 310)
        Me.btnPost.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(92, 30)
        Me.btnPost.TabIndex = 46
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(196, 310)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(92, 30)
        Me.ButtonClear.TabIndex = 47
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(320, 310)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(92, 30)
        Me.ButtonEdit.TabIndex = 48
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'dataGridView
        '
        Me.dataGridView.AllowUserToAddRows = False
        Me.dataGridView.AllowUserToDeleteRows = False
        Me.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.qsoId, Me.dateCol, Me.time, Me.currentCall, Me.contactCountyID, Me.contactCounty, Me.myCountyId, Me.myCounty, Me.hisRst, Me.myRst, Me.band, Me.frequency, Me.mode, Me.subNode, Me.hisOp, Me.myOp})
        Me.dataGridView.ContextMenuStrip = Me.ContextMenuStripLog
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridView.Location = New System.Drawing.Point(-12, 362)
        Me.dataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.RowTemplate.Height = 24
        Me.dataGridView.Size = New System.Drawing.Size(748, 396)
        Me.dataGridView.TabIndex = 49
        '
        'qsoId
        '
        Me.qsoId.FillWeight = 50.0!
        Me.qsoId.HeaderText = "qsoId"
        Me.qsoId.Name = "qsoId"
        Me.qsoId.ReadOnly = True
        Me.qsoId.Visible = False
        '
        'dateCol
        '
        Me.dateCol.HeaderText = "Date"
        Me.dateCol.Name = "dateCol"
        Me.dateCol.ReadOnly = True
        Me.dateCol.Width = 55
        '
        'time
        '
        Me.time.HeaderText = "Time"
        Me.time.Name = "time"
        Me.time.Width = 55
        '
        'currentCall
        '
        Me.currentCall.HeaderText = "Call"
        Me.currentCall.Name = "currentCall"
        Me.currentCall.Width = 49
        '
        'contactCountyID
        '
        Me.contactCountyID.HeaderText = "contactCountyId"
        Me.contactCountyID.Name = "contactCountyID"
        Me.contactCountyID.Visible = False
        '
        'contactCounty
        '
        Me.contactCounty.HeaderText = "His County"
        Me.contactCounty.Name = "contactCounty"
        Me.contactCounty.Width = 83
        '
        'myCountyId
        '
        Me.myCountyId.HeaderText = "myCountyId"
        Me.myCountyId.Name = "myCountyId"
        Me.myCountyId.Visible = False
        '
        'myCounty
        '
        Me.myCounty.HeaderText = "My County"
        Me.myCounty.Name = "myCounty"
        Me.myCounty.Width = 82
        '
        'hisRst
        '
        Me.hisRst.HeaderText = "His RST"
        Me.hisRst.Name = "hisRst"
        Me.hisRst.Width = 72
        '
        'myRst
        '
        Me.myRst.HeaderText = "My RST"
        Me.myRst.Name = "myRst"
        Me.myRst.Width = 71
        '
        'band
        '
        Me.band.HeaderText = "Band"
        Me.band.Name = "band"
        Me.band.Width = 57
        '
        'frequency
        '
        Me.frequency.HeaderText = "Freq"
        Me.frequency.Name = "frequency"
        Me.frequency.Width = 53
        '
        'mode
        '
        Me.mode.HeaderText = "Mode"
        Me.mode.Name = "mode"
        Me.mode.Width = 59
        '
        'subNode
        '
        Me.subNode.HeaderText = "Sub Mode"
        Me.subNode.Name = "subNode"
        Me.subNode.Width = 81
        '
        'hisOp
        '
        Me.hisOp.HeaderText = "His OP"
        Me.hisOp.Name = "hisOp"
        Me.hisOp.Width = 65
        '
        'myOp
        '
        Me.myOp.HeaderText = "My Op"
        Me.myOp.Name = "myOp"
        Me.myOp.Width = 63
        '
        'ContextMenuStripLog
        '
        Me.ContextMenuStripLog.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStripLog.Name = "ContextMenuStripLog"
        Me.ContextMenuStripLog.Size = New System.Drawing.Size(103, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(568, 310)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 30)
        Me.btnClose.TabIndex = 50
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ButtonEditNext
        '
        Me.ButtonEditNext.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonEditNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditNext.Location = New System.Drawing.Point(56, 300)
        Me.ButtonEditNext.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEditNext.Name = "ButtonEditNext"
        Me.ButtonEditNext.Size = New System.Drawing.Size(118, 22)
        Me.ButtonEditNext.TabIndex = 51
        Me.ButtonEditNext.Text = "Edit Next"
        Me.ButtonEditNext.UseVisualStyleBackColor = False
        Me.ButtonEditNext.Visible = False
        '
        'ButtonEditPrevious
        '
        Me.ButtonEditPrevious.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonEditPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditPrevious.Location = New System.Drawing.Point(56, 326)
        Me.ButtonEditPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEditPrevious.Name = "ButtonEditPrevious"
        Me.ButtonEditPrevious.Size = New System.Drawing.Size(120, 22)
        Me.ButtonEditPrevious.TabIndex = 52
        Me.ButtonEditPrevious.Text = "Edit Previous"
        Me.ButtonEditPrevious.UseVisualStyleBackColor = False
        Me.ButtonEditPrevious.Visible = False
        '
        'ButtonSaveEdit
        '
        Me.ButtonSaveEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonSaveEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveEdit.Location = New System.Drawing.Point(196, 294)
        Me.ButtonSaveEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSaveEdit.Name = "ButtonSaveEdit"
        Me.ButtonSaveEdit.Size = New System.Drawing.Size(92, 30)
        Me.ButtonSaveEdit.TabIndex = 53
        Me.ButtonSaveEdit.Text = "Save Edit"
        Me.ButtonSaveEdit.UseVisualStyleBackColor = False
        Me.ButtonSaveEdit.Visible = False
        '
        'cmbContactOperation
        '
        Me.cmbContactOperation.AllowDrop = True
        Me.cmbContactOperation.AutoCompleteCustomSource.AddRange(New String() {"Fixed", "Mobile", "Portable"})
        Me.cmbContactOperation.BackColor = System.Drawing.SystemColors.Window
        Me.cmbContactOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContactOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactOperation.FormattingEnabled = True
        Me.cmbContactOperation.Location = New System.Drawing.Point(340, 84)
        Me.cmbContactOperation.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbContactOperation.Name = "cmbContactOperation"
        Me.cmbContactOperation.Size = New System.Drawing.Size(80, 21)
        Me.cmbContactOperation.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "OP"
        '
        'cmbContactCountyLine
        '
        Me.cmbContactCountyLine.BackColor = System.Drawing.SystemColors.Window
        Me.cmbContactCountyLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContactCountyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactCountyLine.FormattingEnabled = True
        Me.cmbContactCountyLine.Location = New System.Drawing.Point(338, 54)
        Me.cmbContactCountyLine.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbContactCountyLine.Name = "cmbContactCountyLine"
        Me.cmbContactCountyLine.Size = New System.Drawing.Size(242, 21)
        Me.cmbContactCountyLine.TabIndex = 32
        '
        'txtContactCall
        '
        Me.txtContactCall.BackColor = System.Drawing.SystemColors.Window
        Me.txtContactCall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactCall.Location = New System.Drawing.Point(66, 28)
        Me.txtContactCall.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactCall.Name = "txtContactCall"
        Me.txtContactCall.Size = New System.Drawing.Size(150, 19)
        Me.txtContactCall.TabIndex = 33
        Me.txtContactCall.Text = "KA9JAC/KB9YVT"
        Me.txtContactCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMyRST
        '
        Me.txtMyRST.BackColor = System.Drawing.SystemColors.Window
        Me.txtMyRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyRST.Location = New System.Drawing.Point(660, 24)
        Me.txtMyRST.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMyRST.Name = "txtMyRST"
        Me.txtMyRST.Size = New System.Drawing.Size(44, 19)
        Me.txtMyRST.TabIndex = 34
        Me.txtMyRST.Text = "59"
        Me.txtMyRST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHisRST
        '
        Me.txtHisRST.BackColor = System.Drawing.SystemColors.Window
        Me.txtHisRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHisRST.Location = New System.Drawing.Point(660, 54)
        Me.txtHisRST.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHisRST.Name = "txtHisRST"
        Me.txtHisRST.Size = New System.Drawing.Size(44, 19)
        Me.txtHisRST.TabIndex = 35
        Me.txtHisRST.Text = "59"
        Me.txtHisRST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblContactState
        '
        Me.lblContactState.AutoSize = True
        Me.lblContactState.BackColor = System.Drawing.Color.Transparent
        Me.lblContactState.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactState.Location = New System.Drawing.Point(238, 28)
        Me.lblContactState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactState.Name = "lblContactState"
        Me.lblContactState.Size = New System.Drawing.Size(37, 13)
        Me.lblContactState.TabIndex = 36
        Me.lblContactState.Text = "State"
        '
        'lblContactCounty
        '
        Me.lblContactCounty.AutoSize = True
        Me.lblContactCounty.BackColor = System.Drawing.Color.Transparent
        Me.lblContactCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactCounty.Location = New System.Drawing.Point(352, 28)
        Me.lblContactCounty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactCounty.Name = "lblContactCounty"
        Me.lblContactCounty.Size = New System.Drawing.Size(46, 13)
        Me.lblContactCounty.TabIndex = 37
        Me.lblContactCounty.Text = "County"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 32)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Call(s)"
        '
        'lblContactCountyLine
        '
        Me.lblContactCountyLine.AutoSize = True
        Me.lblContactCountyLine.BackColor = System.Drawing.Color.Transparent
        Me.lblContactCountyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactCountyLine.Location = New System.Drawing.Point(238, 60)
        Me.lblContactCountyLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactCountyLine.Name = "lblContactCountyLine"
        Me.lblContactCountyLine.Size = New System.Drawing.Size(74, 13)
        Me.lblContactCountyLine.TabIndex = 38
        Me.lblContactCountyLine.Text = "County Line"
        '
        'lblMyRST
        '
        Me.lblMyRST.AutoSize = True
        Me.lblMyRST.BackColor = System.Drawing.Color.Transparent
        Me.lblMyRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyRST.Location = New System.Drawing.Point(592, 26)
        Me.lblMyRST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMyRST.Name = "lblMyRST"
        Me.lblMyRST.Size = New System.Drawing.Size(52, 13)
        Me.lblMyRST.TabIndex = 39
        Me.lblMyRST.Text = "My RST"
        '
        'lblHisRST
        '
        Me.lblHisRST.AutoSize = True
        Me.lblHisRST.BackColor = System.Drawing.Color.Transparent
        Me.lblHisRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHisRST.Location = New System.Drawing.Point(592, 56)
        Me.lblHisRST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHisRST.Name = "lblHisRST"
        Me.lblHisRST.Size = New System.Drawing.Size(54, 13)
        Me.lblHisRST.TabIndex = 40
        Me.lblHisRST.Text = "His RST"
        '
        'GroupBoxMobileParameters
        '
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtContactHomeCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactHomeCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtContactInfo)
        Me.GroupBoxMobileParameters.Controls.Add(Me.Label13)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtContactNames)
        Me.GroupBoxMobileParameters.Controls.Add(Me.Label10)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblHisRST)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblMyRST)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactCountyLine)
        Me.GroupBoxMobileParameters.Controls.Add(Me.Label11)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactState)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtHisRST)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtMyRST)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtContactCall)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactCountyLine)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactState)
        Me.GroupBoxMobileParameters.Controls.Add(Me.Label3)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactOperation)
        Me.GroupBoxMobileParameters.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxMobileParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMobileParameters.Location = New System.Drawing.Point(12, 160)
        Me.GroupBoxMobileParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxMobileParameters.Name = "GroupBoxMobileParameters"
        Me.GroupBoxMobileParameters.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxMobileParameters.Size = New System.Drawing.Size(708, 122)
        Me.GroupBoxMobileParameters.TabIndex = 45
        Me.GroupBoxMobileParameters.TabStop = False
        Me.GroupBoxMobileParameters.Text = "Contact Data"
        '
        'txtContactHomeCounty
        '
        Me.txtContactHomeCounty.Location = New System.Drawing.Point(338, 4)
        Me.txtContactHomeCounty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactHomeCounty.Name = "txtContactHomeCounty"
        Me.txtContactHomeCounty.ReadOnly = True
        Me.txtContactHomeCounty.Size = New System.Drawing.Size(242, 19)
        Me.txtContactHomeCounty.TabIndex = 47
        '
        'lblContactHomeCounty
        '
        Me.lblContactHomeCounty.AutoSize = True
        Me.lblContactHomeCounty.Location = New System.Drawing.Point(252, 12)
        Me.lblContactHomeCounty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactHomeCounty.Name = "lblContactHomeCounty"
        Me.lblContactHomeCounty.Size = New System.Drawing.Size(82, 13)
        Me.lblContactHomeCounty.TabIndex = 46
        Me.lblContactHomeCounty.Text = "Home County"
        '
        'txtContactInfo
        '
        Me.txtContactInfo.Location = New System.Drawing.Point(72, 88)
        Me.txtContactInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtContactInfo.Name = "txtContactInfo"
        Me.txtContactInfo.Size = New System.Drawing.Size(228, 16)
        Me.txtContactInfo.TabIndex = 45
        Me.txtContactInfo.Text = "Lowell and Sandra"
        '
        'txtContactNames
        '
        Me.txtContactNames.Location = New System.Drawing.Point(68, 58)
        Me.txtContactNames.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtContactNames.Name = "txtContactNames"
        Me.txtContactNames.Size = New System.Drawing.Size(170, 16)
        Me.txtContactNames.TabIndex = 43
        Me.txtContactNames.Text = "Lowell and Sandra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Name(s)"
        '
        'frmLogEntry
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(728, 768)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.ButtonEditPrevious)
        Me.Controls.Add(Me.ButtonEditNext)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.GroupBoxMobileParameters)
        Me.Controls.Add(Me.GroupBoxMyParameters)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogIt)
        Me.Controls.Add(Me.btnMobilePost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ButtonSaveEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSpot)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogEntry"
        Me.Text = "Log Entry Form"
        Me.GroupBoxMyParameters.ResumeLayout(False)
        Me.GroupBoxMyParameters.PerformLayout()
        Me.GroupBoxTeamMembers.ResumeLayout(False)
        Me.GroupBoxTeamMembers.PerformLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripLog.ResumeLayout(False)
        Me.GroupBoxMobileParameters.ResumeLayout(False)
        Me.GroupBoxMobileParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents TimerClock As Timer
    Friend WithEvents btnMobilePost As Button
    Friend WithEvents btnLogIt As Button
    Friend WithEvents btnSpot As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GroupBoxMyParameters As GroupBox
    Friend WithEvents GroupBoxTeamMembers As GroupBox
    Friend WithEvents chkSecondaryTeamMember As CheckBox
    Friend WithEvents ckbPrimaryTeamMember As CheckBox
    Friend WithEvents chkQrp As CheckBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents LabelMyCounty As Label
    Friend WithEvents cmbMyCountyLine As ComboBox
    Friend WithEvents LabelContactCountyLine As Label
    Friend WithEvents cmbMyOperation As ComboBox
    Friend WithEvents cmbMyState As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents chkRunningClock As CheckBox
    Friend WithEvents cmbFrequency As ComboBox
    Friend WithEvents cmbBand As ComboBox
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPost As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents ButtonEditNext As Button
    Friend WithEvents ButtonEditPrevious As Button
    Friend WithEvents ButtonSaveEdit As Button
    Friend WithEvents cmbContactOperation As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbContactState As ComboBox
    Friend WithEvents cmbContactCounty As ComboBox
    Friend WithEvents cmbContactCountyLine As ComboBox
    Friend WithEvents txtContactCall As TextBox
    Friend WithEvents txtMyRST As TextBox
    Friend WithEvents txtHisRST As TextBox
    Friend WithEvents lblContactState As Label
    Friend WithEvents lblContactCounty As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblContactCountyLine As Label
    Friend WithEvents lblMyRST As Label
    Friend WithEvents lblHisRST As Label
    Friend WithEvents GroupBoxMobileParameters As GroupBox
    Friend WithEvents txtContactInfo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtContactNames As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbMyCounty As ComboBox
    Friend WithEvents cmbSubMode As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkBigRig As CheckBox
    Friend WithEvents txtContactHomeCounty As TextBox
    Friend WithEvents lblContactHomeCounty As Label
    Friend WithEvents qsoId As DataGridViewTextBoxColumn
    Friend WithEvents dateCol As DataGridViewTextBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
    Friend WithEvents currentCall As DataGridViewTextBoxColumn
    Friend WithEvents contactCountyID As DataGridViewTextBoxColumn
    Friend WithEvents contactCounty As DataGridViewTextBoxColumn
    Friend WithEvents myCountyId As DataGridViewTextBoxColumn
    Friend WithEvents myCounty As DataGridViewTextBoxColumn
    Friend WithEvents hisRst As DataGridViewTextBoxColumn
    Friend WithEvents myRst As DataGridViewTextBoxColumn
    Friend WithEvents band As DataGridViewTextBoxColumn
    Friend WithEvents frequency As DataGridViewTextBoxColumn
    Friend WithEvents mode As DataGridViewTextBoxColumn
    Friend WithEvents subNode As DataGridViewTextBoxColumn
    Friend WithEvents hisOp As DataGridViewTextBoxColumn
    Friend WithEvents myOp As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStripLog As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
