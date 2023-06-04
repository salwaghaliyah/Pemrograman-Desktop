<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApp))
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnRiwayat = New FontAwesome.Sharp.IconButton()
        Me.btnTransaksi = New FontAwesome.Sharp.IconButton()
        Me.btnStok = New FontAwesome.Sharp.IconButton()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.LabelJam = New System.Windows.Forms.Label()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'imgHome
        '
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(39, 33)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(139, 82)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnRiwayat)
        Me.PanelMenu.Controls.Add(Me.btnTransaksi)
        Me.PanelMenu.Controls.Add(Me.btnStok)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 753)
        Me.PanelMenu.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        Me.btnLogout.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 36
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 673)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(220, 80)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnRiwayat
        '
        Me.btnRiwayat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRiwayat.FlatAppearance.BorderSize = 0
        Me.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRiwayat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRiwayat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRiwayat.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar
        Me.btnRiwayat.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRiwayat.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRiwayat.IconSize = 36
        Me.btnRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRiwayat.Location = New System.Drawing.Point(0, 300)
        Me.btnRiwayat.Name = "btnRiwayat"
        Me.btnRiwayat.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRiwayat.Size = New System.Drawing.Size(220, 80)
        Me.btnRiwayat.TabIndex = 3
        Me.btnRiwayat.Text = "Riwayat Transaksi"
        Me.btnRiwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRiwayat.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnTransaksi.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnTransaksi.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnTransaksi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTransaksi.IconSize = 36
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(0, 220)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnTransaksi.Size = New System.Drawing.Size(220, 80)
        Me.btnTransaksi.TabIndex = 2
        Me.btnTransaksi.Text = "Transaksi"
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'btnStok
        '
        Me.btnStok.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStok.FlatAppearance.BorderSize = 0
        Me.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnStok.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.btnStok.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnStok.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStok.IconSize = 36
        Me.btnStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStok.Location = New System.Drawing.Point(0, 140)
        Me.btnStok.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStok.Name = "btnStok"
        Me.btnStok.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnStok.Size = New System.Drawing.Size(220, 80)
        Me.btnStok.TabIndex = 1
        Me.btnStok.Text = "Manajemen Stok"
        Me.btnStok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStok.UseVisualStyleBackColor = True
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.LabelJam)
        Me.PanelTitleBar.Controls.Add(Me.LabelTanggal)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(862, 60)
        Me.PanelTitleBar.TabIndex = 1
        '
        'LabelJam
        '
        Me.LabelJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJam.Location = New System.Drawing.Point(732, 14)
        Me.LabelJam.Name = "LabelJam"
        Me.LabelJam.Size = New System.Drawing.Size(103, 31)
        Me.LabelJam.TabIndex = 3
        '
        'LabelTanggal
        '
        Me.LabelTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTanggal.Location = New System.Drawing.Point(583, 14)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(124, 31)
        Me.LabelTanggal.TabIndex = 2
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblFormTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormTitle.Location = New System.Drawing.Point(86, 20)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(68, 25)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 40
        Me.IconCurrentForm.Location = New System.Drawing.Point(29, 12)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(40, 40)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.Label11)
        Me.PanelDesktop.Controls.Add(Me.Label7)
        Me.PanelDesktop.Controls.Add(Me.Label8)
        Me.PanelDesktop.Controls.Add(Me.IconPictureBox3)
        Me.PanelDesktop.Controls.Add(Me.Label9)
        Me.PanelDesktop.Controls.Add(Me.Label10)
        Me.PanelDesktop.Controls.Add(Me.IconPictureBox4)
        Me.PanelDesktop.Controls.Add(Me.Label5)
        Me.PanelDesktop.Controls.Add(Me.Label6)
        Me.PanelDesktop.Controls.Add(Me.IconPictureBox2)
        Me.PanelDesktop.Controls.Add(Me.Label4)
        Me.PanelDesktop.Controls.Add(Me.Label3)
        Me.PanelDesktop.Controls.Add(Me.IconPictureBox1)
        Me.PanelDesktop.Controls.Add(Me.Label2)
        Me.PanelDesktop.Controls.Add(Me.Label1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 60)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(862, 693)
        Me.PanelDesktop.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(862, 32)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Kelompok 10"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(657, 505)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "21082010124"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(657, 488)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Taufiq Arinta "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.IconPictureBox3.BackgroundImage = CType(resources.GetObject("IconPictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.IconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 160
        Me.IconPictureBox3.Location = New System.Drawing.Point(657, 276)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(160, 200)
        Me.IconPictureBox3.TabIndex = 15
        Me.IconPictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(455, 505)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 23)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "21082010123"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(455, 488)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Salwa Ghaliyah"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.IconPictureBox4.BackgroundImage = CType(resources.GetObject("IconPictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.IconPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox4.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 160
        Me.IconPictureBox4.Location = New System.Drawing.Point(455, 276)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(160, 200)
        Me.IconPictureBox4.TabIndex = 12
        Me.IconPictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(252, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "21082010110"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 488)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Alwi"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.IconPictureBox2.BackgroundImage = CType(resources.GetObject("IconPictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.IconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 160
        Me.IconPictureBox2.Location = New System.Drawing.Point(252, 276)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(160, 200)
        Me.IconPictureBox2.TabIndex = 9
        Me.IconPictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(50, 505)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "21082010099"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rohmat Ubaidillah F"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.IconPictureBox1.BackgroundImage = CType(resources.GetObject("IconPictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.IconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 160
        Me.IconPictureBox1.Location = New System.Drawing.Point(50, 276)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(160, 200)
        Me.IconPictureBox1.TabIndex = 5
        Me.IconPictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(862, 73)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pemrograman Desktop"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(862, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tugas Final Project "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MainApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 753)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "MainApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Aplikasi"
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnTransaksi As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRiwayat As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnStok As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LabelJam As Label
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label11 As Label
End Class
