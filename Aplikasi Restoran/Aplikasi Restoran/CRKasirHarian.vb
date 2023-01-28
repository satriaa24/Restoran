Public Class CRKasirHarian
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CrystalReportViewer1.SelectionFormula = "totext({tbl_kasir.tanggal})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
        Me.CrystalReportViewer1.ReportSource = "LaporanKasirHarian.rpt"
        Me.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
        Refresh()
    End Sub
End Class