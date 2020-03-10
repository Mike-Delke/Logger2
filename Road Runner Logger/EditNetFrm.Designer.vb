<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditNetFrm
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
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.NetLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NetControlDataSet1 = New Road_Runner_Logger.NetControlDataSet1()
        Me.lblCall = New System.Windows.Forms.Label()
        Me.txtContactcall = New System.Windows.Forms.TextBox()
        Me.lblHState = New System.Windows.Forms.Label()
        Me.txtcontactstate = New System.Windows.Forms.TextBox()
        Me.lblHCounty = New System.Windows.Forms.Label()
        Me.txtContactcounty = New System.Windows.Forms.TextBox()
        Me.lblCntyLine = New System.Windows.Forms.Label()
        Me.txtContactcntyLine = New System.Windows.Forms.TextBox()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.txtFreq = New System.Windows.Forms.TextBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.txtMode = New System.Windows.Forms.TextBox()
        Me.lblMcall = New System.Windows.Forms.Label()
        Me.txtMycall = New System.Windows.Forms.TextBox()
        Me.lblHrst = New System.Windows.Forms.Label()
        Me.txtContactrst = New System.Windows.Forms.TextBox()
        Me.lblMrst = New System.Windows.Forms.Label()
        Me.txtMyrst = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnSaveEdit = New System.Windows.Forms.Button()
        Me.lblHisOper = New System.Windows.Forms.Label()
        Me.txtHisOper = New System.Windows.Forms.TextBox()
        Me.lblMyOper = New System.Windows.Forms.Label()
        Me.txtMyOper = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblBand = New System.Windows.Forms.Label()
        Me.txtBand = New System.Windows.Forms.TextBox()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLastRec = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HCallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountyLineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrequencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HrstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MrstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetLogTableAdapter = New Road_Runner_Logger.NetControlDataSet1TableAdapters.NetLogTableAdapter()
        CType(Me.NetLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetControlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTime
        '
        Me.txtTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Ltime", True))
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(138, 92)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(249, 26)
        Me.txtTime.TabIndex = 1
        '
        'NetLogBindingSource
        '
        Me.NetLogBindingSource.DataMember = "NetLog"
        Me.NetLogBindingSource.DataSource = Me.NetControlDataSet1
        '
        'NetControlDataSet1
        '
        Me.NetControlDataSet1.DataSetName = "NetControlDataSet1"
        Me.NetControlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCall
        '
        Me.lblCall.AutoSize = True
        Me.lblCall.BackColor = System.Drawing.Color.Transparent
        Me.lblCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCall.Location = New System.Drawing.Point(35, 132)
        Me.lblCall.Name = "lblCall"
        Me.lblCall.Size = New System.Drawing.Size(97, 18)
        Me.lblCall.TabIndex = 0
        Me.lblCall.Text = "Contacts Call"
        '
        'txtContactcall
        '
        Me.txtContactcall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactcall.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "HCall", True))
        Me.txtContactcall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactcall.Location = New System.Drawing.Point(138, 128)
        Me.txtContactcall.Name = "txtContactcall"
        Me.txtContactcall.Size = New System.Drawing.Size(249, 26)
        Me.txtContactcall.TabIndex = 1
        '
        'lblHState
        '
        Me.lblHState.AutoSize = True
        Me.lblHState.BackColor = System.Drawing.Color.Transparent
        Me.lblHState.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHState.Location = New System.Drawing.Point(26, 168)
        Me.lblHState.Name = "lblHState"
        Me.lblHState.Size = New System.Drawing.Size(106, 18)
        Me.lblHState.TabIndex = 0
        Me.lblHState.Text = " ContactsState"
        '
        'txtcontactstate
        '
        Me.txtcontactstate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontactstate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "State", True))
        Me.txtcontactstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactstate.Location = New System.Drawing.Point(138, 164)
        Me.txtcontactstate.Name = "txtcontactstate"
        Me.txtcontactstate.Size = New System.Drawing.Size(249, 26)
        Me.txtcontactstate.TabIndex = 1
        '
        'lblHCounty
        '
        Me.lblHCounty.AutoSize = True
        Me.lblHCounty.BackColor = System.Drawing.Color.Transparent
        Me.lblHCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHCounty.Location = New System.Drawing.Point(15, 204)
        Me.lblHCounty.Name = "lblHCounty"
        Me.lblHCounty.Size = New System.Drawing.Size(119, 18)
        Me.lblHCounty.TabIndex = 0
        Me.lblHCounty.Text = "Contacts County"
        '
        'txtContactcounty
        '
        Me.txtContactcounty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "County", True))
        Me.txtContactcounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactcounty.Location = New System.Drawing.Point(138, 200)
        Me.txtContactcounty.Name = "txtContactcounty"
        Me.txtContactcounty.Size = New System.Drawing.Size(249, 26)
        Me.txtContactcounty.TabIndex = 1
        '
        'lblCntyLine
        '
        Me.lblCntyLine.AutoSize = True
        Me.lblCntyLine.BackColor = System.Drawing.Color.Transparent
        Me.lblCntyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCntyLine.Location = New System.Drawing.Point(-1, 240)
        Me.lblCntyLine.Name = "lblCntyLine"
        Me.lblCntyLine.Size = New System.Drawing.Size(133, 18)
        Me.lblCntyLine.TabIndex = 0
        Me.lblCntyLine.Text = "Contacts Cnty Line"
        '
        'txtContactcntyLine
        '
        Me.txtContactcntyLine.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "CountyLine", True))
        Me.txtContactcntyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactcntyLine.Location = New System.Drawing.Point(138, 236)
        Me.txtContactcntyLine.Name = "txtContactcntyLine"
        Me.txtContactcntyLine.Size = New System.Drawing.Size(249, 26)
        Me.txtContactcntyLine.TabIndex = 1
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.BackColor = System.Drawing.Color.Transparent
        Me.lblFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreq.Location = New System.Drawing.Point(54, 276)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(77, 18)
        Me.lblFreq.TabIndex = 0
        Me.lblFreq.Text = "Frequency"
        '
        'txtFreq
        '
        Me.txtFreq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFreq.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Frequency", True))
        Me.txtFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFreq.Location = New System.Drawing.Point(138, 272)
        Me.txtFreq.Name = "txtFreq"
        Me.txtFreq.Size = New System.Drawing.Size(249, 26)
        Me.txtFreq.TabIndex = 1
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Transparent
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(91, 348)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(46, 18)
        Me.lblMode.TabIndex = 0
        Me.lblMode.Text = "Mode"
        '
        'txtMode
        '
        Me.txtMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Mode", True))
        Me.txtMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMode.Location = New System.Drawing.Point(138, 344)
        Me.txtMode.Name = "txtMode"
        Me.txtMode.Size = New System.Drawing.Size(249, 26)
        Me.txtMode.TabIndex = 1
        '
        'lblMcall
        '
        Me.lblMcall.AutoSize = True
        Me.lblMcall.BackColor = System.Drawing.Color.Transparent
        Me.lblMcall.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMcall.Location = New System.Drawing.Point(64, 384)
        Me.lblMcall.Name = "lblMcall"
        Me.lblMcall.Size = New System.Drawing.Size(68, 18)
        Me.lblMcall.TabIndex = 0
        Me.lblMcall.Text = "Your Call"
        '
        'txtMycall
        '
        Me.txtMycall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMycall.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "MCall", True))
        Me.txtMycall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMycall.Location = New System.Drawing.Point(138, 380)
        Me.txtMycall.Name = "txtMycall"
        Me.txtMycall.Size = New System.Drawing.Size(249, 26)
        Me.txtMycall.TabIndex = 1
        '
        'lblHrst
        '
        Me.lblHrst.AutoSize = True
        Me.lblHrst.BackColor = System.Drawing.Color.Transparent
        Me.lblHrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrst.Location = New System.Drawing.Point(25, 420)
        Me.lblHrst.Name = "lblHrst"
        Me.lblHrst.Size = New System.Drawing.Size(106, 18)
        Me.lblHrst.TabIndex = 0
        Me.lblHrst.Text = "Contacts  RST"
        '
        'txtContactrst
        '
        Me.txtContactrst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactrst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Hrst", True))
        Me.txtContactrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactrst.Location = New System.Drawing.Point(138, 416)
        Me.txtContactrst.Name = "txtContactrst"
        Me.txtContactrst.Size = New System.Drawing.Size(249, 26)
        Me.txtContactrst.TabIndex = 1
        '
        'lblMrst
        '
        Me.lblMrst.AutoSize = True
        Me.lblMrst.BackColor = System.Drawing.Color.Transparent
        Me.lblMrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMrst.Location = New System.Drawing.Point(58, 456)
        Me.lblMrst.Name = "lblMrst"
        Me.lblMrst.Size = New System.Drawing.Size(73, 18)
        Me.lblMrst.TabIndex = 0
        Me.lblMrst.Text = "Your RST"
        '
        'txtMyrst
        '
        Me.txtMyrst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMyrst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Mrst", True))
        Me.txtMyrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyrst.Location = New System.Drawing.Point(138, 452)
        Me.txtMyrst.Name = "txtMyrst"
        Me.txtMyrst.Size = New System.Drawing.Size(249, 26)
        Me.txtMyrst.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(95, 96)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 18)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, -520)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Label1"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(98, 60)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 18)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "LDate", True))
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(138, 56)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(249, 26)
        Me.txtDate.TabIndex = 1
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.BackColor = System.Drawing.Color.Yellow
        Me.btnSaveEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEdit.Location = New System.Drawing.Point(119, 607)
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Size = New System.Drawing.Size(144, 46)
        Me.btnSaveEdit.TabIndex = 2
        Me.btnSaveEdit.Text = "Save Edit "
        Me.btnSaveEdit.UseVisualStyleBackColor = False
        '
        'lblHisOper
        '
        Me.lblHisOper.AutoSize = True
        Me.lblHisOper.BackColor = System.Drawing.Color.Transparent
        Me.lblHisOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHisOper.Location = New System.Drawing.Point(30, 492)
        Me.lblHisOper.Name = "lblHisOper"
        Me.lblHisOper.Size = New System.Drawing.Size(105, 18)
        Me.lblHisOper.TabIndex = 0
        Me.lblHisOper.Text = "Contacts Oper"
        '
        'txtHisOper
        '
        Me.txtHisOper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHisOper.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Hoper", True))
        Me.txtHisOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHisOper.Location = New System.Drawing.Point(138, 488)
        Me.txtHisOper.Name = "txtHisOper"
        Me.txtHisOper.Size = New System.Drawing.Size(249, 26)
        Me.txtHisOper.TabIndex = 1
        '
        'lblMyOper
        '
        Me.lblMyOper.AutoSize = True
        Me.lblMyOper.BackColor = System.Drawing.Color.Transparent
        Me.lblMyOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyOper.Location = New System.Drawing.Point(56, 528)
        Me.lblMyOper.Name = "lblMyOper"
        Me.lblMyOper.Size = New System.Drawing.Size(76, 18)
        Me.lblMyOper.TabIndex = 0
        Me.lblMyOper.Text = "Your Oper"
        '
        'txtMyOper
        '
        Me.txtMyOper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMyOper.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Moper", True))
        Me.txtMyOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyOper.Location = New System.Drawing.Point(138, 524)
        Me.txtMyOper.Name = "txtMyOper"
        Me.txtMyOper.Size = New System.Drawing.Size(249, 26)
        Me.txtMyOper.TabIndex = 1
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.BackColor = System.Drawing.Color.Transparent
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(116, 24)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(22, 18)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "ID", True))
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(138, 20)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(109, 26)
        Me.txtID.TabIndex = 1
        '
        'lblBand
        '
        Me.lblBand.AutoSize = True
        Me.lblBand.BackColor = System.Drawing.Color.Transparent
        Me.lblBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand.Location = New System.Drawing.Point(91, 312)
        Me.lblBand.Name = "lblBand"
        Me.lblBand.Size = New System.Drawing.Size(42, 18)
        Me.lblBand.TabIndex = 0
        Me.lblBand.Text = "Band"
        '
        'txtBand
        '
        Me.txtBand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "Band", True))
        Me.txtBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBand.Location = New System.Drawing.Point(138, 308)
        Me.txtBand.Name = "txtBand"
        Me.txtBand.Size = New System.Drawing.Size(249, 26)
        Me.txtBand.TabIndex = 1
        '
        'btnCloseForm
        '
        Me.btnCloseForm.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCloseForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseForm.Location = New System.Drawing.Point(278, 607)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(109, 46)
        Me.btnCloseForm.TabIndex = 3
        Me.btnCloseForm.Text = "Close Form"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'txtDuration
        '
        Me.txtDuration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDuration.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NetLogBindingSource, "NetDuration", True))
        Me.txtDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(138, 560)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(249, 26)
        Me.txtDuration.TabIndex = 5
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(41, 564)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(91, 18)
        Me.lblDuration.TabIndex = 4
        Me.lblDuration.Text = "Net Duration"
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstRecord.ForeColor = System.Drawing.Color.Black
        Me.btnFirstRecord.Location = New System.Drawing.Point(411, 107)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(61, 43)
        Me.btnFirstRecord.TabIndex = 6
        Me.btnFirstRecord.Text = "<<"
        Me.btnFirstRecord.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(411, 199)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(61, 43)
        Me.btnPrevious.TabIndex = 7
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(411, 287)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(61, 43)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLastRec
        '
        Me.btnLastRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLastRec.ForeColor = System.Drawing.Color.Black
        Me.btnLastRec.Location = New System.Drawing.Point(411, 380)
        Me.btnLastRec.Name = "btnLastRec"
        Me.btnLastRec.Size = New System.Drawing.Size(61, 45)
        Me.btnLastRec.TabIndex = 9
        Me.btnLastRec.Text = ">>"
        Me.btnLastRec.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "First"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Last"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Next"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(408, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Previous"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LDateDataGridViewTextBoxColumn, Me.LtimeDataGridViewTextBoxColumn, Me.HCallDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.CountyDataGridViewTextBoxColumn, Me.CountyLineDataGridViewTextBoxColumn, Me.FrequencyDataGridViewTextBoxColumn, Me.BandDataGridViewTextBoxColumn, Me.ModeDataGridViewTextBoxColumn, Me.MCallDataGridViewTextBoxColumn, Me.HrstDataGridViewTextBoxColumn, Me.MrstDataGridViewTextBoxColumn, Me.HoperDataGridViewTextBoxColumn, Me.MoperDataGridViewTextBoxColumn, Me.NetDurationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NetLogBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(82, 100)
        Me.DataGridView1.TabIndex = 14
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LDateDataGridViewTextBoxColumn
        '
        Me.LDateDataGridViewTextBoxColumn.DataPropertyName = "LDate"
        Me.LDateDataGridViewTextBoxColumn.HeaderText = "LDate"
        Me.LDateDataGridViewTextBoxColumn.Name = "LDateDataGridViewTextBoxColumn"
        '
        'LtimeDataGridViewTextBoxColumn
        '
        Me.LtimeDataGridViewTextBoxColumn.DataPropertyName = "Ltime"
        Me.LtimeDataGridViewTextBoxColumn.HeaderText = "Ltime"
        Me.LtimeDataGridViewTextBoxColumn.Name = "LtimeDataGridViewTextBoxColumn"
        '
        'HCallDataGridViewTextBoxColumn
        '
        Me.HCallDataGridViewTextBoxColumn.DataPropertyName = "HCall"
        Me.HCallDataGridViewTextBoxColumn.HeaderText = "HCall"
        Me.HCallDataGridViewTextBoxColumn.Name = "HCallDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'CountyDataGridViewTextBoxColumn
        '
        Me.CountyDataGridViewTextBoxColumn.DataPropertyName = "County"
        Me.CountyDataGridViewTextBoxColumn.HeaderText = "County"
        Me.CountyDataGridViewTextBoxColumn.Name = "CountyDataGridViewTextBoxColumn"
        '
        'CountyLineDataGridViewTextBoxColumn
        '
        Me.CountyLineDataGridViewTextBoxColumn.DataPropertyName = "CountyLine"
        Me.CountyLineDataGridViewTextBoxColumn.HeaderText = "CountyLine"
        Me.CountyLineDataGridViewTextBoxColumn.Name = "CountyLineDataGridViewTextBoxColumn"
        '
        'FrequencyDataGridViewTextBoxColumn
        '
        Me.FrequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency"
        Me.FrequencyDataGridViewTextBoxColumn.HeaderText = "Frequency"
        Me.FrequencyDataGridViewTextBoxColumn.Name = "FrequencyDataGridViewTextBoxColumn"
        '
        'BandDataGridViewTextBoxColumn
        '
        Me.BandDataGridViewTextBoxColumn.DataPropertyName = "Band"
        Me.BandDataGridViewTextBoxColumn.HeaderText = "Band"
        Me.BandDataGridViewTextBoxColumn.Name = "BandDataGridViewTextBoxColumn"
        '
        'ModeDataGridViewTextBoxColumn
        '
        Me.ModeDataGridViewTextBoxColumn.DataPropertyName = "Mode"
        Me.ModeDataGridViewTextBoxColumn.HeaderText = "Mode"
        Me.ModeDataGridViewTextBoxColumn.Name = "ModeDataGridViewTextBoxColumn"
        '
        'MCallDataGridViewTextBoxColumn
        '
        Me.MCallDataGridViewTextBoxColumn.DataPropertyName = "MCall"
        Me.MCallDataGridViewTextBoxColumn.HeaderText = "MCall"
        Me.MCallDataGridViewTextBoxColumn.Name = "MCallDataGridViewTextBoxColumn"
        '
        'HrstDataGridViewTextBoxColumn
        '
        Me.HrstDataGridViewTextBoxColumn.DataPropertyName = "Hrst"
        Me.HrstDataGridViewTextBoxColumn.HeaderText = "Hrst"
        Me.HrstDataGridViewTextBoxColumn.Name = "HrstDataGridViewTextBoxColumn"
        '
        'MrstDataGridViewTextBoxColumn
        '
        Me.MrstDataGridViewTextBoxColumn.DataPropertyName = "Mrst"
        Me.MrstDataGridViewTextBoxColumn.HeaderText = "Mrst"
        Me.MrstDataGridViewTextBoxColumn.Name = "MrstDataGridViewTextBoxColumn"
        '
        'HoperDataGridViewTextBoxColumn
        '
        Me.HoperDataGridViewTextBoxColumn.DataPropertyName = "Hoper"
        Me.HoperDataGridViewTextBoxColumn.HeaderText = "Hoper"
        Me.HoperDataGridViewTextBoxColumn.Name = "HoperDataGridViewTextBoxColumn"
        '
        'MoperDataGridViewTextBoxColumn
        '
        Me.MoperDataGridViewTextBoxColumn.DataPropertyName = "Moper"
        Me.MoperDataGridViewTextBoxColumn.HeaderText = "Moper"
        Me.MoperDataGridViewTextBoxColumn.Name = "MoperDataGridViewTextBoxColumn"
        '
        'NetDurationDataGridViewTextBoxColumn
        '
        Me.NetDurationDataGridViewTextBoxColumn.DataPropertyName = "NetDuration"
        Me.NetDurationDataGridViewTextBoxColumn.HeaderText = "NetDuration"
        Me.NetDurationDataGridViewTextBoxColumn.Name = "NetDurationDataGridViewTextBoxColumn"
        '
        'NetLogTableAdapter
        '
        Me.NetLogTableAdapter.ClearBeforeFill = True
        '
        'EditNetFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(498, 668)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLastRec)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirstRecord)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnSaveEdit)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtMyOper)
        Me.Controls.Add(Me.txtHisOper)
        Me.Controls.Add(Me.txtMyrst)
        Me.Controls.Add(Me.txtContactrst)
        Me.Controls.Add(Me.txtMycall)
        Me.Controls.Add(Me.txtMode)
        Me.Controls.Add(Me.txtBand)
        Me.Controls.Add(Me.txtFreq)
        Me.Controls.Add(Me.txtContactcntyLine)
        Me.Controls.Add(Me.txtContactcounty)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.txtcontactstate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtContactcall)
        Me.Controls.Add(Me.lblMyOper)
        Me.Controls.Add(Me.lblHisOper)
        Me.Controls.Add(Me.lblMrst)
        Me.Controls.Add(Me.lblHrst)
        Me.Controls.Add(Me.lblMcall)
        Me.Controls.Add(Me.lblBand)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblFreq)
        Me.Controls.Add(Me.lblCntyLine)
        Me.Controls.Add(Me.lblHCounty)
        Me.Controls.Add(Me.lblHState)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblCall)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtTime)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EditNetFrm"
        Me.Text = "Edit Net Control Form"
        CType(Me.NetLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetControlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblCall As Label
    Friend WithEvents txtContactcall As TextBox
    Friend WithEvents lblHState As Label
    Friend WithEvents txtcontactstate As TextBox
    Friend WithEvents lblHCounty As Label
    Friend WithEvents txtContactcounty As TextBox
    Friend WithEvents lblCntyLine As Label
    Friend WithEvents txtContactcntyLine As TextBox
    Friend WithEvents lblFreq As Label
    Friend WithEvents txtFreq As TextBox
    Friend WithEvents lblMode As Label
    Friend WithEvents txtMode As TextBox
    Friend WithEvents lblMcall As Label
    Friend WithEvents txtMycall As TextBox
    Friend WithEvents lblHrst As Label
    Friend WithEvents txtContactrst As TextBox
    Friend WithEvents lblMrst As Label
    Friend WithEvents txtMyrst As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents lblHisOper As Label
    Friend WithEvents txtHisOper As TextBox
    Friend WithEvents lblMyOper As Label
    Friend WithEvents txtMyOper As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblBand As Label
    Friend WithEvents txtBand As TextBox
    Friend WithEvents btnCloseForm As Button
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLastRec As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NetControlDataSet1 As NetControlDataSet1
    Friend WithEvents NetLogBindingSource As BindingSource
    Friend WithEvents NetLogTableAdapter As NetControlDataSet1TableAdapters.NetLogTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LtimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HCallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountyLineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FrequencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MCallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HrstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MrstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoperDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoperDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
