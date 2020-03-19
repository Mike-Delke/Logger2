Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Math
Public Class NetControl
    Public Property StringPass As String
    Public _screenUtilities As New clsScreenUtilities
    Private _commonData As clsCommonData = clsCommonData.GetInstance("CommonData")
    Private Sub NetControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCall.Text = StringPass

        DataGridV1.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridV1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        Dim currentDate As DateTime = DateTime.UtcNow
        lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy")

        getState()
        GetCounty()
        FillGrid()


    End Sub
    Dim con As New OleDbConnection
    Private Sub FillGrid()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "NetControl"
        Dim strFileSuffix = ".mdb"
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

        cmbContactState.Items.Clear()

        Dim stateList As DataTable = _commonData.GetStateList
        For Each row As DataRow In stateList.Rows
            Dim state As String = CStr(row("State ID"))
            ' Add state to DropDown
            cmbContactState.Items.Add(state)
        Next

    End Sub

    Private Sub GetCounty()


        'Fill contact county box with available counties
        If cmbContactState.Text = "" Then
            cmbContactCounty.DataSource = Nothing
            cmbContactCounty.Items.Clear()
        Else
            _screenUtilities.LoadCountiesComboBox(cmbContactCounty, cmbContactState.Text)
        End If
        'Clear the county line comboBox
        cmbContactCountyL.DataSource = Nothing
        cmbContactCountyL.Items.Clear()
        Me.Refresh()

    End Sub

    Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactState.SelectedIndexChanged

        GetCounty()

    End Sub

    Private Sub GetCountyL()

        'Fill contact county line box with available countiy lines
        Try
            Dim countyId As Integer = _screenUtilities.GetComboIdReturn(cmbContactCounty)
            If countyId > 0 Then
                _screenUtilities.LoadCountyLinesComboBox(cmbContactCountyL, countyId)
            Else
                'Clear the county line combo box
                cmbContactCountyL.DataSource = Nothing
                cmbContactCountyL.Items.Clear()
            End If
            Me.Refresh()
        Catch
        End Try

    End Sub

    Private Sub cmbCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactCounty.SelectedIndexChanged

        GetCountyL()

    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs)

        If cmbContactCounty.Text IsNot Nothing And
            cmbContactCountyL.Text IsNot Nothing Then

            countyLinePost()

        End If

        Dim a As String
        Dim b As String
        Dim split = txtContactcall.Text.Split("/"c)
        If (split.Count = 2) Then
            a = split(0).ToString
            b = split(1).ToString

            txtContactcall.Text = a
            Post()



            txtContactcall.Text = b
            Post()




        ElseIf (split.Count = 0) Then


            Post()


        End If
        Post()

    End Sub
    Private Sub Post()

        'POST TO NET LOG FOR TIME CREDIT FOR BEING NET CONTROL

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.mdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        If txtContactcall.Text = "" Then
            Exit Sub
        End If

        str = "Insert into NetLog ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Frequency],[Band],[Mode],[MCall],[HRST],[MRST],[Hoper],[Moper],[NetDuration])
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"


        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(lblDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(lblClock.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtContactcall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbContactState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbContactCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbContactCountyL.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", CType(cmbFreq.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCall", CType(lblCall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(cmbContactrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(cmbMyrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbContactoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMyoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NetDuration", CType(lblTimer.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        MsgBox("Your Contact has been saved to the NET LOG")       ' THIS JUST LETS YOU KNOW THAT THE ACTION WAS COMPLETED

        FillGrid()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'THIS MAKES RELAY TIME NOT VISIBLE AND STARTS THE TIMER FOR NET DURATION

        Timer2.Start()
        Timer2.Enabled = True
        tbStartNet.Text = DateTime.UtcNow.ToString("HH:mm:ss")

        'lblTimer.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'THIS STARTS THE CLOCK  THAT SHOWS IN UPPER RIGHT HAND CORNER.............................................................................................

        Dim currenttime As DateTime = DateTime.UtcNow
        lblClock.Text = DateTime.UtcNow.ToString("HH:mm:ss")

    End Sub
    Dim starttime As DateTime
    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        'THIS IS THE TIMER FOR NET DURATION

        Dim span As TimeSpan = DateTime.Now.Subtract(starttime)
        'lblTimer.Text = span.Hours.ToString & ":" & span.Minutes.ToString & ":" & span.Seconds.ToString
        btnEnd.Enabled = True

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        'SETS THE END TIME FOR NET DURATION SO CALCULATION CAN BE PREFORMED 

        tbEndNet.Text = DateTime.UtcNow.ToString("HH:mm:ss")

        NetDuration()

    End Sub

    Private Sub EndNetSesion()

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.mdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        str = "Insert into NetLog ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Frequency],[Band],[Mode],[MCall],[HRST],[MRST],[Hoper],[Moper],[NetDuration])
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"


        'txtHcall.Text = ""
        cmbContactState.Text = "--------"
        cmbContactCounty.Text = "----------------"
        cmbContactCountyL.Text = "----------------"
        cmbFreq.Text = "----------------"
        cmbMode.Text = "--------"
        cmbBand.Text = "--------"
        'lblCall.Text = ""
        cmbContactrst.Text = "----------------"
        cmbMyrst.Text = "--------"
        cmbContactoper.Text = "----------------"
        cmbMyoper.Text = "----------------"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(lblDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(lblClock.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtContactcall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbContactState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbContactCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbContactCountyL.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", CType(cmbFreq.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCall", CType(lblCall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(cmbContactrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(cmbMyrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbContactoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMyoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NetDuration", lblNetLength.Text))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        MsgBox("Info has been saved to the LOG")

        FillGrid()

    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        cmbFreq.Items.Clear()
        SetFrequency()

    End Sub

    Public Sub Spotit()


        'NEXT STATEMENT IS THE POSTING
        Dim commentStr As String
        If cmbContactCountyL.Text = "" Then
            commentStr = cmbContactCounty.Text & "," & cmbContactState.Text & "+" & TextBox1.Text
        Else
            commentStr = cmbContactCounty.Text & "," & cmbContactState.Text & "/" & cmbContactCountyL.Text
        End If

        'WebBrowser1.Document.GetElementById("Add Call").InvokeMember("click")
        Dim request As WebRequest = WebRequest.Create("http://ch.w6rk.com/add.php?add=1")
        ' Set the Method property of the request to POST.  
        request.Method = "POST"
        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "redirect=&user=&code=&call=" & lblCall.Text & "&fq=" &
            cmbFreq.Text & "&DXcall=" & txtContactcall.Text & "&comments=" & commentStr & "&submit=Add+spot"

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

        MsgBox(" The MOBILE has been Spoted on W6RK ")

    End Sub

    Private Sub btnSpotMobile_Click(sender As Object, e As EventArgs) Handles btnSpotMobile.Click
        Spotit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Public Sub countyLinePost()
        'This splits the calls of a team for logging


        'Dim county As String
        Dim split = txtContactcall.Text.Split(CType("/", Char()))
        Dim a As String
        Dim b As String

        If split.Count = 2 Then
            a = split(0).ToString
            b = split(1).ToString

            txtContactcall.Text = a
            Post()

            txtContactcall.Text = b
            Post()

            'Set ContactCounty.Text to be same as ContactCountyLine.text and post it


            cmbContactCounty.Text = cmbContactCountyL.Text
            cmbContactCountyL.Text = ""


            If split.Count = 2 Then
                a = split(0).ToString
                b = split(1).ToString

                txtContactcall.Text = a
                Post()

                txtContactcall.Text = b
                Post()
                txtContactcall.Text = ""
            ElseIf txtContactcall.Text = "" Then

                End
            End If
            txtContactcall.Text = ""
            cmbContactCounty.Text = ""

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Me.Close()

        EditNetFrm.Show()

    End Sub

    Private Sub btnAddLog_Click(sender As Object, e As EventArgs) Handles btnPost.Click

        Post()
        'PostLog()

    End Sub

    Private Sub SetFrequency()
        Select Case cmbMode.Text
            Case "SSB"
                Select Case cmbBand.Text
                    Case "160"
                        cmbFreq.Text = "1.950"
                    Case "80"
                        cmbFreq.Text = "3.901"
                    Case "40"
                        cmbFreq.Text = "7.188"
                    Case "30"
                        'cmbMode.Text = "CW"
                        cmbFreq.Text = "10.1245"
                    Case "20"
                        cmbFreq.Text = "14.336"
                    Case "17"
                        cmbFreq.Text = "18.136"
                    Case "12"
                        cmbFreq.Text = "24.950"
                    Case "10"
                        cmbFreq.Text = "28.336"
                    Case "6"
                        cmbFreq.Text = "52.525"
                End Select
            Case "CW"
                Select Case cmbBand.Text
                    Case "80"
                        cmbFreq.Text = "3.0565"
                    Case "40"
                        cmbFreq.Text = "7.0565"
                    Case "30"
                        cmbFreq.Text = "10.1245"
                    Case "20"
                        cmbFreq.Text = "14.0565"
                    Case "17"
                        cmbFreq.Text = "18.0915"
                    Case "15"
                        cmbFreq.Text = "21.0565"
                    Case "12"
                        cmbFreq.Text = "24.9155"
                    Case "10"
                        cmbFreq.Text = "28.0565"
                End Select
            Case "Digital"
                Select Case cmbBand.Text
                    Case "40"
                        cmbFreq.Text = "7.071"
                    Case "30"
                        cmbFreq.Text = "10.139"
                    Case "20"
                        cmbFreq.Text = "14.071"
                End Select
        End Select
    End Sub

    Private Sub cmbBand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBand.SelectedIndexChanged
        SetFrequency()
    End Sub

    Private Sub cmbContactrst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactrst.SelectedIndexChanged

    End Sub

    Private Sub lblHelpRelay_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim index As Integer
        index = DataGridV1.CurrentCell.RowIndex
        DataGridV1.Rows.RemoveAt(index)


    End Sub

    Private Sub btnRelayHelp_Click(sender As Object, e As EventArgs) Handles btnRelayHelp.Click

        'SETS LBLTIMER TO 10 MINUTES FOR CREDIT TOWARDS MASTER GOLD FOR HELPING WITH RELAYS FOR MOBILE

        'lblTimer.Visible = True
        lblTimer.Text = "00:10:00"
        lblNetLength.Text = lblTimer.Text
        EndNetSesion()

    End Sub

    Private Sub NetDuration()

        'DOES THE CALCULATION TO GET ELAPSED TIME FOR NET DURATION THEN MAKES ENTRY IN LOG FOR END OF NET

        Dim startTime As New TimeSpan()
        Dim endTime As New TimeSpan()
        Dim NetLength As New TimeSpan()


        TimeSpan.TryParse(tbStartNet.Text, startTime)
        TimeSpan.TryParse(tbEndNet.Text, endTime)

        lblNetLength.Text = (endTime - startTime).ToString()

        EndNetSesion()

    End Sub

    Private Sub PostLog()              ' this is the sub that does the actual posting to the log

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.MDB"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        str = "Insert into Log ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MyCall],[HRST],[MRST],[Hoper],[Moper],[MState],[MCounty],[MCntyLine])    
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(lblDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(lblClock.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtContactcall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbContactState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbContactCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbContactCountyL.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", cmbFreq.Text))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MyCall", lblCall.Text))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(cmbContactrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(cmbMyrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbContactoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMyoper.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MState", CType(txtMyState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCounty", CType(txtMyCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCLine", CType(txtMyCountyLine.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            'txtTime.Clear()
            'txtcontactCall.Clear()
            'txtHisrst.Clear()
            'txtMyrst.Clear()  


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        myConnection.Close()
        ' datagridshow()

    End Sub

End Class