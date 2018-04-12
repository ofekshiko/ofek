Public Class Database
    Private con As New OleDb.OleDbConnection
    Public Sub New(ByVal dbpath As String)
        Me.con.ConnectionString = "provider=microsoft.ace.oledb.12.0;data source=" & dbpath
        Me.con.Open()
    End Sub
    Public Function dbselect(ByVal stquery As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As OleDb.OleDbDataAdapter
        da = New OleDb.OleDbDataAdapter(stquery, Me.con)
        da.Fill(ds, "tbl")
        dt = ds.Tables("tbl")
        Return dt
    End Function
    Public Sub insertUpdateDelete(ByVal stquery As String)
        Dim cm As New OleDb.OleDbCommand(stquery, Me.con)
        cm.ExecuteNonQuery()
    End Sub

End Class
