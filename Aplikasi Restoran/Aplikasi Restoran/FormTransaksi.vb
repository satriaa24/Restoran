Imports System.Data.SqlClient
Public Class FormTransaksi
    Dim rd As SqlDataReader
    Dim tgl As String
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
        koneksi()
        DA = New SqlDataAdapter("select no as no, kode as kode, nama as nama, tanggal as tanggal, total as total from tbl_kasir", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
        Me.DGV.Columns(0).HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.DGV.Columns(1).HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.DGV.Columns(2).HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.DGV.Columns(3).HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.DGV.Columns(4).HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        DGV.Columns(4).DefaultCellStyle.Format = "Rp ##,###,###"
        'DGV.Columns(0).Width = 60
        'DGV.Columns(1).Width = 125
        'DGV.Columns(2).Width = 120
        'DGV.Columns(3).Width = 110
        'DGV.Columns(4).Width = 150

        Me.DGV.Columns(0).HeaderText = "No. Meja"
        Me.DGV.Columns(1).HeaderText = "Kode Booking"
        Me.DGV.Columns(2).HeaderText = "Nama"
        Me.DGV.Columns(3).HeaderText = "Tanggal"
        Me.DGV.Columns(4).HeaderText = "Total Pembelian"
        nomor()
    End Sub
    Sub muncullistbox()
        Call koneksi()
        CMD = New SqlCommand("select * from tbl_datamakanan", CONN)
        rd = CMD.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ListBox1.Items.Add(rd.Item(1).ToString & "    " & rd.Item(4).ToString)
            Loop
        End If
    End Sub
    Sub nomor()
        Dim DR As DataRow
        Dim s As String
        DR = sqltable("select max(right(no,1)) as no from tbl_kasir").Rows(0)
        If DR.IsNull("no") Then
            s = "MEJA-1"
        Else
            s = "MEJA-" & Format(DR("no") + 1, "0")
        End If
        TextBox1.Text = s
        TextBox1.Enabled = False
    End Sub
    Sub clear()
        'TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label4.Text = ""
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

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilGrid()
        nomor()
        muncullistbox()
        tampildata1()
        tampildata2()
        tampildata3()
        tampilbooking()
        Call layarpenuh()

        clear()
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
    End Sub
    Sub tampilbooking()
        koneksi()
        DA = New SqlDataAdapter("select * from tbl_booking order by no_booking", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_booking")
        ComboBox1.DataSource = (DS.Tables("tbl_booking"))
        ComboBox1.ValueMember = "no_booking"
    End Sub
    Sub tampildata1()
        koneksi()
        DA = New SqlDataAdapter("select * from tbl_datamakanan order by nama_makanan", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_datamakanan")
        ComboBox3.DataSource = (DS.Tables("tbl_datamakanan"))
        ComboBox3.ValueMember = "nama_makanan"
    End Sub
    Sub tampildata2()
        koneksi()
        DA = New SqlDataAdapter("select * from tbl_datamakanan order by nama_makanan", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_datamakanan")
        ComboBox4.DataSource = (DS.Tables("tbl_datamakanan"))
        ComboBox4.ValueMember = "nama_makanan"
    End Sub
    Sub tampildata3()
        koneksi()
        DA = New SqlDataAdapter("select * from tbl_datamakanan order by nama_makanan", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_datamakanan")
        ComboBox5.DataSource = (DS.Tables("tbl_datamakanan"))
        ComboBox5.ValueMember = "nama_makanan"
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        koneksi()
        Refresh()
        CMD = New SqlCommand("Select * from tbl_datamakanan where nama_makanan='" & ComboBox3.Text & "'", CONN)
        rd = CMD.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox7.Text = rd!harga
        End If
        rd.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clear()
        nomor()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        koneksi()
        Refresh()
        CMD = New SqlCommand("Select * from tbl_datamakanan where nama_makanan='" & ComboBox4.Text & "'", CONN)
        rd = CMD.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.TextBox8.Text = rd!harga
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        koneksi()
        Refresh()
        CMD = New SqlCommand("Select * from tbl_datamakanan where nama_makanan='" & ComboBox5.Text & "'", CONN)
        rd = CMD.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox9.Text = rd!harga
        End If
    End Sub
    Sub hitung1()
        Dim hitung As Integer
        hitung = Val(TextBox7.Text) * Val(TextBox3.Text)
        Label11.Text = hitung
    End Sub
    Sub hitung2()
        Dim hitung As Integer
        hitung = TextBox8.Text * TextBox4.Text
        Label12.Text = hitung
    End Sub
    Sub hitung3()
        Dim hitung As Integer
        hitung = TextBox9.Text * TextBox5.Text
        Label13.Text = hitung
    End Sub
    Sub hitungtotal()
        Dim total As Integer
        total = Val(Label11.Text) + Val(Label12.Text) + Val(Label13.Text)
        Label4.Text = total
    End Sub

    Private Sub TextBox3_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Call hitung1()
            ComboBox4.Focus()
        End If
    End Sub
    Private Sub TextBox4_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Call hitung2()
            ComboBox5.Focus()
        End If
    End Sub
    Private Sub TextBox5_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Call hitung3()
            Label4.Focus()
            Call hitungtotal()

        End If
    End Sub
    Sub kembalian()
        Dim kembali As Integer
        kembali = TextBox6.Text - Label4.Text
        TextBox10.Text = kembali
    End Sub
    Private Sub TextBox6_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If (e.KeyChar = Chr(13)) Then
            kembalian()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        Refresh()
        CMD = New SqlCommand("Select * from tbl_booking where no_booking='" & ComboBox1.Text & "'", CONN)
        rd = CMD.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.TextBox2.Text = rd!nama_pengunjung
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or Label4.Text = "" Then
            MsgBox("Data belum lengkap")
        Else
            Call koneksi()
            Dim tgl As String
            tgl = Format(DTP.Value, "yyyy-MM-dd")
            Dim simpan As String = "insert into tbl_kasir values ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & tgl & "','" & Label4.Text & "')"
            CMD = New SqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            clear()
            Call TampilGrid()
            nomor()

        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or Label4.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call koneksi()
            Dim hapus As String = "delete from tbl_kasir where no='" & TextBox1.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            If MsgBox("Apakah Ingin Menghapus Data?", MsgBoxStyle.YesNoCancel + vbQuestion) = vbYes Then
                MsgBox("Data Berhasil Di Hapus")
                Call clear()
                TampilGrid()
                nomor()
            End If
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum tersedia", MsgBoxStyle.Critical)
        Else
            Dim edit As String
            Dim tgl As String
            tgl = Format(DTP.Value, "yyyy-MM-dd")
            edit = "Update tbl_kasir set nama= '" & TextBox2.Text & "', kode ='" & ComboBox1.Text & "',tanggal='" & tgl & "', total ='" & Label4.Text & "' where no='" & TextBox1.Text & "'"
            CMD = New SqlCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Update", MsgBoxStyle.Information)
            TampilGrid()
            clear()
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim tgl As String
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value.ToString
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(2).Value.ToString
        tgl = DGV.Rows(e.RowIndex).Cells(3).Value.ToString
        Label4.Text = DGV.Rows(e.RowIndex).Cells(4).Value.ToString

    End Sub
End Class