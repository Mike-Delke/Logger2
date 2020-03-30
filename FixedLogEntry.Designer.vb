<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FixedLogEntry
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FixedLogEntry))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMyOperation = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbMyState = New System.Windows.Forms.ComboBox()
        Me.cmbMyCounty = New System.Windows.Forms.ComboBox()
        Me.cmbMyCountyLine = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelMyCounty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbBand = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cmbFrequency = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.cmbContactState = New System.Windows.Forms.ComboBox()
        Me.cmbContactCounty = New System.Windows.Forms.ComboBox()
        Me.cmbContactCountyLine = New System.Windows.Forms.ComboBox()
        Me.txtcontactCall = New System.Windows.Forms.TextBox()
        Me.txtMyrst = New System.Windows.Forms.TextBox()
        Me.txtHisrst = New System.Windows.Forms.TextBox()
        Me.lblContactState = New System.Windows.Forms.Label()
        Me.lblContactCounty = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblContactCountyLine = New System.Windows.Forms.Label()
        Me.lblMrst = New System.Windows.Forms.Label()
        Me.lblHrst = New System.Windows.Forms.Label()
        Me.ButtonSaveEdit = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.LblDate2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.chkRunningClock = New System.Windows.Forms.CheckBox()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnSpot = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbSubMode = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkBigRig = New System.Windows.Forms.CheckBox()
        Me.chkQrp = New System.Windows.Forms.CheckBox()
        Me.ckbPrimaryTeamMember = New System.Windows.Forms.CheckBox()
        Me.chkSecondaryTeamMember = New System.Windows.Forms.CheckBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonEditNext = New System.Windows.Forms.Button()
        Me.ButtonEditPrevious = New System.Windows.Forms.Button()
        Me.txtContactHomeCounty = New System.Windows.Forms.TextBox()
        Me.cmbContactOperation = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtContactNames = New System.Windows.Forms.TextBox()
        Me.txtContactInfo = New System.Windows.Forms.TextBox()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.Info = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBoxMyParameters = New System.Windows.Forms.GroupBox()
        Me.lblCall = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxTeamMembers = New System.Windows.Forms.GroupBox()
        Me.GroupBoxMobileParameters = New System.Windows.Forms.GroupBox()
        Me.lblContactHomeCounty = New System.Windows.Forms.Label()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblYourLog = New System.Windows.Forms.Label()
        Me.txtlDate = New System.Windows.Forms.TextBox()
        Me.txtltime = New System.Windows.Forms.TextBox()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMyParameters.SuspendLayout()
        Me.GroupBoxTeamMembers.SuspendLayout()
        Me.GroupBoxMobileParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(470, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Log Entry Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbMyOperation
        '
        Me.cmbMyOperation.AllowDrop = True
        Me.cmbMyOperation.AutoCompleteCustomSource.AddRange(New String() {"Fixed", "Mobile", "Portable"})
        Me.cmbMyOperation.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbMyOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyOperation.FormattingEnabled = True
        Me.cmbMyOperation.Items.AddRange(New Object() {"Home", "Mobile", "Portable"})
        Me.cmbMyOperation.Location = New System.Drawing.Point(50, 38)
        Me.cmbMyOperation.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMyOperation.Name = "cmbMyOperation"
        Me.cmbMyOperation.Size = New System.Drawing.Size(113, 24)
        Me.cmbMyOperation.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExit.Location = New System.Drawing.Point(1006, 593)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Main Menu"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cmbMyState
        '
        Me.cmbMyState.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbMyState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyState.FormattingEnabled = True
        Me.cmbMyState.Location = New System.Drawing.Point(201, 38)
        Me.cmbMyState.Name = "cmbMyState"
        Me.cmbMyState.Size = New System.Drawing.Size(77, 24)
        Me.cmbMyState.TabIndex = 5
        Me.cmbMyState.Text = "Mi"
        '
        'cmbMyCounty
        '
        Me.cmbMyCounty.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbMyCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyCounty.FormattingEnabled = True
        Me.cmbMyCounty.Location = New System.Drawing.Point(294, 39)
        Me.cmbMyCounty.Name = "cmbMyCounty"
        Me.cmbMyCounty.Size = New System.Drawing.Size(158, 24)
        Me.cmbMyCounty.TabIndex = 6
        Me.cmbMyCounty.Text = "Delta"
        '
        'cmbMyCountyLine
        '
        Me.cmbMyCountyLine.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbMyCountyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyCountyLine.FormattingEnabled = True
        Me.cmbMyCountyLine.Items.AddRange(New Object() {"Menomonee", "Schoolcraft", "Marquette"})
        Me.cmbMyCountyLine.Location = New System.Drawing.Point(236, 86)
        Me.cmbMyCountyLine.Name = "cmbMyCountyLine"
        Me.cmbMyCountyLine.Size = New System.Drawing.Size(222, 24)
        Me.cmbMyCountyLine.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Op"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "State"
        '
        'LabelMyCounty
        '
        Me.LabelMyCounty.AutoSize = True
        Me.LabelMyCounty.BackColor = System.Drawing.Color.Transparent
        Me.LabelMyCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMyCounty.Location = New System.Drawing.Point(343, 21)
        Me.LabelMyCounty.Name = "LabelMyCounty"
        Me.LabelMyCounty.Size = New System.Drawing.Size(58, 17)
        Me.LabelMyCounty.TabIndex = 8
        Me.LabelMyCounty.Text = "County"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(297, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "County Line"
        '
        'cmbMode
        '
        Me.cmbMode.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"SSB", "CW", "AM", "FM", "DIGITAL"})
        Me.cmbMode.Location = New System.Drawing.Point(957, 86)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(94, 24)
        Me.cmbMode.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(975, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Mode"
        '
        'cmbBand
        '
        Me.cmbBand.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBand.FormattingEnabled = True
        Me.cmbBand.Items.AddRange(New Object() {"20", "40", "80", "70 CM", "1.25", "2", "6", "10", "12", "15", "17", "30", "60", "160"})
        Me.cmbBand.Location = New System.Drawing.Point(786, 131)
        Me.cmbBand.Name = "cmbBand"
        Me.cmbBand.Size = New System.Drawing.Size(98, 24)
        Me.cmbBand.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(803, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Band"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(882, 13)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(250, 55)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Time UTC"
        '
        'cmbFrequency
        '
        Me.cmbFrequency.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbFrequency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrequency.FormattingEnabled = True
        Me.cmbFrequency.Location = New System.Drawing.Point(937, 134)
        Me.cmbFrequency.Name = "cmbFrequency"
        Me.cmbFrequency.Size = New System.Drawing.Size(121, 24)
        Me.cmbFrequency.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(955, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Frequency"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'dataGridView
        '
        Me.dataGridView.AllowUserToResizeRows = False
        Me.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridView.Location = New System.Drawing.Point(21, 302)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridView.RowTemplate.Height = 24
        Me.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView.Size = New System.Drawing.Size(1105, 275)
        Me.dataGridView.TabIndex = 13
        Me.dataGridView.TabStop = False
        '
        'cmbContactState
        '
        Me.cmbContactState.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbContactState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactState.FormattingEnabled = True
        Me.cmbContactState.Location = New System.Drawing.Point(742, 12)
        Me.cmbContactState.Name = "cmbContactState"
        Me.cmbContactState.Size = New System.Drawing.Size(50, 24)
        Me.cmbContactState.TabIndex = 14
        '
        'cmbContactCounty
        '
        Me.cmbContactCounty.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbContactCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactCounty.FormattingEnabled = True
        Me.cmbContactCounty.Location = New System.Drawing.Point(859, 12)
        Me.cmbContactCounty.Name = "cmbContactCounty"
        Me.cmbContactCounty.Size = New System.Drawing.Size(257, 24)
        Me.cmbContactCounty.TabIndex = 14
        '
        'cmbContactCountyLine
        '
        Me.cmbContactCountyLine.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbContactCountyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactCountyLine.FormattingEnabled = True
        Me.cmbContactCountyLine.Location = New System.Drawing.Point(587, 40)
        Me.cmbContactCountyLine.Name = "cmbContactCountyLine"
        Me.cmbContactCountyLine.Size = New System.Drawing.Size(293, 24)
        Me.cmbContactCountyLine.TabIndex = 14
        '
        'txtcontactCall
        '
        Me.txtcontactCall.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtcontactCall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontactCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactCall.HideSelection = False
        Me.txtcontactCall.Location = New System.Drawing.Point(70, 42)
        Me.txtcontactCall.Name = "txtcontactCall"
        Me.txtcontactCall.Size = New System.Drawing.Size(275, 22)
        Me.txtcontactCall.TabIndex = 15
        Me.txtcontactCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMyrst
        '
        Me.txtMyrst.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtMyrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyrst.Location = New System.Drawing.Point(953, 42)
        Me.txtMyrst.Name = "txtMyrst"
        Me.txtMyrst.Size = New System.Drawing.Size(100, 22)
        Me.txtMyrst.TabIndex = 15
        Me.txtMyrst.Text = "59"
        Me.txtMyrst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHisrst
        '
        Me.txtHisrst.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtHisrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHisrst.Location = New System.Drawing.Point(953, 72)
        Me.txtHisrst.Name = "txtHisrst"
        Me.txtHisrst.Size = New System.Drawing.Size(100, 22)
        Me.txtHisrst.TabIndex = 15
        Me.txtHisrst.Text = "59"
        Me.txtHisrst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblContactState
        '
        Me.lblContactState.AutoSize = True
        Me.lblContactState.BackColor = System.Drawing.Color.Transparent
        Me.lblContactState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactState.Location = New System.Drawing.Point(694, 15)
        Me.lblContactState.Name = "lblContactState"
        Me.lblContactState.Size = New System.Drawing.Size(44, 16)
        Me.lblContactState.TabIndex = 16
        Me.lblContactState.Text = "State"
        '
        'lblContactCounty
        '
        Me.lblContactCounty.AutoSize = True
        Me.lblContactCounty.BackColor = System.Drawing.Color.Transparent
        Me.lblContactCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactCounty.Location = New System.Drawing.Point(798, 15)
        Me.lblContactCounty.Name = "lblContactCounty"
        Me.lblContactCounty.Size = New System.Drawing.Size(55, 16)
        Me.lblContactCounty.TabIndex = 16
        Me.lblContactCounty.Text = "County"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Call/s"
        '
        'lblContactCountyLine
        '
        Me.lblContactCountyLine.AutoSize = True
        Me.lblContactCountyLine.BackColor = System.Drawing.Color.Transparent
        Me.lblContactCountyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactCountyLine.Location = New System.Drawing.Point(493, 43)
        Me.lblContactCountyLine.Name = "lblContactCountyLine"
        Me.lblContactCountyLine.Size = New System.Drawing.Size(88, 16)
        Me.lblContactCountyLine.TabIndex = 16
        Me.lblContactCountyLine.Text = "County Line"
        '
        'lblMrst
        '
        Me.lblMrst.AutoSize = True
        Me.lblMrst.BackColor = System.Drawing.Color.Transparent
        Me.lblMrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMrst.Location = New System.Drawing.Point(886, 42)
        Me.lblMrst.Name = "lblMrst"
        Me.lblMrst.Size = New System.Drawing.Size(63, 16)
        Me.lblMrst.TabIndex = 16
        Me.lblMrst.Text = "My RST"
        '
        'lblHrst
        '
        Me.lblHrst.AutoSize = True
        Me.lblHrst.BackColor = System.Drawing.Color.Transparent
        Me.lblHrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrst.Location = New System.Drawing.Point(888, 72)
        Me.lblHrst.Name = "lblHrst"
        Me.lblHrst.Size = New System.Drawing.Size(66, 16)
        Me.lblHrst.TabIndex = 16
        Me.lblHrst.Text = "His RST"
        '
        'ButtonSaveEdit
        '
        Me.ButtonSaveEdit.BackColor = System.Drawing.Color.SkyBlue
        Me.ButtonSaveEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveEdit.Location = New System.Drawing.Point(434, 593)
        Me.ButtonSaveEdit.Name = "ButtonSaveEdit"
        Me.ButtonSaveEdit.Size = New System.Drawing.Size(121, 32)
        Me.ButtonSaveEdit.TabIndex = 22
        Me.ButtonSaveEdit.Text = "Save Edit"
        Me.ButtonSaveEdit.UseVisualStyleBackColor = False
        Me.ButtonSaveEdit.Visible = False
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(49, 103)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(114, 22)
        Me.txtTime.TabIndex = 23
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.BackColor = System.Drawing.Color.Transparent
        Me.lblTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(2, 106)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(43, 16)
        Me.lblTime2.TabIndex = 25
        Me.lblTime2.Text = "Time"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(49, 69)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(114, 22)
        Me.txtDate.TabIndex = 26
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDate2
        '
        Me.LblDate2.AutoSize = True
        Me.LblDate2.BackColor = System.Drawing.Color.Transparent
        Me.LblDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate2.Location = New System.Drawing.Point(2, 72)
        Me.LblDate2.Name = "LblDate2"
        Me.LblDate2.Size = New System.Drawing.Size(41, 16)
        Me.LblDate2.TabIndex = 27
        Me.LblDate2.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(608, 282)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 28
        Me.DateTimePicker1.Visible = False
        '
        'chkRunningClock
        '
        Me.chkRunningClock.AutoSize = True
        Me.chkRunningClock.Checked = True
        Me.chkRunningClock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRunningClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRunningClock.Location = New System.Drawing.Point(138, 138)
        Me.chkRunningClock.Name = "chkRunningClock"
        Me.chkRunningClock.Size = New System.Drawing.Size(119, 19)
        Me.chkRunningClock.TabIndex = 29
        Me.chkRunningClock.Text = "Running Clock"
        Me.chkRunningClock.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.SkyBlue
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Location = New System.Drawing.Point(870, 593)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(117, 32)
        Me.btnPost.TabIndex = 30
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'btnSpot
        '
        Me.btnSpot.BackColor = System.Drawing.Color.Yellow
        Me.btnSpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpot.Location = New System.Drawing.Point(13, 593)
        Me.btnSpot.Name = "btnSpot"
        Me.btnSpot.Size = New System.Drawing.Size(113, 32)
        Me.btnSpot.TabIndex = 32
        Me.btnSpot.Text = "Spot"
        Me.btnSpot.UseVisualStyleBackColor = False
        Me.btnSpot.Visible = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.SkyBlue
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(733, 593)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(117, 32)
        Me.ButtonEdit.TabIndex = 33
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(870, 271)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(250, 55)
        Me.WebBrowser1.TabIndex = 34
        Me.WebBrowser1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(119, 275)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 23)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Text = "   (NL)"
        Me.TextBox1.Visible = False
        '
        'cmbSubMode
        '
        Me.cmbSubMode.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbSubMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubMode.FormattingEnabled = True
        Me.cmbSubMode.Items.AddRange(New Object() {"AMTOR", "ATV", "CHIP", "CLOVER", "CONTESTIA", "DOMINO", "DSSTV", "DV", "FSK31", "FT4", "FT8", "QAM", "GTOR", "HAMDRM", "HELL", "HFSK", "JT64", "MT63", "OLIVIA", "PACLET", "PAX", "PSK", "Q15", "ROS", "RTTY", "SSTV", "THOR", "THROB"})
        Me.cmbSubMode.Location = New System.Drawing.Point(786, 85)
        Me.cmbSubMode.Name = "cmbSubMode"
        Me.cmbSubMode.Size = New System.Drawing.Size(97, 24)
        Me.cmbSubMode.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(803, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Sub Mode"
        '
        'chkBigRig
        '
        Me.chkBigRig.AutoSize = True
        Me.chkBigRig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBigRig.Location = New System.Drawing.Point(277, 138)
        Me.chkBigRig.Name = "chkBigRig"
        Me.chkBigRig.Size = New System.Drawing.Size(73, 19)
        Me.chkBigRig.TabIndex = 42
        Me.chkBigRig.Text = "Big Rig"
        Me.chkBigRig.UseVisualStyleBackColor = True
        '
        'chkQrp
        '
        Me.chkQrp.AutoSize = True
        Me.chkQrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQrp.Location = New System.Drawing.Point(362, 138)
        Me.chkQrp.Name = "chkQrp"
        Me.chkQrp.Size = New System.Drawing.Size(55, 19)
        Me.chkQrp.TabIndex = 43
        Me.chkQrp.Text = "QRP"
        Me.chkQrp.UseVisualStyleBackColor = True
        '
        'ckbPrimaryTeamMember
        '
        Me.ckbPrimaryTeamMember.AutoSize = True
        Me.ckbPrimaryTeamMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbPrimaryTeamMember.Location = New System.Drawing.Point(15, 25)
        Me.ckbPrimaryTeamMember.Name = "ckbPrimaryTeamMember"
        Me.ckbPrimaryTeamMember.Size = New System.Drawing.Size(69, 19)
        Me.ckbPrimaryTeamMember.TabIndex = 44
        Me.ckbPrimaryTeamMember.Text = "KB0BA"
        Me.ckbPrimaryTeamMember.UseVisualStyleBackColor = True
        '
        'chkSecondaryTeamMember
        '
        Me.chkSecondaryTeamMember.AutoSize = True
        Me.chkSecondaryTeamMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSecondaryTeamMember.Location = New System.Drawing.Point(138, 24)
        Me.chkSecondaryTeamMember.Name = "chkSecondaryTeamMember"
        Me.chkSecondaryTeamMember.Size = New System.Drawing.Size(69, 19)
        Me.chkSecondaryTeamMember.TabIndex = 45
        Me.chkSecondaryTeamMember.Text = "N0XYL"
        Me.chkSecondaryTeamMember.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.SkyBlue
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(588, 593)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(121, 32)
        Me.ButtonClear.TabIndex = 47
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonEditNext
        '
        Me.ButtonEditNext.BackColor = System.Drawing.Color.SkyBlue
        Me.ButtonEditNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditNext.Location = New System.Drawing.Point(147, 593)
        Me.ButtonEditNext.Name = "ButtonEditNext"
        Me.ButtonEditNext.Size = New System.Drawing.Size(116, 32)
        Me.ButtonEditNext.TabIndex = 48
        Me.ButtonEditNext.Text = "Edit Next"
        Me.ButtonEditNext.UseVisualStyleBackColor = False
        Me.ButtonEditNext.Visible = False
        '
        'ButtonEditPrevious
        '
        Me.ButtonEditPrevious.BackColor = System.Drawing.Color.SkyBlue
        Me.ButtonEditPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditPrevious.Location = New System.Drawing.Point(288, 593)
        Me.ButtonEditPrevious.Name = "ButtonEditPrevious"
        Me.ButtonEditPrevious.Size = New System.Drawing.Size(116, 32)
        Me.ButtonEditPrevious.TabIndex = 49
        Me.ButtonEditPrevious.Text = "Edit Previous"
        Me.ButtonEditPrevious.UseVisualStyleBackColor = False
        Me.ButtonEditPrevious.Visible = False
        '
        'txtContactHomeCounty
        '
        Me.txtContactHomeCounty.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtContactHomeCounty.Location = New System.Drawing.Point(447, 12)
        Me.txtContactHomeCounty.Name = "txtContactHomeCounty"
        Me.txtContactHomeCounty.Size = New System.Drawing.Size(241, 22)
        Me.txtContactHomeCounty.TabIndex = 50
        '
        'cmbContactOperation
        '
        Me.cmbContactOperation.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmbContactOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactOperation.FormattingEnabled = True
        Me.cmbContactOperation.Items.AddRange(New Object() {"M", "F", "P", "U"})
        Me.cmbContactOperation.Location = New System.Drawing.Point(189, 12)
        Me.cmbContactOperation.Name = "cmbContactOperation"
        Me.cmbContactOperation.Size = New System.Drawing.Size(121, 24)
        Me.cmbContactOperation.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(71, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Contact Operation"
        '
        'txtContactNames
        '
        Me.txtContactNames.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtContactNames.Location = New System.Drawing.Point(86, 72)
        Me.txtContactNames.Name = "txtContactNames"
        Me.txtContactNames.Size = New System.Drawing.Size(224, 22)
        Me.txtContactNames.TabIndex = 53
        '
        'txtContactInfo
        '
        Me.txtContactInfo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtContactInfo.Location = New System.Drawing.Point(430, 72)
        Me.txtContactInfo.Name = "txtContactInfo"
        Me.txtContactInfo.Size = New System.Drawing.Size(224, 22)
        Me.txtContactInfo.TabIndex = 54
        '
        'lblNames
        '
        Me.lblNames.AutoSize = True
        Me.lblNames.BackColor = System.Drawing.Color.Transparent
        Me.lblNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.Location = New System.Drawing.Point(11, 75)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(62, 15)
        Me.lblNames.TabIndex = 55
        Me.lblNames.Text = "Name(s)"
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info.Location = New System.Drawing.Point(335, 75)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(89, 16)
        Me.Info.TabIndex = 56
        Me.Info.Text = "Contact Info"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(359, 277)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 57
        Me.btnClose.Text = "Button1"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'GroupBoxMyParameters
        '
        Me.GroupBoxMyParameters.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMyParameters.Controls.Add(Me.lblCall)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label2)
        Me.GroupBoxMyParameters.Controls.Add(Me.GroupBoxTeamMembers)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label3)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyOperation)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyState)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label4)
        Me.GroupBoxMyParameters.Controls.Add(Me.LabelMyCounty)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyCounty)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMode)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label7)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label12)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbSubMode)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label8)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbBand)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label9)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbFrequency)
        Me.GroupBoxMyParameters.Controls.Add(Me.cmbMyCountyLine)
        Me.GroupBoxMyParameters.Controls.Add(Me.chkQrp)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label6)
        Me.GroupBoxMyParameters.Controls.Add(Me.chkBigRig)
        Me.GroupBoxMyParameters.Controls.Add(Me.lblTime)
        Me.GroupBoxMyParameters.Controls.Add(Me.lblTime2)
        Me.GroupBoxMyParameters.Controls.Add(Me.chkRunningClock)
        Me.GroupBoxMyParameters.Controls.Add(Me.Label1)
        Me.GroupBoxMyParameters.Controls.Add(Me.txtTime)
        Me.GroupBoxMyParameters.Controls.Add(Me.txtDate)
        Me.GroupBoxMyParameters.Controls.Add(Me.LblDate2)
        Me.GroupBoxMyParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMyParameters.Location = New System.Drawing.Point(11, 7)
        Me.GroupBoxMyParameters.Name = "GroupBoxMyParameters"
        Me.GroupBoxMyParameters.Size = New System.Drawing.Size(1132, 163)
        Me.GroupBoxMyParameters.TabIndex = 58
        Me.GroupBoxMyParameters.TabStop = False
        Me.GroupBoxMyParameters.Text = "Station Data: K8EMS"
        '
        'lblCall
        '
        Me.lblCall.AutoSize = True
        Me.lblCall.Location = New System.Drawing.Point(10, 144)
        Me.lblCall.Name = "lblCall"
        Me.lblCall.Size = New System.Drawing.Size(35, 16)
        Me.lblCall.TabIndex = 60
        Me.lblCall.Text = "Call"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "UTC"
        '
        'GroupBoxTeamMembers
        '
        Me.GroupBoxTeamMembers.Controls.Add(Me.ckbPrimaryTeamMember)
        Me.GroupBoxTeamMembers.Controls.Add(Me.chkSecondaryTeamMember)
        Me.GroupBoxTeamMembers.Location = New System.Drawing.Point(481, 103)
        Me.GroupBoxTeamMembers.Name = "GroupBoxTeamMembers"
        Me.GroupBoxTeamMembers.Size = New System.Drawing.Size(257, 54)
        Me.GroupBoxTeamMembers.TabIndex = 59
        Me.GroupBoxTeamMembers.TabStop = False
        Me.GroupBoxTeamMembers.Text = "Active Team Members"
        '
        'GroupBoxMobileParameters
        '
        Me.GroupBoxMobileParameters.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactHomeCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtcontactCall)
        Me.GroupBoxMobileParameters.Controls.Add(Me.Label11)
        Me.GroupBoxMobileParameters.Controls.Add(Me.Label15)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtContactNames)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactOperation)
        Me.GroupBoxMobileParameters.Controls.Add(Me.Info)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtContactInfo)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtContactHomeCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblNames)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactState)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactState)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactCounty)
        Me.GroupBoxMobileParameters.Controls.Add(Me.cmbContactCountyLine)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblContactCountyLine)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblHrst)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtMyrst)
        Me.GroupBoxMobileParameters.Controls.Add(Me.lblMrst)
        Me.GroupBoxMobileParameters.Controls.Add(Me.txtHisrst)
        Me.GroupBoxMobileParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMobileParameters.Location = New System.Drawing.Point(21, 171)
        Me.GroupBoxMobileParameters.Name = "GroupBoxMobileParameters"
        Me.GroupBoxMobileParameters.Size = New System.Drawing.Size(1122, 105)
        Me.GroupBoxMobileParameters.TabIndex = 59
        Me.GroupBoxMobileParameters.TabStop = False
        Me.GroupBoxMobileParameters.Text = "Contact Data"
        '
        'lblContactHomeCounty
        '
        Me.lblContactHomeCounty.AutoSize = True
        Me.lblContactHomeCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactHomeCounty.Location = New System.Drawing.Point(335, 15)
        Me.lblContactHomeCounty.Name = "lblContactHomeCounty"
        Me.lblContactHomeCounty.Size = New System.Drawing.Size(92, 15)
        Me.lblContactHomeCounty.TabIndex = 57
        Me.lblContactHomeCounty.Text = "Home County"
        '
        'TimerClock
        '
        Me.TimerClock.Enabled = True
        '
        'lblYourLog
        '
        Me.lblYourLog.AutoSize = True
        Me.lblYourLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourLog.Location = New System.Drawing.Point(21, 279)
        Me.lblYourLog.Name = "lblYourLog"
        Me.lblYourLog.Size = New System.Drawing.Size(64, 15)
        Me.lblYourLog.TabIndex = 62
        Me.lblYourLog.Text = "Your Log"
        '
        'txtlDate
        '
        Me.txtlDate.Location = New System.Drawing.Point(266, 276)
        Me.txtlDate.Name = "txtlDate"
        Me.txtlDate.Size = New System.Drawing.Size(100, 20)
        Me.txtlDate.TabIndex = 61
        '
        'txtltime
        '
        Me.txtltime.Location = New System.Drawing.Point(476, 279)
        Me.txtltime.Name = "txtltime"
        Me.txtltime.Size = New System.Drawing.Size(100, 20)
        Me.txtltime.TabIndex = 63
        '
        'FixedLogEntry
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1145, 637)
        Me.Controls.Add(Me.txtltime)
        Me.Controls.Add(Me.txtlDate)
        Me.Controls.Add(Me.lblYourLog)
        Me.Controls.Add(Me.GroupBoxMobileParameters)
        Me.Controls.Add(Me.GroupBoxMyParameters)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ButtonEditPrevious)
        Me.Controls.Add(Me.ButtonEditNext)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.btnSpot)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ButtonSaveEdit)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "FixedLogEntry"
        Me.Text = "Log Entry Form"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMyParameters.ResumeLayout(False)
        Me.GroupBoxMyParameters.PerformLayout()
        Me.GroupBoxTeamMembers.ResumeLayout(False)
        Me.GroupBoxTeamMembers.PerformLayout()
        Me.GroupBoxMobileParameters.ResumeLayout(False)
        Me.GroupBoxMobileParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMyOperation As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbMyState As ComboBox
    Friend WithEvents cmbMyCounty As ComboBox
    Friend WithEvents cmbMyCountyLine As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelMyCounty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbBand As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents cmbFrequency As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents cmbContactState As ComboBox
    Friend WithEvents cmbContactCounty As ComboBox
    Friend WithEvents cmbContactCountyLine As ComboBox
    Friend WithEvents txtcontactCall As TextBox
    Friend WithEvents txtMyrst As TextBox
    Friend WithEvents txtHisrst As TextBox
    Friend WithEvents lblContactState As Label
    Friend WithEvents lblContactCounty As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblContactCountyLine As Label
    Friend WithEvents lblMrst As Label
    Friend WithEvents lblHrst As Label
    Friend WithEvents ButtonSaveEdit As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblTime2 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents LblDate2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents chkRunningClock As CheckBox
    Friend WithEvents btnPost As Button
    Friend WithEvents btnSpot As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmbSubMode As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkBigRig As CheckBox
    Friend WithEvents chkQrp As CheckBox
    Friend WithEvents ckbPrimaryTeamMember As CheckBox
    Friend WithEvents chkSecondaryTeamMember As CheckBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonEditNext As Button
    Friend WithEvents ButtonEditPrevious As Button
    Friend WithEvents txtContactHomeCounty As TextBox
    Friend WithEvents cmbContactOperation As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtContactNames As TextBox
    Friend WithEvents txtContactInfo As TextBox
    Friend WithEvents lblNames As Label
    Friend WithEvents Info As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBoxMyParameters As GroupBox
    Friend WithEvents GroupBoxTeamMembers As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBoxMobileParameters As GroupBox
    Friend WithEvents lblContactHomeCounty As Label
    Friend WithEvents TimerClock As Timer
    Friend WithEvents lblCall As Label
    Friend WithEvents lblYourLog As Label
    Friend WithEvents txtlDate As TextBox
    Friend WithEvents txtltime As TextBox
End Class
