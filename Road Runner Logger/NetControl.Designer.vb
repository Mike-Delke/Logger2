<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NetControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCall = New System.Windows.Forms.Label()
        Me.btnBkToMain = New System.Windows.Forms.Button()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.DataGridV1 = New System.Windows.Forms.DataGridView()
        Me.lblHCall = New System.Windows.Forms.Label()
        Me.lblHState = New System.Windows.Forms.Label()
        Me.lblHCounty = New System.Windows.Forms.Label()
        Me.lblCountyL = New System.Windows.Forms.Label()
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
        Me.txtContactcall = New System.Windows.Forms.TextBox()
        Me.cmbContactState = New System.Windows.Forms.ComboBox()
        Me.cmbContactCounty = New System.Windows.Forms.ComboBox()
        Me.cmbContactCountyL = New System.Windows.Forms.ComboBox()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.cmbFreq = New System.Windows.Forms.ComboBox()
        Me.cmbContactoper = New System.Windows.Forms.ComboBox()
        Me.cmbMyoper = New System.Windows.Forms.ComboBox()
        Me.cmbContactrst = New System.Windows.Forms.ComboBox()
        Me.cmbMyrst = New System.Windows.Forms.ComboBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.lblList = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbBand = New System.Windows.Forms.ComboBox()
        Me.lblBand = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.gboxedit = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSpotMobile = New System.Windows.Forms.Button()
        Me.btnRelayHelp = New System.Windows.Forms.Button()
        Me.tbStartNet = New System.Windows.Forms.TextBox()
        Me.tbEndNet = New System.Windows.Forms.TextBox()
        Me.lblNetLength = New System.Windows.Forms.Label()
        Me.lblnettime = New System.Windows.Forms.Label()
        Me.txtMyState = New System.Windows.Forms.TextBox()
        Me.txtMyCounty = New System.Windows.Forms.TextBox()
        Me.txtMyCountyLine = New System.Windows.Forms.TextBox()
        CType(Me.DataGridV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxedit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 18)
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
        Me.lblCall.Location = New System.Drawing.Point(46, 27)
        Me.lblCall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCall.Name = "lblCall"
        Me.lblCall.Size = New System.Drawing.Size(116, 60)
        Me.lblCall.TabIndex = 0
        Me.lblCall.Text = "CALL"
        Me.lblCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBkToMain
        '
        Me.btnBkToMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBkToMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBkToMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBkToMain.Location = New System.Drawing.Point(947, 373)
        Me.btnBkToMain.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBkToMain.Name = "btnBkToMain"
        Me.btnBkToMain.Size = New System.Drawing.Size(198, 45)
        Me.btnBkToMain.TabIndex = 41
        Me.btnBkToMain.Text = "Main Menu"
        Me.btnBkToMain.UseVisualStyleBackColor = False
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(936, 9)
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
        Me.lblDate.Location = New System.Drawing.Point(1011, 70)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(81, 17)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "3/30/2018"
        '
        'btnPost
        '
        Me.btnPost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Location = New System.Drawing.Point(451, 31)
        Me.btnPost.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(187, 45)
        Me.btnPost.TabIndex = 11
        Me.btnPost.Text = "Post to Log"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'DataGridV1
        '
        Me.DataGridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridV1.Location = New System.Drawing.Point(16, 424)
        Me.DataGridV1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridV1.Name = "DataGridV1"
        Me.DataGridV1.RowTemplate.Height = 24
        Me.DataGridV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridV1.Size = New System.Drawing.Size(1166, 297)
        Me.DataGridV1.TabIndex = 6
        '
        'lblHCall
        '
        Me.lblHCall.AutoSize = True
        Me.lblHCall.BackColor = System.Drawing.Color.Transparent
        Me.lblHCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHCall.Location = New System.Drawing.Point(232, 112)
        Me.lblHCall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHCall.Name = "lblHCall"
        Me.lblHCall.Size = New System.Drawing.Size(109, 20)
        Me.lblHCall.TabIndex = 7
        Me.lblHCall.Text = "Mobile's Call"
        '
        'lblHState
        '
        Me.lblHState.AutoSize = True
        Me.lblHState.BackColor = System.Drawing.Color.Transparent
        Me.lblHState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHState.Location = New System.Drawing.Point(288, 151)
        Me.lblHState.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHState.Name = "lblHState"
        Me.lblHState.Size = New System.Drawing.Size(53, 20)
        Me.lblHState.TabIndex = 8
        Me.lblHState.Text = "State"
        '
        'lblHCounty
        '
        Me.lblHCounty.AutoSize = True
        Me.lblHCounty.BackColor = System.Drawing.Color.Transparent
        Me.lblHCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHCounty.Location = New System.Drawing.Point(276, 181)
        Me.lblHCounty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHCounty.Name = "lblHCounty"
        Me.lblHCounty.Size = New System.Drawing.Size(65, 20)
        Me.lblHCounty.TabIndex = 9
        Me.lblHCounty.Text = "County"
        '
        'lblCountyL
        '
        Me.lblCountyL.AutoSize = True
        Me.lblCountyL.BackColor = System.Drawing.Color.Transparent
        Me.lblCountyL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountyL.Location = New System.Drawing.Point(237, 218)
        Me.lblCountyL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCountyL.Name = "lblCountyL"
        Me.lblCountyL.Size = New System.Drawing.Size(104, 20)
        Me.lblCountyL.TabIndex = 10
        Me.lblCountyL.Text = "County Line"
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.BackColor = System.Drawing.Color.Transparent
        Me.lblFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreq.Location = New System.Drawing.Point(688, 109)
        Me.lblFreq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(93, 20)
        Me.lblFreq.TabIndex = 7
        Me.lblFreq.Text = "Frequency"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Transparent
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(288, 258)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(53, 20)
        Me.lblMode.TabIndex = 11
        Me.lblMode.Text = "Mode"
        '
        'lblHoper
        '
        Me.lblHoper.AutoSize = True
        Me.lblHoper.BackColor = System.Drawing.Color.Transparent
        Me.lblHoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoper.Location = New System.Drawing.Point(662, 146)
        Me.lblHoper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoper.Name = "lblHoper"
        Me.lblHoper.Size = New System.Drawing.Size(119, 20)
        Me.lblHoper.TabIndex = 7
        Me.lblHoper.Text = "His Operation"
        '
        'lblMoper
        '
        Me.lblMoper.AutoSize = True
        Me.lblMoper.BackColor = System.Drawing.Color.Transparent
        Me.lblMoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoper.Location = New System.Drawing.Point(666, 188)
        Me.lblMoper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMoper.Name = "lblMoper"
        Me.lblMoper.Size = New System.Drawing.Size(115, 20)
        Me.lblMoper.TabIndex = 7
        Me.lblMoper.Text = "My Operation"
        '
        'lblHrst
        '
        Me.lblHrst.AutoSize = True
        Me.lblHrst.BackColor = System.Drawing.Color.Transparent
        Me.lblHrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrst.Location = New System.Drawing.Point(706, 234)
        Me.lblHrst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHrst.Name = "lblHrst"
        Me.lblHrst.Size = New System.Drawing.Size(75, 20)
        Me.lblHrst.TabIndex = 7
        Me.lblHrst.Text = "His RST"
        '
        'lblMrst
        '
        Me.lblMrst.AutoSize = True
        Me.lblMrst.BackColor = System.Drawing.Color.Transparent
        Me.lblMrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMrst.Location = New System.Drawing.Point(710, 281)
        Me.lblMrst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMrst.Name = "lblMrst"
        Me.lblMrst.Size = New System.Drawing.Size(71, 20)
        Me.lblMrst.TabIndex = 7
        Me.lblMrst.Text = "My RST"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(851, 261)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(98, 34)
        Me.lblTimer.TabIndex = 7
        Me.lblTimer.Text = "0:10:00"
        Me.lblTimer.Visible = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(976, 257)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(86, 25)
        Me.btnStart.TabIndex = 41
        Me.btnStart.Text = "Start Net"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1906, 193)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Label4"
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(976, 289)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(86, 25)
        Me.btnEnd.TabIndex = 41
        Me.btnEnd.Text = "End Net"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.car_20
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(914, 89)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 165)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txtContactcall
        '
        Me.txtContactcall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactcall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactcall.Location = New System.Drawing.Point(352, 109)
        Me.txtContactcall.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContactcall.Name = "txtContactcall"
        Me.txtContactcall.Size = New System.Drawing.Size(247, 26)
        Me.txtContactcall.TabIndex = 0
        '
        'cmbContactState
        '
        Me.cmbContactState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactState.FormattingEnabled = True
        Me.cmbContactState.Location = New System.Drawing.Point(352, 143)
        Me.cmbContactState.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbContactState.Name = "cmbContactState"
        Me.cmbContactState.Size = New System.Drawing.Size(63, 28)
        Me.cmbContactState.TabIndex = 1
        '
        'cmbContactCounty
        '
        Me.cmbContactCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactCounty.FormattingEnabled = True
        Me.cmbContactCounty.Location = New System.Drawing.Point(352, 178)
        Me.cmbContactCounty.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbContactCounty.Name = "cmbContactCounty"
        Me.cmbContactCounty.Size = New System.Drawing.Size(265, 28)
        Me.cmbContactCounty.TabIndex = 2
        '
        'cmbContactCountyL
        '
        Me.cmbContactCountyL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactCountyL.FormattingEnabled = True
        Me.cmbContactCountyL.Location = New System.Drawing.Point(352, 215)
        Me.cmbContactCountyL.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbContactCountyL.Name = "cmbContactCountyL"
        Me.cmbContactCountyL.Size = New System.Drawing.Size(265, 28)
        Me.cmbContactCountyL.TabIndex = 3
        '
        'cmbMode
        '
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"SSB", "CW", "DIGITAL"})
        Me.cmbMode.Location = New System.Drawing.Point(352, 250)
        Me.cmbMode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(114, 28)
        Me.cmbMode.TabIndex = 4
        '
        'cmbFreq
        '
        Me.cmbFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreq.FormattingEnabled = True
        Me.cmbFreq.Items.AddRange(New Object() {"14.336", "14.328", "520525", "28.336", "24.950", "21.338", "18.136", "7.188", "3.901", "1.950"})
        Me.cmbFreq.Location = New System.Drawing.Point(789, 106)
        Me.cmbFreq.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFreq.Name = "cmbFreq"
        Me.cmbFreq.Size = New System.Drawing.Size(95, 28)
        Me.cmbFreq.TabIndex = 6
        Me.cmbFreq.Text = "14.0565"
        '
        'cmbContactoper
        '
        Me.cmbContactoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactoper.FormattingEnabled = True
        Me.cmbContactoper.Items.AddRange(New Object() {"M", "F"})
        Me.cmbContactoper.Location = New System.Drawing.Point(789, 143)
        Me.cmbContactoper.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbContactoper.Name = "cmbContactoper"
        Me.cmbContactoper.Size = New System.Drawing.Size(45, 28)
        Me.cmbContactoper.TabIndex = 7
        Me.cmbContactoper.Text = "M"
        '
        'cmbMyoper
        '
        Me.cmbMyoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyoper.FormattingEnabled = True
        Me.cmbMyoper.Location = New System.Drawing.Point(789, 185)
        Me.cmbMyoper.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMyoper.Name = "cmbMyoper"
        Me.cmbMyoper.Size = New System.Drawing.Size(45, 28)
        Me.cmbMyoper.TabIndex = 8
        Me.cmbMyoper.Text = "F"
        '
        'cmbContactrst
        '
        Me.cmbContactrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContactrst.FormattingEnabled = True
        Me.cmbContactrst.Items.AddRange(New Object() {"59", "599", "45", "44", "33", "22"})
        Me.cmbContactrst.Location = New System.Drawing.Point(789, 231)
        Me.cmbContactrst.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbContactrst.Name = "cmbContactrst"
        Me.cmbContactrst.Size = New System.Drawing.Size(58, 28)
        Me.cmbContactrst.TabIndex = 9
        Me.cmbContactrst.Text = "559"
        '
        'cmbMyrst
        '
        Me.cmbMyrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMyrst.FormattingEnabled = True
        Me.cmbMyrst.Items.AddRange(New Object() {"59", "599", "45", "44", "33", "22"})
        Me.cmbMyrst.Location = New System.Drawing.Point(789, 278)
        Me.cmbMyrst.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMyrst.Name = "cmbMyrst"
        Me.cmbMyrst.Size = New System.Drawing.Size(58, 28)
        Me.cmbMyrst.TabIndex = 10
        Me.cmbMyrst.Text = "559"
        '
        'txtList
        '
        Me.txtList.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtList.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtList.Location = New System.Drawing.Point(16, 125)
        Me.txtList.Margin = New System.Windows.Forms.Padding(2)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(164, 275)
        Me.txtList.TabIndex = 15
        Me.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.BackColor = System.Drawing.Color.Transparent
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(16, 96)
        Me.lblList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(161, 24)
        Me.lblList.TabIndex = 16
        Me.lblList.Text = "         List           "
        Me.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.cmbBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBand.FormattingEnabled = True
        Me.cmbBand.Items.AddRange(New Object() {"6", "10", "12", "15", "17", "20", "30", "40", "80", "160"})
        Me.cmbBand.Location = New System.Drawing.Point(352, 285)
        Me.cmbBand.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBand.Name = "cmbBand"
        Me.cmbBand.Size = New System.Drawing.Size(87, 28)
        Me.cmbBand.TabIndex = 5
        '
        'lblBand
        '
        Me.lblBand.AutoSize = True
        Me.lblBand.BackColor = System.Drawing.Color.Transparent
        Me.lblBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand.Location = New System.Drawing.Point(290, 288)
        Me.lblBand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBand.Name = "lblBand"
        Me.lblBand.Size = New System.Drawing.Size(51, 20)
        Me.lblBand.TabIndex = 19
        Me.lblBand.Text = "Band"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(857, 297)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "     "
        Me.TextBox1.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(330, 30)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(106, 45)
        Me.btnEdit.TabIndex = 41
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'gboxedit
        '
        Me.gboxedit.BackColor = System.Drawing.Color.Transparent
        Me.gboxedit.Controls.Add(Me.btnDelete)
        Me.gboxedit.Controls.Add(Me.btnEdit)
        Me.gboxedit.Controls.Add(Me.btnSpotMobile)
        Me.gboxedit.Controls.Add(Me.btnPost)
        Me.gboxedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxedit.Location = New System.Drawing.Point(233, 326)
        Me.gboxedit.Name = "gboxedit"
        Me.gboxedit.Size = New System.Drawing.Size(651, 92)
        Me.gboxedit.TabIndex = 26
        Me.gboxedit.TabStop = False
        Me.gboxedit.Text = "Page Controls"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Yellow
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnDelete.Location = New System.Drawing.Point(145, 30)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(163, 45)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "Delete Row"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSpotMobile
        '
        Me.btnSpotMobile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSpotMobile.BackColor = System.Drawing.Color.Yellow
        Me.btnSpotMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpotMobile.Location = New System.Drawing.Point(7, 30)
        Me.btnSpotMobile.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpotMobile.Name = "btnSpotMobile"
        Me.btnSpotMobile.Size = New System.Drawing.Size(120, 45)
        Me.btnSpotMobile.TabIndex = 40
        Me.btnSpotMobile.Text = "Spot"
        Me.btnSpotMobile.UseVisualStyleBackColor = False
        '
        'btnRelayHelp
        '
        Me.btnRelayHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRelayHelp.Location = New System.Drawing.Point(986, 345)
        Me.btnRelayHelp.Name = "btnRelayHelp"
        Me.btnRelayHelp.Size = New System.Drawing.Size(117, 23)
        Me.btnRelayHelp.TabIndex = 43
        Me.btnRelayHelp.Text = "Help With Relays"
        Me.btnRelayHelp.UseVisualStyleBackColor = False
        '
        'tbStartNet
        '
        Me.tbStartNet.Location = New System.Drawing.Point(1067, 259)
        Me.tbStartNet.Name = "tbStartNet"
        Me.tbStartNet.Size = New System.Drawing.Size(78, 20)
        Me.tbStartNet.TabIndex = 47
        '
        'tbEndNet
        '
        Me.tbEndNet.Location = New System.Drawing.Point(1067, 289)
        Me.tbEndNet.Name = "tbEndNet"
        Me.tbEndNet.Size = New System.Drawing.Size(78, 20)
        Me.tbEndNet.TabIndex = 48
        '
        'lblNetLength
        '
        Me.lblNetLength.AutoSize = True
        Me.lblNetLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetLength.Location = New System.Drawing.Point(1088, 320)
        Me.lblNetLength.Name = "lblNetLength"
        Me.lblNetLength.Size = New System.Drawing.Size(43, 15)
        Me.lblNetLength.TabIndex = 49
        Me.lblNetLength.Text = "00.00"
        '
        'lblnettime
        '
        Me.lblnettime.AutoSize = True
        Me.lblnettime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblnettime.Location = New System.Drawing.Point(983, 322)
        Me.lblnettime.Name = "lblnettime"
        Me.lblnettime.Size = New System.Drawing.Size(79, 13)
        Me.lblnettime.TabIndex = 50
        Me.lblnettime.Text = "Net Duration"
        '
        'txtMyState
        '
        Me.txtMyState.Location = New System.Drawing.Point(480, 297)
        Me.txtMyState.Name = "txtMyState"
        Me.txtMyState.Size = New System.Drawing.Size(100, 20)
        Me.txtMyState.TabIndex = 51
        Me.txtMyState.Visible = False
        '
        'txtMyCounty
        '
        Me.txtMyCounty.Location = New System.Drawing.Point(586, 297)
        Me.txtMyCounty.Name = "txtMyCounty"
        Me.txtMyCounty.Size = New System.Drawing.Size(100, 20)
        Me.txtMyCounty.TabIndex = 52
        Me.txtMyCounty.Visible = False
        '
        'txtMyCountyLine
        '
        Me.txtMyCountyLine.Location = New System.Drawing.Point(531, 275)
        Me.txtMyCountyLine.Name = "txtMyCountyLine"
        Me.txtMyCountyLine.Size = New System.Drawing.Size(100, 20)
        Me.txtMyCountyLine.TabIndex = 53
        Me.txtMyCountyLine.Visible = False
        '
        'NetControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1199, 756)
        Me.Controls.Add(Me.txtMyCountyLine)
        Me.Controls.Add(Me.txtMyCounty)
        Me.Controls.Add(Me.txtMyState)
        Me.Controls.Add(Me.lblnettime)
        Me.Controls.Add(Me.lblNetLength)
        Me.Controls.Add(Me.tbEndNet)
        Me.Controls.Add(Me.tbStartNet)
        Me.Controls.Add(Me.btnRelayHelp)
        Me.Controls.Add(Me.gboxedit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblBand)
        Me.Controls.Add(Me.cmbBand)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.txtList)
        Me.Controls.Add(Me.cmbMyrst)
        Me.Controls.Add(Me.cmbContactrst)
        Me.Controls.Add(Me.cmbMyoper)
        Me.Controls.Add(Me.cmbContactoper)
        Me.Controls.Add(Me.cmbFreq)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.cmbContactCountyL)
        Me.Controls.Add(Me.cmbContactCounty)
        Me.Controls.Add(Me.cmbContactState)
        Me.Controls.Add(Me.txtContactcall)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMode)
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
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnBkToMain)
        Me.Controls.Add(Me.lblCall)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NetControl"
        Me.Text = "NetControl"
        CType(Me.DataGridV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxedit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCall As Label
    Friend WithEvents btnBkToMain As Button
    Friend WithEvents lblClock As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnPost As Button
    Friend WithEvents DataGridV1 As DataGridView
    Friend WithEvents lblHCall As Label
    Friend WithEvents lblHState As Label
    Friend WithEvents lblHCounty As Label
    Friend WithEvents lblCountyL As Label
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
    Friend WithEvents txtContactcall As TextBox
    Friend WithEvents cmbContactState As ComboBox
    Friend WithEvents cmbContactCounty As ComboBox
    Friend WithEvents cmbContactCountyL As ComboBox
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents cmbFreq As ComboBox
    Friend WithEvents cmbContactoper As ComboBox
    Friend WithEvents cmbMyoper As ComboBox
    Friend WithEvents cmbContactrst As ComboBox
    Friend WithEvents cmbMyrst As ComboBox
    Friend WithEvents txtList As TextBox
    Friend WithEvents lblList As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmbBand As ComboBox
    Friend WithEvents lblBand As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents gboxedit As GroupBox
    Friend WithEvents btnSpotMobile As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRelayHelp As Button
    Friend WithEvents tbStartNet As TextBox
    Friend WithEvents tbEndNet As TextBox
    Friend WithEvents lblNetLength As Label
    Friend WithEvents lblnettime As Label
    Friend WithEvents txtMyState As TextBox
    Friend WithEvents txtMyCounty As TextBox
    Friend WithEvents txtMyCountyLine As TextBox
End Class
