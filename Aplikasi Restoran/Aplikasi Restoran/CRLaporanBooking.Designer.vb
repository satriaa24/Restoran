<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRLaporanBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRLaporanBooking))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(470, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Per hari "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(666, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Perbulan"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Tampilkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(532, 195)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(575, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(807, 292)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 1
        '
        'CRLaporanBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 498)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CRLaporanBooking"
        Me.Text = "CRLaporanDataBooking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport

End Class
