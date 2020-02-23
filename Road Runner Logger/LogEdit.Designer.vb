<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogEdit
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
        Me.grpBoxEdit = New System.Windows.Forms.GroupBox()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnState = New System.Windows.Forms.Button()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.btnCounty = New System.Windows.Forms.Button()
        Me.btnLast90 = New System.Windows.Forms.Button()
        Me.btnFromTo = New System.Windows.Forms.Button()
        Me.btnYear = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnViewEdit = New System.Windows.Forms.Button()
        Me.grpBoxEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxEdit
        '
        Me.grpBoxEdit.BackColor = System.Drawing.Color.Transparent
        Me.grpBoxEdit.Controls.Add(Me.btnYear)
        Me.grpBoxEdit.Controls.Add(Me.btnFromTo)
        Me.grpBoxEdit.Controls.Add(Me.btnLast90)
        Me.grpBoxEdit.Controls.Add(Me.btnCounty)
        Me.grpBoxEdit.Controls.Add(Me.btnCall)
        Me.grpBoxEdit.Controls.Add(Me.btnState)
        Me.grpBoxEdit.Controls.Add(Me.btnDate)
        Me.grpBoxEdit.Controls.Add(Me.btnToday)
        Me.grpBoxEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxEdit.Location = New System.Drawing.Point(40, 786)
        Me.grpBoxEdit.Name = "grpBoxEdit"
        Me.grpBoxEdit.Size = New System.Drawing.Size(1040, 100)
        Me.grpBoxEdit.TabIndex = 0
        Me.grpBoxEdit.TabStop = False
        Me.grpBoxEdit.Text = "View By"
        '
        'btnToday
        '
        Me.btnToday.Location = New System.Drawing.Point(22, 27)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(120, 58)
        Me.btnToday.TabIndex = 0
        Me.btnToday.Text = "Todays" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "QSOs"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(148, 27)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(120, 58)
        Me.btnDate.TabIndex = 0
        Me.btnDate.Text = "Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnState
        '
        Me.btnState.Location = New System.Drawing.Point(274, 27)
        Me.btnState.Name = "btnState"
        Me.btnState.Size = New System.Drawing.Size(120, 58)
        Me.btnState.TabIndex = 0
        Me.btnState.Text = "State"
        Me.btnState.UseVisualStyleBackColor = True
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(400, 27)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(120, 58)
        Me.btnCall.TabIndex = 0
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'btnCounty
        '
        Me.btnCounty.Location = New System.Drawing.Point(526, 27)
        Me.btnCounty.Name = "btnCounty"
        Me.btnCounty.Size = New System.Drawing.Size(120, 58)
        Me.btnCounty.TabIndex = 0
        Me.btnCounty.Text = "County"
        Me.btnCounty.UseVisualStyleBackColor = True
        '
        'btnLast90
        '
        Me.btnLast90.Location = New System.Drawing.Point(652, 27)
        Me.btnLast90.Name = "btnLast90"
        Me.btnLast90.Size = New System.Drawing.Size(120, 58)
        Me.btnLast90.TabIndex = 0
        Me.btnLast90.Text = "Last 90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Days"
        Me.btnLast90.UseVisualStyleBackColor = True
        '
        'btnFromTo
        '
        Me.btnFromTo.Location = New System.Drawing.Point(778, 26)
        Me.btnFromTo.Name = "btnFromTo"
        Me.btnFromTo.Size = New System.Drawing.Size(120, 58)
        Me.btnFromTo.TabIndex = 0
        Me.btnFromTo.Text = "From/to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date"
        Me.btnFromTo.UseVisualStyleBackColor = True
        '
        'btnYear
        '
        Me.btnYear.Location = New System.Drawing.Point(904, 26)
        Me.btnYear.Name = "btnYear"
        Me.btnYear.Size = New System.Drawing.Size(120, 58)
        Me.btnYear.TabIndex = 0
        Me.btnYear.Text = "Year To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date"
        Me.btnYear.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(610, 27)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(783, 98)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "View / Edit / Print - Log"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(1614, 812)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(190, 71)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnViewEdit
        '
        Me.btnViewEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewEdit.Location = New System.Drawing.Point(1399, 813)
        Me.btnViewEdit.Name = "btnViewEdit"
        Me.btnViewEdit.Size = New System.Drawing.Size(189, 70)
        Me.btnViewEdit.TabIndex = 3
        Me.btnViewEdit.Text = "View / Edit"
        Me.btnViewEdit.UseVisualStyleBackColor = True
        '
        'LogEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Road_Runner_Logger.My.Resources.Resources.imagesO7PSW12X
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1839, 918)
        Me.Controls.Add(Me.btnViewEdit)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grpBoxEdit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LogEdit"
        Me.Text = "Log Editing Screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpBoxEdit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBoxEdit As GroupBox
    Friend WithEvents btnYear As Button
    Friend WithEvents btnFromTo As Button
    Friend WithEvents btnLast90 As Button
    Friend WithEvents btnCounty As Button
    Friend WithEvents btnCall As Button
    Friend WithEvents btnState As Button
    Friend WithEvents btnDate As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnViewEdit As Button
End Class
