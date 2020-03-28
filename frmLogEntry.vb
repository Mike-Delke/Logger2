Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Text

Public Class frmLogEntry
    Public Property StringPass As String

    Public _logEntryType As ScreenType = ScreenType.None
    Public _locationLeftEdge As Integer = 0

    Private _mainMenu As MainMenu
    Private _backColor As Color
    Private _informedMainMenuClosing As Boolean = False

    Private _primaryCallData As CallData
    Private _secondaryCallData As CallData
    Private _contactCallData1 As CallData
    Private _contactCallData2 As CallData

    Private _holdContactData As HoldContactData

    Private _primaryLog As clsLog = clsPrimaryLog.GetInstance("PrimaryLog")
    Private _secondaryLog As clsLog = clsSecondaryLog.GetInstance("SecondaryLog")
    Private _commonData As clsCommonData = clsCommonData.GetInstance("CommonData")
    Private _netControl As clsNetControl = clsNetControl.GetInstance("NetControl")

    Private Sub frmLogEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True    ' This allowing the form to break on a key push anywhere on form

        _mainMenu = DirectCast(Me.MdiParent, MainMenu)
        Me.Left = _locationLeftEdge
        Me.Top = 0

        Me.dataGridView.DefaultCellStyle.Font = New Font("Tahoma", 7)
        'Me.dataGridView.ColumnHeaderDefaultCellStyle = New Font("Tahoma", 7)

        Select Case _logEntryType
            Case ScreenType.None
                Dim errorMsg = "No Screen Type is defined in frmLogEntry_Load. This is likely a programming error associated " &
                               " with the frmLogEntry initiation. Application will end"
                MsgBox(errorMsg, vbCritical)
                Application.Exit()
            Case ScreenType.Fixed
                SetupFixedLogEntry()
            Case ScreenType.Mobile
                SetupContactLogEntry()
        End Select

        _primaryCallData = _commonData.GetCallData(_mainMenu._strPrimaryCall)
        GroupBoxMyParameters.Text = "Station Data: " & _primaryCallData.currentCall
        ControlTeamData()

        Dim Now As DateTime = DateTime.Now.ToUniversalTime()
        txtTime.Text = Now.ToString("HH") & Now.ToString("mm")

        InitializeCmbContactOperation()

        LoadtStateData()
        cmbMyState.Text = _primaryCallData.state
        cmbMyCounty.Text = _primaryCallData.homeCounty

        InitializeBlankContact()

        'This sets the datagrid to alternating colors
        'dataGrid1.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        'dataGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        'SETS THE COMBO BOX TO FIRST VALUE IN LIST...................................................
        cmbMode.Text = (cmbMode.Items(0)).ToString
        cmbBand.Text = (cmbBand.Items(0)).ToString

        ' Set special contact locatio data
        lblContactHomeCounty.Top = lblContactCounty.Top
        txtContactHomeCounty.Top = cmbContactCounty.Top

        'WebBrowser1.Navigate("http://ch.w6rk.com/")

    End Sub

    Private Sub InitializeBlankContact()
        txtContactCall.Text = ""
        cmbContactState.Text = ""
        cmbContactCounty.Text = ""
        cmbContactCountyLine.Text = ""
        If _logEntryType = ScreenType.Fixed Then
            cmbContactOperation.Text = "Mobile"
        Else
            cmbContactOperation.Text = "Fixed"
        End If
        txtContactNames.Text = ""
        txtContactInfo.Text = ""
        txtContactHomeCounty.Text = ""
        txtContactHomeCounty.Tag = 0
    End Sub

    Private Sub ControlTeamData()
        If _mainMenu._blnTeam Then
            _secondaryCallData = _commonData.GetCallData(_mainMenu._strSecondaryCall)
            Me.Text = "Log Entry Form for the Team Of " & _primaryCallData.currentCall & " and " & _secondaryCallData.currentCall

            GroupBoxTeamMembers.Visible = True
            ckbPrimaryTeamMember.Text = _primaryCallData.currentCall
            chkSecondaryTeamMember.Text = _secondaryCallData.currentCall
        Else
            Me.Text = "Log Entry Form for " & _primaryCallData.currentCall

            GroupBoxTeamMembers.Visible = False
        End If
    End Sub

    Private Sub InitializeCmbContactOperation()
        Dim choise As New ArrayList()
        choise.Add(New taggedClass("Unknown", "U"))
        choise.Add(New taggedClass("Home", "F"))
        choise.Add(New taggedClass("Mobile", "M"))
        choise.Add(New taggedClass("Portable", "P"))
        'choise.Add(New taggedClass("Remote", "R"))

        cmbContactOperation.DataSource = choise
        cmbContactOperation.DisplayMember = "Description"
        cmbContactOperation.ValueMember = "Value"
    End Sub

    Private Sub SetupFixedLogEntry()
        Me.BackColor = Color.LightBlue

        ' Set initial time
        Dim currentTime As DateTime = DateTime.UtcNow
        txtTime.Text = DateTime.UtcNow.ToString("hhmm")

        Dim currentDate As DateTime = DateTime.UtcNow
        txtDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy")

        Dim myOperationList As New ArrayList()

        ' Inuitialize My Operation control
        myOperationList.Add(New taggedClass("Home", "F"))
        myOperationList.Add(New taggedClass("Portable", "P"))
        myOperationList.Add(New taggedClass("Remote", "R"))

        cmbMyOperation.DataSource = myOperationList
        cmbMyOperation.DisplayMember = "Description"
        cmbMyOperation.ValueMember = "Value"

        cmbMyOperation.Text = "Fixed"
        ControlMyOperation()

        Dim contactOperationList As New ArrayList()

        ' Initialize Contact Operation control
        contactOperationList.Add(New taggedClass("Home", "F"))
        contactOperationList.Add(New taggedClass("Unknown", "U"))
        contactOperationList.Add(New taggedClass("Mobile", "M"))
        contactOperationList.Add(New taggedClass("Portable", "P"))
        contactOperationList.Add(New taggedClass("Remote", "R"))

        cmbContactOperation.DataSource = contactOperationList
        cmbContactOperation.DisplayMember = "Description"
        cmbContactOperation.ValueMember = "Value"

        cmbContactOperation.Text = "Mobile"
        ControlContactOperation()

    End Sub

    Private Sub SetupContactLogEntry()
        Me.BackColor = Color.PaleGreen

        chkRunningClock.Visible = False
        chkRunningClock.Checked = False
        TimerClock.Enabled = False
        txtTime.Text = ""
        txtDate.Text = ""

        ' Initial My Operation control
        Dim choise As New ArrayList()

        choise.Add(New taggedClass("Mobile", "M"))
        'choise.Add(New taggedClass("Unknown", "U"))
        'choise.Add(New taggedClass("Fixed", "F"))
        'choise.Add(New taggedClass("Portable", "P"))
        'choise.Add(New taggedClass("Remote", "R"))

        cmbMyOperation.DataSource = choise
        cmbMyOperation.DisplayMember = "Description"
        cmbMyOperation.ValueMember = "Value"

        cmbMyOperation.Text = "Mobile"
        ControlMyOperation()

        Dim contactOperationList As New ArrayList()

        ' Initialize Contact Operation control
        contactOperationList.Add(New taggedClass("Home", "F"))
        contactOperationList.Add(New taggedClass("Mobile", "M"))
        contactOperationList.Add(New taggedClass("Unknown", "U"))
        contactOperationList.Add(New taggedClass("Portable", "P"))
        contactOperationList.Add(New taggedClass("Remote", "R"))

        cmbContactOperation.DataSource = contactOperationList
        cmbContactOperation.DisplayMember = "Description"
        cmbContactOperation.ValueMember = "Value"

        'cmbContactOperation.Text = "Homee"
        ControlContactOperation()
    End Sub

    Private Sub LoadtStateData()

        ' Place a blank line at top of cmbContactState
        cmbContactState.Items.Add("")

        ' Add alist of states to the StateCombo Boxes
        Dim stateList As DataTable = _commonData.GetStateList
        For Each row As DataRow In stateList.Rows
            Dim state As String = CStr(row("State ID"))
            ' Add state to MyState
            cmbMyState.Items.Add(state)
            cmbContactState.Items.Add(state)
        Next


    End Sub

    Private Sub txtTime_Click(sender As Object, e As EventArgs)

        'Sets the screen to an entry box for the time for entering a mobile run
        'txtTime.Focus()

    End Sub

    Public Sub LoadStateComboBox(cmb As ComboBox, blnAddEmptyLine As Boolean)

        'Clear state combobox
        cmb.Items.Clear()

        ' Add blank line if requested
        If blnAddEmptyLine Then
            cmb.Items.Add("")
        End If

        'Fill all state comboBoxes
        Dim dataTable As DataTable = _commonData.GetStateList()
        For Each row As DataRow In dataTable.Rows
            cmb.Items.Add(row("State ID"))
        Next
    End Sub

    Private Sub txtDate_Click(sender As Object, e As EventArgs)

        'DateTimePicker1.Visible = True

    End Sub

    Private Sub txtTime_LostFocus(sender As Object, e As EventArgs)

        'Dim a As Double
        ''a = CDbl(txtTime.Text)
        ''txtTime.Text = a.ToString("##:##")

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

        'txtDate.Text = DateTimePicker1.Value.ToShortDateString()

        'DateTimePicker1.Visible = False

    End Sub

    Private Sub txtTime_GotFocus(sender As Object, e As EventArgs)

        'DateTimePicker1.Visible = False

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)

        'EditFrm.Show()
        'Hide()

    End Sub


    Private Sub btnSpot_Click(sender As Object, e As EventArgs) Handles btnSpot.Click

        '''NEXT STATEMENT IS THE POSTING
        'Dim commentStr As String
        'If cmbxMCLine.Text = "" Then
        '    commentStr = cmbxHCounty.Text & "+" & cmbHState.Text
        'Else
        '    commentStr = cmbxHCounty.Text & "+" & cmbHState.Text & "+" & cmbxCLine.Text & "," & cmbHCLineState.Text
        'End If

        ''WebBrowser1.Document.GetElementById("Add Call").InvokeMember("click")
        'Dim request As WebRequest = WebRequest.Create("http://ch.w6rk.com/add.php?add=1")
        '' Set the Method property of the request to POST.  
        'request.Method = "POST"
        '' Create POST data and convert it to a byte array.  
        'Dim postData As String = "redirect=&user=&code=&call=" & lblCall.Text & "&fq=" &
        '    cmbxFrequency.Text & "&DXcall=" & txtCall.Text & "&comments=" & commentStr & "&submit=Add+spot"

        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        '' Set the ContentType property of the WebRequest.  
        'request.ContentType = "application/x-www-form-urlencoded"
        '' Set the ContentLength property of the WebRequest.  
        'request.ContentLength = byteArray.Length
        '' Get the request stream.  
        'Dim dataStream As Stream = request.GetRequestStream()
        '' Write the data to the request stream.  
        'dataStream.Write(byteArray, 0, byteArray.Length)
        '' Close the Stream object.  
        'dataStream.Close()
        '' Get the response.  
        'Dim response As WebResponse = request.GetResponse()
        '' Display the status.  
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        '' Get the stream containing content returned by the server.  
        'dataStream = response.GetResponseStream()
        '' Open the stream using a StreamReader for easy access.  
        'Dim reader As New StreamReader(dataStream)
        '' Read the content.  
        'Dim responseFromServer As String = reader.ReadToEnd()
        '' Display the content.  
        'Console.WriteLine(responseFromServer)
        '' Clean up the streams.  
        'reader.Close()
        'dataStream.Close()
        'response.Close()
        Spotit()
    End Sub
    Public Sub Spotit()

        ''NEXT STATEMENT IS THE POSTING
        Dim commentStr As String
        If cmbMyCountyLine.Text = "" Then
            'commentStr = cmbxHCounty.Text & "," & cmbHState.Text & "+" & TextBox1.Text
        Else
            'commentStr = cmbxHCounty.Text & "," & cmbHState.Text & "/" & cmbxCLine.Text & "," & cmbHCLineState.Text & "+" & TextBox1.Text
            'commentStr = cmbxHCounty.Text & "," & cmbHState.Text & "/" & cmbxCLine.Text & "," & TextBox1.Text
        End If

        'WebBrowser1.Document.GetElementById("Add Call").InvokeMember("click")
        Dim request As WebRequest = WebRequest.Create("http://ch.w6rk.com/add.php?add=1")
        ' Set the Method property of the request to POST.  
        request.Method = "POST"
        ' Create POST data and convert it to a byte array.  
        'Dim postData As String = "redirect=&user=&code=&call=" & lblCall.Text & "&fq=" &
        'cmbxFrequency.Text & "&DXcall=" & txtCall.Text & "&comments=" & commentStr & "&submit=Add+spot"

        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        ' Set the ContentType property of the WebRequest.  
        request.ContentType = "application/x-www-form-urlencoded"
        ' Set the ContentLength property of the WebRequest.  
        'request.ContentLength = byteArray.Length
        ' Get the request stream.  
        Dim dataStream As Stream = request.GetRequestStream()
        ' Write the data to the request stream.  
        'dataStream.Write(byteArray, 0, byteArray.Length)
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

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ' Edit the Top Row
        PerformEdit(0)
    End Sub

    Private Sub PerformEdit(dataRow As Integer)
        If ButtonEdit.Text = "Edit" Then
            ButtonEdit.Text = "Exit Edit"
            ControlEdit(False)

            _backColor = Me.BackColor
            Me.BackColor = Color.Yellow

            _holdContactData = ExtractContactData()
            Dim editData = ReadContactData(dataRow)
            RestoretContactData(editData)
        Else
            ButtonEdit.Text = "Edit"
            ControlEdit(True)

            Me.BackColor = _backColor

            RestoretContactData(_holdContactData)
        End If
    End Sub

    Private Sub ControlEdit(blnFlag As Boolean)
        btnPost.Visible = blnFlag
        ButtonClear.Visible = blnFlag
        btnSpot.Visible = blnFlag
        btnClose.Visible = blnFlag

        ButtonSaveEdit.Top = ButtonClear.Top
        ButtonSaveEdit.Visible = Not blnFlag
        ButtonEditNext.Visible = Not blnFlag
        ButtonEditPrevious.Visible = Not blnFlag
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Dim ReturnFlag = False

        Dim logData As LogData = ExtractBasicLogData()
        ReturnFlag = SaveLogByContactCounties(logData)

        InitializeBlankContact()
    End Sub

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        'Clock timer.............................................................................................
        Dim Now As DateTime = DateTime.Now.ToUniversalTime()
        txtTime.Text = Now.ToString("HH") & Now.ToString("mm")

    End Sub

    Private Sub btnLogIt_StyleChanged(sender As Object, e As EventArgs) Handles btnLogIt.StyleChanged
        'LoadCountyComboBox(cmbMyCounty, cmbMyState.Text, False)
    End Sub

    Private Sub cmbMyOperation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyOperation.SelectedIndexChanged
        ControlMyOperation()
    End Sub

    Private Sub ControlMyOperation()
        Dim variableLocation As Boolean = False
        Select Case cmbMyOperation.SelectedValue.ToString
            Case "F"
                variableLocation = False
                LabelMyCounty.Text = "Home Cny"
            Case Else
                variableLocation = True
                LabelMyCounty.Text = "County"
        End Select

        cmbMyState.Enabled = variableLocation
        cmbMyCounty.Enabled = variableLocation
        cmbMyCountyLine.Enabled = variableLocation
    End Sub

    Private Sub cmbContactOperation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactOperation.SelectedIndexChanged
        ControlContactOperation()
    End Sub

    Private Sub ControlContactOperation()
        Dim variableLocation As Boolean = False

        Dim value As String = cmbContactOperation.SelectedValue.ToString

        Select Case cmbContactOperation.SelectedValue.ToString
            Case "F"
                variableLocation = False
            Case Else
                variableLocation = True
        End Select

        lblContactState.Visible = variableLocation
        cmbContactState.Visible = variableLocation

        lblContactCounty.Visible = variableLocation
        cmbContactCounty.Visible = variableLocation

        lblContactCountyLine.Visible = variableLocation
        cmbContactCountyLine.Visible = variableLocation

        lblContactHomeCounty.Visible = Not variableLocation
        txtContactHomeCounty.Visible = Not variableLocation
    End Sub

    Private Sub cmbMyState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMyState.SelectedIndexChanged
        ' Fill my county box with available counties
        LoadCountyComboBox(cmbMyCounty, cmbMyState.Text, False)
    End Sub

    Private Sub cmbContactState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactState.SelectedIndexChanged
        ' Fill contact county box with available counties
        LoadCountyComboBox(cmbContactCounty, cmbContactState.Text, True)
    End Sub

    Public Sub LoadCountyComboBox(cmb As ComboBox, state As String, blnAddBlankLine As Boolean)

        Dim countyList As New ArrayList()

        If blnAddBlankLine Then
            'cmb.Items.Add("")
            countyList.Add(New taggedIntegerClass("", 0))
        End If

        ' Fill counties into combobox
        Dim dataTable As DataTable = _commonData.GetCountyList(state)
        For Each row As DataRow In dataTable.Rows
            Dim county As String = CStr(row("county"))
            Dim countyId As Integer = CInt(row("county ID"))
            countyList.Add(New taggedIntegerClass(county, countyId))
        Next

        cmb.DataSource = countyList
        cmb.DisplayMember = "Description"
        cmb.ValueMember = "Value"
    End Sub

    Private Sub cmbMyCounty_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Fill my county line box with available countiy lines
        'LoadCountyComboBox(cmbMyCountyLine, cmbMyCounty.SelectedIndex, False)
    End Sub

    Private Sub cmbContactCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContactCounty.SelectedIndexChanged
        ' Fill contact county line box with available countiy lines
        Try
            Dim countyId As Integer = CInt(cmbContactCounty.SelectedValue.ToString)
            If countyId > 0 Then
                LoadCountyLineComboBox(cmbContactCountyLine, countyId, True)
            End If
        Catch
        End Try
    End Sub

    Public Sub LoadCountyLineComboBox(cmb As ComboBox, countyId As Integer, blnAddBlankLine As Boolean)
        If countyId > 0 Then
            Dim countyLineList As New ArrayList()

            If blnAddBlankLine Then
                'cmb.Items.Add("")
                countyLineList.Add(New taggedIntegerClass("", 0))
            End If

            '   Fill countLineList into Collection
            Dim countyLineCollection As Collection = _commonData.GetRelatedCountyLines(countyId)
            For Each countyLine As CountyData In countyLineCollection
                Dim county As String = countyLine.fullCountyName
                Dim countyLineId As Integer = countyLine.countyId
                countyLineList.Add(New taggedIntegerClass(county, countyId))
            Next

            cmb.DataSource = countyLineList
            cmb.DisplayMember = "Description"
            cmb.ValueMember = "Value"
        End If
    End Sub

    Private Function ExtractBasicLogData() As LogData
        Dim logData As New LogData
        logData.Create()

        logData.mode = cmbMode.Text
        logData.subMode = cmbSubMode.Text
        logData.band = cmbBand.Text
        logData.frequency = CSng(cmbFrequency.Text)

        logData.myDate = txtDate.Text
        logData.myTime = txtTime.Text
        logData.myOperation = cmbMyOperation.SelectedValue.ToString
        logData.contactOperation = cmbContactOperation.SelectedValue.ToString

        logData.myRST = CInt(txtMyRST.Text)
        logData.hisRST = CInt(txtHisRST.Text)

        Return logData

    End Function

    Private Function GetContactCall(logData As LogData) As LogData

        Dim split = txtContactCall.Text.Split("/"c)
        Return logData
    End Function

    Private Sub txtContactCall_Leave(sender As Object, e As EventArgs) Handles txtContactCall.Leave
        Dim call1 As String = ""
        Dim call2 As String = ""

        Dim split = txtContactCall.Text.Split("/"c)
        If (split.Count = 2) Then
            call1 = split(0)
            call2 = split(1)
        ElseIf (split.Count = 1) Then
            call1 = split(0)
        ElseIf (split.Count = 0) Then
            Dim errorMsg = "The Contact Call(s) is not in an acceptable format. Please re-enter"
            MsgBox(errorMsg, vbCritical)
        End If

        Dim names = ""
        If call1.Length > 0 Then
            _contactCallData1 = _commonData.GetCallData(call1)
            If _contactCallData1.callId > 0 Then
                names = _contactCallData1.firstName
            Else
                names = "?"
            End If
            If call2.Length > 0 Then
                _contactCallData2 = _commonData.GetCallData(call2)
                If _contactCallData2.callId > 0 Then
                    names = names & " and " & _contactCallData2.firstName
                Else
                    names = names & " and ?"
                End If
            End If
        End If

        txtContactHomeCounty.Text = _contactCallData1.homeCountyName
        txtContactHomeCounty.Tag = _contactCallData1.homeCountyId

        txtContactNames.Text = names
    End Sub

    Private Function SaveQso(logData As LogData, teamMember As Integer) As Boolean
        Dim returnFlag = False

        Return returnFlag
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '_mainMenu.closeLogEntryScreen(_logEntryType)
        Me.Close()
    End Sub

    Private Sub frmLogEntry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _informedMainMenuClosing Then
            _informedMainMenuClosing = True
            e.Cancel = True
            _mainMenu.closeLogEntryScreen(_logEntryType)
        End If
    End Sub

    Private Sub frmLogEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.F2
                cmbBand.Text = "20"
            Case Keys.F3
                cmbBand.Text = "30"
            Case Keys.F4
                cmbBand.Text = "40"
            Case Keys.F6
                cmbMode.Text = "PSK"
            Case Keys.F7
                cmbMode.Text = "SSB"
            Case Keys.F8
                cmbMode.Text = "CW"
        End Select
    End Sub

    Private Sub SetFrequency()
        Select Case cmbMode.Text
            Case "SSB"
                Select Case cmbBand.Text
                    Case "40"
                        cmbFrequency.Text = "7.188"
                    Case "30"
                        'cmbMode.Text = "CW"
                        cmbFrequency.Text = "10.1245"
                    Case "20"
                        cmbFrequency.Text = "14.336"
                End Select
            Case "CW"
                Select Case cmbBand.Text
                    Case "40"
                        cmbFrequency.Text = "7.0565"
                    Case "30"
                        cmbFrequency.Text = "10.1245"
                    Case "20"
                        cmbFrequency.Text = "14.0565"
                End Select
            Case "PSK"
                Select Case cmbBand.Text
                    Case "40"
                        cmbFrequency.Text = "7.0565"
                    Case "30"
                        cmbFrequency.Text = "10.1245"
                    Case "20"
                        cmbFrequency.Text = "14.0565"
                End Select
        End Select
    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        If cmbMode.Text = "SSB" And cmbBand.Text = "30" Then
            cmbMode.Text = "30"
        End If
        SetFrequency()
        AdjustRST()
    End Sub

    Private Sub cmbBand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBand.SelectedIndexChanged
        If cmbBand.Text = "30" Then
            cmbMode.Text = "CW"
        End If
        SetFrequency()
    End Sub

    Private Sub AdjustRST()
        Dim newRST As String = ""
        Select Case cmbMode.Text
            Case "SSB"
                ' RST for SSB operation must be 2 characters long, If 3 characters , remove last character
                txtMyRST.Text = AdjustRSTLength(txtMyRST.Text, 2)
                txtHisRST.Text = AdjustRSTLength(txtHisRST.Text, 2)
            Case Else
                ' RST for CW or any digital operation must be 32 characters long, If 2 characters , add "9"
                txtMyRST.Text = AdjustRSTLength(txtMyRST.Text, 3)
                txtHisRST.Text = AdjustRSTLength(txtHisRST.Text, 3)
        End Select
    End Sub

    Private Function AdjustRSTLength(currentRST As String, requiredLength As Integer) As String
        Dim newRST As String = ""
        Dim length As Integer = currentRST.Length
        If length = requiredLength Then
            newRST = currentRST
        Else
            Select Case length
                Case 2
                    ' Must change from SSB format to CW format
                    newRST = currentRST & "9"
                Case 3
                    ' Must change from CW to SSB format
                    newRST = currentRST.Substring(0, 2)
                Case Else
                    ' Format messed up. Convert to default
                    If requiredLength = 2 Then
                        ' Use SSB format
                        newRST = "59"
                    Else
                        ' Use CW format
                        newRST = "599"
                    End If
            End Select
        End If
        Return newRST
    End Function

    Private Function SaveLogByContactCounties(logData As LogData) As Boolean
        Dim returnFlag As Boolean

        Dim contactCountyId As Integer = extractCountyId(cmbContactCounty)
        If contactCountyId > 0 Then
            logData.contactCountyId = contactCountyId
            returnFlag = SaveLogByContactOperators(logData)
        End If

        If returnFlag Then
            Dim contactCountyLineId As Integer = extractCountyId(cmbContactCountyLine)
            If contactCountyLineId > 0 Then
                logData.contactCountyId = contactCountyId
                returnFlag = SaveLogByContactOperators(logData)
            End If

        End If
        Return returnFlag
    End Function

    Private Function SaveLogByContactOperators(logData As LogData) As Boolean
        Dim returnFlag As Boolean

        If _contactCallData1.callId > 0 Then
            logData.contactCall = _contactCallData1.currentCall
            logData.contactCallId = _contactCallData1.callId
            logData.contactCountyName = cmbContactCounty.Text & ", " & cmbContactState.Text
            returnFlag = SaveLogByMyCounties(logData)
        End If

        If returnFlag Then
            If _contactCallData2.callId > 0 Then
                logData.contactCall = _contactCallData2.currentCall
                logData.contactCallId = _contactCallData2.callId
                logData.contactCountyName = cmbContactCountyLine.Text
                returnFlag = SaveLogByMyCounties(logData)
            End If
        End If
        Return returnFlag
    End Function

    Private Function SaveLogByMyCounties(logData As LogData) As Boolean
        Dim returnFlag As Boolean

        Dim myCountyId As Integer = extractCountyId(cmbMyCounty)
        If myCountyId > 0 Then
            logData.myCountyId = myCountyId
            logData.myCountyName = cmbMyCounty.Text & ", " & cmbMyState.Text
            returnFlag = SaveLogByMyOperators(logData)
        End If

        If returnFlag Then
            Dim myCountyLineId As Integer = extractCountyId(cmbMyCountyLine)
            If myCountyLineId > 0 Then
                logData.myCountyId = myCountyLineId
                logData.myCountyName = cmbMyCountyLine.Text & ", " & cmbMyState.Text
                returnFlag = SaveLogByMyOperators(logData)
            End If
        End If
        Return returnFlag
    End Function

    Private Function SaveLogByMyOperators(logData As LogData) As Boolean
        Dim returnFlag As Boolean = True

        If (ckbPrimaryTeamMember.Checked) Then
            logData.qsoId = _primaryLog.GetNextIndex("QSO - Master", "QSO ID")
            logData.myCallId = _primaryCallData.callId
            returnFlag = _primaryLog.AddLogRecord(logData)
            If returnFlag Then
                returnFlag = updateBooks(logData)   ' Does nothing for now
                loadIntoDisplayLog(logData, 0)         ' Does nothing for now
            End If
        End If

        If returnFlag Then
            If _mainMenu._blnTeam Then
                If (chkSecondaryTeamMember.Checked) Then
                    logData.qsoId = _secondaryLog.GetNextIndex("QSO - Master", "QSO ID")
                    logData.myCallId = _secondaryCallData.callId
                    returnFlag = _secondaryLog.AddLogRecord(logData)
                    If returnFlag Then
                        returnFlag = updateBooks(logData)   ' Does nothing for now
                        loadIntoDisplayLog(logData, 0)         ' Does nothing for now
                    End If
                End If
            End If
        End If
        Return returnFlag
    End Function

    Private Function extractCountyId(cmb As ComboBox) As Integer
        Dim countyId = 0
        Try
            countyId = CInt(cmb.SelectedValue.ToString)
        Catch
            'Dim ii As Integer = 0
        End Try
        Return countyId
    End Function

    Private Function updateBooks(logData As LogData) As Boolean
        Dim returnFlag As Boolean = True

        Return returnFlag
    End Function

    Private Sub loadIntoDisplayLog(logData As LogData, rowId As Integer)

        ' Insert blank row at top
        dataGridView.Rows.Insert(0, 1)

        ' Add required data
        dataGridView.Rows(rowId).Cells("qsoId").Value = logData.qsoId.ToString
        dataGridView.Rows(rowId).Cells("dateCol").Value = logData.myDate
        dataGridView.Rows(rowId).Cells("time").Value = logData.myTime
        dataGridView.Rows(rowId).Cells("currentCall").Value = logData.contactCall
        dataGridView.Rows(rowId).Cells("contactCountyId").Value = logData.contactCountyId.ToString
        dataGridView.Rows(rowId).Cells("contactCounty").Value = logData.contactCountyName
        dataGridView.Rows(rowId).Cells("myCountyId").Value = logData.myCountyId.ToString
        dataGridView.Rows(rowId).Cells("myCounty").Value = logData.myCountyName.ToString
        dataGridView.Rows(rowId).Cells("hisRst").Value = logData.hisRST.ToString
        dataGridView.Rows(rowId).Cells("myRst").Value = logData.myRST.ToString
        dataGridView.Rows(rowId).Cells("band").Value = logData.band.ToString
        dataGridView.Rows(rowId).Cells("frequency").Value = logData.frequency.ToString
        dataGridView.Rows(rowId).Cells("mode").Value = logData.mode.ToString
        dataGridView.Rows(rowId).Cells("frequency").Value = logData.frequency.ToString
        dataGridView.Rows(rowId).Cells("mode").Value = logData.mode.ToString
        dataGridView.Rows(rowId).Cells("hisOp").Value = logData.contactOperation.ToString
        dataGridView.Rows(rowId).Cells("myOp").Value = logData.myOperation.ToString
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        InitializeBlankContact()
    End Sub

    Private Function ExtractContactData() As HoldContactData
        Dim holdData As New HoldContactData
        holdData.Create()

        holdData.contactCall = txtContactCall.Text
        holdData.contactState = cmbContactState.Text
        holdData.contactCountyId = extractCountyId(cmbContactCounty)
        holdData.contactCountyLineId = extractCountyId(cmbContactCountyLine)
        holdData.contactHomeCounty = txtContactHomeCounty.Text
        holdData.contactOperation = cmbContactOperation.Text
        holdData.myOperation = cmbMyOperation.Text
        holdData.HisRST = txtHisRST.Text
        holdData.myRST = txtMyRST.Text

        Return holdData
    End Function

    Private Function RestoretContactData(holdData As HoldContactData) As HoldContactData
        holdData.Create()

        txtContactCall.Text = holdData.contactCall
        cmbContactState.Text = holdData.contactState
        cmbContactCounty.SelectedValue = holdData.contactCountyId
        cmbContactCountyLine.SelectedValue = holdData.contactCountyLineId
        txtContactHomeCounty.Text = holdData.contactHomeCounty
        cmbContactOperation.Text = holdData.contactOperation
        holdData.HisRST = txtHisRST.Text
        holdData.myRST = txtMyRST.Text

        Return holdData
    End Function

    Private Function ReadContactData(rowId As Integer) As HoldContactData
        Dim holdData As HoldContactData
        holdData.Create()

        holdData.contactCall = dataGridView.Rows(rowId).Cells("currentCall").Value.ToString
        'holdData.contactState = dataGridView.Rows(rowId).Cells("contactState").Value.ToString
        'cmbContactCounty.Text = holdData.contactCounty
        'cmbContactCountyLine.Text = holdData.contactCountyLine
        'txtContactHomeCounty.Text = dataGridView.Rows(rowId).Cells("currentCall").Value.ToString
        'holdData.contactOperation = dataGridView.Rows(rowId).Cells("contactOp").Value.ToString
        'holdData.myOperation = dataGridView.Rows(rowId).Cells("myOp").Value.ToString
        'holdData.HisRST = dataGridView.Rows(rowId).Cells("hisRst").Value.ToString
        'holdData.myRST = dataGridView.Rows(rowId).Cells("myRst").Value.ToString

        Return holdData
    End Function

    Private Function ParseCountName(countyName As String) As CountyStateData
        Dim countyStateData As CountyStateData
        countyStateData.Create()

        Dim split = txtContactCall.Text.Split(","c)
        If (split.Count = 2) Then
            countyStateData.county = split(0).Trim
            countyStateData.state = split(1).Trim
        End If

        Return countyStateData
    End Function

    Private Sub GroupBoxMobileParameters_Enter(sender As Object, e As EventArgs) Handles GroupBoxMobileParameters.Enter

    End Sub


End Class

Public Class taggedClass
    Private label As String
    Private symbol As String

    Public Sub New(ByVal label As String, ByVal symbol As String)
        Me.label = label
        Me.symbol = symbol
    End Sub

    Public Property Description() As String
        Get
            Return label
        End Get
        Set(ByVal value As String)
            label = value
        End Set
    End Property

    Public Property Value() As String
        Get
            Return symbol
        End Get
        Set(ByVal value As String)
            symbol = value
        End Set
    End Property

End Class

Public Class taggedIntegerClass
    Private label As String
    Private id As Integer

    Public Sub New(ByVal label As String, ByVal id As Integer)
        Me.label = label
        Me.id = id
    End Sub

    Public Property Description() As String
        Get
            Return label
        End Get
        Set(ByVal value As String)
            label = value
        End Set
    End Property

    Public Property Value() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

End Class

Public Structure LogData
    Public validData As Boolean
    Public qsoId As Integer
    Public contactCall As String
    Public contactCallId As Integer
    Public contactCountyId As Integer
    Public contactCountyName As String
    Public myCallId As Integer
    Public myCountyId As Integer
    Public myCountyName As String
    Public myDate As String
    Public myTime As String
    Public frequency As Single
    Public mode As String
    Public subMode As String
    Public band As String
    Public myRST As Integer
    Public hisRST As Integer
    Public myOperation As String
    Public contactOperation As String

    Public Sub Create()
        validData = False
        qsoId = 0
        contactCall = ""
        contactCallId = 0
        contactCountyName = ""
        myCallId = 0
        myCountyId = 0
        myCountyName = ""
        myDate = ""
        myTime = ""
        mode = ""
        subMode = ""
        band = ""
        myRST = 0
        hisRST = 0
        myOperation = ""
        contactOperation = ""
    End Sub
End Structure

Public Structure HoldContactData
    Public contactCall As String
    Public contactState As String
    Public contactCountyId As Integer
    Public contactCountyLineId As Integer
    Public contactHomeCounty As String
    Public contactOperation As String
    Public myOperation As String
    Public myRST As String
    Public HisRST As String

    Public Sub Create()
        contactCall = ""
        contactState = ""
        contactCountyId = 0
        contactCountyLineId = 0
        contactHomeCounty = ""
        contactOperation = ""
        myOperation = ""
        myRST = ""
        HisRST = ""
    End Sub
End Structure

Public Structure CountyStateData
    Public county As String
    Public state As String

    Public Sub Create()
        county = ""
        state = ""
    End Sub

End Structure
