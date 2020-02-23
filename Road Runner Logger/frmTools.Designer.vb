<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTools
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.lblCall = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpDateMaster = New System.Windows.Forms.Button()
        Me.btnDownloadUpdates = New System.Windows.Forms.Button()
        Me.btnBackupDatabase = New System.Windows.Forms.Button()
        Me.btnRecalcBook = New System.Windows.Forms.Button()
        Me.cmdButton7 = New System.Windows.Forms.Button()
        Me.cmdButton6 = New System.Windows.Forms.Button()
        Me.cmdButton2 = New System.Windows.Forms.Button()
        Me.cmdButton1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(141, 18)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(260, 60)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Tools Menu"
        '
        'btnCloseForm
        '
        Me.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCloseForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseForm.Location = New System.Drawing.Point(298, 519)
        Me.btnCloseForm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(176, 58)
        Me.btnCloseForm.TabIndex = 2
        Me.btnCloseForm.Text = "Close Form"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'lblCall
        '
        Me.lblCall.AutoSize = True
        Me.lblCall.BackColor = System.Drawing.Color.Transparent
        Me.lblCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCall.Location = New System.Drawing.Point(237, 78)
        Me.lblCall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCall.Name = "lblCall"
        Me.lblCall.Size = New System.Drawing.Size(64, 36)
        Me.lblCall.TabIndex = 3
        Me.lblCall.Text = "call"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnUpDateMaster)
        Me.GroupBox1.Controls.Add(Me.btnDownloadUpdates)
        Me.GroupBox1.Controls.Add(Me.btnBackupDatabase)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(26, 420)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(448, 95)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update"
        '
        'btnUpDateMaster
        '
        Me.btnUpDateMaster.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnUpDateMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpDateMaster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpDateMaster.Location = New System.Drawing.Point(281, 24)
        Me.btnUpDateMaster.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpDateMaster.Name = "btnUpDateMaster"
        Me.btnUpDateMaster.Size = New System.Drawing.Size(151, 58)
        Me.btnUpDateMaster.TabIndex = 0
        Me.btnUpDateMaster.Text = "Update From Master"
        Me.btnUpDateMaster.UseVisualStyleBackColor = False
        '
        'btnDownloadUpdates
        '
        Me.btnDownloadUpdates.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDownloadUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloadUpdates.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDownloadUpdates.Location = New System.Drawing.Point(153, 24)
        Me.btnDownloadUpdates.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDownloadUpdates.Name = "btnDownloadUpdates"
        Me.btnDownloadUpdates.Size = New System.Drawing.Size(113, 58)
        Me.btnDownloadUpdates.TabIndex = 0
        Me.btnDownloadUpdates.Text = "Download Updates"
        Me.btnDownloadUpdates.UseVisualStyleBackColor = False
        '
        'btnBackupDatabase
        '
        Me.btnBackupDatabase.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnBackupDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupDatabase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackupDatabase.Location = New System.Drawing.Point(20, 24)
        Me.btnBackupDatabase.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackupDatabase.Name = "btnBackupDatabase"
        Me.btnBackupDatabase.Size = New System.Drawing.Size(113, 58)
        Me.btnBackupDatabase.TabIndex = 0
        Me.btnBackupDatabase.Text = "Backup Database"
        Me.btnBackupDatabase.UseVisualStyleBackColor = False
        '
        'btnRecalcBook
        '
        Me.btnRecalcBook.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnRecalcBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecalcBook.Location = New System.Drawing.Point(26, 519)
        Me.btnRecalcBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecalcBook.Name = "btnRecalcBook"
        Me.btnRecalcBook.Size = New System.Drawing.Size(232, 58)
        Me.btnRecalcBook.TabIndex = 1
        Me.btnRecalcBook.Text = "Recalculate Book"
        Me.btnRecalcBook.UseVisualStyleBackColor = False
        '
        'cmdButton7
        '
        Me.cmdButton7.AccessibleName = ""
        Me.cmdButton7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmdButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdButton7.Location = New System.Drawing.Point(243, 102)
        Me.cmdButton7.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdButton7.Name = "cmdButton7"
        Me.cmdButton7.Size = New System.Drawing.Size(205, 69)
        Me.cmdButton7.TabIndex = 5
        Me.cmdButton7.Text = "Needs"
        Me.cmdButton7.UseVisualStyleBackColor = False
        '
        'cmdButton6
        '
        Me.cmdButton6.AccessibleName = ""
        Me.cmdButton6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmdButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdButton6.Location = New System.Drawing.Point(243, 30)
        Me.cmdButton6.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdButton6.Name = "cmdButton6"
        Me.cmdButton6.Size = New System.Drawing.Size(205, 68)
        Me.cmdButton6.TabIndex = 6
        Me.cmdButton6.Text = "MRC"
        Me.cmdButton6.UseVisualStyleBackColor = False
        '
        'cmdButton2
        '
        Me.cmdButton2.AccessibleName = ""
        Me.cmdButton2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmdButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdButton2.Location = New System.Drawing.Point(20, 102)
        Me.cmdButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdButton2.Name = "cmdButton2"
        Me.cmdButton2.Size = New System.Drawing.Size(212, 69)
        Me.cmdButton2.TabIndex = 7
        Me.cmdButton2.Text = "Log"
        Me.cmdButton2.UseVisualStyleBackColor = False
        '
        'cmdButton1
        '
        Me.cmdButton1.AccessibleName = ""
        Me.cmdButton1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.cmdButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdButton1.Location = New System.Drawing.Point(20, 30)
        Me.cmdButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdButton1.Name = "cmdButton1"
        Me.cmdButton1.Size = New System.Drawing.Size(212, 68)
        Me.cmdButton1.TabIndex = 8
        Me.cmdButton1.Text = "Book"
        Me.cmdButton1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdButton2)
        Me.GroupBox2.Controls.Add(Me.cmdButton7)
        Me.GroupBox2.Controls.Add(Me.cmdButton6)
        Me.GroupBox2.Controls.Add(Me.cmdButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 190)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Printing Group"
        '
        'frmTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(511, 600)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRecalcBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCall)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTools"
        Me.Text = "Tools"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCloseForm As Button
    Friend WithEvents lblCall As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUpDateMaster As Button
    Friend WithEvents btnDownloadUpdates As Button
    Friend WithEvents btnBackupDatabase As Button
    Friend WithEvents btnRecalcBook As Button
    Friend WithEvents cmdButton7 As Button
    Friend WithEvents cmdButton6 As Button
    Friend WithEvents cmdButton2 As Button
    Friend WithEvents cmdButton1 As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
