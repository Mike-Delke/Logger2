Public Class clsCommonData
    Inherits clsDatabase

    Public Shared _instance As New clsCommonData

    Public Shared Function GetInstance(strLabel As String) As clsCommonData
        Try
            If IsNothing(_instance) Then
                _instance = New clsCommonData()
            End If
        Catch ex As Exception
            Dim errorMsg As String
            errorMsg = "The attempt to create an instance of the " &
                       strLabel & " Database failed." &
                       Chr(10) & Chr(13) & "Error: " & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try
        Return _instance
    End Function

    ' **** Call Database Routines ********************************************

    Public Function GetFullCallData(strCurrentCall As String) As FullCallData
        Dim strSql As String = "SELECT * FROM [County Hunters] WHERE [Current Call]='" &
                               strCurrentCall & "'"
        Dim dataTable As DataTable = Read(strSql)
        Dim fullCallData As FullCallData = ExtractFullCallData(dataTable)
        Return fullCallData
    End Function

    Public Function GetFullCallData(intCallId As Integer) As FullCallData
        Dim strSql As String = "SELECT * FROM [County Hunters] WHERE [Call ID=" & intCallId
        Dim dataTable As DataTable = Read(strSql)
        Dim fullCallData As FullCallData = ExtractFullCallData(dataTable)
        Return fullCallData
    End Function

    Public Function ExtractFullCallData(dataTable As DataTable) As FullCallData

        Dim fullCallData As New FullCallData
        fullCallData.Create()

        Try
            If dataTable.Rows.Count > 0 Then
                Dim row As DataRow = dataTable.Rows(0)
                fullCallData.validData = True
                fullCallData.callId = CInt(row("Call ID"))
                fullCallData.currentCall = CStr(row("Current Call"))
                fullCallData.firstName = CStr(row("First Name"))
                fullCallData.lastName = CStr(row("Last Name"))
                fullCallData.CreateFullName()
                fullCallData.address = CStr(row("Address"))
                fullCallData.city = CStr(row("City"))
                fullCallData.state = CStr(row("State"))
                fullCallData.zip = CStr(row("Zip"))
                fullCallData.addressDX = CStr(row("Address DX"))
                fullCallData.homeCounty = CStr(row("Home County"))

                Dim countyData As CountyData
                countyData = GetCountyData(fullCallData.homeCounty, fullCallData.state)
                fullCallData.homeCountyId = countyData.countyId
                fullCallData.homeCountyName = countyData.fullCountyName

                fullCallData.expirationDate = CStr(row("MARAC Expiration Date"))
                fullCallData.phoneNumber = CStr(row("Phone Number"))
                fullCallData.emailAddress = CStr(row("E Mail Address"))
                fullCallData.birthDate = CStr(row("Birthday"))
            End If
        Catch ex As Exception
            fullCallData.validData = False
            Dim errorMsg = "An error occurred when when attempting to extract " &
                "full call data from the County Hunter Data Table" &
                Chr(10) & Chr(13) & "Error: " & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try
        Return fullCallData
    End Function

    Public Function GetCallData(strCurrentCall As String) As CallData
        Dim strSql As String = "SELECT * FROM [County Hunters] WHERE [Current Call]='" &
                               strCurrentCall & "'"
        Dim dataTable As DataTable = Read(strSql)
        Dim callData As CallData = ExtractCallData(dataTable)
        Return callData
    End Function

    Public Function GetCallData(intCallId As Integer) As CallData
        Dim strSql As String = "SELECT * FROM [County Hunters] WHERE [Call ID=" & intCallId
        Dim dataTable As DataTable = Read(strSql)
        Dim callData As CallData = ExtractCallData(dataTable)
        Return callData
    End Function

    Public Function ExtractCallData(dataTable As DataTable) As CallData

        Dim callData As New CallData
        callData.Create()

        Try
            If dataTable.Rows.Count > 0 Then
                Dim row As DataRow = dataTable.Rows(0)
                callData.validData = True
                callData.callId = CInt(row("Call ID"))
                callData.currentCall = CStr(row("Current Call"))
                callData.firstName = CStr(row("First Name"))
                callData.lastName = CStr(row("Last Name"))
                callData.CreateFullName()
                callData.state = CStr(row("State"))
                callData.homeCounty = CStr(row("Home County"))

                Dim countyData As CountyData
                countyData = GetCountyData(callData.homeCounty, callData.state)
                callData.homeCountyId = countyData.countyId
                callData.homeCountyName = countyData.fullCountyName
            Else
                callData.validData = False
            End If
        Catch ex As Exception
            callData.validData = False
            Dim errorMsg = "An error occurred when when attempting to extract " &
                "call data from the County Hunter Data Table" &
                Chr(10) & Chr(13) & "Error: " & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try
        Return callData
    End Function

    ' **** Call County Routines ********************************************

    Public Function GetCountyId(county As String, state As String) As Integer
        Dim countyId As Integer = 0
        Dim CountyData As CountyData = GetCountyData(county, state)
        countyId = CountyData.countyId
        Return countyId
    End Function

    Public Function GetCountyData(countyId As Integer) As CountyData
        Dim strSql As String = "SELECT * FROM [List Of Counties] " &
                              "WHERE [County ID]=" & countyId
        Dim dataTable As DataTable = Read(strSql)
        Dim countyData As CountyData = ExtractCountyData(dataTable)
        Return countyData
    End Function

    Public Function GetCountyData(county As String, state As String) As CountyData
        Dim strSql As String = "SELECT * FROM [List Of Counties] " &
                               "WHERE [County]='" & county & "'" &
                               "And [State ID]='" & state & "'"
        Dim dataTable As DataTable = Read(strSql)
        Dim countyData As CountyData = ExtractCountyData(dataTable)
        Return countyData
    End Function

    Public Function ExtractCountyData(dataTable As DataTable) As CountyData
        Dim countyData As New CountyData
        countyData.Create()

        Try
            If dataTable.Rows.Count > 0 Then
                Dim row As DataRow = dataTable.Rows(0)
                countyData.validCounty = True
                countyData.countyId = CInt(row("County ID"))
                countyData.county = CStr(row("County"))
                countyData.state = CStr(row("State ID"))
                countyData.CreateFullName()
            Else
                countyData.validCounty = False
            End If
        Catch ex As Exception
            countyData.validCounty = False
            Dim errorMsg = "An error occurred when when attempting to extract " &
                           "county data from the County Hunter Data Table" &
                           Chr(10) & Chr(13) & "Error: " & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try
        Return countyData
    End Function

    Public Function ExtractCountyData(row As DataRow) As CountyData
        Dim countyData As New CountyData
        countyData.Create()

        Try
            'If DataTable.Rows.Count > 0 Then
            countyData.validCounty = True
            countyData.countyId = CInt(row("County ID"))
            countyData.county = CStr(row("County"))
            countyData.state = CStr(row("State ID"))
            countyData.CreateFullName()
            'Else
            'countyData.validCounty = False
            'End If
        Catch ex As Exception
            countyData.validCounty = False
            Dim errorMsg = "An error occurred when when attempting to extract " &
                           "county data from the County Hunter Data Table" &
                           Chr(10) & Chr(13) & "Error: " & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try
        Return countyData
    End Function

    Public Function GetRelatedCountyLines(countyId As Integer) As Collection
        Dim relatedCountyLines As New Collection

        Dim strSql As String = "SELECT * FROM [County Lines] " &
                              "WHERE [County ID]=" & countyId
        Dim dataTable As DataTable = Read(strSql)

        For Each row As DataRow In dataTable.Rows
            Dim countyLineData As CountyLineData = ExtractCountyLineData(row)
            Dim countyLineId As Integer = CInt(row("County Line ID"))
            If countyLineId > 0 Then
                Dim countyData As CountyData = GetCountyData(countyLineId)
                relatedCountyLines.Add(countyData)
            End If
        Next

        Return relatedCountyLines
    End Function

    Public Function ExtractCountyLineData(row As DataRow) As CountyLineData
        Dim countyLineData As New CountyLineData
        countyLineData.Create()

        countyLineData.validCounty = True
        countyLineData.countyId = CInt(row("County ID"))
        countyLineData.countyLineId = CInt(row("County Line Id"))
        Return countyLineData
    End Function

    Public Function GetStateList() As DataTable
        Return Read("SELECT [State ID] FROM States ORDER BY [State ID]")
    End Function

    Public Function GetCountyList(state As String) As DataTable
        Return Read("SELECT * FROM [List Of Counties] WHERE [State ID]='" & state & "' ORDER BY County")
    End Function

    Public Function GetModeList() As DataTable
        Return Read("SELECT * FROM [Modes] ORDER BY [Mode] ASC")
    End Function

    Public Function GetSubModeList(modeId As Integer) As DataTable
        Return Read("SELECT * FROM [Modes - Sub] WHERE [mode ID]=" & modeId & " ORDER BY [Sub Mode] ASC")
    End Function

End Class

Public Structure CallData
    Public validData As Boolean
    Public callId As Integer
    Public currentCall As String
    Public firstName As String
    Public middleInitial As String
    Public lastName As String
    Public fullName As String
    Public state As String
    Public homeCounty As String
    Public homeCountyId As Integer
    Public homeCountyName As String


    Sub CreateFullName()
        fullName = firstName & " " & middleInitial & " " & lastName
    End Sub

    Public Sub Create()
        validData = False
        callId = 0
        currentCall = ""
        firstName = ""
        middleInitial = ""
        lastName = ""
        fullName = ""
        state = ""
        homeCounty = ""
        homeCountyId = 0
        homeCountyName = ""
    End Sub
End Structure

Public Structure FullCallData
    Public validData As Boolean
    Public callId As Integer
    Public currentCall As String
    Public firstName As String
    Public middleInitial As String
    Public lastName As String
    Public fullName As String
    Public address As String
    Public city As String
    Public state As String
    Public zip As String
    Public addressDX As String
    Public homeCounty As String
    Public homeCountyId As Integer
    Public homeCountyName As String
    Public expirationDate As String
    Public phoneNumber As String
    Public emailAddress As String
    Public birthDate As String

    Public Sub CreateFullName()
        fullName = firstName
        If middleInitial.Length > 0 Then
            fullName = fullName & " " + middleInitial
        End If
        fullName = fullName & " " + lastName
    End Sub

    Public Sub Create()
        validData = False
        callId = 0
        currentCall = ""
        firstName = ""
        middleInitial = ""
        lastName = ""
        fullName = ""
        address = ""
        city = ""
        state = ""
        zip = ""
        homeCounty = ""
        homeCountyId = 0
        homeCountyName = ""
        addressDX = ""
        expirationDate = ""
        emailAddress = ""
        birthDate = ""
    End Sub
End Structure

Public Structure CountyData
    Public validCounty As Boolean
    Public countyId As Integer
    Public county As String
    Public state As String
    Public fullCountyName As String

    Sub Create()
        validCounty = False
        countyId = 0
        county = "" '
        state = ""
        fullCountyName = ""
    End Sub

    Public Sub CreateFullName()
        fullCountyName = county & ", " & state
    End Sub
End Structure

Public Structure CountyLineData
    Public validCounty As Boolean
    Public countyId As Integer
    Public countyLineId As Integer

    Sub Create()
        validCounty = False
        countyId = 0
    End Sub
End Structure





