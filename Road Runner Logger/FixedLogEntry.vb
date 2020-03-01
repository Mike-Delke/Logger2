﻿
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.AxHost

Public Class FixedLogEntry
    Public Property StringPass As String
    Public _screenUtilities As New clsScreenUtilities
    Private _commonData As clsCommonData = clsCommonData.GetInstance("CommonData")


    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Removes the logging page from the screen

        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Clock timer.....................................for the text box used for logging when running clock is checked
        Dim currenttime As DateTime = DateTime.UtcNow
        lblTime.Text = DateTime.UtcNow.ToString("HH:mm:ss")

    End Sub

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        'Clock timer................for the large clock in upper right corner
        Dim Now As DateTime = DateTime.Now.ToUniversalTime()
        txtTime.Text = Now.ToString("HH") & Now.ToString("mm")

    End Sub

    Dim con As New OleDbConnection
    Private Sub FixedLogEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This line supresses a script error generated by the web page used for spotting has nothing to do with programs code
        WebBrowser1.ScriptErrorsSuppressed = True

        'THIS IS THE DATE IN TOP CENTER RIGHT CORNER
        Dim currentDate As DateTime = DateTime.UtcNow
        txtDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy")

        'Set's the users call
        lblCall.Text = StringPass

        'This sets the datagrid to alternating colors
        dataGridView.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        'btnPost.Visible = False
        btnPost.Visible = True
        'gbxMobile.Visible = False
        txtTime.Visible = False
        ' lblFormat.Visible = False
        lblTime2.Visible = True
        LblDate2.Visible = False
        ' lblDFormat.Visible = False
        txtDate.Visible = False

        'SETS THE COMBO BOX TO FIRST VALUE IN LIST...................................................
        cmbMode.Text = (cmbMode.Items(0)).ToString
        cmbBand.Text = (cmbBand.Items(0)).ToString

        ' HomeCounty()

        WebBrowser1.Navigate("http://ch.w6rk.com/")

        'DataGridViewMem.Visible = True
        GetState()
        GetHState()

    End Sub

    Private Sub datagridshow()

        ' This sets datagrid1 to the table and shows it for Logging Fixed Contacts
        ' Dim mcall = lblCall.Text
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "County Hunter - "
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString
        dataGridView.DataSource = dt.DefaultView
        con.Open()

        da = New OleDbDataAdapter("SELECT * FROM Log  ORDER BY ID DESC", con)

        da.Fill(dt)



        con.Close()

    End Sub

    Private Sub cmbMyOperation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyOperation.SelectedIndexChanged

        'Sets the screen to the type of logging doing with appropriate datagrid
        'Set starting text for contacts operation
        If cmbMyOperation.Text = "Home" And chkRunningClock.Checked = True Then
            cmbContactOperation.Text = "Mobile"
            datagridshow()
            ' btnPost.Visible = False
            btnPost.Visible = True
            ' Button1.Visible = False
            lblTime.Visible = True
            txtTime.Visible = False
            'lblFormat.Visible = False
            'lblTime2.Visible = False
            LblDate2.Visible = True
            ' lblDFormat.Visible = False
            txtDate.Visible = True
            btnSpot.Visible = True
            chkRunningClock.Visible = True
            txtTime.Visible = True
            lblTime2.Visible = True
        Else
            If cmbMyOperation.Text = "Home" And chkRunningClock.Checked = False Then
                cmbContactOperation.Text = "Mobile"
                datagridshow()
                btnPost.Visible = False
                ' btnPost.Visible = True
                'Button1.Visible = False
                lblTime.Visible = False
                txtTime.Visible = True
                'lblFormat.Visible = True
                lblTime2.Visible = True
                LblDate2.Visible = True
                ' lblDFormat.Visible = True
                txtDate.Visible = True
                btnSpot.Visible = False
                chkRunningClock.Visible = True
                txtTime.Visible = True
                lblTime2.Visible = True
            Else
                If cmbMyOperation.Text = "Mobile" Then
                    cmbContactOperation.Text = "Home"
                    datagridshow()
                    'MobileLogShow()
                    'Button1.Visible = False
                    ' btnLogIt.Visible = False
                    btnPost.Visible = True
                    lblTime.Visible = False
                    txtTime.Visible = True
                    'lblFormat.Visible = True
                    lblTime2.Visible = True
                    LblDate2.Visible = True
                    'lblDFormat.Visible = True
                    txtDate.Visible = True
                    btnSpot.Visible = False
                    chkRunningClock.Visible = True
                    txtTime.Visible = True
                    lblTime2.Visible = True
                Else
                    If cmbMyOperation.Text = "Portable" Then
                        cmbContactOperation.Text = "Mobile"
                        datagridshow()
                        btnPost.Visible = True
                        ' btnLogIt.Visible = True
                        ' Button1.Visible = False
                        lblTime.Visible = True
                        txtTime.Visible = False
                        'lblFormat.Visible = False
                        lblTime2.Visible = False
                        LblDate2.Visible = True
                        'lblDFormat.Visible = False
                        txtDate.Visible = False
                        btnSpot.Visible = True
                        txtTime.Visible = True
                        lblTime2.Visible = True
                        txtDate.Visible = True
                    Else
                        If cmbMyOperation.Text = "Remote" Then
                            cmbContactOperation.Text = "Mobile"
                            datagridshow()
                            btnPost.Visible = True
                            ' btnLogIt.Visible = True
                            ' Button1.Visible = False
                            lblTime.Visible = True
                            txtTime.Visible = False
                            'lblFormat.Visible = False
                            lblTime2.Visible = False
                            LblDate2.Visible = True
                            'lblDFormat.Visible = False
                            txtDate.Visible = False
                            btnSpot.Visible = True
                            txtTime.Visible = True
                            lblTime2.Visible = True
                            txtDate.Visible = True
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txtTime_Click(sender As Object, e As EventArgs) Handles txtTime.Click

        'Sets the screen to an entry box for the time for entering a mobile run
        txtTime.Focus()

    End Sub

    Public Sub GetState()        'This gets the State list to show in combobox MyState


        cmbMyState.Items.Clear()

        Dim stateList As DataTable = _commonData.GetStateList
        For Each row As DataRow In stateList.Rows
            Dim state As String = CStr(row("State ID"))
            ' Add state to DropDown
            cmbMyState.Items.Add(state)
        Next

    End Sub

    Public Sub GetHState()     ' fills the combo box with contacts list of states

        cmbContactState.Items.Clear()

        Dim stateList As DataTable = _commonData.GetStateList
        For Each row As DataRow In stateList.Rows
            Dim state As String = CStr(row("State ID"))
            ' Add state to DropDown
            cmbContactState.Items.Add(state)
        Next

    End Sub

    Private Sub GetMCounty()       ' Gets the list of counties to put into combobox MyCounty

        cmbMyCounty.Items.Clear()

        Dim countyList As DataTable = _commonData.GetCountyList("county")
        For Each row As DataRow In countyList.Rows
            Dim county As String = CStr(row("countyId"))
            Dim countyId As Integer = CInt(row("countyId"))
            ' Add county to DropDown
            cmbMyCounty.Items.Add(county)
        Next

    End Sub


    Private Sub cmbMyState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyState.SelectedIndexChanged

        ' GetMCounty()
        'Fill this county combo box with available counties
        _screenUtilities.LoadCountiesComboBox(cmbMyCounty, cmbMyState.Text)
        'Clear the county line comboBox
        cmbMyCountyLine.DataSource = Nothing
        cmbMyCountyLine.Items.Clear()
        Me.Refresh()



    End Sub

    Private Sub cmbContactState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactState.SelectedIndexChanged

        ' GetHCounty()
        'Fill contact county box with available counties
        If cmbContactState.Text = "" Then
            cmbContactCounty.DataSource = Nothing
            cmbContactCounty.Items.Clear()
        Else
            _screenUtilities.LoadCountiesComboBox(cmbContactCounty, cmbContactState.Text)
        End If
        'Clear the county line comboBox
        cmbContactCountyLine.DataSource = Nothing
        cmbContactCountyLine.Items.Clear()
        Me.Refresh()


    End Sub

    Private Sub cmbMCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyCounty.SelectedIndexChanged

        'GetMCLCounty()

        'Fill this county combo box with available counties
        Try
            Dim countyId As Integer = _screenUtilities.GetComboIdReturn(cmbMyCounty)
            If countyId > 0 Then
                _screenUtilities.LoadCountyLinesComboBox(cmbMyCountyLine, countyId)
            Else
                'Clear the county line combo box
                cmbMyCountyLine.DataSource = Nothing
                cmbMyCountyLine.Items.Clear()
            End If
            Me.Refresh()
        Catch
        End Try


    End Sub

    Private Sub cmbContactCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactCounty.SelectedIndexChanged

        ' GetContactCountyLine()

        ' Fill contact county line box with available countiy lines
        Try
            Dim countyId As Integer = _screenUtilities.GetComboIdReturn(cmbContactCounty)
            If countyId > 0 Then
                _screenUtilities.LoadCountyLinesComboBox(cmbContactCountyLine, countyId)
            Else
                'Clear the county line combo box
                cmbContactCountyLine.DataSource = Nothing
                cmbContactCountyLine.Items.Clear()
            End If
            Me.Refresh()
        Catch
        End Try


    End Sub

    Private Sub PostLog()              ' this is the sub that does the actual posting to the log

        Dim myConnection As OleDbConnection = New OleDbConnection

        Dim databaseFile As String = "C:\RRLogger Data\NetControl.accdb"
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile
        myConnection.ConnectionString = conString
        myConnection.Open()
        Dim str As String

        If txtcontactCall.Text = "" Then
            Exit Sub
        End If



        str = "Insert into Log ([LDate],[LTime],[HCall],[State],[County],[CountyLine],[Freq],[Band],[Mode],[MyCall],[HRST],[MRST],[Hoper],[Moper],[MState],[MCounty],[MCntyLine])    
                 Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("Date", CType(txtDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(txtTime.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCall", CType(txtcontactCall.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HState", CType(cmbContactState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCounty", CType(cmbContactCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HCLine", CType(cmbContactCountyLine.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Freq", cmbFrequency.Text))
        cmd.Parameters.Add(New OleDbParameter("Band", CType(cmbBand.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mode", CType(cmbMode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MyCall", lblCall.Text))
        cmd.Parameters.Add(New OleDbParameter("HRST", CType(txtHisrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MRST", CType(txtMyrst.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("HOper", CType(cmbContactOperation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Moper", CType(cmbMyOperation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MState", CType(cmbMyState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCounty", CType(cmbMyCounty.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MCLine", CType(cmbMyCountyLine.Text, String)))

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
        datagridshow()

    End Sub

    Private Sub txtDate_Click(sender As Object, e As EventArgs) Handles txtDate.Click

        DateTimePicker1.Visible = True

    End Sub

    Private Sub txtTime_LostFocus(sender As Object, e As EventArgs) Handles txtTime.LostFocus

        Dim a As Double
        a = CDbl(txtTime.Text)
        txtTime.Text = a.ToString("##:##")

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        txtDate.Text = DateTimePicker1.Value.ToShortDateString()

        DateTimePicker1.Visible = False

    End Sub

    Private Sub txtTime_GotFocus(sender As Object, e As EventArgs) Handles txtTime.GotFocus

        DateTimePicker1.Visible = True

    End Sub

    Public Sub HomeCounty()

        'Dim mcall = lblCall.Text
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        '------------ FROM HERE THE NEXT LINES SET UP THE CONNECTION STRING FOR USER'S DATABASE------------------

        Dim strFilePrefix = "County Hunters - Common"
        Dim strFileSuffix = ".accdb"
        Dim databaseFile As String = "C:\RRLogger Data\" & strFilePrefix & strFileSuffix
        Dim conString = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source= " & databaseFile

        '--------------------------------------------------------------------------------------------------------------
        con.ConnectionString = conString

        con.Open()

        da = New OleDbDataAdapter("SELECT [Home County] FROM [County Hunters] Where Current Call = lblCall.text", con)
        'ds.ToString()
        cmbMyCounty.Text = ds.ToString()

        con.Close()


    End Sub

    Private Sub btnSpot_Click(sender As Object, e As EventArgs) Handles btnSpot.Click

        Spot()

    End Sub

    Private Sub Spot()

        ''NEXT STATEMENT IS THE POSTING
        Dim commentStr As String
        If cmbMyCountyLine.Text = "" Then
            commentStr = cmbContactCounty.Text & "+" & cmbContactState.Text
        Else
            commentStr = cmbContactCounty.Text & "+" & cmbContactState.Text & "+" & cmbContactCountyLine.Text
        End If

        'WebBrowser1.Document.GetElementById("Add Call").InvokeMember("click")
        Dim request As WebRequest = WebRequest.Create("http://ch.w6rk.com/add.php?add=1")
        ' Set the Method property of the request to POST.  
        request.Method = "POST"
        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "redirect=&user=&code=&call=" & lblCall.Text & "&fq=" &
            cmbFrequency.Text & "&DXcall=" & txtcontactCall.Text & "&comments=" & commentStr & "&submit=Add+spot"

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
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the program

        Me.Close()

    End Sub

    Private Sub btnPost_Click_1(sender As Object, e As EventArgs) Handles btnPost.Click

        'this checks to see if both combo boxs have entries if they do then sets up county Line post

        If cmbContactCounty.Text IsNot Nothing And
            cmbContactCountyLine.Text IsNot Nothing Then

            countyLinePost()

        End If


        'Post info on screen to the log
        'This splits the calls of a team for logging

        Dim a As String
        Dim b As String

        Dim split = txtcontactCall.Text.Split(CType("/", Char()))
        If split.Count = 2 Then
            a = split(0).ToString
            b = split(1).ToString

            txtcontactCall.Text = a
            PostLog()

            txtcontactCall.Text = b
            PostLog()

            'txtcontactCall.Text = ""
            'txtHisrst.Text = ""
            'txtMyrst.Text = ""

        ElseIf split.Count = 1 Then

            PostLog()
            '  txtcontactCall.Text = ""
        End If
        txtcontactCall.Text = ""
        ' PostLog()

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        'Turns on and off the buttons used when editing

        ButtonClear.Visible = True
        ButtonEditNext.Visible = True
        ButtonEditPrevious.Visible = True
        ButtonSaveEdit.Visible = True
    End Sub

    Private Sub SetFrequency()
        Select Case cmbMode.Text
            Case "SSB"
                Select Case cmbBand.Text
                    Case "160"
                        cmbFrequency.Text = "1.950"
                    Case "80"
                        cmbFrequency.Text = "3.901"
                    Case "40"
                        cmbFrequency.Text = "7.188"
                    Case "30"
                        'cmbMode.Text = "CW"
                        cmbFrequency.Text = "10.1245"
                    Case "20"
                        cmbFrequency.Text = "14.336"
                    Case "17"
                        cmbFrequency.Text = "18.136"
                    Case "12"
                        cmbFrequency.Text = "24.950"
                    Case "10"
                        cmbFrequency.Text = "28.336"
                    Case "6"
                        cmbFrequency.Text = "52.525"
                End Select
            Case "CW"
                Select Case cmbBand.Text
                    Case "80"
                        cmbFrequency.Text = "3.0565"
                    Case "40"
                        cmbFrequency.Text = "7.0565"
                    Case "30"
                        cmbFrequency.Text = "10.1245"
                    Case "20"
                        cmbFrequency.Text = "14.0565"
                    Case "17"
                        cmbFrequency.Text = "18.0915"
                    Case "15"
                        cmbFrequency.Text = "21.0565"
                    Case "12"
                        cmbFrequency.Text = "24.9155"
                    Case "10"
                        cmbFrequency.Text = "28.0565"
                End Select
            Case "PSK"
                Select Case cmbBand.Text
                    Case "40"
                        cmbFrequency.Text = "7.071"
                    Case "30"
                        cmbFrequency.Text = "10.139"
                    Case "20"
                        cmbFrequency.Text = "14.071"
                End Select
        End Select
    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged

        SetFrequency()    'sets the frequency when mode is changed

    End Sub

    Private Sub cmbBand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBand.SelectedIndexChanged

        SetFrequency()    'sets the frequency when Band is changed

    End Sub

    Public Sub countyLinePost()

        'This splits the calls of a team for logging


        'Dim county As String
        Dim split = txtcontactCall.Text.Split(CType("/", Char()))
        Dim a As String
        Dim b As String

        If split.Count = 2 Then
            a = split(0).ToString
            b = split(1).ToString

            txtcontactCall.Text = a
            PostLog()

            txtcontactCall.Text = b
            PostLog()

            'Set ContactCounty.Text to be same as ContactCountyLine.text and post it


            cmbContactCounty.Text = cmbContactCountyLine.Text
            cmbContactCountyLine.Text = ""


            If split.Count = 2 Then
                a = split(0).ToString
                b = split(1).ToString

                txtcontactCall.Text = a
                PostLog()

                txtcontactCall.Text = b
                PostLog()
                txtcontactCall.Text = ""
            ElseIf txtcontactCall.text = "" Then

                End
            End If
            txtcontactCall.Text = ""
            cmbContactCounty.Text = ""
            cmbContactCountyLine.Text = ""
        End If
    End Sub


End Class