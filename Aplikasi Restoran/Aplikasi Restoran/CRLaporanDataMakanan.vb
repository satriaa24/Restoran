Public Class CRLaporanDataMakanan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxCrystalReport1.SelectionFormula = "totext({tbl_datamakanan.tanggal_dibuat})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
        AxCrystalReport1.ReportFileName = "LaporanDataMakanan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Sub layarpenuh()
        Dim x, y, h, w As Integer
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        x = Windows.Forms.Screen.PrimaryScreen.Bounds.X
        y = Windows.Forms.Screen.PrimaryScreen.Bounds.Y
        h = Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        w = Windows.Forms.Screen.PrimaryScreen.Bounds.Width

        Me.SetBounds(x, y, w, h)
        Me.MaximizeBox = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
        Refresh()
    End Sub

    Private Sub CRLaporanDataMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call layarpenuh()
    End Sub
End Class