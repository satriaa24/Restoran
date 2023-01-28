Imports System.Data.SqlClient
Public Class FormDataMasakan
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
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
    Private Sub FormDataMasakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call layarpenuh()
        Call koneksi()
        Call TampilGrid()
        TextBox1.Text = ""
        Label7.Text = ""
    End Sub
    Sub TampilGrid()
        DA = New SqlDataAdapter("select * from tbl_makanan", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        DGV.Columns(3).DefaultCellStyle.Format = "Rp ##,###,###"
        DGV.Columns(0).Width = 60
        DGV.Columns(1).Width = 125
        DGV.Columns(2).Width = 120
        DGV.Columns(3).Width = 110
        DGV.Columns(4).Width = 150

        Me.DGV.Columns(0).HeaderText = "Kode"
        Me.DGV.Columns(1).HeaderText = "Nama Makanan"
        Me.DGV.Columns(2).HeaderText = "Jenis Makanan"
        Me.DGV.Columns(3).HeaderText = "Harga"
        Me.DGV.Columns(4).HeaderText = "Gambar"

    End Sub
    Sub nomor()
        Dim DR As DataRow
        Dim s As String
        DR = sqltable("select max(right(no,1)) as no from tbl_makanan").Rows(0)
        If DR.IsNull("no") Then
            s = "MKN-1"
        Else
            s = "MKN-" & Format(DR("no") + 1, "0")
        End If
        TextBox1.Text = s
        TextBox1.Enabled = False
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        Label7.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        PictureBox1.ImageLocation = Label7.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs)
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class