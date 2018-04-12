Public Class Form19
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dt As DataTable
    Dim dt4 As DataTable
    Dim dt5 As DataTable
    Dim dtt As DataTable
    Dim stquery As String = ""
    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        db.insertUpdateDelete("insert into cars(car_lic) values(0)")
        dt4 = db.dbselect("select  * from cars order by car_id")
        dt5 = db.dbselect("select  * from car_types")
        For i As Integer = 0 To dt5.Rows.Count - 1
            ComboBox2.Items.Add(New Itdat(dt5.Rows(i).Item("cartype_id"), dt5.Rows(i).Item("cartype_company") & " " & dt5.Rows(i).Item("cartype_model")))
        Next
        ComboBox2.DisplayMember = "name"
        Label4.Text = dt4.Rows(dt4.Rows.Count - 1).Item("car_id")
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ToolTip1.ShowAlways = True
        ToolTip1.SetToolTip(Me.Label9, "m - גיר ידני" & vbCrLf & "a - גיר אוטומט")
        
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        stquery = stquery & "update cars set car_bdate='" & DateTimePicker1.Value.Date & "',car_lic='" & TextBox3.Text & "-" & TextBox1.Text & "-" & TextBox2.Text & "', car_gear='" & ComboBox1.SelectedItem & "', car_typeid= '" & ComboBox2.SelectedItem.id & "', car_km='" & TextBox4.Text
        stquery = stquery & "' where car_id =" & Val(Label4.Text)
        MsgBox("!ההוספה בוצעה בהצלחה")
        db.insertUpdateDelete(stquery)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class