Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Text
Public Class NetControl
    Public Property StringPass As String

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    If lblTimer.Text = "0:10:0" Then
    '        EndNetSesion()
    '    End If



    '    'Dim obj As New MainMenu
    '    'obj.StringPass = lblCall.Text
    '    'obj.Show()
    '    Me.Hide()


    'End Sub

    Private Sub NetControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DataGridV1.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridV1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        lblCall.Text = StringPass
        FillGrid()
        getState()
        GetCounty()

        Dim currentDate As DateTime = DateTime.UtcNow
        lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy")


    End Sub
    Dim con As New OleDbConnection
    Private Sub FillGrid()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT * FROM NetLog ORDER BY ID DESC", con)


        da.Fill(dt)

        DataGridV1.DataSource = dt.DefaultView

        con.Close()


    End Sub

    Private Sub getState()

        Dim mcall = lblCall.Text
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT State FROM State1", con)

        da.Fill(dt)

        con.Close()


        'CLEar combobox
        'cmbState.Items.Clear()

        'FILL COMBOBOX
        For Each R As DataRow In dt.Rows
            cmbState.Items.Add(R("State"))

        Next

        'DISPLAY FIRST RECORD

        cmbState.Text = CType(dt.Rows(0).Item(0), String)



    End Sub

    Private Sub GetCounty()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        cmbCounty.Items.Clear()
        con.Open()

        da = New OleDbDataAdapter("SELECT County FROM County WHERE State = '" & cmbState.Text & "'", con)


        da.Fill(dt)

        con.Close()

        cmbCounty.Items.Clear()

        For Each R As DataRow In dt.Rows
            cmbCounty.Items.Add(R("County"))
        Next

        'DISPLAY FIRST RECORD

        cmbCounty.Text = CType(dt.Rows(0).Item(0), String)

    End Sub

    Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged

        GetCounty()

    End Sub

    Private Sub GetCountyL()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        con.Open()

        da = New OleDbDataAdapter("SELECT clCounty FROM CountyLine WHERE clState = '" & cmbState.Text & "' And CountyLine = '" & cmbCounty.Text & "'", con)


        da.Fill(dt)

        con.Close()

        cmbHCountyL.Items.Clear()

        For Each R As DataRow In dt.Rows
            cmbHCountyL.Items.Add(R("clCounty"))
        Next


    End Sub

    Private Sub cmbCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCounty.SelectedIndexChanged

        GetCountyL()

    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click

        ' Post()
        'LogContact()

        If CheckBox1.Checked = True Then
            lblTimer.Text = ""
            CheckBox1.Checked = False
        End If

        Dim a As String
        Dim b As String
        Dim split = txtHcall.Text.Split("/"c)
        If (split.Count = 2) Then
            a = split(0).ToString
            b = split(1).ToString

            txtHcall.Text = a
            Post()

            'LogContact()

            txtHcall.Text = b
                Post()
            ' LogContact()



        ElseIf (split.Count = 0) Then


            Post()
            ' LogContact()

        End If
        Post()
        'LogContact()

        'btnAddLog.Visible = True
    End Sub
    Private Sub Post()

        'POST TO NET LOG FOR TIME CREDIT FOR BEING NET CONTROL

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        If txtHcall.Text = "" Then
            Exit Sub
        End If

        str = "Insert into NetLog ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Frequency],[Band],[Mode],[MCall],[HRST],[MRST],[Hoper],[Moper],[NetDuration])
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"


        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(lblDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(lblClock.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtHcall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbHCountyL.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", CType(cmbFreq.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCall", CType(lblCall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(cmbHrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(cmbMrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbHoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NetDuration", CType(lblTimer.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        FillGrid()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        'THIS SET THE TIMER TO 10 MINUTES FOR HELPING WITH RELAYS AND MAKES NET TIMER UNUSABLE AS YOU CANT GET CREDIT FOR BOTH

        If CheckBox1.Checked = True Then
            Timer2.Enabled = False
            lblTimer.Text = "0:10:00"
            lblTimer.Visible = True
        End If

        EndNetSesion()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'THIS MAKES RELAY TIME NOT VISIBLE AND STARTS THE TIMER FOR NET DURATION

        CheckBox1.Visible = False

        starttime = DateTime.Now()
        Timer2.Start()
        Timer2.Enabled = True

        lblTimer.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        'Clock timer.............................................................................................
        Dim currenttime As DateTime = DateTime.UtcNow
        lblClock.Text = DateTime.UtcNow.ToString("HH:mm:ss")

    End Sub
    Dim starttime As DateTime
    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        'THIS IS THE TIMER FOR NET DURATION

        Dim span As TimeSpan = DateTime.Now.Subtract(starttime)
        lblTimer.Text = span.Hours.ToString & ":" & span.Minutes.ToString & ":" & span.Seconds.ToString
        btnEnd.Enabled = True


    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        'STOPS THE TIMER FOR LENGTH OF NET

        If (Timer2.Enabled) Then
            Timer2.Stop()
            lblTimer.Visible = False
        End If

        EndNetSesion()


    End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblList.Click

    '    'THIS MAKES VISIBLE THE LIST BOX IF NEEDED AND HIDES IT IF NOT NEEDED

    '    If txtList.Visible = False Then

    '        txtList.Visible = True

    '    ElseIf txtList.Visible = True Then

    '        txtList.Visible = True

    '    End If


    'End Sub

    Private Sub EndNetSesion()

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        str = "Insert into NetLog ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Frequency],[Band],[Mode],[MCall],[HRST],[MRST],[Hoper],[Moper],[NetDuration])
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"


        'txtHcall.Text = ""
        cmbState.Text = "--------"
        cmbCounty.Text = "----------------"
        cmbHCountyL.Text = "----------------"
        cmbFreq.Text = "----------------"
        cmbMode.Text = "--------"
        cmbBand.Text = "--------"
        'lblCall.Text = ""
        cmbHrst.Text = "----------------"
        cmbMrst.Text = "--------"
        cmbHoper.Text = "----------------"
        cmbMoper.Text = "----------------"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(lblDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(lblClock.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtHcall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbHCountyL.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", CType(cmbFreq.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCall", CType(lblCall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(cmbHrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(cmbMrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbHoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NetDuration", CType(lblTimer.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        FillGrid()

    End Sub

    Private Sub Getfreq()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        con.Open()

        da = New OleDbDataAdapter("SELECT freq FROM themfreq WHERE mode = '" & cmbMode.Text & "'", con)


        da.Fill(dt)

        con.Close()

        'DISPLAY FIRST RECORD

        For Each R As DataRow In dt.Rows
            cmbFreq.Items.Add(R("freq"))
        Next

        cmbFreq.Text = CType(dt.Rows(0).Item(0), String)

    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        cmbFreq.Items.Clear()
        'cmbFreq.Text = ""
        Getfreq()

    End Sub

    'Private Sub btnAddLog_Click(sender As Object, e As EventArgs) Handles btnAddLog.Click

    '    LogContact()

    'End Sub

    'Private Sub LogContact()



    '    Dim myConnection As OleDbConnection = New OleDbConnection

    '    Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
    '    Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
    '    myConnection.ConnectionString = conString
    '    myConnection.Open()
    '    Dim str As String

    '    str = "Insert INTO Log ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MyCall],[HRST],[MRST],[HOper],[MOper])
    '            SELECT [LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MCall],[HRST],[MRST],[Hoper],[Moper]                
    '            FROM NetLog"
    '    'WHERE LDATE = Date"

    '    Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

    '    cmd.ExecuteNonQuery()
    '    cmd.Dispose()

    '    myConnection.Close()

    '    ' ClearTempTbl()

    '    ' MobileLogShow()


    'End Sub

    '

    ' Private Sub btnAddLog_Click(sender As Object, e As EventArgs) Handles btnAddLog.Click

    'dateCompare()


    ' End Sub

    'Private Sub dateCompare()

    '    Dim str1 As String
    '    Dim str2 As String

    '    str1 = DateTime.Now.ToString("MM/dd/yy")
    '    str2 = lDate.Text
    '    If (str1 = str2) Then
    '        LogContact()
    '    Else
    '        MsgBox("didn't work")
    '    End If


    'End Sub
    Public Sub Spotit()


        ''NEXT STATEMENT IS THE POSTING
        Dim commentStr As String
        If cmbHCountyL.Text = "" Then
            commentStr = cmbCounty.Text & "," & cmbState.Text & "+" & TextBox1.Text
        Else
            commentStr = cmbCounty.Text & "," & cmbState.Text & "/" & cmbHCountyL.Text & "," & cmbCntyLState.Text & "+" & TextBox1.Text
        End If

        'WebBrowser1.Document.GetElementById("Add Call").InvokeMember("click")
        Dim request As WebRequest = WebRequest.Create("http://ch.w6rk.com/add.php?add=1")
        ' Set the Method property of the request to POST.  
        request.Method = "POST"
        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "redirect=&user=&code=&call=" & lblCall.Text & "&fq=" &
            cmbFreq.Text & "&DXcall=" & txtHcall.Text & "&comments=" & commentStr & "&submit=Add+spot"

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        ' Set the ContentType property of the WebRequest.  
        request.ContentType = "application/x-www-form-urlencoded"
        ' Set the ContentLength property of the WebRequest.  
        request.ContentLength = byteArray.Length
        ' Get the request stream.  
        Dim dataStream As Stream = request.GetRequestStream()
        ' Write the data to the request stream.  
        dataStream.Write(byteArray, 0, byteArray.Length)
        ' Close the Stream object.  
        dataStream.Close()
        ' Get the response.  
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.  
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.  
        dataStream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.  
        Dim reader As New StreamReader(dataStream)
        ' Read the content.  
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.  
        Console.WriteLine(responseFromServer)
        ' Clean up the streams.  
        reader.Close()
        dataStream.Close()
        response.Close()
    End Sub

    Private Sub btnSpotMobile_Click(sender As Object, e As EventArgs) Handles btnSpotMobile.Click
        Spotit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()

    End Sub

    Public Sub countyLinePost()

        'This splits the calls of a team for logging


        'Dim county As String
        Dim split = txtHcall.Text.Split(CType("/", Char()))
        Dim a As String
        Dim b As String

        If split.Count = 2 Then
            a = split(0).ToString
            b = split(1).ToString

            txtHcall.Text = a
            Post()

            txtHcall.Text = b
            Post()

            'Set ContactCounty.Text to be same as ContactCountyLine.text and post it


            cmbCounty.Text = cmbHCountyL.Text
            cmbHCountyL.Text = ""


            If split.Count = 2 Then
                a = split(0).ToString
                b = split(1).ToString

                txtHcall.Text = a
                Post()

                txtHcall.Text = b
                Post()
                txtHcall.Text = ""
            ElseIf txtHCall.text = "" Then

                End
            End If
            txtHcall.Text = ""
            cmbCounty.Text = ""
            cmbHCountyL.Text = ""
        End If
    End Sub

End Class