Public Class ViewEditMenu

    Public Property StringPass As String

    Private Sub cmdButton0_Click(sender As Object, e As EventArgs) Handles cmdButton0.Click

        '    Dim obj As New MainMenu
        '    obj.StringPass = lblCall.Text
        '    obj.Show()
        Me.Hide()

    End Sub

    Private Sub ViewEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCall.Text = StringPass

    End Sub

    Private Sub cmdButton8_Click(sender As Object, e As EventArgs) Handles cmdButton8.Click

        frmMARAC.Show()
        Close()

    End Sub

    Private Sub cmdButton7_Click(sender As Object, e As EventArgs) Handles cmdButton7.Click
        'LogEdit.Show()
        Me.Close()

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        frmBook.Show()
        Me.Close()

    End Sub
End Class