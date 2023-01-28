<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRLaporanDataMakanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRLaporanDataMakanan))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(662, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(682, 313)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(537, 206)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'CRLaporanDataMakanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 464)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CRLaporanDataMakanan"
        Me.Text = "CRLaporanDataMakanan"
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
