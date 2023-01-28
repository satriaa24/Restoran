Imports System.Data.SqlClient
Public Class FormDataBooking
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
    Sub tampildatabooking()
        koneksi()
        DA = New SqlDataAdapter("select * from tbl_booking order by no_booking", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_booking")
        ComboBox1.DataSource = (DS.Tables("tbl_booking"))
        ComboBox1.ValueMember = "no_booking"

    End Sub
    'Sub tampildata()
    '    koneksi()
    '    DA = New SqlDataAdapter("select * from tbl_booking order by no_booking", CONN)
    '    DS = New DataSet
    '    DS.Clear()
    '    DA.Fill(DS, "tbl_booking")
    '    DataGridView1.DataSource = (DS.Tables("tbl_booking"))
    'End Sub
    Sub clear()
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

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
    Private Sub FormDataBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call layarpenuh()
        tampildatabooking()
        clear()
        TampilGrid()

        TextBox3.Text = "00:00:00"
        'TextBox4.Text = "00:00:00"
        TextBox5.Text = "0:00:0"

    End Sub
    Sub alarm()
        On Error Resume Next
        Dim conf As Object
        Dim hasil As TimeSpan = TimeValue(TextBox3.Text) - TimeValue(TextBox4.Text)
        TextBox5.Text = (String.Format("{0}:{1}:{2}", hasil.Hours, hasil.Minutes, hasil.Seconds))

        If TextBox5.Text > "0:30:00" Then
            MsgBox("Maaf Bokingan anda tidak bisa dilakukan karena sisa booking anda: " & TextBox5.Text & "", vbCritical)
            TextBox5.Text = ""
            Exit Sub
        ElseIf TextBox5.Text < "0:00:00" Then
            MsgBox("Maaf Bokingan anda tidak bisa dilakukan karena jam booking sudah selesai", vbCritical)
            TextBox5.Text = ""
            Exit Sub
        Else
            conf = MsgBox("Sisa Booking Anda: " & TextBox5.Text & " ,Apakah anda ingin konfirmasi?", MessageBoxButtons.YesNoCancel, vbQuestion)
            If conf = Windows.Forms.DialogResult.Yes Then
                MsgBox("Konfirmasi Berhasil!", MsgBoxStyle.Information, "Notifikasi")
                TextBox6.Text = "Sudah DiKonfirmasi"
            ElseIf conf = Windows.Forms.DialogResult.No Then
                MsgBox("Anda Belum Konfirmasi", MsgBoxStyle.Critical, "Notifikasi")
                'TextBox6.Text = "BelumDikonfirmasi"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call alarm()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox4.Text = TimeOfDay
    End Sub
    Sub TampilGrid()
        Call koneksi()
        DA = New SqlDataAdapter("select no as no, nama as nama, tanggal as tanggal, jam as jam, sisa_menit as sisa_menit, konfirmasi as konfirmasi From tbl_databooking", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_databooking")
        DataGridView1.DataSource = DS.Tables("tbl_databooking")
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        DateTimePicker1.Value = Today
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormMenu.Show()
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call koneksi()
            Dim tgl As String
            Dim jam As String
            tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            jam = Format(TextBox3.Text, "HH\:mm\:ss")
            Dim simpan As String = "insert into tbl_databooking values ('" & ComboBox1.Text & "','" & TextBox2.Text & "','" & tgl & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            CMD = New SqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            TampilGrid()
            clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call koneksi()
            Dim hapus As String = "delete from tbl_databooking where no='" & ComboBox1.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            If MsgBox("Apakah Ingin Menghapus Data?", MsgBoxStyle.YesNoCancel + vbQuestion) = vbYes Then
                MsgBox("Data Berhasil Di Hapus")
                TampilGrid()
                clear()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Dim edit As String
            Dim tgl As String
            Dim jam As String
            tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            edit = "Update tbl_databooking set nama= '" & TextBox2.Text & "', tanggal ='" & tgl & "',jam='" & TextBox3.Text & "',sisa_menit='" & TextBox5.Text & "',konfirmasi='" & TextBox6.Text & "' where no='" & ComboBox1.Text & "'"
            CMD = New SqlCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("data sudah update", MsgBoxStyle.Information)
            TampilGrid()
            clear()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim tgl As String
        tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd")

        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        tgl = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        koneksi()
        CMD = New SqlCommand("Select * from tbl_booking where no_booking='" & ComboBox1.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBox2.Text = RD.Item("nama_pengunjung")
            TextBox3.Text = RD.Item("jam").ToString
            DateTimePicker1.Value = RD.Item("tanggal_booking").ToString

        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class