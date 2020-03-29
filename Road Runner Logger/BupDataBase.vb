Public Class BupDataBase

    Public Function GenerateSequentialFileName(ByVal strPath As String,
                                                ByVal strBaseName As String,
                                                ByVal strExtension As String,
                                                Optional ByVal intMinSequence As Object = 1,
                                                Optional ByVal strSeparator As String = "-BACKUP-",
                                                Optional ByVal byteFormatDigits As Object = 4) As String

        'THIS FUNCTION RETURNS THE NEXT FILE NAME IN SEQUENCE, USING A SCHEME WHERE A SEQUENTIAL NUMBER IS ADDED TO THE FILE NAME BEFORE THE EXTENSION
        'IF FILE NUMBERS ARE MISSING IN SEQUENCE THE FUNCTION RETURNS THE NEXT ONE AFTER THE CURRENT HIGHEST NUMBER
        'USAGE EXAMPLE: GENERATEsEQUENTIALfILEnAME("C:\RRLOGGER DATA\","COUNTY HUNTER - K8EMS","MDB",1,"-BACKUP-",4) THIS WOULD
        'GENERATE A FILE NAME FORMATTED LIKE  "C:\RRLOGGER DATA\COUNTY HUNTER - K8EMS-BACKUP-0001.MDB"
        'PARAMETERS:
        ' strPath: FULL PATH NAME INCLUDING SLASH
        ' strBaseName: FILENAME
        ' strExtension: FILE EXTENSION WITH NO DOT(.)
        ' intMinSequence: STARTING SEQUENCE NUMBER, USED IF NO FILES ALREADY EXSIST (OPTIONAL, DEFAULT 1)
        ' strSeparator: STRING USED BETWEEN THE BASE FILE NAME AND THE NUMBER (OPTIONAL DEFAULT IS '-BACKUP-')
        ' byteFormatDigits: NUMBER OF DIGITS TO FORMAT THE NUMBER TO (OPTIONAL DEFAULT IS 4)
        ' THIS CODE WAS FOUND ON UTTERACCESS.COM WRITTEN BY CLIPPIT

        On Error GoTo ErrorHandler
        Dim strFilePattern As String
        Dim strThisFile As String
        Dim intMaxSequenceNumberFound As Integer
        Dim intSequenceNumber As Integer
        Dim strNumberPlusPart As String
        Dim strNumberPart As String

        intMaxSequenceNumberFound = -1

        strFilePattern = strPath & strBaseName & strSeparator & "*" & "." & strExtension
        strThisFile = Dir(strFilePattern) ' get the first file matching the pattern
        Do Until strThisFile = "" ' loop thru all files matching the pattern
            ' parse the file name to find the sequence number if there is one
            strNumberPlusPart = Mid(strThisFile, Len(strBaseName & strSeparator) + 1, 99)
            If Len(strNumberPlusPart) = Len("." & strExtension) Then
                strNumberPart = ""
            Else
                strNumberPart = Left(strNumberPlusPart, Len(strNumberPlusPart) - Len("." & strExtension))
            End If
            If IsNumeric(strNumberPart) Then
                If Val(strNumberPart) > intMaxSequenceNumberFound Then
                    intMaxSequenceNumberFound = CInt(Val(strNumberPart))
                End If
            End If
            strThisFile = Dir() ' get the next file matching the pattern
        Loop

        If intMaxSequenceNumberFound = -1 Then  ' -1 indicates no files were found
            intSequenceNumber = CInt(intMinSequence)
        Else
            intSequenceNumber = intMaxSequenceNumberFound + 1

        End If

        GenerateSequentialFileName = strPath & strBaseName & strSeparator &
            Format(intSequenceNumber, Left("000000", CInt(byteFormatDigits))) & "." & strExtension


ErrorHandler:
        Debug.Print("Function GenerateSequencialFileName encountered error" & Err.Description & "(#" & Err.Number & ")")
        On Error Resume Next
        GenerateSequentialFileName = ""


        BackupDB()

    End Function


    Public Sub BackupDB()
        Dim sSourceFile As String
        Const sPath = "C:\RRLogger Data\"
        Const sFilename = "County Hunter - K8EMS"
        Const sExtension = "mdb"
        Const sSeparator = "-Logger Two BACKUP-"

        sSourceFile = sPath & sFilename & "." & sExtension
        FileCopy(sSourceFile, GenerateSequentialFileName(sPath, sFilename, sExtension, 1, sSeparator, 4))
    End Sub
End Class
