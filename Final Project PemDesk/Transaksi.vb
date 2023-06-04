Imports System.Data.OleDb
Public Class Transaksi
    Dim temp As String
    Dim hargadiskon As Integer
    Dim totalharga As Integer

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
    Sub datacombobox()
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_barang", conn)
        rd = cmd.ExecuteReader
        cbNamaBarang.Items.Clear()
        Do While rd.Read = True
            cbNamaBarang.Items.Add(rd.Item("nama_barang"))
        Loop
    End Sub

    Sub autonumber()
        Call koneksi()

        cmd = New OleDbCommand("select * from tbl_detail_transaksi where id_transaksi in (select max(id_transaksi) from tbl_detail_transaksi)", conn)
        Dim UrutanID As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanID = "TR" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            UrutanID = "TR" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        tbIdTransaksi.Text = UrutanID
    End Sub

    Public Function autonumber2() As String
        Call koneksi()

        cmd = New OleDbCommand("select * from tbl_detail_transaksi where id_transaksi in (select max(id_transaksi) from tbl_detail_transaksi)", conn)
        Dim UrutanID As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanID = "TR" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3)
            UrutanID = "TR" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        tbIdTransaksi.Text = UrutanID

        Return UrutanID
    End Function

    Sub tampildata()
        Call koneksi()
        cmd = New OleDbCommand("Select * From tbl_detail_transaksi", conn)
        rd = cmd.ExecuteReader
        lv_Transaksi.Items.Clear()
        Do While rd.Read = True
            lv_transaksi.Items.Add(rd.Item(1))
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(rd.Item(2))
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(rd.Item(3))
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(rd.Item(4))
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(rd.Item(5))
        Loop
    End Sub
    Sub bersih()
        cbNamaBarang.Text = ""
        tbHargaTransaksi.Text = ""
        tbIdBarangTransaksi.Text = ""
        NumericUpDown1.Value = 1
        cbNamaBarang.Focus()
    End Sub

    Sub hapustransaksi()
        lv_Transaksi.Items.Clear()
        tbSebelumDiskon.Text = ""
        tbMasukkanUang.Text = ""
        tbKembalian.Text = ""

    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call datacombobox()
        Call autonumber()
    End Sub

    Private Sub cbNamaBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNamaBarang.SelectedIndexChanged
        Call koneksi()
        cmd = New OleDbCommand("Select * From tbl_barang where nama_barang = '" & cbNamaBarang.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            tbHargaTransaksi.Text = rd.Item("harga")
            tbIdBarangTransaksi.Text = rd.Item("id_barang")
        Else
            tbHargaTransaksi.Text = ""
            tbIdBarangTransaksi.Text = ""
        End If
    End Sub
    Dim total As Integer
    Private Sub btnTambahTransaksi_Click(sender As Object, e As EventArgs) Handles btnTambahTransaksi.Click

        If cbNamaBarang.Text = "" Or tbHargaTransaksi.Text = "" Or tbIdTransaksi.Text = "" Or tbIdBarangTransaksi.Text = "" Or NumericUpDown1.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong!!")
        Else

            Dim hargasementara = tbHargaTransaksi.Text * NumericUpDown1.Text
            total = total + hargasementara

            lv_transaksi.Items.Add(tbIdBarangTransaksi.Text)
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(cbNamaBarang.Text)
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(tbHargaTransaksi.Text)
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(NumericUpDown1.Text)
            lv_transaksi.Items(lv_transaksi.Items.Count - 1).SubItems.Add(hargasementara)
            Call bersih()
            If total < 500000 Then
                MessageBox.Show("Lakukan Pembelian Minimal 500 Ribu untuk mendapatkan diskon sebesar 5%")
                tbDiskon.Text = "Tidak Ada"
            Else
                hargadiskon = Val(tbSebelumDiskon.Text) * 0.05
                tbDiskon.Text = hargadiskon
                tbSebelumDiskon.Text = total
                tbTotalHarga.Text = CInt(tbSebelumDiskon.Text) - CInt(tbDiskon.Text)
            End If
            tbSebelumDiskon.Text = total
            tbTotalHarga.Text = total - hargadiskon

        End If
    End Sub

    Private Sub btnBayarTransaksi_Click(sender As Object, e As EventArgs) Handles btnBayarTransaksi.Click
        Dim jumlahItem As Integer = 0
        Dim stok As Integer = 0

        If tbMasukkanUang.Text = "" Then
            MessageBox.Show("Anda Belum Memasukkan Uang!!")
        ElseIf tbMasukkanUang.Text < tbTotalHarga.Text Then
            MsgBox("Uang Yang Anda Masukkan Tidak Cukup")
        Else
            Call koneksi()
            For i As Integer = 0 To lv_transaksi.Items.Count - 1

                cmd = New OleDbCommand("select stok from tbl_barang where id_barang =  '" & lv_transaksi.Items(i).SubItems(0).Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                stok = rd.Item("stok")
                Dim temp As Integer = lv_transaksi.Items(i).SubItems(3).Text

                If stok - temp < 0 Then
                    MsgBox("Stok Tidak Mencukupi")
                    Return
                Else
                    stok = stok - temp
                    cmd = New OleDbCommand("Update tbl_barang set stok = '" & stok & "' where id_barang = '" & lv_transaksi.Items(i).SubItems(0).Text & "'", conn)
                    cmd.ExecuteNonQuery()
                End If
                stok = 0
                temp = 0
            Next


            Call koneksi()
            For i As Integer = 0 To lv_transaksi.Items.Count - 1
                jumlahItem += CInt(lv_transaksi.Items(i).SubItems(4).Text)

                cmd = New OleDbCommand("insert into tbl_detail_transaksi values('" & tbIdTransaksi.Text &
                                   "','" & lv_transaksi.Items(i).SubItems(0).Text &
                                   "','" & lv_transaksi.Items(i).SubItems(1).Text &
                                   "','" & lv_transaksi.Items(i).SubItems(2).Text &
                                   "','" & lv_transaksi.Items(i).SubItems(3).Text &
                                   "','" & lv_transaksi.Items(i).SubItems(4).Text &
                                   "','" & MainApp.LabelTanggal.Text & "')", conn)

                cmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Pembayaran Berhasil")
            Form2.Show()

            Call autonumber()
            Call hapustransaksi()

        End If

    End Sub

    Private Sub tbTotalHarga_TextChanged(sender As Object, e As EventArgs) Handles tbTotalHarga.TextChanged
        labelTotalHarga.Text = Terbilang(tbTotalHarga.Text)

    End Sub

    Private Sub btnHapusTransaksi_Click(sender As Object, e As EventArgs) Handles btnHapusTransaksi.Click
        total = total - CInt(lv_transaksi.SelectedItems(0).SubItems(4).Text)
        Dim sementara As Integer = CInt(lv_transaksi.SelectedItems(0).SubItems(4).Text)
        If MessageBox.Show("Apakah Anda Ingin Menghapus Data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            lv_transaksi.Items.Remove(lv_transaksi.SelectedItems(0))
            If total < 500000 Then
                tbDiskon.Text = "Tidak Ada"
                tbTotalHarga.Text = (CInt(tbTotalHarga.Text) + hargadiskon) - sementara
                tbSebelumDiskon.Text = CInt(tbSebelumDiskon.Text) - sementara
            Else
                tbDiskon.Text = CInt(tbDiskon.Text) - (total * 0.05)
                tbSebelumDiskon.Text = total
                tbTotalHarga.Text = CInt(tbSebelumDiskon.Text) - CInt(tbDiskon.Text)

            End If
        End If

    End Sub

    Private Sub tbMasukkanUang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMasukkanUang.KeyPress
        If e.KeyChar = Chr(13) Then
            If CInt(tbMasukkanUang.Text) > CInt(tbTotalHarga.Text) Then
                tbKembalian.Text = CStr(CInt(tbMasukkanUang.Text - tbTotalHarga.Text))
            Else
                MsgBox("Uang Tidak Cukup!")
                tbTotalHarga.Text = ""
            End If

        End If
    End Sub

End Class