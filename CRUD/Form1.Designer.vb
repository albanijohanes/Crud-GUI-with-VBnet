<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblAplikasiMahasiswa = New System.Windows.Forms.Label()
        Me.lblNamaMahasiswa = New System.Windows.Forms.Label()
        Me.lblNimMahasiswa = New System.Windows.Forms.Label()
        Me.txtNimMahasiswa = New System.Windows.Forms.TextBox()
        Me.txtNamaMahasiswa = New System.Windows.Forms.TextBox()
        Me.txtJk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAplikasiMahasiswa
        '
        Me.lblAplikasiMahasiswa.AutoSize = True
        Me.lblAplikasiMahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAplikasiMahasiswa.Location = New System.Drawing.Point(12, 9)
        Me.lblAplikasiMahasiswa.Name = "lblAplikasiMahasiswa"
        Me.lblAplikasiMahasiswa.Size = New System.Drawing.Size(241, 29)
        Me.lblAplikasiMahasiswa.TabIndex = 0
        Me.lblAplikasiMahasiswa.Text = "Aplikasi Mahasiswa"
        '
        'lblNamaMahasiswa
        '
        Me.lblNamaMahasiswa.AutoSize = True
        Me.lblNamaMahasiswa.Location = New System.Drawing.Point(14, 105)
        Me.lblNamaMahasiswa.Name = "lblNamaMahasiswa"
        Me.lblNamaMahasiswa.Size = New System.Drawing.Size(91, 13)
        Me.lblNamaMahasiswa.TabIndex = 1
        Me.lblNamaMahasiswa.Text = "Nama Mahasiswa"
        '
        'lblNimMahasiswa
        '
        Me.lblNimMahasiswa.AutoSize = True
        Me.lblNimMahasiswa.Location = New System.Drawing.Point(14, 58)
        Me.lblNimMahasiswa.Name = "lblNimMahasiswa"
        Me.lblNimMahasiswa.Size = New System.Drawing.Size(83, 13)
        Me.lblNimMahasiswa.TabIndex = 2
        Me.lblNimMahasiswa.Text = "NIM Mahasiswa"
        '
        'txtNimMahasiswa
        '
        Me.txtNimMahasiswa.Location = New System.Drawing.Point(17, 74)
        Me.txtNimMahasiswa.Name = "txtNimMahasiswa"
        Me.txtNimMahasiswa.Size = New System.Drawing.Size(190, 20)
        Me.txtNimMahasiswa.TabIndex = 3
        '
        'txtNamaMahasiswa
        '
        Me.txtNamaMahasiswa.Location = New System.Drawing.Point(17, 121)
        Me.txtNamaMahasiswa.Name = "txtNamaMahasiswa"
        Me.txtNamaMahasiswa.Size = New System.Drawing.Size(190, 20)
        Me.txtNamaMahasiswa.TabIndex = 4
        '
        'txtJk
        '
        Me.txtJk.FormattingEnabled = True
        Me.txtJk.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.txtJk.Location = New System.Drawing.Point(17, 184)
        Me.txtJk.Name = "txtJk"
        Me.txtJk.Size = New System.Drawing.Size(105, 21)
        Me.txtJk.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Jenis Kelamin"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(258, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(304, 239)
        Me.DataGridView1.TabIndex = 7
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(17, 227)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(104, 29)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(137, 227)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(104, 29)
        Me.btnHapus.TabIndex = 9
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(18, 270)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(104, 29)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 311)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJk)
        Me.Controls.Add(Me.txtNamaMahasiswa)
        Me.Controls.Add(Me.txtNimMahasiswa)
        Me.Controls.Add(Me.lblNimMahasiswa)
        Me.Controls.Add(Me.lblNamaMahasiswa)
        Me.Controls.Add(Me.lblAplikasiMahasiswa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAplikasiMahasiswa As Label
    Friend WithEvents lblNamaMahasiswa As Label
    Friend WithEvents lblNimMahasiswa As Label
    Friend WithEvents txtNimMahasiswa As TextBox
    Friend WithEvents txtNamaMahasiswa As TextBox
    Friend WithEvents txtJk As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
End Class
