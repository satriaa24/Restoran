Public Class CRLaporanUser
    Private Sub CRLaporanUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CrystalReportViewer1.ReportSource = "LaporanDataUser.rpt"
        Me.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
        Refresh()
    End Sub
End Class