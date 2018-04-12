Public Class Form21
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dtt As DataTable
    Dim stquery As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = db.dbselect("select * from customers")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class