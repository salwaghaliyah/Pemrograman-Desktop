Imports System.Data.OleDb
Public Class FormStok
    Sub tampildata()
        Call koneksi()
        cmd = New OleDbCommand("Select * From tbl_barang", conn)
        rd = cmd.ExecuteReader
        lv_stok.Items.Clear()

        Do While rd.Read = True
            lv_stok.Items.Add(rd.Item(0))
            lv_stok.Items(lv_stok.Items.Count - 1).SubItems.Add(rd.Item(1))
            lv_stok.Items(lv_stok.Items.Count - 1).SubItems.Add(rd.Item(2))
            lv_stok.Items(lv_stok.Items.Count - 1).SubItems.Add(rd.Item(3))
        Loop
    End Sub

    Sub bersih()
        tbIdBarang.Text = ""
        tbNamaBarang.Text = ""
        tbStok.Text = ""
        tbHarga.Text = ""
        tbIdBarang.Focus()
    End Sub

    Sub autonumber()
        Call koneksi()

        cmd = New OleDbCommand("select * from tbl_barang where id_barang in (select max(id_barang) from tbl_barang)", conn)
        Dim UrutanID As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanID = "BR" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            UrutanID = "BR" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        tbIdBarang.Text = UrutanID
    End Sub

    Private Sub FormStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildata()
        Call autonumber()
    End Sub
    Private Sub btnTambahStok_Click(sender As Object, e As EventArgs) Handles btnTambahStok.Click
        If tbIdBarang.Text = "" Or tbNamaBarang.Text = "" Or tbStok.Text = "" Or tbHarga.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong!!")
        Else
            'melakukan cek duplikat data id barang
            Call koneksi()
            cmd = New OleDbCommand("Select * From tbl_barang where id_barang='" & tbIdBarang.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MessageBox.Show("Data Dengan Id Barang '" & tbIdBarang.Text & "' Sudah Ada, Mohon Input Id Barang Lain!!")
            Else
                'simpan data
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_barang values('" & tbIdBarang.Text &
                                   "','" & tbNamaBarang.Text &
                                   "','" & tbStok.Text &
                                   "','" & tbHarga.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Ditambahkan")
                Call tampildata()
                Call bersih()
                Call autonumber()
            End If
        End If
    End Sub

    Private Sub tbIdBarang_TextChanged(sender As Object, e As EventArgs) Handles tbIdBarang.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("Select * From tbl_barang Where id_barang = '" & tbIdBarang.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            tbNamaBarang.Text = rd(1)
            tbStok.Text = rd.Item(2)
            tbHarga.Text = rd.Item(3)
        Else
            tbNamaBarang.Text = ""
            tbStok.Text = ""
            tbHarga.Text = ""
        End If
    End Sub

    Private Sub btnUbahStok_Click(sender As Object, e As EventArgs) Handles btnUbahStok.Click
        If tbIdBarang.Text = "" Or tbNamaBarang.Text = "" Or tbStok.Text = "" Or tbHarga.Text = "" Then
            MessageBox.Show("Data masih ada yang kosong!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("update tbl_barang set nama_barang = '" & tbNamaBarang.Text &
                                   "', stok = '" & tbStok.Text &
                                   "', harga = '" & tbHarga.Text &
                                   "' where id_barang = '" & tbIdBarang.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Ubah !!")
            Call tampildata()
            Call bersih()
        End If
    End Sub

    Private Sub btnHapusStok_Click(sender As Object, e As EventArgs) Handles btnHapusStok.Click
        If tbIdBarang.Text = "" Or tbNamaBarang.Text = "" Or tbStok.Text = "" Or tbHarga.Text = "" Then
            MessageBox.Show("Data masih ada yang kosong!!")

        ElseIf MessageBox.Show("Apakah Anda Ingin Menghapus Data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
                cmd = New OleDbCommand("delete from tbl_barang where id_barang='" & tbIdBarang.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Hapus!!")
                Call tampildata()
                Call bersih()
            Else
                Call bersih()
        End If
    End Sub

    Private Sub tbCariStok_TextChanged(sender As Object, e As EventArgs) Handles tbCariStok.TextChanged
        Call koneksi()
        cmd = New OleDbCommand("select * from tbl_barang where nama_barang like '%" & tbCariStok.Text & "%'", conn)
        rd = cmd.ExecuteReader
        lv_stok.Items.Clear()
        Do While rd.Read = True
            lv_stok.Items.Add(rd.Item(0))
            lv_stok.Items(lv_stok.Items.Count - 1).SubItems.Add(rd.Item(1))
            lv_stok.Items(lv_stok.Items.Count - 1).SubItems.Add(rd.Item(2))
            lv_stok.Items(lv_stok.Items.Count - 1).SubItems.Add(rd.Item(3))
        Loop
    End Sub
End Class