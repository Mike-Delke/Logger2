Public Class clsLog
    Inherits clsDatabase

    Public Function AddLogRecord(logData As LogData) As Boolean
        Dim btnReturnFlag As Boolean = True

        ' Format date string with embedded ":" to properly code to DateTime
        Dim strTime As String

        strTime = logData.myTime.Substring(0, 2) & ":" & logData.myTime.Substring(2)
        Dim strSql As String
        strSql = "INSERT INTO [QSO - MASTER] (" &
                 "[QSO ID],Call,[County ID],[County ID - Mine]," &
                 "[Date],[Time],[Band],Frequency,[Mode]," &
                 "[RST - Mine],[RST - His]," &
                 "[Operation - Mine],[Operation - His],[Sub Mode]" &
                 ") VALUES (" &
                 logData.qsoId.ToString & "," &
                 "'" & logData.contactCall & "'," &
                 logData.contactCallId & "," &
                 logData.myCountyId & "," &
                 "#" & logData.myDate & "#," &
                 "#" & strTime & "#," &
                 "'" & logData.band & "'," &
                 logData.frequency & "," &
                 "'" & logData.mode & "'," &
                 logData.myRST & "," &
                 logData.hisRST & "," &
                 "'" & logData.myOperation & "'," &
                 "'" & logData.contactOperation & "'," &
                 "'" & logData.subMode & "'" &
                 ")"
        'MsgBox(strSql)
        btnReturnFlag = Write(strSql)
        Dim ii As Integer = 0
        Return btnReturnFlag
    End Function

    Public Function UpdateLogRecordLogRecord(logData As LogData) As Boolean
        Dim returnFlag As Boolean = True
        Return returnFlag
    End Function

    Public Function ReadLogRecordLogRecord(qsoId As Integer) As LogData
        Dim strSql As String = "SELECT * FROM [QSO -Master] WHERE [QSO ID]=" & qsoId
        Dim dataTable As DataTable = Read(strSql)
        Dim logData As LogData = ExtractLogRecord(dataTable)
        Return logData
    End Function

    Private Function ExtractLogRecord(dataTable As DataTable) As LogData

        Dim logData As New LogData
        logData.Create()

        Try
            Dim row As DataRow = dataTable.Rows(0)
            logData.qsoId = CInt(row("QSO ID"))
            logData.contactCall = CStr(row("Call"))
            logData.contactCallId = CInt(row("Call ID"))
            logData.contactCountyId = CInt(row("County ID"))
            logData.myCountyId = CInt(row("County ID - Mine"))
            logData.frequency = CSng(row("Frequency"))
            logData.mode = CStr(row("Mode"))
            logData.subMode = CStr(row("Sub Mode"))
            logData.band = CStr(row("Band"))
            logData.myRST = CInt(row("RST - His"))
            logData.hisRST = CInt(row("RST - Mine"))
            logData.myOperation = CStr(row("Operation - Mine"))
            logData.contactOperation = CStr(row("Operation - His"))

            Dim logDate As DateTime = CType(row("Date"), DateTime)
            logData.myDate = logDate.ToShortDateString
            Dim logTime As DateTime = CType(row("Time"), DateTime)
            logData.myTime = logTime.ToShortTimeString
        Catch ex As Exception
            logData.validData = False
            Dim errorMsg = "An error occurred when when attempting to convert " &
            "read DataTable into logdata array" &
            Chr(10) & Chr(13) & "Error: " & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try

        Return logData
    End Function

End Class
