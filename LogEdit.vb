Public Class LogEdit
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnViewEdit_Click(sender As Object, e As EventArgs) Handles btnViewEdit.Click

        ViewEdit.Show()
        Me.Close()

    End Sub
End Class