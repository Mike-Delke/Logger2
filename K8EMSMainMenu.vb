
Imports System.Data.OleDb

Public Enum ScreenType
    None
    Fixed
    Mobile
End Enum

Public Class K8EMSMainMenu

    Public _strPrimaryCall As String = ""
    Public _strSecondaryCall As String = ""
    Public _blnTeam As Boolean = False
    Public _rootFolder As String

    Public _logEntryType As String = ""

    Private _fixedLogEntry As frmLogEntry
    Private _mobileLogEntry As frmLogEntry

    Private _primaryLog As clsLog = clsPrimaryLog.GetInstance("PrimaryLog")
    Private _secondaryLog As clsLog = clsSecondaryLog.GetInstance("SecondaryLog")
    Private _commonData As clsCommonData = clsCommonData.GetInstance("CommonData")
    Private _netControl As clsNetControl = clsNetControl.GetInstance("NetControl")

    Public txtoptCall2 As Object
    Public Property StringPass As String

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openDatabases()
        lblCall.Text = StringPass

    End Sub

    Private Sub btnQuitLogger_Click(sender As Object, e As EventArgs) Handles btnQuitLogger.Click

        'End
        Application.Exit()

    End Sub

    Private Sub btnLogEntryMenu_Click(sender As Object, e As EventArgs) Handles btnLogEntryMenu.Click

        Dim obj As New FixedLogEntry
        obj.StringPass = _strPrimaryCall
        obj.Show()
        'Me.Hide()

    End Sub

    Private Sub btnPrintMenu_Click(sender As Object, e As EventArgs) Handles btnPrintMenu.Click

        Dim obj As New frmTools
        obj.StringPass = lblCall.Text
        obj.Show()
        ' Me.Hide()

    End Sub

    Private Sub btnViewEditMenu_Click(sender As Object, e As EventArgs) Handles btnViewEditMenu.Click

        Dim obj As New ViewEditMenu
        obj.StringPass = lblCall.Text
        obj.Show()
        ' Me.Hide()

    End Sub

    Private Sub btnNetControl_Click(sender As Object, e As EventArgs) Handles btnNetControl.Click

        Dim obj As New NetControl
        obj.StringPass = lblCall.Text
        obj.Show()
        ' Me.Hide()

    End Sub

    Private Sub btnToolsMenu_Click(sender As Object, e As EventArgs) Handles btnToolsMenu.Click

        Dim obj As New frmTools
        obj.StringPass = lblCall.Text
        obj.Show()
        ' Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Function openDatabases() As Boolean
        Dim blnFlag As Boolean

        Dim primaryLog As String = "County Hunter - " & _strPrimaryCall
        Dim secondaryLog As String = "County Hunter - " & _strSecondaryCall

        ' NOTE: The database extension and OLEDB provider is defined when opening the d
        ' Open main database
        blnFlag = _primaryLog.Open(_rootFolder, primaryLog)
        If blnFlag Then
            ' Open secondary database if required
            If _blnTeam Then
                blnFlag = _secondaryLog.Open(_rootFolder, secondaryLog)
            End If


            ' The Common Database has already been opened in the StartScreen routine
            ' It does Not need to be opened again

            If blnFlag Then
                ' Open netControl database
                blnFlag = _netControl.Open(_rootFolder, "NetControl")
            End If
        End If

        Return blnFlag
    End Function

    Private Sub closeDatabases()
        _primaryLog.Close()
        If _blnTeam Then
            _secondaryLog.Close()
        End If
        _commonData.Close()
        _netControl.Close()
    End Sub

    Public Sub closeLogEntryScreen(typeScreen As ScreenType)
        Select Case typeScreen
            Case ScreenType.Fixed
                FixedToolStripMenuItem.Checked = False
                _fixedLogEntry.Close()
                _fixedLogEntry.Dispose()
            Case ScreenType.Mobile
                MobileToolStripMenuItem.Checked = False
                _mobileLogEntry.Close()
                _mobileLogEntry.Dispose()
        End Select
    End Sub

    Private Sub FixedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixedToolStripMenuItem.Click
        ControlDisplay(False)
        If FixedToolStripMenuItem.Checked Then
            _fixedLogEntry.Show()
        Else
            _fixedLogEntry = New frmLogEntry
            _fixedLogEntry.MdiParent = Me
            _fixedLogEntry._logEntryType = ScreenType.Fixed
            _fixedLogEntry._locationLeftEdge = GetLeftEdge()
            FixedToolStripMenuItem.Checked = True
            _fixedLogEntry.Show()
        End If
    End Sub

    Private Sub MobileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobileToolStripMenuItem.Click
        ControlDisplay(False)
        If MobileToolStripMenuItem.Checked Then
            _mobileLogEntry.Show()
        Else
            _mobileLogEntry = New frmLogEntry
            _mobileLogEntry.MdiParent = Me
            _mobileLogEntry._logEntryType = ScreenType.Mobile
            _mobileLogEntry._locationLeftEdge = GetLeftEdge()
            MobileToolStripMenuItem.Checked = True
            _mobileLogEntry.Show()
        End If
    End Sub

    Private Function GetLeftEdge() As Integer
        Dim leftEdge = 0
        If FixedToolStripMenuItem.Checked Then
            leftEdge = _fixedLogEntry.Width + 1
        ElseIf MobileToolStripMenuItem.Checked Then
            leftEdge = _mobileLogEntry.Width + 1
        End If
        Return leftEdge
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeDatabases()
        e.Cancel = False
        Application.Exit()
    End Sub

    Private Sub ControlDisplay(blnFlag As Boolean)
        'Label1.Visible = blnFlag
        Label2.Visible = blnFlag
        'PictureBox1.Visible = blnFlag
        ' PictureBox2.Visible = blnFlag
        btnQuitLogger.Visible = blnFlag
        btnLogEntryMenu.Visible = blnFlag
        btnPrintMenu.Visible = blnFlag
        btnViewEditMenu.Visible = blnFlag
        btnNetControl.Visible = blnFlag
        btnToolsMenu.Visible = blnFlag
        lblCall.Visible = blnFlag
    End Sub

    Private Sub btnNeeds_Click(sender As Object, e As EventArgs) Handles btnNeeds.Click

        Dim obj As New NeedsAtGlance
        obj.StringPass = _strPrimaryCall
        obj.Show()

    End Sub
End Class