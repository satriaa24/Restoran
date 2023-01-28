Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FormGantiPassword

    Private Sub FormGantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call layarpenuh()
        TextBox2.Enabled = False
        TextBox3.Enabled = False
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
    Sub koneksi()
        str = "data source=DESKTOP-8TK8LD1\SQLEXPRESS01;initial catalog=db_restoran;integrated security=SSPI;Persist Security Info=True;MultipleActiveResultSets=True"
        CONN = New SqlConnection(str)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New SqlCommand("select * from tbl_user where nama='" & FormMenu.SLabel2.Text & "' and password='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If RD.HasRows Then
                TextBox2.Enabled = True
                TextBox3.Enabled = True
            Else
                MsgBox("Password Anda Salah! Mohon Diisi Dengan Benar")
                TextBox1.Text = ""
            End If
            RD.Close()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        clear()
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnGanti_Click(sender As Object, e As EventArgs) Handles btnGanti.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Mohon Password Diisi Dengan Benar")
        Else
            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password Baru dan Konfirmasi Password Harus Sama!", vbCritical)
            Else
                Dim update As String = "update tbl_user set password='" & TextBox3.Text & "' where nama='" & FormMenu.SLabel2.Text & "'"
                CMD = New SqlCommand(update, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Password Berhasil Diubah", MsgBoxStyle.Information, "Information")
                clear()
            End If
        End If
    End Sub
End Class