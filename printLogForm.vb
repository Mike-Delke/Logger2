Imports CrystalDecisions.CrystalReports.Engine

Public Class printLogForm
    Private Sub printLogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\RRLogger Data\Crystal_Reports\Net Control.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class