Imports System.Data.OleDb
Imports System.IO

Public Class frmStartScreen
    Public CallPass As Object
    Public Property StringPass As String

    Private _rootFolder As String = "C:\RRLogger Data - Flynn\"
    Private _boolTeam As Boolean = False
    Private _initalLocationOfChangeButton As Integer

    Private _commonData As clsCommonData = clsCommonData.GetInstance("CommonData")

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Boolean

    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _initalLocationOfChangeButton = btnChange.Top

        Me.KeyPreview = True    ' This allowing the form to break on a key push anywhere on form

        Dim boolFlag = _commonData.Open(_rootFolder, "County Hunters - Common")
        'Timer1.Start()
        fillInfo()
        GetMemShip()

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' The following code tests for an entered F10 (121)
        If (GetAsyncKeyState(121)) Then
            cmdLocateDatabase.Visible = True
        End If

    End Sub

    Private Sub cmdLocateDatabase_Click(sender As Object, e As EventArgs) Handles cmdLocateDatabase.Click

        OpenFileDialog.Filter = "Database File |*.accdb"

        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            'TextBox1.Visible = True
            'TextBox1.Text = OpenFileDialog1.FileName

        End If

    End Sub
    Private Sub fillInfo()

        Dim values() As String = File.ReadAllText(_rootFolder & "InitialData.txt").Split("|"c)

        RadioButtonCall1.Text = values(0)
        RadioButtonCall1.Visible = True
        LabelExpiration1.Visible = True

        RadioButtonCall2.Text = values(1)
        If values(1) <> "" Then
            RadioButtonCall2.Visible = True
            LabelExpiration2.Visible = True
            ckbTeamOperation.Text = RadioButtonCall1.Text & " and " & RadioButtonCall2.Text & " will operate as a team"
            If values(2) = "Yes" Then
                ckbTeamOperation.Checked = True
            End If
            btnChange.Top = _initalLocationOfChangeButton
        Else
            RadioButtonCall2.Visible = False
            LabelExpiration2.Visible = False
            ckbTeamOperation.Visible = False
            ckbTeamOperation.Checked = False
            btnChange.Top = RadioButtonCall2.Top
        End If
        RadioButtonCall1.Checked = False

        _rootFolder = values(3)  ' operating data folder

    End Sub

    Private Sub SaveInfo()

        Dim teamFlag As String = "No"
        If ckbTeamOperation.Checked Then
            teamFlag = "Yes"
        End If
        File.WriteAllText(_rootFolder & "InitialData.txt", String.Join("|", New String() {RadioButtonCall1.Text, RadioButtonCall2.Text, teamFlag, _rootFolder}))

    End Sub

    Dim con As New OleDbConnection

    Private Sub GetMemShip()

        Dim fullCallData As FullCallData = _commonData.GetFullCallData(RadioButtonCall1.Text)
        LabelExpiration1.Text = LabelExpiration1.Text & " " & CStr(fullCallData.expirationDate)

        If RadioButtonCall2.Visible Then
            fullCallData = _commonData.GetFullCallData(RadioButtonCall2.Text)
            LabelExpiration2.Text = LabelExpiration2.Text & " " & CStr(fullCallData.expirationDate)
        End If

    End Sub

    Private Sub RadioButtonCall1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCall1.CheckedChanged

        If RadioButtonCall1.Checked Then
            _commonData.Close()

            Dim mainMenu As New K8EMSMainMenu
            mainMenu.StringPass = RadioButtonCall1.Text
            mainMenu._strPrimaryCall = RadioButtonCall1.Text
            mainMenu._strSecondaryCall = RadioButtonCall2.Text
            mainMenu._blnTeam = ckbTeamOperation.Checked
            mainMenu._rootFolder = _rootFolder
            mainMenu.Show()
            SaveInfo()
            Hide()
        End If


    End Sub

    Private Sub RadioButtonCall2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCall2.CheckedChanged

        If RadioButtonCall2.Checked Then
            _commonData.Close()

            Dim mainMenu As New K8EMSMainMenu
            mainMenu.StringPass = RadioButtonCall2.Text
            mainMenu._strPrimaryCall = RadioButtonCall2.Text
            mainMenu._strSecondaryCall = RadioButtonCall1.Text
            mainMenu._blnTeam = ckbTeamOperation.Checked
            mainMenu._rootFolder = _rootFolder
            mainMenu.Show()
            SaveInfo()
            Hide()
        End If

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim changeCalls As frmChangeLoggingCalls = New frmChangeLoggingCalls
        changeCalls.txtCall1.Text = RadioButtonCall1.Text
        If RadioButtonCall2.Visible Then
            changeCalls.txtCall2.Text = RadioButtonCall2.Text
        Else
            changeCalls.txtCall2.Text = ""
        End If

        If changeCalls.ShowDialog() = DialogResult.OK Then
            RadioButtonCall1.Text = changeCalls.txtCall1.Text.Trim
            If changeCalls.txtCall2.Text.Length > 0 Then
                RadioButtonCall2.Text = changeCalls.txtCall2.Text.Trim
                RadioButtonCall2.Visible = True
                ckbTeamOperation.Visible = True
                ckbTeamOperation.Checked = True
            Else
                RadioButtonCall2.Text = ""
                RadioButtonCall2.Visible = False
                ckbTeamOperation.Visible = False
                ckbTeamOperation.Checked = False
            End If

            SaveInfo()
            fillInfo()
        End If
    End Sub

    Private Function TestAllDatabasesExist() As Boolean
        Dim blnReturnFlag = True

        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            blnReturnFlag = True
            Dim strFileName As String = OpenFileDialog.FileName
            _rootFolder = Path.GetDirectoryName(strFileName) + "\"

            If RadioButtonCall1.Text.Length > 0 Then
                TestDatabaseExistence(RadioButtonCall1.Text)
            End If
            If RadioButtonCall2.Text.Length > 0 Then
                TestDatabaseExistence(RadioButtonCall2.Text)
            End If
        End If

        Return blnReturnFlag
    End Function

    Private Function TestDatabaseExistence(strCall As String) As Boolean
        Dim blnReturnFlag = True

        Dim strFullFileName = _rootFolder & "County Hunter - " & strCall & ".mdb"
        Dim strFileName = "County Hunter -" & strCall & ".mdb"
        If Not File.Exists(strFullFileName) Then
            blnReturnFlag = False
            MsgBox("The database " & strFileName & " cannot be found in the folder " & _rootFolder & ". The application will end", vbCritical)
            Application.Exit()
        End If
        Return blnReturnFlag
    End Function

    Private Sub frmStartScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim blnReturnFlag As Boolean
        Select Case e.KeyValue
            Case Keys.F10
                blnReturnFlag = FindDatabaseFolder()
        End Select
    End Sub

    Private Function FindDatabaseFolder() As Boolean
        Dim blnReturnFlag = False

        OpenFileDialog.Filter = "Database File |*.mdb"
        OpenFileDialog.InitialDirectory = _rootFolder
        OpenFileDialog.Title = "Locate the folder containing your database"
        OpenFileDialog.FileName = ""

        TestAllDatabasesExist()

        SaveInfo()

        Return blnReturnFlag
    End Function


End Class