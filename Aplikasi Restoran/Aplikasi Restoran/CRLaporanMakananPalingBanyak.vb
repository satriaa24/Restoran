Public Class CRLaporanMakananPalingBanyak

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
        Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxCrystalReport1.SelectionFormula = "totext({tbl_datamakanan.tanggal_dibuat})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
        AxCrystalReport1.ReportFileName = "LaporanMakananPalingBanyak.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class