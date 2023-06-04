<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labelTotalHarga = New System.Windows.Forms.Label()
        Me.tbSebelumDiskon = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lv_transaksi = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbHargaTransaksi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbKembalian = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBayarTransaksi = New System.Windows.Forms.Button()
        Me.tbMasukkanUang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbDiskon = New System.Windows.Forms.TextBox()
        Me.tbTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.cbNamaBarang = New System.Windows.Forms.ComboBox()
        Me.btnHapusTransaksi = New System.Windows.Forms.Button()
        Me.btnTambahTransaksi = New System.Windows.Forms.Button()
        Me.tbIdBarangTransaksi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbIdTransaksi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 573)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 20)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Terbilang"
        '
        'labelTotalHarga
        '
        Me.labelTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalHarga.Location = New System.Drawing.Point(135, 574)
        Me.labelTotalHarga.Name = "labelTotalHarga"
        Me.labelTotalHarga.Size = New System.Drawing.Size(205, 60)
        Me.labelTotalHarga.TabIndex = 109
        '
        'tbSebelumDiskon
        '
        Me.tbSebelumDiskon.Enabled = False
        Me.tbSebelumDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSebelumDiskon.Location = New System.Drawing.Point(615, 189)
        Me.tbSebelumDiskon.Name = "tbSebelumDiskon"
        Me.tbSebelumDiskon.Size = New System.Drawing.Size(212, 30)
        Me.tbSebelumDiskon.TabIndex = 108
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(378, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 20)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Total Harga Sebelum Diskon"
        '
        'lv_transaksi
        '
        Me.lv_transaksi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lv_transaksi.FullRowSelect = True
        Me.lv_transaksi.HideSelection = False
        Me.lv_transaksi.Location = New System.Drawing.Point(20, 240)
        Me.lv_transaksi.Name = "lv_transaksi"
        Me.lv_transaksi.Size = New System.Drawing.Size(808, 212)
        Me.lv_transaksi.TabIndex = 106
        Me.lv_transaksi.UseCompatibleStateImageBehavior = False
        Me.lv_transaksi.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Barang"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Barang"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Harga"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jumlah"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total Harga"
        Me.ColumnHeader5.Width = 180
        '
        'tbHargaTransaksi
        '
        Me.tbHargaTransaksi.Enabled = False
        Me.tbHargaTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHargaTransaksi.Location = New System.Drawing.Point(158, 69)
        Me.tbHargaTransaksi.Name = "tbHargaTransaksi"
        Me.tbHargaTransaksi.Size = New System.Drawing.Size(171, 30)
        Me.tbHargaTransaksi.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Harga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(565, 486)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(564, 580)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 20)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Rp."
        '
        'tbKembalian
        '
        Me.tbKembalian.Enabled = False
        Me.tbKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKembalian.Location = New System.Drawing.Point(614, 570)
        Me.tbKembalian.Name = "tbKembalian"
        Me.tbKembalian.Size = New System.Drawing.Size(214, 30)
        Me.tbKembalian.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(407, 580)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Kembalian"
        '
        'btnBayarTransaksi
        '
        Me.btnBayarTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnBayarTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayarTransaksi.Location = New System.Drawing.Point(714, 521)
        Me.btnBayarTransaksi.Name = "btnBayarTransaksi"
        Me.btnBayarTransaksi.Size = New System.Drawing.Size(113, 39)
        Me.btnBayarTransaksi.TabIndex = 99
        Me.btnBayarTransaksi.Text = "Bayar"
        Me.btnBayarTransaksi.UseVisualStyleBackColor = False
        '
        'tbMasukkanUang
        '
        Me.tbMasukkanUang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMasukkanUang.Location = New System.Drawing.Point(615, 476)
        Me.tbMasukkanUang.Name = "tbMasukkanUang"
        Me.tbMasukkanUang.Size = New System.Drawing.Size(212, 30)
        Me.tbMasukkanUang.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(407, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 20)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Masukkan Uang"
        '
        'tbDiskon
        '
        Me.tbDiskon.Enabled = False
        Me.tbDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiskon.Location = New System.Drawing.Point(140, 476)
        Me.tbDiskon.Name = "tbDiskon"
        Me.tbDiskon.Size = New System.Drawing.Size(200, 30)
        Me.tbDiskon.TabIndex = 96
        '
        'tbTotalHarga
        '
        Me.tbTotalHarga.Enabled = False
        Me.tbTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalHarga.Location = New System.Drawing.Point(140, 524)
        Me.tbTotalHarga.Name = "tbTotalHarga"
        Me.tbTotalHarga.Size = New System.Drawing.Size(200, 30)
        Me.tbTotalHarga.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 531)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Total Harga"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(158, 121)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(171, 30)
        Me.NumericUpDown1.TabIndex = 92
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbNamaBarang
        '
        Me.cbNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNamaBarang.FormattingEnabled = True
        Me.cbNamaBarang.Location = New System.Drawing.Point(158, 16)
        Me.cbNamaBarang.Name = "cbNamaBarang"
        Me.cbNamaBarang.Size = New System.Drawing.Size(171, 33)
        Me.cbNamaBarang.TabIndex = 91
        '
        'btnHapusTransaksi
        '
        Me.btnHapusTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnHapusTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusTransaksi.Location = New System.Drawing.Point(581, 121)
        Me.btnHapusTransaksi.Name = "btnHapusTransaksi"
        Me.btnHapusTransaksi.Size = New System.Drawing.Size(107, 39)
        Me.btnHapusTransaksi.TabIndex = 90
        Me.btnHapusTransaksi.Text = "Hapus"
        Me.btnHapusTransaksi.UseVisualStyleBackColor = False
        '
        'btnTambahTransaksi
        '
        Me.btnTambahTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnTambahTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahTransaksi.Location = New System.Drawing.Point(439, 121)
        Me.btnTambahTransaksi.Name = "btnTambahTransaksi"
        Me.btnTambahTransaksi.Size = New System.Drawing.Size(119, 39)
        Me.btnTambahTransaksi.TabIndex = 89
        Me.btnTambahTransaksi.Text = "Tambah"
        Me.btnTambahTransaksi.UseVisualStyleBackColor = False
        '
        'tbIdBarangTransaksi
        '
        Me.tbIdBarangTransaksi.Enabled = False
        Me.tbIdBarangTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdBarangTransaksi.Location = New System.Drawing.Point(615, 69)
        Me.tbIdBarangTransaksi.Name = "tbIdBarangTransaksi"
        Me.tbIdBarangTransaksi.Size = New System.Drawing.Size(213, 30)
        Me.tbIdBarangTransaksi.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(435, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "ID Barang"
        '
        'tbIdTransaksi
        '
        Me.tbIdTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdTransaksi.Location = New System.Drawing.Point(615, 12)
        Me.tbIdTransaksi.Name = "tbIdTransaksi"
        Me.tbIdTransaksi.Size = New System.Drawing.Size(213, 30)
        Me.tbIdTransaksi.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "ID Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Nama Barang"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 646)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.labelTotalHarga)
        Me.Controls.Add(Me.tbSebelumDiskon)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lv_transaksi)
        Me.Controls.Add(Me.tbHargaTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbKembalian)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBayarTransaksi)
        Me.Controls.Add(Me.tbMasukkanUang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbDiskon)
        Me.Controls.Add(Me.tbTotalHarga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.cbNamaBarang)
        Me.Controls.Add(Me.btnHapusTransaksi)
        Me.Controls.Add(Me.btnTambahTransaksi)
        Me.Controls.Add(Me.tbIdBarangTransaksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbIdTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents labelTotalHarga As Label
    Friend WithEvents tbSebelumDiskon As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lv_transaksi As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents tbHargaTransaksi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbKembalian As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBayarTransaksi As Button
    Friend WithEvents tbMasukkanUang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbDiskon As TextBox
    Friend WithEvents tbTotalHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents cbNamaBarang As ComboBox
    Friend WithEvents btnHapusTransaksi As Button
    Friend WithEvents btnTambahTransaksi As Button
    Friend WithEvents tbIdBarangTransaksi As TextBox
    Friend WithEvents Label5 As Label
    Public WithEvents tbIdTransaksi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
