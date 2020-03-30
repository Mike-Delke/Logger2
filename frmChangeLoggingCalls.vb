Public Class frmChangeLoggingCalls
    Private Sub txtCall1_TextChanged(sender As Object, e As EventArgs) Handles txtCall1.TextChanged
        txtCall1.Text = UCase(txtCall1.Text)
        txtCall1.SelectionStart = txtCall1.Text.Length
    End Sub

    Private Sub txtCall2_TextChanged(sender As Object, e As EventArgs) Handles txtCall2.TextChanged
        txtCall2.Text = UCase(txtCall2.Text)
        txtCall2.SelectionStart = txtCall2.Text.Length
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DialogResult = DialogResult.OK
    End Sub
End Class