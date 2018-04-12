Public Class Form22
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dtt As DataTable
    Dim stquery As String = ""
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox1.Visible = True
            ComboBox1.Items.Clear()
            dt = db.dbselect("select distinct cust_city from customers ")
            For i = 0 To dt.Rows.Count - 1
                ComboBox1.Items.Add(dt.Rows(i).Item("cust_city"))
            Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt10 As DataTable
        Dim stqr As String = "select * from customers where 1=1"
        If CheckBox1.Checked = True Then stqr = stqr & " and cust_city='" & ComboBox1.SelectedItem & "'"
        MsgBox(stqr)
        dt10 = db.dbselect(stqr)
        DataGridView1.DataSource = dt10
    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class