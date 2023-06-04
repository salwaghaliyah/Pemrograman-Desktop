<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRiwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRiwayat))
        Dim btnKeluar As System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelTerbilang = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_cari_riwayat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lv_produk_terlaris = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_riwayat = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCariTransaksi = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPendapatan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(btnKeluar)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.labelTerbilang)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cb_cari_riwayat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lv_produk_terlaris)
        Me.Panel1.Controls.Add(Me.lv_riwayat)
        Me.Panel1.Controls.Add(Me.btnCariTransaksi)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbPendapatan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 646)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 42)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Cetak Laporan Transaksi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(391, 436)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Terbilang :"
        '
        'labelTerbilang
        '
        Me.labelTerbilang.Location = New System.Drawing.Point(474, 436)
        Me.labelTerbilang.Name = "labelTerbilang"
        Me.labelTerbilang.Size = New System.Drawing.Size(351, 23)
        Me.labelTerbilang.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(506, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Cari"
        '
        'cb_cari_riwayat
        '
        Me.cb_cari_riwayat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cari_riwayat.FormattingEnabled = True
        Me.cb_cari_riwayat.Location = New System.Drawing.Point(570, 95)
        Me.cb_cari_riwayat.Name = "cb_cari_riwayat"
        Me.cb_cari_riwayat.Size = New System.Drawing.Size(183, 28)
        Me.cb_cari_riwayat.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Produk Terlaris"
        '
        'lv_produk_terlaris
        '
        Me.lv_produk_terlaris.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_produk_terlaris.HideSelection = False
        Me.lv_produk_terlaris.Location = New System.Drawing.Point(45, 501)
        Me.lv_produk_terlaris.Name = "lv_produk_terlaris"
        Me.lv_produk_terlaris.Size = New System.Drawing.Size(299, 133)
        Me.lv_produk_terlaris.TabIndex = 31
        Me.lv_produk_terlaris.UseCompatibleStateImageBehavior = False
        Me.lv_produk_terlaris.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Barang"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jumlah"
        Me.ColumnHeader4.Width = 120
        '
        'lv_riwayat
        '
        Me.lv_riwayat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader7, Me.ColumnHeader5, Me.ColumnHeader2})
        Me.lv_riwayat.HideSelection = False
        Me.lv_riwayat.Location = New System.Drawing.Point(45, 151)
        Me.lv_riwayat.Name = "lv_riwayat"
        Me.lv_riwayat.Size = New System.Drawing.Size(784, 215)
        Me.lv_riwayat.TabIndex = 30
        Me.lv_riwayat.UseCompatibleStateImageBehavior = False
        Me.lv_riwayat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Transaksi"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nama Barang"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Harga"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Jumlah"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tanggal & Waktu"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Total Belanja"
        Me.ColumnHeader2.Width = 150
        '
        'btnCariTransaksi
        '
        Me.btnCariTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnCariTransaksi.BackgroundImage = CType(resources.GetObject("btnCariTransaksi.BackgroundImage"), System.Drawing.Image)
        Me.btnCariTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCariTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariTransaksi.Location = New System.Drawing.Point(771, 93)
        Me.btnCariTransaksi.Name = "btnCariTransaksi"
        Me.btnCariTransaksi.Size = New System.Drawing.Size(58, 30)
        Me.btnCariTransaksi.TabIndex = 29
        Me.btnCariTransaksi.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(567, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rp."
        '
        'tbPendapatan
        '
        Me.tbPendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPendapatan.Location = New System.Drawing.Point(609, 387)
        Me.tbPendapatan.Name = "tbPendapatan"
        Me.tbPendapatan.Size = New System.Drawing.Size(220, 30)
        Me.tbPendapatan.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(391, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Pendapatan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Riwayat Transaksi"
        '
        'btnKeluar
        '
        btnKeluar.Location = New System.Drawing.Point(180, 37)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New System.Drawing.Size(75, 23)
        btnKeluar.TabIndex = 38
        btnKeluar.Text = "keluar"
        btnKeluar.UseVisualStyleBackColor = True
        AddHandler btnKeluar.Click, AddressOf Me.btnKeluar_Click
        '
        'FormRiwayat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 646)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormRiwayat"
        Me.Text = "Riwayat Transaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPendapatan As TextBox
    Friend WithEvents btnCariTransaksi As Button
    Friend WithEvents lv_riwayat As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents lv_produk_terlaris As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents cb_cari_riwayat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents labelTerbilang As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
