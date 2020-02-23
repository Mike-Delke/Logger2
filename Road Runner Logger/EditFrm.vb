Imports System.Data.OleDb

Public Class EditFrm

    ' 
    Dim con As OleDbConnection = New OleDbConnection

    Private Sub EditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl "
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"                                                  '& strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()
        Dim str As String


        str = ("Update TempLog SET [LDate] = '" & txtDate.Text & "',[LTime] = '" & txtTime.Text & "',[HCall] = '" & txtHcall.Text & "',[State] = '" & txtHstate.Text & "',
                             [County] = '" & txtHcounty.Text & "',[CountyLine] = '" & txtHcntyLine.Text & "',[Freq] = '" & txtFreq.Text & "',[Band] = '" & txtBand.Text & "',[Mode] = '" & txtMode.Text & "',
                             [MyCall] = '" & txtMycall.Text & "',[HRST] = '" & txtHrst.Text & "',[MRST] = '" & txtMrst.Text & "',[MState] = '" & txtMstate.Text & "',
                             [MCounty] = '" & txtMcounty.Text & "',[MCountyLine] = '" & txtMcntyLine.Text & "'
                             WHERE [Id] = " & txtID.Text)

        Dim cmd As OleDbCommand = New OleDbCommand(str, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

            txtID.Clear()
            txtTime.Clear()
            txtDate.Clear()
            txtHcall.Clear()
            txtHstate.Clear()
            txtHcounty.Clear()
            txtHcntyLine.Clear()
            txtFreq.Clear()
            txtMode.Clear()
            txtMycall.Clear()
            txtHrst.Clear()
            txtMrst.Clear()
            txtMstate.Clear()
            txtMcounty.Clear()
            txtMcntyLine.Clear()
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
End Class