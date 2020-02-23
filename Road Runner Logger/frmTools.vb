Public Class frmTools
    Public Property StringPass As String

    Private Sub frmTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCall.Text = StringPass
        btnRecalcBook.Visible = False
        btnBackupDatabase.Visible = True
        btnDownloadUpdates.Visible = False
        btnUpDateMaster.Visible = False


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click

        'Dim obj As New MainMenu
        'obj.StringPass = lblCall.Text
        'obj.Show()
        Me.Hide()

    End Sub


    Private Sub btnBackupDatabase_Click(sender As Object, e As EventArgs) Handles btnBackupDatabase.Click

        btnDownloadUpdates.Visible = True
        btnRecalcBook.Visible = True

    End Sub

    Private Sub btnDownloadUpdates_Click(sender As Object, e As EventArgs) Handles btnDownloadUpdates.Click

        btnUpDateMaster.Visible = True

    End Sub


End Class