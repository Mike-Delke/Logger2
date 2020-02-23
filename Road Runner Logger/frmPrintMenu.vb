Public Class frmPrintMenu
    Public Property StringPass As String

    Private Sub cmdButton0_Click_1(sender As Object, e As EventArgs) Handles cmdButton0.Click

        Dim obj As New MainMenu
        obj.StringPass = lblCall.Text
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub frmPrintMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCall.Text = StringPass
    End Sub

    Private Sub cmdButton7_Click(sender As Object, e As EventArgs) Handles cmdButton7.Click

    End Sub
End Class