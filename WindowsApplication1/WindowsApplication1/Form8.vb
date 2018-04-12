Public Class Form8
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dt As DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = db.dbselect("select * from orders where order_id=" & Val(ordern.Text))
        If dt.Rows.Count = 0 Then
            MsgBox("אין הזמנה כזו")
        Else
            id1.Text = dt.Rows(0).Item("order_custid")
            Label1.Text = dt.Rows(0).Item("order_datef")
            Label3.Text = dt.Rows(0).Item("order_model")
            Label5.Text = dt.Rows(0).Item("order_lic")
            Label7.Text = dt.Rows(0).Item("order_return")
            GroupBox1.Visible = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dt = db.dbselect("select * from orders where order_id=" & Val(ordern.Text) & "")
        If (dt.Rows(0).Item("order_return") = True) Then
            MsgBox("!בוצעה ההחזרה להזמנה זו בעבר")
        Else
            db.insertUpdateDelete("update cars set car_rent=false where car_lic='" & Label5.Text & "'")
            db.insertUpdateDelete("update orders set order_return=true where order_id=" & Val(ordern.Text) & "")
            db.insertUpdateDelete("update cars set car_km=" & TextBox1.Text & " where car_lic ='" & Label5.Text & "'")
            MsgBox("!ההחזרה בוצעה בהצלחה, תודה")
        End If
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ToolTip1.ShowAlways = True
        ToolTip1.SetToolTip(Me.Label8, "True = הרכב הוחזר" & vbCrLf & "False = הרכב לא הוחזר")
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class