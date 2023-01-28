Imports System.Data.SqlClient
Public Class FormUser
    Sub koneksi()
        str = "data source=DESKTOP-8TK8LD1\SQLEXPRESS01;initial catalog=db_restoran;integrated security=SSPI;Persist Security Info=True;MultipleActiveResultSets=True"
        CONN = New SqlConnection(str)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub TampilGrid()
        Call koneksi()
        DA = New SqlDataAdapter("select kode as kode,nama as nama,password as password, level_user as level From tbl_user", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_user")
        DataGridView1.DataSource = DS.Tables("tbl_user")
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 90
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

    End Sub
    Sub Pilihan()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Operator")
        ComboBox1.Items.Add("Kasir")
        ComboBox1.Items.Add("Koki")
        ComboBox1.Items.Add("Kepala Restoran")
        ComboBox1.Items.Add("Administrator")
    End Sub
    Sub layapenuh()
        Dim x, y, h, w As Integer
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        x = Windows.Forms.Screen.PrimaryScreen.Bounds.X
        y = Windows.Forms.Screen.PrimaryScreen.Bounds.Y
        h = Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        w = Windows.Forms.Screen.PrimaryScreen.Bounds.Width

        Me.SetBounds(x, y, w, h)
        Me.MaximizeBox = False
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Pilihan()
        Call TampilGrid()
        Call KondisiAwal()
        Call layapenuh()

    End Sub
    Sub KondisiAwal()
        koneksi()
        DA = New SqlDataAdapter("Select * from tbl_user", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_user")
        DataGridView1.DataSource = (DS.Tables("tbl_user"))
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbl_user values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            CMD = New SqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Dim edit As String = "update tbl_user set nama='" & TextBox2.Text & "', password='" & TextBox3.Text & "',level_user='" & ComboBox1.Text & "' where kode='" & TextBox1.Text & "'"
            CMD = New SqlCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Edit", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call koneksi()
        Dim dgv As Integer
        dgv = DataGridView1.CurrentRow.Index
        CMD = New SqlCommand("Select * from tbl_user where kode='" & DataGridView1.Item(0, dgv).Value & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            TextBox1.Focus()
        Else
            TextBox1.Text = RD.Item("Kode")
            TextBox2.Text = RD.Item("Nama")
            TextBox3.Text = RD.Item("Password")
            ComboBox1.Text = RD.Item("Level_User")
            TextBox1.Focus()
            RD.Close()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call koneksi()
            Dim hapus As String = "delete from tbl_user where kode='" & TextBox1.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "Information")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Call koneksi()
        CMD = New SqlCommand("Select * from tbl_user where kode Like '%" & TextBox4.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call koneksi()
            DA = New SqlDataAdapter("Select * from tbl_user where kode Like '%" & TextBox4.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "KetemuData")
            DataGridView1.DataSource = DS.Tables("KetemuData")
            DataGridView1.ReadOnly = True
            RD.Close()
        End If
    End Sub
End Class