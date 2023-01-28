Public Class FormMenu

   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Selected1.Visible = True
        Selected2.Visible = False
        Selected3.Visible = False
        Selected4.Visible = False
        Selected5.Visible = False
        Selected6.Visible = False
        SelectBeranda.Visible = False

        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        PanelBeranda.Visible = False
    End Sub

  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Selected1.Visible = False
        Selected2.Visible = True
        Selected3.Visible = False
        Selected4.Visible = False
        Selected5.Visible = False
        Selected6.Visible = False
        SelectBeranda.Visible = False

        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        PanelBeranda.Visible = False

    End Sub

   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Selected1.Visible = False
        Selected2.Visible = False
        Selected3.Visible = True
        Selected4.Visible = False
        Selected5.Visible = False
        Selected6.Visible = False
        SelectBeranda.Visible = False

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
        PanelBeranda.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Selected1.Visible = False
        Selected2.Visible = False
        Selected3.Visible = False
        Selected4.Visible = True
        Selected5.Visible = False
        Selected6.Visible = False
        SelectBeranda.Visible = False

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel5.Visible = False
        PanelBeranda.Visible = False

    End Sub

   

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Selected1.Visible = False
        Selected2.Visible = False
        Selected3.Visible = False
        Selected4.Visible = False
        Selected5.Visible = True
        Selected6.Visible = False
        SelectBeranda.Visible = False

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
        PanelBeranda.Visible = False

    End Sub

    Private Sub btnBeranda_Click(sender As Object, e As EventArgs) Handles btnBeranda.Click

        Selected1.Visible = False
        Selected2.Visible = False
        Selected3.Visible = False
        Selected4.Visible = False
        Selected5.Visible = False
        Selected6.Visible = False
        SelectBeranda.Visible = True

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        PanelBeranda.Visible = True

    End Sub
    Sub clear()
        SLabel2.Text = ""
        SLabel4.Text = ""
        Login.txtNama.Text = ""
        Login.txtPassword.Text = ""
    End Sub
    Sub Sambutan()
        Dim jam As Integer
        jam = Now.Hour
        If jam < 1 Then
            Label7.Text = "Selamat Datang dan Selamat Malam"
        ElseIf jam < 11 Then
            Label7.Text = "Selamat Datang dan Selamat Pagi"
        ElseIf jam < 15 Then
            Label7.Text = "Selamat Datang dan Selamat Siang"
        ElseIf jam < 18 Then
            Label7.Text = "Selamat Datang dan Selamat Sore"
        End If
    End Sub

   
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        messagebox.Show()
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
        Call Sambutan()
        Me.WindowState = FormWindowState.Maximized

        SLabel6.Text = Today
        Selected1.Visible = False
        Selected2.Visible = False
        Selected3.Visible = False
        Selected4.Visible = False
        Selected5.Visible = False
        Selected6.Visible = False
        SelectBeranda.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SLabel8.Text = TimeOfDay
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FormGantiPassword.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        FormGantiPassword.Show()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        FormUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        FormGantiPassword.Show()
        Me.Hide()
    End Sub
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        CRLaporanUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        FormInputBooking.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        CRLaporanBooking.Show()
        Me.Hide()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FormDataBooking.Show()
        Me.Hide()
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        FormNamaMakanan.Show()
        Me.Hide()
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        FormDataMakanan.Show()
        Me.Hide()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        FormTransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        CRKasirHarian.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FormDataMasakan.Show()
        Me.Hide()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        FormGantiPassword.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        FormRiwayatTransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        CRLaporanDataMakanan.Show()
        Me.Hide()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        CRLaporanBooking.Show()
        Me.Hide()
    End Sub


    Private Sub Button23_Click(sender As Object, e As EventArgs)
        CRLaporanMakananPalingBanyak.Show()
        Me.Hide()
    End Sub

    Private Sub Button23_Click_1(sender As Object, e As EventArgs) Handles Button23.Click
        CRLaporanMakananPalingBanyak.Show()
        Me.Hide()
    End Sub

    Private Sub PanelAtas_Paint(sender As Object, e As PaintEventArgs) Handles PanelAtas.Paint
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FormRiwayatBooking.Show()
        Me.Hide()
    End Sub
End Class
