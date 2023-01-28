Imports System.Data.SqlClient
Public Class Login
    Sub koneksi()
        str = "data source=DESKTOP-8TK8LD1\SQLEXPRESS01;initial catalog=db_restoran;integrated security=true;MultipleActiveResultSets=True"
        CONN = New SqlConnection(str)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.Focus()
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtNama.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Data yang anda masukan belum lengkap")
            Exit Sub
        Else
            Call koneksi()
            CMD = New SqlCommand("select * from tbl_user where kode='" & txtNama.Text & "' and password='" & txtPassword.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Selamat Datang di Aplikasi Ikhsan Restoran. Untuk melanjutkan, silahkan klik OK", MsgBoxStyle.Information + MessageBoxButtons.OK, "Notifikasi")
                FormMenu.SLabel2.Text = RD!Nama
                FormMenu.SLabel4.Text = RD!Level_User
                If FormMenu.SLabel4.Text = "Administrator" Then
                    FormMenu.btnBeranda.Enabled = True
                    FormMenu.Button1.Enabled = False
                    FormMenu.Button2.Enabled = False
                    FormMenu.Button3.Enabled = False
                    FormMenu.Button4.Enabled = False
                    FormMenu.Button5.Enabled = True
                    FormMenu.Selected1.Enabled = False
                    FormMenu.Selected2.Enabled = False
                    FormMenu.Selected3.Enabled = False
                    FormMenu.Selected4.Enabled = False
                    FormMenu.Selected5.Enabled = False
                    FormMenu.Panel1.Enabled = False
                    FormMenu.Panel2.Enabled = False
                    FormMenu.Panel3.Enabled = False
                    FormMenu.Panel4.Enabled = False
                    FormMenu.Panel5.Enabled = True
                    FormMenu.PanelBeranda.Show()
                Else
                    FormMenu.btnBeranda.Enabled = True
                    FormMenu.Button1.Enabled = True
                    FormMenu.Button2.Enabled = True
                    FormMenu.Button3.Enabled = True
                    FormMenu.Button4.Enabled = True
                    FormMenu.Selected1.Enabled = True
                    FormMenu.Selected2.Enabled = True
                    FormMenu.Selected3.Enabled = True
                    FormMenu.Selected4.Enabled = True
                    FormMenu.Panel1.Enabled = True
                    FormMenu.Panel2.Enabled = True
                    FormMenu.Panel3.Enabled = True
                    FormMenu.Panel4.Enabled = True

                End If
                Call kepres()
                Call Koki()
                Call kasir()
                Call operator1()

                Me.Hide()
                FormMenu.Show()
                penunjuk()
                RD.Close()
            Else
                MsgBox("Kode atau Password salah", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

   
    Sub penunjuk()
        FormMenu.Selected1.Visible = False
        FormMenu.Selected2.Visible = False
        FormMenu.Selected3.Visible = False
        FormMenu.Selected4.Visible = False
        FormMenu.Selected5.Visible = False
        FormMenu.Selected6.Visible = False
        FormMenu.SelectBeranda.Visible = True
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Text = ""
        txtPassword.Text = ""
        txtNama.MaxLength = 30
        Call layarpenuh()
    End Sub
    Private Sub Form1_Validating(sender As Object, e As EventArgs) Handles Me.Validating
        txtNama.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtNama.Focus()
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
    Sub administrator()
        FormMenu.btnBeranda.Enabled = True
        FormMenu.Button1.Enabled = False
        FormMenu.Button2.Enabled = False
        FormMenu.Button3.Enabled = False
        FormMenu.Button4.Enabled = False
        FormMenu.Selected1.Enabled = False
        FormMenu.Selected2.Enabled = False
        FormMenu.Selected3.Enabled = False
        FormMenu.Selected4.Enabled = False
        FormMenu.Panel1.Enabled = False
        FormMenu.Panel2.Enabled = False
        FormMenu.Panel3.Enabled = False
        FormMenu.Panel4.Enabled = False
        FormMenu.PanelBeranda.Show()
        FormMenu.Panel5.Show()
    End Sub
    Sub operator1()
        If FormMenu.SLabel4.Text = "Operator" Then
            FormMenu.btnBeranda.Enabled = True
            FormMenu.Button2.Enabled = False
            FormMenu.Button3.Enabled = False
            FormMenu.Button4.Enabled = False
            FormMenu.Button5.Enabled = False
            FormMenu.Selected2.Enabled = False
            FormMenu.Selected3.Enabled = False
            FormMenu.Selected4.Enabled = False
            FormMenu.Selected5.Enabled = False
            FormMenu.Panel2.Enabled = False
            FormMenu.Panel3.Enabled = False
            FormMenu.Panel4.Enabled = False
            FormMenu.Panel5.Enabled = False
            FormMenu.PanelBeranda.Show()
            FormMenu.Panel1.Show()
        End If
    End Sub
    Sub kepres()
        If FormMenu.SLabel4.Text = "Kepala Restoran" Then
            FormMenu.btnBeranda.Enabled = True
            FormMenu.Button1.Enabled = False
            FormMenu.Button2.Enabled = False
            FormMenu.Button3.Enabled = False
            FormMenu.Button5.Enabled = False
            FormMenu.Selected1.Enabled = False
            FormMenu.Selected2.Enabled = False
            FormMenu.Selected3.Enabled = False
            FormMenu.Selected5.Enabled = False
            FormMenu.Panel1.Enabled = False
            FormMenu.Panel2.Enabled = False
            FormMenu.Panel3.Enabled = False
            FormMenu.Panel5.Enabled = False
            FormMenu.PanelBeranda.Show()
            FormMenu.Panel4.Show()
        End If
    End Sub
    Sub Koki()
        If FormMenu.SLabel4.Text = "Koki" Then
            FormMenu.btnBeranda.Enabled = True
            FormMenu.Button1.Enabled = False
            FormMenu.Button2.Enabled = False
            FormMenu.Button4.Enabled = False
            FormMenu.Button5.Enabled = False
            FormMenu.Selected1.Enabled = False
            FormMenu.Selected2.Enabled = False
            FormMenu.Selected4.Enabled = False
            FormMenu.Selected5.Enabled = False
            FormMenu.Panel1.Enabled = False
            FormMenu.Panel2.Enabled = False
            FormMenu.Panel4.Enabled = False
            FormMenu.Panel5.Enabled = False
            FormMenu.PanelBeranda.Show()
            FormMenu.Panel3.Show()
        End If
    End Sub
    Sub kasir()
        If FormMenu.SLabel4.Text = "Kasir" Then
            FormMenu.btnBeranda.Enabled = True
            FormMenu.Button1.Enabled = False
            FormMenu.Button3.Enabled = False
            FormMenu.Button4.Enabled = False
            FormMenu.Button5.Enabled = False
            FormMenu.Selected1.Enabled = False
            FormMenu.Selected3.Enabled = False
            FormMenu.Selected4.Enabled = False
            FormMenu.Selected5.Enabled = False
            FormMenu.Panel1.Enabled = False
            FormMenu.Panel3.Enabled = False
            FormMenu.Panel4.Enabled = False
            FormMenu.Panel5.Enabled = False
            FormMenu.PanelBeranda.Show()
            FormMenu.Panel2.Show()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class