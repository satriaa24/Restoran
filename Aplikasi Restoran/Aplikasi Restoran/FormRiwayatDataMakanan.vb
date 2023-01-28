Imports System.Data.SqlClient
Public Class FormRiwayatDataMakanan
    Public Sub koneksi()
        str = "data source=DESKTOP-8TK8LD1\SQLEXPRESS01;initial catalog=db_restoran;integrated security=true;MultipleActiveResultSets=True"
        CONN = New SqlConnection(str)
        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub TampilGrid()
        DA = New SqlDataAdapter("select * from tbl_datamakanan", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        'DGV.Columns(0).Width = 60
        'DGV.Columns(1).Width = 125
        'DGV.Columns(2).Width = 120
        'DGV.Columns(3).Width = 110
        'DGV.Columns(4).Width = 150

        'Me.DGV.Columns(0).HeaderText = "Kode"
        'Me.DGV.Columns(1).HeaderText = "Nama Makanan"
        'Me.DGV.Columns(2).HeaderText = "Jenis Makanan"
        'Me.DGV.Columns(3).HeaderText = "Harga"
        'Me.DGV.Columns(4).HeaderText = "Gambar"
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
    Private Sub FormRiwayatDataMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call layarpenuh()
        Call koneksi()
        Call TampilGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
    End Sub
End Class