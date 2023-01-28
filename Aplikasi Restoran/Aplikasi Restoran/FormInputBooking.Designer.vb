<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInputBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputBooking))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(603, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 33)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "FORM DATA BOOKING"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP2)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.btnKeluar)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(228, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 449)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Silakan Diisi"
        '
        'DTP2
        '
        Me.DTP2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTP2.CustomFormat = ""
        Me.DTP2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP2.Location = New System.Drawing.Point(133, 155)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.ShowUpDown = True
        Me.DTP2.Size = New System.Drawing.Size(78, 22)
        Me.DTP2.TabIndex = 13
        '
        'DTP
        '
        Me.DTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTP.CustomFormat = ""
        Me.DTP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(133, 123)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(101, 22)
        Me.DTP.TabIndex = 12
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Orange
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKeluar.Location = New System.Drawing.Point(254, 297)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 79)
        Me.btnKeluar.TabIndex = 11
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Orange
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(133, 203)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(74, 76)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Orange
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(254, 200)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 79)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Orange
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReset.Location = New System.Drawing.Point(133, 297)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(78, 76)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jam Booking"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Orange
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(14, 203)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 76)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tanggal Booking"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nomor Telepon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Pengunjung"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(133, 84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(196, 22)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(133, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 22)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Booking"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(638, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(563, 444)
        Me.DataGridView1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(237, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 26)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "FORM INPUT DATA BOOKING"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(662, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Cari Nama:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(751, 113)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 20)
        Me.TextBox4.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(690, 593)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Jumlah Data Booking:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(807, 594)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Banyak Data"
        '
        'FormInputBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1299, 718)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInputBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInputBooking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
