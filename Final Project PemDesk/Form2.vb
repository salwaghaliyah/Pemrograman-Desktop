Imports System.Data.OleDb
Public Class Form2
    Dim dtb As DataTable = New DataTable()
    Private lv_transaksi As Object

    Sub viewdata()

        cmd = New OleDbCommand("select * from tbl_detail_transaksi where id_transaksi = '" & Transaksi.autonumber2 & "' ", conn)

        da = New OleDbDataAdapter(cmd)
            da.Fill(dtb)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        dtb.Clear()
        Call koneksi()

        Dim myrpt As New Struk
        viewdata()
        myrpt.Database.Tables("tbl_detail_transaksi").SetDataSource(dtb)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class