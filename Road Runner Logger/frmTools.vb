Imports System.IO

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






    'Try
    '    'set the destination and a file name with the date and time
    '    Dim backupfiledestination1 As String = "C:\RRLogger Data - Flynn\County Hunter - " & lblCall.Text & Format(Now(), " Md H-m ") & ".accdb"
    '    Dim backupfiledestination2 As String = "C:\RRLogger Data - Flynn\County Hunters - common" & Format(Now(), " Md H-m  ") & ".accdb"
    '    'location of the database file that you want to backup
    '    Dim databaseFile1 As String = "C:\RRLogger Data" & "\County Hunter - " & lblCall.Text & ".accdb"
    '    Dim databaseFile2 As String = "C:\RRLogger Data" & "\County Hunters - common" & ".accdb"

    '    'create a backup by using Filecopy Command to copy the file from  location to destination
    '    FileCopy(databaseFile1, backupfiledestination1)
    '    FileCopy(databaseFile2, backupfiledestination2)
    '    MsgBox("Database Backup has been Created Successfully!")


    'Catch ex As Exception
    '    'catch an error  
    '    MsgBox(ex.Message)

    'End Try

    'btnDownloadUpdates.Visible = True
    'btnRecalcBook.Visible = True
    Private Sub btnBackupDatabase_Click(sender As Object, e As EventArgs) Handles btnBackupDatabase.Click




    End Sub

    Private Sub btnDownloadUpdates_Click(sender As Object, e As EventArgs) Handles btnDownloadUpdates.Click

        btnUpDateMaster.Visible = True

    End Sub

    Private Sub btnPrintLog_Click(sender As Object, e As EventArgs) Handles btnPrintLog.Click

        Dim obj As New printLogForm
        '  obj.StringPass = _strPrimaryCall
        obj.Show()
        'Me.Hide()

    End Sub
End Class