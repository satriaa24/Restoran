Public Class messagebox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As String
        clear()
        Me.Hide()
        FormMenu.Hide()
        b = "Terimakasih " & FormMenu.SLabel2.Text & " Telah Melakukan Login"
        MsgBox(b, MsgBoxStyle.Information, "Notifikasi")
        penunjuk()
        Login.Show()
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
    Sub clear()
        Login.txtNama.Text = ""
        Login.txtPassword.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
        FormMenu.Hide()
        Me.Hide()
        MsgBox("Terimakasih Telah Menggunakan Aplikasi Kami", MsgBoxStyle.Information, "Notifikasi")
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub messagebox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class