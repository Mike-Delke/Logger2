<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMARAC
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCall = New System.Windows.Forms.Label()
        Me.lblDirectors = New System.Windows.Forms.Label()
        Me.lblClubOfficers = New System.Windows.Forms.Label()
        Me.DataGridViewOfficers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewDirectors = New System.Windows.Forms.DataGridView()
        Me.btnViewEdit = New System.Windows.Forms.Button()
        CType(Me.DataGridViewOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDirectors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 117)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MARAC"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(246, 516)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(185, 63)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Main Menu"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblCall
        '
        Me.lblCall.AutoSize = True
        Me.lblCall.Location = New System.Drawing.Point(412, 39)
        Me.lblCall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCall.Name = "lblCall"
        Me.lblCall.Size = New System.Drawing.Size(39, 13)
        Me.lblCall.TabIndex = 2
        Me.lblCall.Text = "Label2"
        '
        'lblDirectors
        '
        Me.lblDirectors.AutoSize = True
        Me.lblDirectors.BackColor = System.Drawing.Color.Transparent
        Me.lblDirectors.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectors.Location = New System.Drawing.Point(125, 194)
        Me.lblDirectors.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDirectors.Name = "lblDirectors"
        Me.lblDirectors.Size = New System.Drawing.Size(220, 60)
        Me.lblDirectors.TabIndex = 3
        Me.lblDirectors.Text = "Directors"
        '
        'lblClubOfficers
        '
        Me.lblClubOfficers.AutoSize = True
        Me.lblClubOfficers.BackColor = System.Drawing.Color.Transparent
        Me.lblClubOfficers.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClubOfficers.Location = New System.Drawing.Point(493, 194)
        Me.lblClubOfficers.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClubOfficers.Name = "lblClubOfficers"
        Me.lblClubOfficers.Size = New System.Drawing.Size(292, 60)
        Me.lblClubOfficers.TabIndex = 3
        Me.lblClubOfficers.Text = "Club Officers"
        '
        'DataGridViewOfficers
        '
        Me.DataGridViewOfficers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewOfficers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewOfficers.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridViewOfficers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOfficers.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewOfficers.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewOfficers.Location = New System.Drawing.Point(480, 275)
        Me.DataGridViewOfficers.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewOfficers.Name = "DataGridViewOfficers"
        Me.DataGridViewOfficers.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewOfficers.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewOfficers.RowHeadersVisible = False
        Me.DataGridViewOfficers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewOfficers.RowTemplate.Height = 24
        Me.DataGridViewOfficers.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridViewOfficers.Size = New System.Drawing.Size(309, 293)
        Me.DataGridViewOfficers.TabIndex = 6
        '
        'DataGridViewDirectors
        '
        Me.DataGridViewDirectors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewDirectors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridViewDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDirectors.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewDirectors.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewDirectors.Location = New System.Drawing.Point(19, 275)
        Me.DataGridViewDirectors.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewDirectors.Name = "DataGridViewDirectors"
        Me.DataGridViewDirectors.RowHeadersVisible = False
        Me.DataGridViewDirectors.RowTemplate.Height = 24
        Me.DataGridViewDirectors.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridViewDirectors.Size = New System.Drawing.Size(412, 207)
        Me.DataGridViewDirectors.TabIndex = 7
        '
        'btnViewEdit
        '
        Me.btnViewEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewEdit.Location = New System.Drawing.Point(45, 516)
        Me.btnViewEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewEdit.Name = "btnViewEdit"
        Me.btnViewEdit.Size = New System.Drawing.Size(157, 63)
        Me.btnViewEdit.TabIndex = 8
        Me.btnViewEdit.Text = "View / Edit"
        Me.btnViewEdit.UseVisualStyleBackColor = True
        '
        'frmMARAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(825, 585)
        Me.Controls.Add(Me.btnViewEdit)
        Me.Controls.Add(Me.DataGridViewDirectors)
        Me.Controls.Add(Me.DataGridViewOfficers)
        Me.Controls.Add(Me.lblClubOfficers)
        Me.Controls.Add(Me.lblDirectors)
        Me.Controls.Add(Me.lblCall)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMARAC"
        Me.Text = "MARAC"
        CType(Me.DataGridViewOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDirectors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblCall As Label
    Friend WithEvents lblDirectors As Label
    Friend WithEvents lblClubOfficers As Label
    Friend WithEvents DataGridViewOfficers As DataGridView
    Friend WithEvents DataGridViewDirectors As DataGridView
    Friend WithEvents btnViewEdit As Button
End Class
