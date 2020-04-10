Imports System.IO

Public Class frmTools
    Private sFilename As String
    Private SourceFile As String
    Private fileexsist As Boolean
    Private I As Integer
    Public Property StringPass As String

    Private Sub frmTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCall.Text = StringPass
        btnRecalcBook.Visible = False
        btnBackupDatabase.Visible = True
        btnDownloadUpdates.Visible = False
        btnUpDateMaster.Visible = False


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click


        Me.Hide()

    End Sub

    Private Sub BtnBackupDatabase_Click(sender As Object, e As EventArgs) Handles btnBackupDatabase.Click


        GetNextUserBackup("C:\RRLogger Data\County Hunter - K8EMS.mdb")

        GetnextCommonBackUp("C:\RRLogger Data\County Hunters - Common.mdb")

        btnDownloadUpdates.Visible = True
        btnUpDateMaster.Visible = True

    End Sub

    Private Sub btnDownloadUpdates_Click(sender As Object, e As EventArgs) Handles btnDownloadUpdates.Click

        btnUpDateMaster.Visible = True

    End Sub

    Private Sub btnPrintLog_Click(sender As Object, e As EventArgs) Handles btnPrintLog.Click




    End Sub



    Public Function GetNextUserBackup(strFileFullPath As String) As String
        'Dim aFile As String
        Dim strF As String
        Dim i As Integer = 0
        'Dim fullPath As String


        'strFileFullPath = "c:\RRLogger Data\County Hunter - K8EMS.mdb"  <------------------------This is file I am copying
        ' ("c:\RRLogger Data\County Hunter - K8EMS-RRLog-Bup#.mdb") <----------------------This is the file that is written

        ' check if file already exist - start increamnt -N to file name
        Do
            If i = 0 Then
                strF = strFileFullPath
            Else
                strF = Path.GetDirectoryName(strFileFullPath) & "\" & Path.GetFileNameWithoutExtension(strFileFullPath) & "-RRLog-Bup-" & i & Path.GetExtension(strFileFullPath)
                'strF = Path.GetFileNameWithoutExtension(strFileFullPath) & "-RRLog-Bup-" & i & Path.GetExtension(strFileFullPath)
            End If
            If File.Exists(strF) = False Then
                Exit Do
            End If
            i = i + 1
        Loop
        FileCopy(strFileFullPath, strF)
        Return strF

    End Function

    Public Function GetnextCommonBackUp(strFileFullPath As String) As String

        'Dim aFile As String
        Dim strF As String
        Dim i As Integer = 0
        'Dim fullPath As String


        'strFileFullPath = "c:\RRLogger Data\County Hunter - K8EMS.mdb"  <------------------------This is file I am copying
        ' ("c:\RRLogger Data\County Hunter - K8EMS-RRLog-Bup#.mdb") <----------------------This is the file that is written

        ' check if file already exist - start increamnt -N to file name
        Do
            If i = 0 Then
                strF = strFileFullPath
            Else
                strF = Path.GetDirectoryName(strFileFullPath) & "\" & Path.GetFileNameWithoutExtension(strFileFullPath) & "-RRLog-Bup-" & i & Path.GetExtension(strFileFullPath)
                'strF = Path.GetFileNameWithoutExtension(strFileFullPath) & "-RRLog-Bup-" & i & Path.GetExtension(strFileFullPath)
            End If
            If File.Exists(strF) = False Then
                Exit Do
            End If
            i = i + 1
        Loop
        FileCopy(strFileFullPath, strF)
        Return strF

    End Function

    Private Sub btnNetControlLog_Click(sender As Object, e As EventArgs) Handles btnNetControlLog.Click

        Dim obj As New printLogForm

        obj.Show()

    End Sub
End Class