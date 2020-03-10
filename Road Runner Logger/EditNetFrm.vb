Imports System.Data.OleDb

Public Class EditNetFrm
    Private Access As New DBControl

    Private CurrentRecord As Integer = 0


    ' 
    Dim con As OleDbConnection = New OleDbConnection

    Private Sub EditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''TODO: This line of code loads data into the 'NetControlDataSet1.NetLog' table. You can move, or remove it, as needed.
        Me.NetLogTableAdapter.Fill(Me.NetControlDataSet1.NetLog)
        LoadForm()
    End Sub

    ' ERROR CHECKING & REPORTING 
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LoadForm()
        ' QUERY USERS TO FILL DATA TABLE
        Access.ExecNonQuery("SELECT * FROM NetLog")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' GET FIRST RECORD
        GetRecord()
    End Sub

    Private Sub GetRecord()


        ' FAIL If NO RECORDS FOUND Or POSITION Is OUT OF RANGE
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        'RETRN FIRST USER FOUND
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        'POPULATE FIELDS
        txtID.Text = r("ID").ToString
        txtDate.Text = r("LDate").ToString
        txtTime.Text = r("LTime").ToString
        txtContactcall.Text = r("HCall").ToString
        txtcontactstate.Text = r("State").ToString
        txtContactcounty.Text = r("County").ToString
        txtContactcntyLine.Text = r("CountyLine").ToString
        txtFreq.Text = r("Frequency").ToString
        txtBand.Text = r("Band").ToString
        txtMode.Text = r("Mode").ToString
        txtMycall.Text = r("MCall").ToString
        txtContactrst.Text = r("Hrst").ToString
        txtMyrst.Text = r("Mrst").ToString
        txtHisOper.Text = r("Hoper").ToString
        txtMyOper.Text = r("Moper").ToString
        txtDuration.Text = r("NetDuration").ToString

    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal ' Advance position by AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0 ' Loop to first record
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1 ' Loop to last record

        ' UPDATE FORM
        GetRecord()
    End Sub

    Private Sub previousRecord(AddVal As Integer)

        CurrentRecord += AddVal ' Advance position by AddVal
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1 ' Loop to last record

    End Sub

    Private Sub UpdateRecord()
        ' FAIL IF NO USER SELECTED
        If String.IsNullOrEmpty(txtID.Text) Then Exit Sub

        ' ADD PARAMETERS - ORDER MATTERS !!!

        Access.AddParam("@uid", txtID.Text)
        Access.AddParam("@Date", txtDate.Text)
        Access.AddParam("@Time", txtTime.Text)
        Access.AddParam("@Hcall", txtContactcall.Text)
        Access.AddParam("@Hstate", txtcontactstate.Text)
        Access.AddParam("@Hcounty", txtContactcounty.Text)
        Access.AddParam("@CountyLine", txtContactcntyLine.Text)
        Access.AddParam("@freq", txtFreq.Text)
        Access.AddParam("@band", txtBand.Text)
        Access.AddParam("@mode", txtMode.Text)
        Access.AddParam("@mcall", txtMycall.Text)
        Access.AddParam("@hrst", txtContactrst.Text)
        Access.AddParam("@mrst", txtMyrst.Text)
        Access.AddParam("@hoper", txtHisOper.Text)
        Access.AddParam("@moper", txtMyOper.Text)
        Access.AddParam("@dur", txtDuration.Text)

        ' RUN COMMAND
        Access.ExecNonQuery("UPDATE Netlog " &
                        "SET ldate = @Date,ltime = @time,Hcall = @Hcall,state = @Hstate,County = @Hcounty,[CountyLine] = @CountyLine,
                        Frequency = @freq,Band = @band,Mode = @modet,MCall = @mcall,Hrst = @hrst,Mrst = @mrst,
                        Hoper = @hoper,Moper = @moper,NetDuration = @dur " &
                         "WHERE ID = @uid")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' REFRESH THE USERS DATATABLE & FETCH CURRENT RECORD
        GetRecord()
        Me.Text = Me.Text & " - " & "SAVED!"
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click



        ' On Error GoTo SaveErr
        NetLogBindingSource.EndEdit()
        NetLogTableAdapter.Update(NetControlDataSet1.NetLog)

ErrEx:
        Exit Sub
SaveErr:
        MsgBox("Error Number " & Err.Number & vbNewLine &
               "Error Description " & Err.Description, MsgBoxStyle.Critical,
               "Reset Error!")
        ' Resume ErrEx
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl "
        Dim strFileSuffix = ".mdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()
        Dim str As String



        Dim cmd As OleDbCommand = New OleDbCommand(str, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

            MsgBox("The update info was changed")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Hide()

    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click

        NetLogBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click

        NetLogBindingSource.MoveNext()
    End Sub

    Private Sub btnFirstRecord_Click(sender As Object, e As EventArgs) Handles btnFirstRecord.Click
        CurrentRecord = 0
        GetRecord()
    End Sub

    Private Sub btnLastRec_Click(sender As Object, e As EventArgs) Handles btnLastRec.Click
        CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub



    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click


        Me.Close()
        NetControl.Show()

    End Sub

End Class