Imports System.Data.SqlClient
Public Class FormDataMakanan
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
    Private Sub FormDataMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call layarpenuh()
        koneksi()
        TampilGrid()
        tampildatamakanan()
        bersih()
    End Sub
    Sub bersih()
        ComboBox2.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label9.Text = ""
        PictureBox1.ImageLocation = ""

        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
    End Sub
    Sub tampildatamakanan()
        koneksi()
        DA = New SqlDataAdapter("select * from tbl_makanan order by no", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_makanan")
        ComboBox2.DataSource = (DS.Tables("tbl_makanan"))
        ComboBox2.ValueMember = "no"
    End Sub
    Sub TampilGrid()
        DA = New SqlDataAdapter("select * from tbl_datamakanan", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        DGV.Columns(4).DefaultCellStyle.Format = "Rp ##,###,###"
        Me.DGV.Columns(0).HeaderText = "Kode"
        Me.DGV.Columns(1).HeaderText = "Nama Makanan"
        Me.DGV.Columns(2).HeaderText = "Jenis Makanan"
        Me.DGV.Columns(3).HeaderText = "Dibuat"
        Me.DGV.Columns(4).HeaderText = "Harga(Pcs)"
        Me.DGV.Columns(5).HeaderText = "Stok"
        Me.DGV.Columns(6).HeaderText = "Gambar"

        DGV.Columns(0).Width = 60
        DGV.Columns(1).Width = 90
        DGV.Columns(2).Width = 90
        DGV.Columns(3).Width = 80
        DGV.Columns(4).Width = 75
        DGV.Columns(5).Width = 50
        DGV.Columns(6).Width = 90

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ComboBox2.Text = "" Or Me.TextBox2.Text = "" Or Me.ComboBox1.Text = "" Or Me.TextBox3.Text = "" Or Me.Label9.Text = "" Then
            MsgBox(" Maaf Data Anda Belum Lengkap, Silahkan Lengkapi Kembali Input Data Anda", MsgBoxStyle.Information)
        Else
            Dim tgl As String
            tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            Dim simpan As String
            simpan = "insert into tbl_datamakanan values('" & Me.ComboBox2.Text & "','" & Me.TextBox2.Text & "','" & Me.ComboBox1.Text & "','" & tgl & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "', '" & Me.Label9.Text & "')"
            CMD = New SqlCommand(simpan, CONN) ' untuk menghubungkan ke database dan table lalu simpan
            CMD.ExecuteNonQuery() ' mengeksekusi datanya
            MsgBox("Data Anda Berhasil Disimpan ", MsgBoxStyle.Information)
            TampilGrid()
            bersih()
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        koneksi()
        Refresh()
        CMD = New SqlCommand("Select * from tbl_makanan where no='" & ComboBox2.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBox2.Text = RD!nama_makanan
            ComboBox1.Text = RD!jenis_makanan
            TextBox3.Text = RD!harga
            Label9.Text = RD!urlgambar
            PictureBox1.ImageLocation = Label9.Text
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.ComboBox2.Text = "" Or Me.TextBox2.Text = "" Or Me.ComboBox1.Text = "" Or Me.TextBox3.Text = "" Or Me.Label9.Text = "" Then
            MsgBox(" Maaf data anda belum lengkap,silahkan lengkapi kembali input data anda", MsgBoxStyle.Information)
        Else
            Dim edit As String
            edit = "update tbl_datamakanan set nama_makanan = '" & Me.TextBox2.Text & "',jenis_makanan ='" & Me.ComboBox1.Text & "',harga = '" & Me.TextBox3.Text & "',jumlah = '" & Me.TextBox4.Text & "', urlgambar = '" & Me.Label9.Text & "' where no = '" & Me.ComboBox2.Text & "'"
            CMD = New SqlCommand(edit, CONN) ' untuk menghubungkan ke database dan table lalu update
            CMD.ExecuteNonQuery() ' mengeksekusi datanya
            MsgBox("Proses update data telah berhasil", MsgBoxStyle.Information)
            bersih()
            TampilGrid()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bersih()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.ComboBox2.Text = "" Or Me.TextBox2.Text = "" Or Me.ComboBox1.Text = "" Or Me.TextBox3.Text = "" Or Me.Label9.Text = "" Then
            MsgBox(" Maaf data anda belum lengkap,silahkan lengkapi kembali input data anda", MsgBoxStyle.Information)
        Else
            Call koneksi()
            Dim hapus As String = "delete from tbl_datamakanan where no ='" & ComboBox2.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            If MsgBox("Apakah Ingin Menghapus Data?", MsgBoxStyle.YesNoCancel + vbQuestion) = vbYes Then
                MsgBox("Data Berhasil Di Hapus")
                Call bersih()
                TampilGrid()
            End If
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        ComboBox2.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        TextBox4.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        Label9.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        PictureBox1.ImageLocation = Label9.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Button1.Enabled = False
        DateTimePicker1.Enabled = False
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
    End Sub
End Class