Public Class clsScreenUtilities

    Private _commonData As clsCommonData = clsCommonData.GetInstance("CommonData")

    Public Sub LoadStateComboBox(cmb As ComboBox)
        'Setup error test if wrong type error  return
        cmb.Tag = ComboBoxReturnType.NoIndexedReturn

        'Clear the options in combo box just to be sure it is empty
        cmb.Items.Clear()

        'Place a blank line at the top
        cmb.Items.Add("")

        'Create a list of available counties in the combo box
        Dim dataTable As DataTable = _commonData.GetStateList()
        For Each row As DataRow In dataTable.Rows
            Dim state As String = CStr(row("State ID"))
            ' Add state to combo box
            cmb.Items.Add(state)
        Next
    End Sub

    Public Sub LoadCountiesComboBox(cmb As ComboBox, state As String)
        If Len(state) > 0 Then
            'Setup error test if wrong type error  return
            cmb.Tag = ComboBoxReturnType.IntegerReturn

            'We don't need to clear the entries because we are changing the data source

            'Create a list to hold available and index
            Dim countyList As New ArrayList()

            'Place a blank line at the top with a index of 0
            countyList.Add(New taggedIntegerReturn("", 0))

            Dim dataTable As DataTable = _commonData.GetCountyList(state)
            For Each row As DataRow In dataTable.Rows
                Dim county As String = CStr(row("county"))
                Dim countyId As Integer = CInt(row("county ID"))
                countyList.Add(New taggedIntegerReturn(county, countyId))
            Next

            'Add a list of available counties in the combo box
            cmb.DataSource = countyList
            cmb.DisplayMember = "Description"
            cmb.ValueMember = "Value"
        End If
    End Sub

    Public Sub LoadCountyLinesComboBox(cmb As ComboBox, countyId As Integer)
        'Setup error test if wrong type error  return
        cmb.Tag = ComboBoxReturnType.IntegerReturn

        'We don't need to clear the entries because we are changing the data source

        'Create a list to hold available and index
        Dim countyList As New ArrayList()

        'Place a blank line at the top with a index of 0
        countyList.Add(New taggedIntegerReturn("", 0))

        'Add a list of available counties in the combo box
        Dim countyLineCollectiom As Collection = _commonData.GetRelatedCountyLines(countyId)
        For Each countyLineData As CountyData In countyLineCollectiom
            Dim countyLine As String = countyLineData.fullCountyName
            Dim countyLineId As Integer = countyLineData.countyId
            countyList.Add(New taggedIntegerReturn(countyLine, countyLineId))
        Next

        cmb.DataSource = countyList
        cmb.DisplayMember = "Description"
        cmb.ValueMember = "Value"
    End Sub

    Public Sub LoadModes(cmb As ComboBox)
        'Setup error test if wrong type error  return
        cmb.Tag = ComboBoxReturnType.IntegerReturn

        'We don't need to clear the entries because we are changing the data source

        Dim modeList As New ArrayList()

        'Add CW, SSB and PSK at top of list
        modeList.Add(New taggedIntegerReturn("CW", 7))
        modeList.Add(New taggedIntegerReturn("SSB", 30))
        modeList.Add(New taggedIntegerReturn("PSK", 26))

        'Fill modelist into CollectionmodeId =
        Dim dataTable As DataTable = _commonData.GetModeList()
        For Each row As DataRow In dataTable.Rows
            Dim mode As String = CStr(row("Mode"))
            Dim modeId As Integer = CInt(row("Mode Id"))
            If (Not mode.Equals("CW")) And (Not mode.Equals("SSB")) And (Not mode.Equals("PSK")) Then
                modeList.Add(New taggedIntegerReturn(mode, modeId))
            End If
        Next

        cmb.DataSource = modeList
        cmb.DisplayMember = "Description"
        cmb.ValueMember = "Value"
    End Sub

    Public Function LoadSubModes(cmb As ComboBox, modeId As Integer) As Boolean
        Dim returnFlag As Boolean = False

        'NOTE:The submode combo box does not uses taggedIndexing
        '     To read the sectected submode, use the normal Text function
        '     However, you can use the  GetComboStringReturn, where the Text value will be returned

        'Setup error test if wrong type error  return
        cmb.Tag = ComboBoxReturnType.UseTextForStringReturn

        'We don't need to clear the entries because we are changing the data source

        Dim dataTable As DataTable = _commonData.GetSubModeList(modeId)
        Dim subMode As String

        If Not dataTable.Rows.Count = 0 Then
            'Fill subModeList into dropdown
            For Each row As DataRow In dataTable.Rows
                subMode = CStr(row("Sub Mode"))
                cmb.Items.Add(subMode)
                returnFlag = True
            Next
        End If

        Return returnFlag
    End Function

    Public Sub LoadFixedMyOperation(cmb As ComboBox, blnAllowRemote As Boolean)
        'Setup error test if wrong type error  return
        cmb.Tag = ComboBoxReturnType.StringReturn

        Dim opList As New ArrayList
        opList.Add(New taggedStringReturn("Home", "F"))
        opList.Add(New taggedStringReturn("Portable", "P"))
        If blnAllowRemote Then
            opList.Add(New taggedStringReturn("Remote", "R"))
        End If

        cmb.DataSource = opList
        cmb.DisplayMember = "Description"
        cmb.ValueMember = "Value"
    End Sub

    Public Sub LoadMobileMyOperation(cmb As ComboBox, blnAllowRemote As Boolean)
        'Setup error test if wrong type error  return
        cmb.Tag = ComboBoxReturnType.StringReturn

        Dim opList As New ArrayList
        opList.Add(New taggedStringReturn("Mobile", "M"))

        cmb.DataSource = opList
        cmb.DisplayMember = "Description"
        cmb.ValueMember = "Value"
    End Sub

    Public Sub LoadContactOperation(cmb As ComboBox, blnAllowRemote As Boolean)
        'Setup error test if wrong type error  return
        cmb.Tag = ComboBoxReturnType.StringReturn

        Dim opList As New ArrayList
        opList.Add(New taggedStringReturn("Home", "F"))
        opList.Add(New taggedStringReturn("Unknown", "U"))
        opList.Add(New taggedStringReturn("Mobile", "M"))
        opList.Add(New taggedStringReturn("Portable", "P"))
        If blnAllowRemote Then
            opList.Add(New taggedStringReturn("Remote", "R"))
        End If

        cmb.DataSource = opList
        cmb.DisplayMember = "Description"
        cmb.ValueMember = "Value"
    End Sub

    Public Function GetComboIdReturn(cmb As ComboBox) As Integer
        Dim name As String = cmb.Name
        Dim id = 0
        Dim type As ComboBoxReturnType = ComboBoxReturnType.NoIndexedReturn

        Try
            Dim objType As Object = cmb.Tag
            type = DirectCast(objType, ComboBoxReturnType)
        Catch
        End Try

        If Not type = ComboBoxReturnType.IntegerReturn Then
            Dim errorMsg = "You are trying to get a selectedValue from the combo box " & cmb.Name & " which is poorly defined. This is likely a programming error"
            MsgBox(errorMsg, vbCritical)
        Else
            Try
                id = CInt(cmb.SelectedValue.ToString)
            Catch
                id = 0
            End Try
        End If

        Return id
    End Function

    Public Function GetComboStringReturn(cmb As ComboBox) As String
        Dim returnString = ""
        Dim type As ComboBoxReturnType = ComboBoxReturnType.NoIndexedReturn

        Try
            Dim objType As Object = cmb.Tag
            type = DirectCast(objType, ComboBoxReturnType)
        Catch
        End Try

        If type = ComboBoxReturnType.UseTextForStringReturn Then
            returnString = cmb.Text
        ElseIf Not type = ComboBoxReturnType.StringReturn Then
            Dim errorMsg = "You are trying to get a selectedValue from the combo box " & cmb.Name & " which is poorly defined. This is likely a programming error"
            MsgBox(errorMsg, vbCritical)
        Else
            Try
                returnString = cmb.SelectedValue.ToString
            Catch
                returnString = ""
            End Try
        End If

        Return returnString
    End Function


    Public Function EditTimeStringWithColor(strTime As String) As ReturnStringData
        Dim strExtra = " in the 00:00 or 0000 format"
        Dim errorMsg1 = "The time cannot be blank. Please enter a valid timet" & strExtra
        Dim errorMsg2 = "The time string contains a not numeric character. Please enter a valid time" & strExtra
        Dim errorMsg3 = "The time string cannot contain more than 4 characters. Please enter a valid time" & strExtra
        Dim errorMsg = "Unknown error checking for time with a colon"

        Dim returnData As ReturnStringData
        returnData.create()
        Dim returnData2 As ReturnStringData

        returnData.strReturn = strTime

        If Len(strTime) = 0 Then
            errorMsg = errorMsg1
        Else
            ' Check if there is a colon in the time
            Dim colonFlag As Integer = strTime.IndexOf(":")
            If Not colonFlag = -1 Then
                ' There is a colon
                Dim parts = strTime.Split(":"c)
                If parts.Count = 2 Then
                    ' Chect first part
                    If Len(parts(0)) = 0 Then
                        returnData.validReturn = True
                        returnData.strReturn = "00"
                    ElseIf IsNumeric(parts(0)) Then
                        returnData = CheckTwoDigitNumericString(parts(0))
                    Else
                        errorMsg = errorMsg2
                    End If
                    If returnData.validReturn Then
                        If IsNumeric(parts(1)) Then
                            returnData2 = CheckTwoDigitNumericString(parts(1))
                            If returnData2.validReturn Then
                                returnData.validReturn = True
                                returnData.strReturn = returnData.strReturn & ":" & returnData2.strReturn
                            Else
                                errorMsg = returnData.strError
                                errorMsg = errorMsg2
                            End If
                        Else
                            errorMsg = returnData.strError
                        End If
                    End If
                End If
            Else
                ' There is no colon
                If IsNumeric(strTime) Then
                    If (Len(strTime) <= 4) Then
                        Dim intTime As Integer = CInt(strTime)
                        returnData.validReturn = True
                        strTime = intTime.ToString("D4")
                        returnData.strReturn = strTime.Substring(0, 2) & ":" & strTime.Substring(2)
                        returnData.validReturn = True
                    Else
                        errorMsg = errorMsg2
                    End If
                Else
                    errorMsg = errorMsg3
                End If
            End If
        End If

        If Not returnData.validReturn Then
            MsgBox(errorMsg, vbCritical)
        End If

        Return returnData
    End Function

    Private Function CheckTwoDigitNumericString(strText As String) As ReturnStringData
        Dim returnData As ReturnStringData
        returnData.create()

        If Len(strText) <= 2 Then
            Dim intTime As Integer = CInt(strText)
            returnData.validReturn = True
            returnData.strReturn = intTime.ToString("D2")
        Else
            returnData.strError = "The time string cannot contain more than 2 characters for either the hour or minut. Please enter a valid time in the 00:00 format"
        End If

        Return returnData
    End Function

    Public Function ProcessRstTextBoxLeave(txtBox As TextBox, label As String, mode As String) As Boolean

        ' NOTE: The strReturnFlag is used to handle the Handle function
        Dim blnReturnFlag = True
        Dim newText As String = ""

        ' Hand blank RST box
        Select Case Len(txtBox.Text)
            Case 0
                Dim errorMsg As String = "The " & label & " cannot be blank. Please enter a value"
                MsgBox(errorMsg, vbCritical)
                txtBox.Select()
            Case 1
                Select Case txtBox.Text
                    Case "0"
                        newText = ""
                    Case "1"
                        newText = "11"
                    Case "2"
                        newText = "22"
                    Case "3"
                        newText = "33"
                    Case "4"
                        newText = "44"
                    Case "5"
                        newText = "55"
                    Case "6"
                        newText = "56"
                    Case "7"
                        newText = "57"
                    Case "8"
                        newText = "58"
                    Case "9"
                        newText = "59"
                End Select
                If Not mode = "SSB" Then
                    newText = newText & "9"
                End If
                txtBox.Text = newText
        End Select
        Return blnReturnFlag
    End Function

    Public Function ProcessIntegerTextBoxKeyPush(keyInteger As Integer) As Boolean
        ' NOTE: The strReturnFlag is used to handle the Handle function
        Dim blnReturnFlag As Boolean = False

        If (keyInteger >= 48) And (keyInteger <= 57) Then
            blnReturnFlag = False
        Else
            blnReturnFlag = True
        End If

        Return blnReturnFlag
    End Function

End Class

Public Class taggedStringReturn
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

Public Class taggedIntegerReturn
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


Public Structure ReturnStringData
    Public validReturn As Boolean
    Public strReturn As String
    Public strError As String

    Public Sub create()
        validReturn = False
        strReturn = ""
    End Sub
End Structure

Public Enum ComboBoxReturnType
    NoIndexedReturn
    IntegerReturn
    StringReturn
    UseTextForStringReturn
End Enum



