Imports System.Data.OleDb
Module Module1
    Public cmd As OleDbCommand
    Public cmdtr As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public rd As OleDbDataReader
    Public conn As OleDbConnection
    Sub koneksi()
        conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=TokoKeramik.mdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
