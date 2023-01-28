<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGantiPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnGanti = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(472, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "FORM GANTI PASSWORD"
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Orange
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatal.Location = New System.Drawing.Point(214, 137)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 16
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnGanti
        '
        Me.btnGanti.BackColor = System.Drawing.Color.Orange
        Me.btnGanti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGanti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGanti.Location = New System.Drawing.Point(102, 137)
        Me.btnGanti.Name = "btnGanti"
        Me.btnGanti.Size = New System.Drawing.Size(75, 23)
        Me.btnGanti.TabIndex = 15
        Me.btnGanti.Text = "Ganti"
        Me.btnGanti.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(194, 91)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(155, 22)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(194, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(194, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 22)
        Me.TextBox1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(39, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Konfirmasi Password Baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(39, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password Baru"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(39, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Password Lama"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnGanti)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(375, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 182)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Silahkan Diisi"
        '
        'FormGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1061, 592)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGantiPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGantiPassword"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnGanti As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
