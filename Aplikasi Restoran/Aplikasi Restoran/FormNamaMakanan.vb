Imports System.Data
Imports System.Data.SqlClient
Public Class FormNamaMakanan
    Dim kodesd
    Public Sub koneksi()
        str = "data source=DESKTOP-8TK8LD1\SQLEXPRESS01;initial catalog=db_restoran;integrated security=SSPI;Persist Security Info=True;MultipleActiveResultSets=True"
        CONN = New SqlConnection(str)
        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
        End Try
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Focus()
        Call koneksi()
        Call TampilGrid()
        Call layarpenuh()

        Label7.Text = ""
        TextBox2.Focus()
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

    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
        Label7.Text = ""
        PictureBox1.ImageLocation = ""

        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
    End Sub
    Sub Ketemu()
        On Error Resume Next
        TextBox2.Text = RD.Item("nama_masakan")
        ComboBox1.Text = RD.Item("jenis_masakan")
        TextBox3.Text = RD.Item("harga")

        TextBox1.Focus()
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
        nomor()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or Me.ComboBox1.Text = "" Or Me.TextBox3.Text = "" Or Me.Label7.Text = "" Then
            MsgBox("Maaf Data Anda Belum Lengkap", MsgBoxStyle.Information)
        Else
            Dim simpan As String
            simpan = "insert into tbl_makanan values('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.ComboBox1.Text & "','" & Me.TextBox3.Text & "','" & Me.Label7.Text & "')"
            CMD = New SqlCommand(simpan, CONN) ' untuk menghubungkan ke database dan table lalu simpan
            CMD.ExecuteNonQuery() ' mengeksekusi datanya
            MsgBox("Data anda akan disimpan ")
            TampilGrid()
            bersih()
            nomor()
        End If
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        DA = New SqlDataAdapter("select * from tbl_makanan where no like '%" & Me.TextBox5.Text & "%'", CONN)
        DS = New DataSet
        ' ds.Clear()
        DA.Fill(DS, "tbl_makanan")
        DGV.DataSource = (DS.Tables("tbl_makanan"))
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or Me.Label7.Text = "" Then
            MsgBox(" Maaf data tidak ter-update")
        Else
            Dim edit As String
            edit = "update tbl_makanan set nama_makanan = '" & Me.TextBox2.Text & "',jenis_makanan ='" & Me.ComboBox1.Text & "',harga = '" & Me.TextBox3.Text & "' ,urlgambar='" & Me.Label7.Text & "' where no = '" & Me.TextBox1.Text & "'"
            CMD = New SqlCommand(edit, CONN) ' untuk menghubungkan ke database dan table lalu update
            CMD.ExecuteNonQuery() ' mengeksekusi datanya
            MsgBox("Proses update data telah berhasil", MsgBoxStyle.Information)
            bersih()
            nomor()
            TampilGrid()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or Me.Label7.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call koneksi()
            Dim hapus As String = "delete from tbl_makanan where no ='" & TextBox1.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            If MsgBox("Apakah Ingin Menghapus Data?", MsgBoxStyle.YesNoCancel + vbQuestion) = vbYes Then
                MsgBox("Data Berhasil Di Hapus")
                Call bersih()
                nomor()
                TampilGrid()
            End If
        End If
    End Sub
    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs)
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGV.Rows.Remove(DGV.CurrentRow)
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bersih()
        nomor()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
    End Sub
    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        Label7.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        PictureBox1.ImageLocation = Label7.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        Me.Button1.Enabled = False
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OpenFileDialog1.Filter = "*.jpg|"
        OpenFileDialog1.ShowDialog()
        Label7.Text = OpenFileDialog1.FileName
        PictureBox1.ImageLocation = Label7.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class