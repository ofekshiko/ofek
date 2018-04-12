Public Class Form2
    Dim dt As DataTable
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = db.dbselect("select * from customers where cust_myid='" & TextBox1.Text & "'")
        If dt.Rows.Count = 0 Then
            MsgBox("הלקוח אינו קיים במערכת")
        Else
            fname.Text = dt.Rows(0).Item("cust_fname")
            lname.Text = dt.Rows(0).Item("cust_lname")
            email.Text = dt.Rows(0).Item("cust_email")
            phone.Text = dt.Rows(0).Item("cust_phone")
            GroupBox1.Visible = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim st As String = "?האם אתה בטוח שברצונך למחוק את הלקוח" & vbCrLf & dt.Rows(0).Item(1) & vbCrLf & dt.Rows(0).Item(2)
        Dim result As Integer = MsgBox(st, MsgBoxStyle.OkCancel + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight)
        If result = DialogResult.OK Then
            db.insertUpdateDelete("DELETE * from customers where cust_myid ='" & TextBox1.Text & "'")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class