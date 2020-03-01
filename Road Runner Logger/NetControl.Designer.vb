<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetControl
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCall = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnAddLog = New System.Windows.Forms.Button()
        Me.btnSpotMobile = New System.Windows.Forms.Button()
        Me.DataGridV1 = New System.Windows.Forms.DataGridView()
        Me.lblHCall = New System.Windows.Forms.Label()
        Me.lblHState = New System.Windows.Forms.Label()
        Me.lblHCounty = New System.Windows.Forms.Label()
        Me.lblCountyL = New System.Windows.Forms.Label()
        Me.lblCntyLineState = New System.Windows.Forms.Label()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblHoper = New System.Windows.Forms.Label()
        Me.lblMoper = New System.Windows.Forms.Label()
        Me.lblHrst = New System.Windows.Forms.Label()
        Me.lblMrst = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtHcall = New System.Windows.Forms.TextBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.cmbCounty = New System.Windows.Forms.ComboBox()
        Me.cmbHCountyL = New System.Windows.Forms.ComboBox()
        Me.cmbCntyLState = New System.Windows.Forms.ComboBox()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.cmbFreq = New System.Windows.Forms.ComboBox()
        Me.cmbHoper = New System.Windows.Forms.ComboBox()
        Me.cmbMoper = New System.Windows.Forms.ComboBox()
        Me.cmbHrst = New System.Windows.Forms.ComboBox()
        Me.cmbMrst = New System.Windows.Forms.ComboBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.lblList = New System.Windows.Forms.Label()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbBand = New System.Windows.Forms.ComboBox()
        Me.lblBand = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C.H. Net Control LOGGER"
        '
        'lblCall
        '
        Me.lblCall.AutoSize = True
        Me.lblCall.BackColor = System.Drawing.Color.Transparent
        Me.lblCall.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCall.Location = New System.Drawing.Point(192, 17)
        Me.lblCall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCall.Name = "lblCall"
        Me.lblCall.Size = New System.Drawing.Size(116, 60)
        Me.lblCall.TabIndex = 0
        Me.lblCall.Text = "CALL"
        Me.lblCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1066, 381)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(1026, 18)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(209, 60)
        Me.lblClock.TabIndex = 2
        Me.lblClock.Text = "00:00:00"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1091, 79)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(81, 17)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "3/30/2018"
        '
        'btnAddLog
        '
        Me.btnAddLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLog.Location = New System.Drawing.Point(540, 381)
        Me.btnAddLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddLog.Name = "btnAddLog"
        Me.btnAddLog.Size = New System.Drawing.Size(160, 45)
        Me.btnAddLog.TabIndex = 4
        Me.btnAddLog.Text = "Add to Log"
        Me.btnAddLog.UseVisualStyleBackColor = False
        Me.btnAddLog.Visible = False
        '
        'btnSpotMobile
        '
        Me.btnSpotMobile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSpotMobile.BackColor = System.Drawing.Color.Yellow
        Me.btnSpotMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpotMobile.Location = New System.Drawing.Point(718, 383)
        Me.btnSpotMobile.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpotMobile.Name = "btnSpotMobile"
        Me.btnSpotMobile.Size = New System.Drawing.Size(164, 45)
        Me.btnSpotMobile.TabIndex = 5
        Me.btnSpotMobile.Text = "Spot"
        Me.btnSpotMobile.UseVisualStyleBackColor = False
        '
        'DataGridV1
        '
        Me.DataGridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridV1.Location = New System.Drawing.Point(13, 432)
        Me.DataGridV1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridV1.Name = "DataGridV1"
        Me.DataGridV1.RowTemplate.Height = 24
        Me.DataGridV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridV1.Size = New System.Drawing.Size(1222, 297)
        Me.DataGridV1.TabIndex = 6
        '
        'lblHCall
        '
        Me.lblHCall.AutoSize = True
        Me.lblHCall.BackColor = System.Drawing.Color.Transparent
        Me.lblHCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHCall.Location = New System.Drawing.Point(190, 116)
        Me.lblHCall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHCall.Name = "lblHCall"
        Me.lblHCall.Size = New System.Drawing.Size(148, 26)
        Me.lblHCall.TabIndex = 7
        Me.lblHCall.Text = "Mobile's Call"
        '
        'lblHState
        '
        Me.lblHState.AutoSize = True
        Me.lblHState.BackColor = System.Drawing.Color.Transparent
        Me.lblHState.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHState.Location = New System.Drawing.Point(267, 164)
        Me.lblHState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHState.Name = "lblHState"
        Me.lblHState.Size = New System.Drawing.Size(68, 26)
        Me.lblHState.TabIndex = 8
        Me.lblHState.Text = "State"
        '
        'lblHCounty
        '
        Me.lblHCounty.AutoSize = True
        Me.lblHCounty.BackColor = System.Drawing.Color.Transparent
        Me.lblHCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHCounty.Location = New System.Drawing.Point(249, 213)
        Me.lblHCounty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHCounty.Name = "lblHCounty"
        Me.lblHCounty.Size = New System.Drawing.Size(87, 26)
        Me.lblHCounty.TabIndex = 9
        Me.lblHCounty.Text = "County"
        '
        'lblCountyL
        '
        Me.lblCountyL.AutoSize = True
        Me.lblCountyL.BackColor = System.Drawing.Color.Transparent
        Me.lblCountyL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountyL.Location = New System.Drawing.Point(199, 259)
        Me.lblCountyL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCountyL.Name = "lblCountyL"
        Me.lblCountyL.Size = New System.Drawing.Size(139, 26)
        Me.lblCountyL.TabIndex = 10
        Me.lblCountyL.Text = "County Line"
        '
        'lblCntyLineState
        '
        Me.lblCntyLineState.AutoSize = True
        Me.lblCntyLineState.BackColor = System.Drawing.Color.Transparent
        Me.lblCntyLineState.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCntyLineState.Location = New System.Drawing.Point(164, 309)
        Me.lblCntyLineState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCntyLineState.Name = "lblCntyLineState"
        Me.lblCntyLineState.Size = New System.Drawing.Size(176, 26)
        Me.lblCntyLineState.TabIndex = 11
        Me.lblCntyLineState.Text = "Cnty Line State"
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.BackColor = System.Drawing.Color.Transparent
        Me.lblFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreq.Location = New System.Drawing.Point(665, 113)
        Me.lblFreq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(123, 26)
        Me.lblFreq.TabIndex = 7
        Me.lblFreq.Text = "Frequency"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Transparent
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(264, 356)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(70, 26)
        Me.lblMode.TabIndex = 11
        Me.lblMode.Text = "Mode"
        '
        'lblHoper
        '
        Me.lblHoper.AutoSize = True
        Me.lblHoper.BackColor = System.Drawing.Color.Transparent
        Me.lblHoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoper.Location = New System.Drawing.Point(632, 162)
        Me.lblHoper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoper.Name = "lblHoper"
        Me.lblHoper.Size = New System.Drawing.Size(158, 26)
        Me.lblHoper.TabIndex = 7
        Me.lblHoper.Text = "His Operation"
        '
        'lblMoper
        '
        Me.lblMoper.AutoSize = True
        Me.lblMoper.BackColor = System.Drawing.Color.Transparent
        Me.lblMoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoper.Location = New System.Drawing.Point(636, 216)
        Me.lblMoper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMoper.Name = "lblMoper"
        Me.lblMoper.Size = New System.Drawing.Size(154, 26)
        Me.lblMoper.TabIndex = 7
        Me.lblMoper.Text = "My Operation"
        '
        'lblHrst
        '
        Me.lblHrst.AutoSize = True
        Me.lblHrst.BackColor = System.Drawing.Color.Transparent
        Me.lblHrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrst.Location = New System.Drawing.Point(689, 264)
        Me.lblHrst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHrst.Name = "lblHrst"
        Me.lblHrst.Size = New System.Drawing.Size(100, 26)
        Me.lblHrst.TabIndex = 7
        Me.lblHrst.Text = "His RST"
        '
        'lblMrst
        '
        Me.lblMrst.AutoSize = True
        Me.lblMrst.BackColor = System.Drawing.Color.Transparent
        Me.lblMrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMrst.Location = New System.Drawing.Point(693, 312)
        Me.lblMrst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMrst.Name = "lblMrst"
        Me.lblMrst.Size = New System.Drawing.Size(96, 26)
        Me.lblMrst.TabIndex = 7
        Me.lblMrst.Text = "My RST"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(1018, 300)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(98, 34)
        Me.lblTimer.TabIndex = 7
        Me.lblTimer.Text = "0:10:00"
        Me.lblTimer.Visible = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(1161, 283)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(74, 25)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start Net"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1633, 193)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Label4"
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(1164, 319)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(71, 25)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "End Net"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.car_20
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1008, 98)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 181)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txtHcall
        '
        Me.txtHcall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHcall.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHcall.Location = New System.Drawing.Point(365, 114)
        Me.txtHcall.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHcall.Name = "txtHcall"
        Me.txtHcall.Size = New System.Drawing.Size(212, 32)
        Me.txtHcall.TabIndex = 13
        '
        'cmbState
        '
        Me.cmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(365, 159)
        Me.cmbState.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(98, 34)
        Me.cmbState.TabIndex = 14
        '
        'cmbCounty
        '
        Me.cmbCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCounty.FormattingEnabled = True
        Me.cmbCounty.Location = New System.Drawing.Point(365, 208)
        Me.cmbCounty.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.Size = New System.Drawing.Size(228, 34)
        Me.cmbCounty.TabIndex = 14
        '
        'cmbHCountyL
        '
        Me.cmbHCountyL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHCountyL.FormattingEnabled = True
        Me.cmbHCountyL.Location = New System.Drawing.Point(365, 256)
        Me.cmbHCountyL.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbHCountyL.Name = "cmbHCountyL"
        Me.cmbHCountyL.Size = New System.Drawing.Size(228, 34)
        Me.cmbHCountyL.TabIndex = 14
        '
        'cmbCntyLState
        '
        Me.cmbCntyLState.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCntyLState.FormattingEnabled = True
        Me.cmbCntyLState.Location = New System.Drawing.Point(365, 304)
        Me.cmbCntyLState.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCntyLState.Name = "cmbCntyLState"
        Me.cmbCntyLState.Size = New System.Drawing.Size(125, 34)
        Me.cmbCntyLState.TabIndex = 14
        '
        'cmbMode
        '
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"SSB", "CW", "DIGITAL"})
        Me.cmbMode.Location = New System.Drawing.Point(365, 351)
        Me.cmbMode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(125, 34)
        Me.cmbMode.TabIndex = 14
        '
        'cmbFreq
        '
        Me.cmbFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreq.FormattingEnabled = True
        Me.cmbFreq.Items.AddRange(New Object() {"14.336", "14.328", "520525", "28.336", "24.950", "21.338", "18.136", "7.188", "3.901", "1.950"})
        Me.cmbFreq.Location = New System.Drawing.Point(851, 110)
        Me.cmbFreq.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFreq.Name = "cmbFreq"
        Me.cmbFreq.Size = New System.Drawing.Size(139, 34)
        Me.cmbFreq.TabIndex = 14
        '
        'cmbHoper
        '
        Me.cmbHoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoper.FormattingEnabled = True
        Me.cmbHoper.Items.AddRange(New Object() {"M", "F"})
        Me.cmbHoper.Location = New System.Drawing.Point(851, 159)
        Me.cmbHoper.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbHoper.Name = "cmbHoper"
        Me.cmbHoper.Size = New System.Drawing.Size(114, 34)
        Me.cmbHoper.TabIndex = 14
        Me.cmbHoper.Text = "M"
        '
        'cmbMoper
        '
        Me.cmbMoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoper.FormattingEnabled = True
        Me.cmbMoper.Location = New System.Drawing.Point(851, 213)
        Me.cmbMoper.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMoper.Name = "cmbMoper"
        Me.cmbMoper.Size = New System.Drawing.Size(114, 34)
        Me.cmbMoper.TabIndex = 14
        Me.cmbMoper.Text = "F"
        '
        'cmbHrst
        '
        Me.cmbHrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHrst.FormattingEnabled = True
        Me.cmbHrst.Items.AddRange(New Object() {"59", "599", "45", "44", "33", "22"})
        Me.cmbHrst.Location = New System.Drawing.Point(851, 262)
        Me.cmbHrst.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbHrst.Name = "cmbHrst"
        Me.cmbHrst.Size = New System.Drawing.Size(114, 34)
        Me.cmbHrst.TabIndex = 14
        Me.cmbHrst.Text = "59"
        '
        'cmbMrst
        '
        Me.cmbMrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMrst.FormattingEnabled = True
        Me.cmbMrst.Items.AddRange(New Object() {"59", "599", "45", "44", "33", "22"})
        Me.cmbMrst.Location = New System.Drawing.Point(851, 310)
        Me.cmbMrst.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMrst.Name = "cmbMrst"
        Me.cmbMrst.Size = New System.Drawing.Size(114, 34)
        Me.cmbMrst.TabIndex = 14
        Me.cmbMrst.Text = "59"
        '
        'txtList
        '
        Me.txtList.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtList.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtList.Location = New System.Drawing.Point(9, 143)
        Me.txtList.Margin = New System.Windows.Forms.Padding(2)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(141, 275)
        Me.txtList.TabIndex = 15
        Me.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.BackColor = System.Drawing.Color.Transparent
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(9, 114)
        Me.lblList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(161, 24)
        Me.lblList.TabIndex = 16
        Me.lblList.Text = "         List           "
        Me.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPost
        '
        Me.btnPost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPost.BackColor = System.Drawing.Color.Lime
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Location = New System.Drawing.Point(895, 383)
        Me.btnPost.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(164, 45)
        Me.btnPost.TabIndex = 5
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(1117, 351)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(118, 21)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Help Relay's"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'cmbBand
        '
        Me.cmbBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBand.FormattingEnabled = True
        Me.cmbBand.Items.AddRange(New Object() {"6", "10", "12", "15", "17", "20", "30", "40", "80", "160"})
        Me.cmbBand.Location = New System.Drawing.Point(365, 392)
        Me.cmbBand.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBand.Name = "cmbBand"
        Me.cmbBand.Size = New System.Drawing.Size(98, 34)
        Me.cmbBand.TabIndex = 18
        '
        'lblBand
        '
        Me.lblBand.AutoSize = True
        Me.lblBand.BackColor = System.Drawing.Color.Transparent
        Me.lblBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand.Location = New System.Drawing.Point(269, 392)
        Me.lblBand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBand.Name = "lblBand"
        Me.lblBand.Size = New System.Drawing.Size(67, 26)
        Me.lblBand.TabIndex = 19
        Me.lblBand.Text = "Band"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(527, 309)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "     (NL)"
        Me.TextBox1.Visible = False
        '
        'NetControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 756)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblBand)
        Me.Controls.Add(Me.cmbBand)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.txtList)
        Me.Controls.Add(Me.cmbMrst)
        Me.Controls.Add(Me.cmbHrst)
        Me.Controls.Add(Me.cmbMoper)
        Me.Controls.Add(Me.cmbHoper)
        Me.Controls.Add(Me.cmbFreq)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.cmbCntyLState)
        Me.Controls.Add(Me.cmbHCountyL)
        Me.Controls.Add(Me.cmbCounty)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.txtHcall)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblCntyLineState)
        Me.Controls.Add(Me.lblCountyL)
        Me.Controls.Add(Me.lblHCounty)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblMrst)
        Me.Controls.Add(Me.lblHrst)
        Me.Controls.Add(Me.lblMoper)
        Me.Controls.Add(Me.lblHoper)
        Me.Controls.Add(Me.lblHState)
        Me.Controls.Add(Me.lblFreq)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblHCall)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.DataGridV1)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnSpotMobile)
        Me.Controls.Add(Me.btnAddLog)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCall)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NetControl"
        Me.Text = "NetControl"
        CType(Me.DataGridV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCall As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblClock As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnAddLog As Button
    Friend WithEvents btnSpotMobile As Button
    Friend WithEvents DataGridV1 As DataGridView
    Friend WithEvents lblHCall As Label
    Friend WithEvents lblHState As Label
    Friend WithEvents lblHCounty As Label
    Friend WithEvents lblCountyL As Label
    Friend WithEvents lblCntyLineState As Label
    Friend WithEvents lblFreq As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents lblHoper As Label
    Friend WithEvents lblMoper As Label
    Friend WithEvents lblHrst As Label
    Friend WithEvents lblMrst As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtHcall As TextBox
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents cmbCounty As ComboBox
    Friend WithEvents cmbHCountyL As ComboBox
    Friend WithEvents cmbCntyLState As ComboBox
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents cmbFreq As ComboBox
    Friend WithEvents cmbHoper As ComboBox
    Friend WithEvents cmbMoper As ComboBox
    Friend WithEvents cmbHrst As ComboBox
    Friend WithEvents cmbMrst As ComboBox
    Friend WithEvents txtList As TextBox
    Friend WithEvents lblList As Label
    Friend WithEvents btnPost As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmbBand As ComboBox
    Friend WithEvents lblBand As Label
    Friend WithEvents TextBox1 As TextBox
End Class
