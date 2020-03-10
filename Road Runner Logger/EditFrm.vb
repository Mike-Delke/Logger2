Imports System.Data.OleDb

Public Class EditFrm

    ' 
    Dim con As OleDbConnection = New OleDbConnection

    Private Sub EditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GetRecord()
        '' FAIL IF NO RECORDS FOUND OR POSITION IS OUT OF RANGE
        'If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        '' RETRN FIRST USER FOUND
        'Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        '' POPULATE FIELDS
        'txtUserID.Text = r("ID").ToString
        'txtUser.Text = r("username").ToString
        'txtPass.Text = r("password").ToString
        'txtEmail.Text = r("email").ToString
        'txtWebsite.Text = r("website").ToString

        'If r("Active") IsNot Nothing Then cbActive.Checked = r("Active")
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        'CurrentRecord += AddVal ' Advance position by AddVal
        'If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0 ' Loop to first record
        'If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1 ' Loop to last record

        '' UPDATE FORM
        'GetRecord()
    End Sub

    Private Sub UpdateRecord()
        '' FAIL IF NO USER SELECTED
        'If String.IsNullOrEmpty(txtUserID.Text) Then Exit Sub

        '' ADD PARAMETERS - ORDER MATTERS !!!
        'Access.AddParam("@user", txtUser.Text)
        'Access.AddParam("@pass", txtPass.Text)
        'Access.AddParam("@email", txtEmail.Text)
        'Access.AddParam("@website", txtWebsite.Text)
        'Access.AddParam("@active", cbActive.Checked)
        'Access.AddParam("@uid", txtUserID.Text)

        '' RUN COMMAND
        'Access.ExecQuery("UPDATE members " &
        '                 "SET username=@user,[Password]=@pass,email=@email,website=@website,Active=@active " &
        '                 "WHERE id=@uid")

        '' REPORT & ABORT ON ERRORS
        'If NoErrors(True) = False Then Exit Sub

        '' REFRESH THE USERS DATATABLE & FETCH CURRENT RECORD
        'GetUsers()
        'Me.Text = Me.Text & " - " & "SAVED!"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl "
        Dim strFileSuffix = ".mdb"
        Dim databaseFile As String = "C:\RRLogger Data\NetControl.mdb"                                                  '& strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()
        Dim str As String


        str = ("Update NetLog SET [LDate] = '" & txtDate.Text & "',[LTime] = '" & txtTime.Text & "',[HCall] = '" & txtContactcall.Text & "',[State] = '" & txtcontactstate.Text & "',
                             [County] = '" & txtContactcounty.Text & "',[CountyLine] = '" & txtContactcntyLine.Text & "',[Freq] = '" & txtFreq.Text & "',[Band] = '" & txtBand.Text & "',[Mode] = '" & txtMode.Text & "',
                             [MyCall] = '" & txtMycall.Text & "',[HRST] = '" & txtContactrst.Text & "',[MRST] = '" & txtMyrst.Text & "',[MState] = '" & txtMystate.Text & "',
                             [MCounty] = '" & txtMycounty.Text & "',[MCountyLine] = '" & txtMycntyLine.Text & "'
                             WHERE [Id] = " & txtID.Text)

        Dim cmd As OleDbCommand = New OleDbCommand(str, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

            txtID.Clear()
            txtTime.Clear()
            txtDate.Clear()
            txtContactcall.Clear()
            txtcontactstate.Clear()
            txtContactcounty.Clear()
            txtContactcntyLine.Clear()
            txtFreq.Clear()
            txtMode.Clear()
            txtMycall.Clear()
            txtContactrst.Clear()
            txtMyrst.Clear()
            txtMystate.Clear()
            txtMycounty.Clear()
            txtMycntyLine.Clear()
            txtHisOper.Clear()
            txtMyOper.Clear()
            txtBand.Clear()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()

    End Sub

    'Private Sub UpdateUser_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    '    GetUsers()
    'End Sub

    'Private Sub cmdPrev_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrev.Click
    '    NextRecord(-1)
    'End Sub

    'Private Sub cmdNext_Click(sender As System.Object, e As System.EventArgs) Handles cmdNext.Click
    '    NextRecord(1)
    'End Sub

    'Private Sub cmdFirst_Click(sender As System.Object, e As System.EventArgs) Handles cmdFirst.Click
    '    CurrentRecord = 0
    '    GetRecord()
    'End Sub

    'Private Sub cmdLast_Click(sender As System.Object, e As System.EventArgs) Handles cmdLast.Click
    '    CurrentRecord = Access.DBDT.Rows.Count - 1
    '    GetRecord()
    'End Sub

    'Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
    '    UpdateRecord()
    'End Sub
End Class