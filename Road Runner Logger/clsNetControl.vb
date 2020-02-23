Public Class clsNetControl
    Inherits clsDatabase

    Public Shared _instance As New clsNetControl

    Public Shared Function GetInstance(strLabel As String) As clsNetControl
        Try
            If IsNothing(_instance) Then
                _instance = New clsNetControl()
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
