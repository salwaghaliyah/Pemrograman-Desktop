Imports System.Data.OleDb
Public Class Form1
    Dim dtb As DataTable = New DataTable()

    Sub viewdata()
        cmd = New OleDbCommand("Select * From tbl_detail_transaksi", conn)
        da = New OleDbDataAdapter(cmd)
        da.Fill(dtb)
        conn.Close()
        conn.Dispose()
    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        dtb.Clear()
        Call koneksi()

        Dim myrpt As New MyReport
        viewdata()
        myrpt.Database.Tables("tbl_detail_transaksi").SetDataSource(dtb)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class