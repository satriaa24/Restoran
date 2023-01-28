Imports System.Data.SqlClient

Public Class FormInputBooking
    Dim tgl As String
    Dim jam As String
    Sub koneksi()
        str = "data source=DESKTOP-8TK8LD1\SQLEXPRESS01;initial catalog=db_restoran;integrated security=true;MultipleActiveResultSets=True"
        CONN = New SqlConnection(str)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub TampilGrid()
        Call koneksi()
        DA = New SqlDataAdapter("select no_booking as no_booking, nama_pengunjung as nama_pengunjung, nomor_telepon as nomor_telepon, tanggal_booking as tanggal_booking, jam as jam From tbl_booking", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_booking")
        DataGridView1.DataSource = DS.Tables("tbl_booking")
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 97
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
        nomor()
    End Sub
    Sub Awal()
        koneksi()
        DA = New SqlDataAdapter("Select * from tbl_booking", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_booking")
        DataGridView1.DataSource = (DS.Tables("tbl_booking"))
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Sub nomor()
        Dim DR As DataRow
        Dim angka As String

        DR = sqltable("select max(right(no_booking,3)) as nomor from tbl_booking").Rows(0)
        If DR.IsNull("Nomor") Then
            angka = "BK001"
        Else
            angka = "BK" & Format(DR("Nomor") + 1, "000")
        End If

        TextBox1.Text = angka
        TextBox1.Enabled = False
        TextBox2.Focus()
    End Sub
    Sub jumlahdata()
        Dim jumlahdata
        jumlahdata = DataGridView1.RowCount
        Label10.Text = jumlahdata - 1
    End Sub
    Private Sub FormInputBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Awal()
        TampilGrid()
        jumlahdata()
        Call layarpenuh()
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

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call koneksi()
            Dim tgl As String
            Dim jam As String
            tgl = Format(DTP.Value, "yyyy-MM-dd")
            jam = Format(DTP2.Value, "HH\:mm\:ss")
            Dim simpan As String = "insert into tbl_booking values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & tgl & "','" & jam & "')"
            CMD = New SqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Call Awal()
            Call jumlahdata()
            Call TampilGrid()
        End If
    End Sub
    Sub clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clear()
        nomor()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Call koneksi()
        CMD = New SqlCommand("Select * from tbl_booking where nama_pengunjung Like '%" & TextBox4.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call koneksi()
            DA = New SqlDataAdapter("Select * from tbl_booking where nama_pengunjung Like '%" & TextBox4.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "KetemuData")
            DataGridView1.DataSource = DS.Tables("KetemuData")
            DataGridView1.ReadOnly = True
            RD.Close()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.MaxLength = 15
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap !")
            Exit Sub
        Else
            Call koneksi()
            Dim hapus As String = "delete from tbl_booking where no_booking='" & TextBox1.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            If MsgBox("Apakah Ingin Menghapus Data?", MsgBoxStyle.YesNoCancel + vbQuestion) = vbYes Then
                MsgBox("Data Berhasil Di Hapus")
                Call clear()
                Call jumlahdata()
                TampilGrid()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim tgl As String
        Dim jam As String
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum tersedia", MsgBoxStyle.Critical)
        Else
            Dim edit As String
            Dim tgl As String
            Dim jam As String
            tgl = Format(DTP.Value, "yyyy-MM-dd")
            jam = Format(DTP2.Value, "HH\: mm\:ss")
            edit = "Update tbl_booking set nama_pengunjung= '" & TextBox2.Text & "', nomor_telepon ='" & TextBox3.Text & "',tanggal_booking='" & tgl & "', jam ='" & jam & "' where no_booking='" & TextBox1.Text & "'"
            CMD = New SqlCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("data sudah update", MsgBoxStyle.Information)
            TampilGrid()
            clear()
        End If
    End Sub
End Class