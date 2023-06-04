Imports FontAwesome.Sharp
Public Class MainApp
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    'methods
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        DisabledButton()
        If senderBtn IsNot Nothing Then
            'button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(254, 208, 73)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left border
            leftBorderBtn.BackColor = Color.FromArgb(254, 208, 73)
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = Color.FromArgb(37, 27, 55)
        End If
    End Sub

    Private Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(254, 208, 73)
            currentBtn.ForeColor = Color.FromArgb(37, 27, 55)
            currentBtn.IconColor = Color.FromArgb(37, 27, 55)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    Private Sub btnStok_Click(sender As Object, e As EventArgs) Handles btnStok.Click
        ActivateButton(sender, Color.FromArgb(12, 30, 127))
        OpenChildForm(New FormStok)
    End Sub
    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        ActivateButton(sender, Color.FromArgb(12, 30, 127))
        OpenChildForm(New Transaksi)
    End Sub
    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        ActivateButton(sender, Color.FromArgb(12, 30, 127))
        OpenChildForm(New FormRiwayat)
    End Sub
    Private Sub reset()
        DisabledButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.FromArgb(37, 27, 55)
        lblFormTitle.Text = "Home"
    End Sub
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        reset()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLogin.Show()
        FormLogin.tbUsername.Text = ""
        FormLogin.tbPassword.Text = ""
    End Sub

    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelJam.Text = TimeOfDay
    End Sub

End Class