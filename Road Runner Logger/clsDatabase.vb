Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.IO

Public Class clsDatabase

    Private _databaseConnection As New OleDbConnection

    Private _strExtension As String = ".mdb"
    Private _strBaseProviderString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source="

    ' Use the following whenupgrading Access
    'Private _strExtension As String = ".accdb"
    'Private _strBaseProviderString As String = "Provider = Microsoft.Ace.OLEDB.12.0; Data Source="

    Protected _strFilename As String
    Protected _strFullFileName As String
    Protected _blnDatabaseOpen As Boolean = False

    Public ReadOnly Property Filename() As String
        Get
            Filename = _strFilename
        End Get
    End Property

    Public ReadOnly Property FullFilename() As String
        Get
            FullFilename = _strFullFileName
        End Get
    End Property

    Public ReadOnly Property DatabaseOpen() As Boolean
        Get
            DatabaseOpen = _blnDatabaseOpen
        End Get
    End Property

    Public Function Open(strPath As String, strFilename As String) As Boolean
        Dim boolFlag As Boolean = False

        Dim strTempFileName = strPath & strFilename & _strExtension
        Dim blnGoOn As Boolean = True

        If _blnDatabaseOpen Then
            blnGoOn = False
            If strTempFileName = _strFullFileName Then
                MsgBox("You are attempting to open the same database a second time. " &
                        "You shpild be attempting this. You might consider removing " &
                        "the second attempt. This requested will be ignored.", vbCritical)
            Else
                MsgBox("You are attempting to open a database that is already open using a different name. " &
                       "The database " & _strFullFileName & " is already open and cannot be opened again using " &
                       "the name " & _strFullFileName, vbCritical)
            End If
        End If

        If blnGoOn Then
            ' Save flle name
            _strFilename = strFilename
            _strFullFileName = strTempFileName

            ' Determine if the database exists
            If File.Exists(_strFullFileName) Then
                Dim connectionString = _strBaseProviderString & _strFullFileName

                ' Actual open database
                Try
                    _databaseConnection.ConnectionString = connectionString
                    _databaseConnection.Open()
                    boolFlag = True
                    _blnDatabaseOpen = True
                Catch ex As Exception
                    Dim errorMsg = "The database " & _strFullFileName & " could not be opened. " &
                                   Chr(10) & Chr(13) & "Error: " & ex.Message &
                                   Chr(10) & Chr(13) & "Logger will end. "
                    MsgBox(errorMsg, vbCritical)
                End Try
            Else
                Dim errorMsg = "The file " & _strFullFileName & " could not be found. Logger will end. "
                MsgBox(errorMsg, vbCritical)
            End If
        End If
        Return boolFlag
    End Function

    Public Sub Close()
        _databaseConnection.Close()
    End Sub

    Public Function Read(strSql As String) As DataTable
        Dim dataAdapter As New OleDbDataAdapter
        Dim dataTable As New DataTable

        Try
            dataAdapter = New OleDbDataAdapter(strSql, _databaseConnection)
            ' Get data table from Access
            dataAdapter.Fill(dataTable)
        Catch ex As Exception
            Dim errorMsg = "An error occurred when using the following SQL to extract " &
                " from the " & _strFilename & Chr(10) & Chr(13) & strSql &
                Chr(10) & Chr(13) & "Error: " & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try
        Return dataTable
    End Function

    Public Function Write(strSql As String) As Boolean
        Dim boolFlag = True

        Try
            Dim cmd As OleDbCommand = New OleDbCommand(strSql, _databaseConnection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            Dim errorMsg As String = "Error writing data to the " & _strFilename & " database using " & Chr(10) & Chr(13) & " SQL=" &
                strSql & Chr(10) & Chr(13) & "Reported Error=" & ex.Message
            MsgBox(errorMsg, vbCritical)
        End Try

        Return boolFlag
    End Function

    Public Function CleanQuotes(strValue As String) As String
        Dim strNewValue = strValue
        If String.IsNullOrEmpty(strValue) Then
            strNewValue = ""
        Else
            strNewValue = strValue.Replace("'", "''")
        End If
        Return strNewValue
    End Function

    Public Function GetNextIndex(table As String, column As String) As Integer
        Dim strSql As String = "SELECT MAX([" & column & "]) as highestIndex FROM [" & table & "]"
        Dim dataTable As DataTable = Read(strSql)
        Dim row As DataRow = dataTable.Rows(0)
        Dim highestIndex As Integer = CInt(row("highestIndex"))
        Dim nextIndex As Integer = highestIndex + 1
        Return nextIndex
    End Function
End Class
