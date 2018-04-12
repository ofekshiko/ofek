Public Class Form20
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dtt As DataTable
    Dim stquery As String = ""
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Visible = True
            Label2.Visible = True
            TextBox2.Visible = True
            Label3.Visible = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ComboBox1.Visible = True
            ComboBox1.Items.Clear()
            dt = db.dbselect("select cartype_company from cars,car_types where cars.car_typeid=car_types.cartype_id and cars.car_sale=true ")
            For i = 0 To dt.Rows.Count - 1
                ComboBox1.Items.Add(dt.Rows(i).Item("cartype_company"))
            Next
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ComboBox2.Visible = True
            ComboBox2.Items.Clear()
            dt = db.dbselect("select distinct cartype_model from cars,car_types where cars.car_typeid=car_types.cartype_id and cars.car_sale=true ")
            For i = 0 To dt.Rows.Count - 1
                ComboBox2.Items.Add(dt.Rows(i).Item("cartype_model"))
            Next
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ComboBox3.Visible = True
            ComboBox3.Items.Clear()
            dt = db.dbselect("select car_bdate from cars,car_types where cars.car_typeid=car_types.cartype_id and cars.car_sale=true ")
            Dim curyear As Integer = Today.Date.Year
            For i = curyear - 8 To curyear - 2
                ComboBox3.Items.Add(i)
            Next
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt10 As DataTable
        Dim stqr As String = "select * from cars, car_types where cars.car_typeid=car_types.cartype_id and cars.car_sale=true and 1=1"
        If CheckBox1.Checked = True Then stqr = stqr & " and cartype_priceforsale between " & Val(TextBox1.Text) & " and " & Val(TextBox2.Text)
        If CheckBox2.Checked = True Then stqr = stqr & " and cartype_company='" & ComboBox1.Text & "'"
        If CheckBox3.Checked = True Then stqr = stqr & " and cartype_model= '" & ComboBox2.Text & "'"
        If CheckBox4.Checked = True Then stqr = stqr & " and year(car_bdate)=" & Val(ComboBox3.Text)
        If CheckBox5.Checked = True Then stqr = stqr & " and car_gear ='a'"
        MsgBox(stqr)
        dt10 = db.dbselect(stqr)
        DataGridView1.DataSource = dt10
    End Sub

    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class