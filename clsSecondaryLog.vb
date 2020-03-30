Public Class clsSecondaryLog
    Inherits clsLog

    Public Shared _instance As New clsSecondaryLog

    Public Shared Function GetInstance(strLabel As String) As clsSecondaryLog
        Try
            If IsNothing(_instance) Then
                _instance = New clsSecondaryLog()
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
End Class
