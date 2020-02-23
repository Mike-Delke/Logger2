<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStartScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartScreen))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdLocateDatabase = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelExpiration1 = New System.Windows.Forms.Label()
        Me.RadioButtonCall1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCall2 = New System.Windows.Forms.RadioButton()
        Me.LabelExpiration2 = New System.Windows.Forms.Label()
        Me.ckbTeamOperation = New System.Windows.Forms.CheckBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.road_runner1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-708, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1924, 318)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Road Runner Logger"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Select Call To Log"
        '
        'cmdLocateDatabase
        '
        Me.cmdLocateDatabase.BackColor = System.Drawing.Color.Silver
        Me.cmdLocateDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLocateDatabase.Location = New System.Drawing.Point(444, 403)
        Me.cmdLocateDatabase.Name = "cmdLocateDatabase"
        Me.cmdLocateDatabase.Size = New System.Drawing.Size(380, 123)
        Me.cmdLocateDatabase.TabIndex = 5
        Me.cmdLocateDatabase.Text = "             " & Global.Microsoft.VisualBasic.ChrW(10) & "        CLICK HERE TO LOCATE THE" & Global.Microsoft.VisualBasic.ChrW(10) & "              FOLDER WHERE YOUR" & Global.Microsoft.VisualBasic.ChrW(10) & "  " &
    "           DATABASE IS LOCATED"
        Me.cmdLocateDatabase.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(323, 683)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(422, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Award Tracking Software for County Hunters"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        Me.OpenFileDialog.InitialDirectory = "c:\logger data"
        '
        'Timer1
        '
        '
        'LabelExpiration1
        '
        Me.LabelExpiration1.AutoSize = True
        Me.LabelExpiration1.BackColor = System.Drawing.Color.Transparent
        Me.LabelExpiration1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExpiration1.Location = New System.Drawing.Point(208, 537)
        Me.LabelExpiration1.Name = "LabelExpiration1"
        Me.LabelExpiration1.Size = New System.Drawing.Size(193, 15)
        Me.LabelExpiration1.TabIndex = 16
        Me.LabelExpiration1.Text = "MARAC Membership expires "
        '
        'RadioButtonCall1
        '
        Me.RadioButtonCall1.AutoSize = True
        Me.RadioButtonCall1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonCall1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCall1.Location = New System.Drawing.Point(121, 535)
        Me.RadioButtonCall1.Name = "RadioButtonCall1"
        Me.RadioButtonCall1.Size = New System.Drawing.Size(62, 19)
        Me.RadioButtonCall1.TabIndex = 19
        Me.RadioButtonCall1.Text = "Call 1"
        Me.RadioButtonCall1.UseVisualStyleBackColor = False
        '
        'RadioButtonCall2
        '
        Me.RadioButtonCall2.AutoSize = True
        Me.RadioButtonCall2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonCall2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCall2.Location = New System.Drawing.Point(121, 566)
        Me.RadioButtonCall2.Name = "RadioButtonCall2"
        Me.RadioButtonCall2.Size = New System.Drawing.Size(62, 19)
        Me.RadioButtonCall2.TabIndex = 21
        Me.RadioButtonCall2.Text = "Call 2"
        Me.RadioButtonCall2.UseVisualStyleBackColor = False
        '
        'LabelExpiration2
        '
        Me.LabelExpiration2.AutoSize = True
        Me.LabelExpiration2.BackColor = System.Drawing.Color.Transparent
        Me.LabelExpiration2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExpiration2.Location = New System.Drawing.Point(208, 568)
        Me.LabelExpiration2.Name = "LabelExpiration2"
        Me.LabelExpiration2.Size = New System.Drawing.Size(193, 15)
        Me.LabelExpiration2.TabIndex = 20
        Me.LabelExpiration2.Text = "MARAC Membership expires "
        '
        'ckbTeamOperation
        '
        Me.ckbTeamOperation.AutoSize = True
        Me.ckbTeamOperation.BackColor = System.Drawing.Color.Transparent
        Me.ckbTeamOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ckbTeamOperation.ForeColor = System.Drawing.Color.LightYellow
        Me.ckbTeamOperation.Location = New System.Drawing.Point(149, 613)
        Me.ckbTeamOperation.Name = "ckbTeamOperation"
        Me.ckbTeamOperation.Size = New System.Drawing.Size(256, 17)
        Me.ckbTeamOperation.TabIndex = 22
        Me.ckbTeamOperation.Text = "Call 1 and Call 2 Will Operate as a Team"
        Me.ToolTip.SetToolTip(Me.ckbTeamOperation, "Check this Check Box if the two calls will operate as a team")
        Me.ckbTeamOperation.UseVisualStyleBackColor = False
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(252, 657)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 23
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.ReshowDelay = 100
        '
        'frmStartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(894, 722)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.ckbTeamOperation)
        Me.Controls.Add(Me.RadioButtonCall2)
        Me.Controls.Add(Me.LabelExpiration2)
        Me.Controls.Add(Me.RadioButtonCall1)
        Me.Controls.Add(Me.LabelExpiration1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdLocateDatabase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStartScreen"
        Me.Tag = ""
        Me.Text = "Splash Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdLocateDatabase As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelExpiration1 As Label
    Friend WithEvents RadioButtonCall1 As RadioButton
    Friend WithEvents RadioButtonCall2 As RadioButton
    Friend WithEvents LabelExpiration2 As Label
    Friend WithEvents ckbTeamOperation As CheckBox
    Friend WithEvents btnChange As Button
    Friend WithEvents ToolTip As ToolTip
End Class
