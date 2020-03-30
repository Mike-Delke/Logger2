<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditFrm))
        Me.txtTime = New System.Windows.Forms.TextBox()
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
        Me.lblMstate = New System.Windows.Forms.Label()
        Me.txtMystate = New System.Windows.Forms.TextBox()
        Me.lblMcounty = New System.Windows.Forms.Label()
        Me.txtMycounty = New System.Windows.Forms.TextBox()
        Me.lblMcntyline = New System.Windows.Forms.Label()
        Me.txtMycntyLine = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblHisOper = New System.Windows.Forms.Label()
        Me.txtHisOper = New System.Windows.Forms.TextBox()
        Me.lblMyOper = New System.Windows.Forms.Label()
        Me.txtMyOper = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblBand = New System.Windows.Forms.Label()
        Me.txtBand = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.BtnPreviousRecord = New System.Windows.Forms.Button()
        Me.BtnLastRecord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTime
        '
        Me.txtTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(138, 92)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(249, 26)
        Me.txtTime.TabIndex = 1
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
        Me.lblMcall.Location = New System.Drawing.Point(56, 384)
        Me.lblMcall.Name = "lblMcall"
        Me.lblMcall.Size = New System.Drawing.Size(78, 18)
        Me.lblMcall.TabIndex = 0
        Me.lblMcall.Text = "Home Call"
        '
        'txtMycall
        '
        Me.txtMycall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.lblMrst.Location = New System.Drawing.Point(50, 456)
        Me.lblMrst.Name = "lblMrst"
        Me.lblMrst.Size = New System.Drawing.Size(83, 18)
        Me.lblMrst.TabIndex = 0
        Me.lblMrst.Text = "Home RST"
        '
        'txtMyrst
        '
        Me.txtMyrst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMyrst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyrst.Location = New System.Drawing.Point(138, 452)
        Me.txtMyrst.Name = "txtMyrst"
        Me.txtMyrst.Size = New System.Drawing.Size(249, 26)
        Me.txtMyrst.TabIndex = 1
        '
        'lblMstate
        '
        Me.lblMstate.AutoSize = True
        Me.lblMstate.BackColor = System.Drawing.Color.Transparent
        Me.lblMstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMstate.Location = New System.Drawing.Point(40, 564)
        Me.lblMstate.Name = "lblMstate"
        Me.lblMstate.Size = New System.Drawing.Size(87, 18)
        Me.lblMstate.TabIndex = 0
        Me.lblMstate.Text = "Home State"
        '
        'txtMystate
        '
        Me.txtMystate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMystate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMystate.Location = New System.Drawing.Point(138, 560)
        Me.txtMystate.Name = "txtMystate"
        Me.txtMystate.Size = New System.Drawing.Size(249, 26)
        Me.txtMystate.TabIndex = 1
        '
        'lblMcounty
        '
        Me.lblMcounty.AutoSize = True
        Me.lblMcounty.BackColor = System.Drawing.Color.Transparent
        Me.lblMcounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMcounty.Location = New System.Drawing.Point(32, 600)
        Me.lblMcounty.Name = "lblMcounty"
        Me.lblMcounty.Size = New System.Drawing.Size(100, 18)
        Me.lblMcounty.TabIndex = 0
        Me.lblMcounty.Text = "Home County"
        '
        'txtMycounty
        '
        Me.txtMycounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMycounty.Location = New System.Drawing.Point(138, 596)
        Me.txtMycounty.Name = "txtMycounty"
        Me.txtMycounty.Size = New System.Drawing.Size(249, 26)
        Me.txtMycounty.TabIndex = 1
        '
        'lblMcntyline
        '
        Me.lblMcntyline.AutoSize = True
        Me.lblMcntyline.BackColor = System.Drawing.Color.Transparent
        Me.lblMcntyline.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMcntyline.Location = New System.Drawing.Point(16, 636)
        Me.lblMcntyline.Name = "lblMcntyline"
        Me.lblMcntyline.Size = New System.Drawing.Size(114, 18)
        Me.lblMcntyline.TabIndex = 0
        Me.lblMcntyline.Text = "Home Cnty Line"
        '
        'txtMycntyLine
        '
        Me.txtMycntyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMycntyLine.Location = New System.Drawing.Point(138, 632)
        Me.txtMycntyLine.Name = "txtMycntyLine"
        Me.txtMycntyLine.Size = New System.Drawing.Size(249, 26)
        Me.txtMycntyLine.TabIndex = 1
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
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(138, 56)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(249, 26)
        Me.txtDate.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Yellow
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(138, 679)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(125, 46)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.lblMyOper.Location = New System.Drawing.Point(47, 528)
        Me.lblMyOper.Name = "lblMyOper"
        Me.lblMyOper.Size = New System.Drawing.Size(86, 18)
        Me.lblMyOper.TabIndex = 0
        Me.lblMyOper.Text = "Home Oper"
        '
        'txtMyOper
        '
        Me.txtMyOper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.txtBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBand.Location = New System.Drawing.Point(138, 308)
        Me.txtBand.Name = "txtBand"
        Me.txtBand.Size = New System.Drawing.Size(249, 26)
        Me.txtBand.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(278, 679)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close Form"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.BackColor = System.Drawing.Color.SkyBlue
        Me.btnFirstRecord.Location = New System.Drawing.Point(393, 164)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(90, 62)
        Me.btnFirstRecord.TabIndex = 4
        Me.btnFirstRecord.Text = "FIRST RECORD"
        Me.btnFirstRecord.UseVisualStyleBackColor = False
        '
        'btnNextRecord
        '
        Me.btnNextRecord.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNextRecord.Location = New System.Drawing.Point(393, 272)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(90, 62)
        Me.btnNextRecord.TabIndex = 5
        Me.btnNextRecord.Text = "NEXT RECORD"
        Me.btnNextRecord.UseVisualStyleBackColor = False
        '
        'BtnPreviousRecord
        '
        Me.BtnPreviousRecord.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnPreviousRecord.Location = New System.Drawing.Point(393, 379)
        Me.BtnPreviousRecord.Name = "BtnPreviousRecord"
        Me.BtnPreviousRecord.Size = New System.Drawing.Size(90, 59)
        Me.BtnPreviousRecord.TabIndex = 6
        Me.BtnPreviousRecord.Text = "PREVIOUS RECORD"
        Me.BtnPreviousRecord.UseVisualStyleBackColor = False
        '
        'BtnLastRecord
        '
        Me.BtnLastRecord.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnLastRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLastRecord.Location = New System.Drawing.Point(393, 486)
        Me.BtnLastRecord.Name = "BtnLastRecord"
        Me.BtnLastRecord.Size = New System.Drawing.Size(90, 64)
        Me.BtnLastRecord.TabIndex = 7
        Me.BtnLastRecord.Text = "LAST RECORD"
        Me.BtnLastRecord.UseVisualStyleBackColor = False
        '
        'EditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(495, 737)
        Me.Controls.Add(Me.BtnLastRecord)
        Me.Controls.Add(Me.BtnPreviousRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.btnFirstRecord)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtMycntyLine)
        Me.Controls.Add(Me.txtMycounty)
        Me.Controls.Add(Me.txtMystate)
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
        Me.Controls.Add(Me.lblMcntyline)
        Me.Controls.Add(Me.lblMyOper)
        Me.Controls.Add(Me.lblMcounty)
        Me.Controls.Add(Me.lblHisOper)
        Me.Controls.Add(Me.lblMstate)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditFrm"
        Me.Text = "Edit Log Form"
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
    Friend WithEvents lblMstate As Label
    Friend WithEvents txtMystate As TextBox
    Friend WithEvents lblMcounty As Label
    Friend WithEvents txtMycounty As TextBox
    Friend WithEvents lblMcntyline As Label
    Friend WithEvents txtMycntyLine As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblHisOper As Label
    Friend WithEvents txtHisOper As TextBox
    Friend WithEvents lblMyOper As Label
    Friend WithEvents txtMyOper As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblBand As Label
    Friend WithEvents txtBand As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents BtnPreviousRecord As Button
    Friend WithEvents BtnLastRecord As Button
End Class
