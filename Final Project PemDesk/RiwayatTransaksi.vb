Imports System.Data.OleDb
Public Class FormRiwayat
    Dim totalpendapatan As Integer
    Dim totalriwayat As Integer

    'Funsi terbilang
    Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima",
       "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}
        If nilai < 12 Then
            Return " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " Belas"
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " Puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " Seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " Ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " SERIBU" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " Ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " Juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " Milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " Trilyun") + Terbilang(nilai Mod 1000000000000)
        Else
            Return (Terbilang("Nol"))
        End If
    End Function
    Sub tampildata()
        Call koneksi()
        cmd = New OleDbCommand("Select * From tbl_detail_transaksi", conn)
        rd = cmd.ExecuteReader
        lv_riwayat.Items.Clear()
        totalriwayat = 0
        Do While rd.Read = True
            'lv_Transaksi.Rows.Add(rd.Item("rd.Item("id_barang"), rd.Item("nama_barang"), rd.Item("harga"), rd.Item("jumlah"), rd.Item("total_harga"))
            'DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3))
            lv_riwayat.Items.Add(rd.Item(0))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(2))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(3))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(4))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(6))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(5))
            totalriwayat = totalriwayat + rd.Item(5)

            'lv_Transaksi.Items(lv_Transaksi.Items.Count - 1).SubItems.Add(rd.Item(6))
        Loop
        tbPendapatan.Text = totalriwayat
    End Sub

    Sub Terlaris()
        Call koneksi()
        cmd = New OleDbCommand("Select nama_barang, sum(jumlah) from tbl_detail_transaksi group by nama_barang order by sum(jumlah) desc", conn)
        rd = cmd.ExecuteReader
        lv_produk_terlaris.Items.Clear()

        Do While rd.Read = True
            lv_produk_terlaris.Items.Add(rd.Item(0))
            lv_produk_terlaris.Items(lv_produk_terlaris.Items.Count - 1).SubItems.Add(rd.Item(1))
        Loop

        'lv_produk_terlaris.Items.Add(rd.Item("count(jumlah)"))
    End Sub

    Sub comboboxriwayat()
        Call koneksi()
        cmd = New OleDbCommand("select distinct tanggal from tbl_detail_transaksi", conn)
        rd = cmd.ExecuteReader
        cb_cari_riwayat.Items.Clear()
        Do While rd.Read = True
            cb_cari_riwayat.Items.Add(rd.Item("tanggal"))
        Loop
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Call koneksi()
        MessageBox.Show("koneksi db sukses")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Call koneksi()
        MessageBox.Show("koneksi db sukses")
    End Sub

    Private Sub FormRiwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildata()
        Call Terlaris()
        Call comboboxriwayat()


    End Sub

    Private Sub cb_cari_riwayat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cari_riwayat.SelectedIndexChanged
        Call koneksi()
        cmd = New OleDbCommand("Select * From tbl_detail_transaksi where tanggal like '%" & cb_cari_riwayat.Text & "%'", conn)
        rd = cmd.ExecuteReader
        lv_riwayat.Items.Clear()
        totalriwayat = 0
        Do While rd.Read = True

            lv_riwayat.Items.Add(rd.Item(0))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(2))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(3))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(4))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(6))
            lv_riwayat.Items(lv_riwayat.Items.Count - 1).SubItems.Add(rd.Item(5))
            totalriwayat = totalriwayat + rd.Item(5)

        Loop

        tbPendapatan.Text = totalriwayat

    End Sub

    Private Sub btnCariTransaksi_Click(sender As Object, e As EventArgs) Handles btnCariTransaksi.Click
        Call tampildata()
    End Sub

    Private Sub tbPendapatan_TextChanged(sender As Object, e As EventArgs) Handles tbPendapatan.TextChanged
        labelTerbilang.Text = Terbilang(tbPendapatan.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub
End Class