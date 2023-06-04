<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStok
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
        Me.btnHapusStok = New System.Windows.Forms.Button()
        Me.btnUbahStok = New System.Windows.Forms.Button()
        Me.btnTambahStok = New System.Windows.Forms.Button()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbStok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbIdBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCariStok = New System.Windows.Forms.TextBox()
        Me.lv_stok = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHapusStok
        '
        Me.btnHapusStok.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnHapusStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusStok.Location = New System.Drawing.Point(720, 143)
        Me.btnHapusStok.Name = "btnHapusStok"
        Me.btnHapusStok.Size = New System.Drawing.Size(107, 39)
        Me.btnHapusStok.TabIndex = 23
        Me.btnHapusStok.Text = "Hapus"
        Me.btnHapusStok.UseVisualStyleBackColor = False
        '
        'btnUbahStok
        '
        Me.btnUbahStok.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnUbahStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbahStok.Location = New System.Drawing.Point(580, 143)
        Me.btnUbahStok.Name = "btnUbahStok"
        Me.btnUbahStok.Size = New System.Drawing.Size(107, 39)
        Me.btnUbahStok.TabIndex = 22
        Me.btnUbahStok.Text = "Ubah"
        Me.btnUbahStok.UseVisualStyleBackColor = False
        '
        'btnTambahStok
        '
        Me.btnTambahStok.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnTambahStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahStok.Location = New System.Drawing.Point(429, 143)
        Me.btnTambahStok.Name = "btnTambahStok"
        Me.btnTambahStok.Size = New System.Drawing.Size(116, 39)
        Me.btnTambahStok.TabIndex = 21
        Me.btnTambahStok.Text = "Tambah"
        Me.btnTambahStok.UseVisualStyleBackColor = False
        '
        'tbHarga
        '
        Me.tbHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHarga.Location = New System.Drawing.Point(614, 79)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(213, 30)
        Me.tbHarga.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(481, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Harga"
        '
        'tbStok
        '
        Me.tbStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStok.Location = New System.Drawing.Point(614, 22)
        Me.tbStok.Name = "tbStok"
        Me.tbStok.Size = New System.Drawing.Size(213, 30)
        Me.tbStok.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(481, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Stok"
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaBarang.Location = New System.Drawing.Point(217, 79)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.Size = New System.Drawing.Size(197, 30)
        Me.tbNamaBarang.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama Barang"
        '
        'tbIdBarang
        '
        Me.tbIdBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdBarang.Location = New System.Drawing.Point(217, 22)
        Me.tbIdBarang.Name = "tbIdBarang"
        Me.tbIdBarang.Size = New System.Drawing.Size(197, 30)
        Me.tbIdBarang.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ID Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lv_stok)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbCariStok)
        Me.Panel1.Controls.Add(Me.btnTambahStok)
        Me.Panel1.Controls.Add(Me.btnHapusStok)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnUbahStok)
        Me.Panel1.Controls.Add(Me.tbIdBarang)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbHarga)
        Me.Panel1.Controls.Add(Me.tbNamaBarang)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbStok)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 646)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Cari Barang"
        '
        'tbCariStok
        '
        Me.tbCariStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCariStok.Location = New System.Drawing.Point(145, 145)
        Me.tbCariStok.Name = "tbCariStok"
        Me.tbCariStok.Size = New System.Drawing.Size(189, 30)
        Me.tbCariStok.TabIndex = 26
        '
        'lv_stok
        '
        Me.lv_stok.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_stok.HideSelection = False
        Me.lv_stok.Location = New System.Drawing.Point(23, 229)
        Me.lv_stok.Name = "lv_stok"
        Me.lv_stok.Size = New System.Drawing.Size(804, 389)
        Me.lv_stok.TabIndex = 28
        Me.lv_stok.UseCompatibleStateImageBehavior = False
        Me.lv_stok.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Barang"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Barang"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Stok"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Harga"
        Me.ColumnHeader4.Width = 150
        '
        'FormStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 646)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormStok"
        Me.Text = "Manajemen Stok"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHapusStok As Button
    Friend WithEvents btnUbahStok As Button
    Friend WithEvents btnTambahStok As Button
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbStok As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNamaBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbIdBarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbCariStok As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lv_stok As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
