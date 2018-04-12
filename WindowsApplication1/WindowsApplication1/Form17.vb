Public Class Form17
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dtt As DataTable
    Dim stquery As String = ""
    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dt = db.dbselect("select * from customers")
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(New Itdat(dt.Rows(i).Item("cust_myid"), dt.Rows(i).Item("cust_fname") & " " & dt.Rows(i).Item("cust_lname") & "(" & dt.Rows(i).Item("cust_myid") & ")"))
        Next
        ComboBox1.DisplayMember = "name"
        dt1 = db.dbselect("select distinct cartype_company as ct from cars,car_types where car_types.cartype_id= cars.car_typeid and car_sale=true")
        ComboBox3.Items.Clear()
        For i = 0 To dt1.Rows.Count - 1
            ComboBox3.Items.Add(dt1.Rows(i).Item("ct"))
        Next
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ToolTip1.ShowAlways = True
        ToolTip1.SetToolTip(Me.Label12, "m - גיר ידני" & vbCrLf & "a - גיר אוטומט")
        db.insertUpdateDelete("insert into salles(sale_custid) values(0)")
        dtt = db.dbselect("select * from salles")
        Label14.Text = dtt.Rows(dtt.Rows.Count - 1).Item("sale_id")
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        dt = db.dbselect("select distinct cartype_model from cars,car_types where car_types.cartype_id= cars.car_typeid and car_sale=true and cartype_company='" & ComboBox3.SelectedItem & "'")
        ComboBox4.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ComboBox4.Items.Add(dt.Rows(i).Item("cartype_model"))
        Next
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        dt = db.dbselect("select distinct car_gear from cars,car_types where car_types.cartype_id= cars.car_typeid and car_sale=true and cartype_company='" & ComboBox3.SelectedItem & "'and cartype_model='" & ComboBox4.SelectedItem & "'")
        ComboBox5.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ComboBox5.Items.Add(dt.Rows(i).Item("car_gear"))
        Next
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        dt = db.dbselect("select distinct car_lic from cars,car_types where car_types.cartype_id= cars.car_typeid and car_sale=true and cartype_company='" & ComboBox3.SelectedItem & "' and cartype_model='" & ComboBox4.SelectedItem & "' and car_gear= '" & ComboBox5.SelectedItem & "'")
        ComboBox6.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ComboBox6.Items.Add(dt.Rows(i).Item("car_lic"))
        Next
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        dt = db.dbselect("select distinct car_km from cars,car_types where car_types.cartype_id= cars.car_typeid and car_sale=true and cartype_company='" & ComboBox3.SelectedItem & "' and cartype_model='" & ComboBox4.SelectedItem & "' and car_gear= '" & ComboBox5.SelectedItem & "' and car_lic= '" & ComboBox6.SelectedItem & "'")
        For i = 0 To dt.Rows.Count - 1
            Label13.Text = (dt.Rows(i).Item("car_km"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = db.dbselect("select cartype_price from cars,car_types where car_types.cartype_id= cars.car_typeid and car_sale=true and cartype_company='" & ComboBox3.SelectedItem & "' and cartype_model='" & ComboBox4.SelectedItem & "' and car_gear= '" & ComboBox5.SelectedItem & "' and car_lic= '" & ComboBox6.SelectedItem & "'")
        GroupBox1.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label8.Visible = True

        Label9.Text = dt.Rows(0).Item("cartype_price") * (675)
        Label11.Text = (Label9.Text) * (1.17)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        stquery = stquery & "update salles set sale_custid='" & ComboBox1.SelectedItem.id & "',sale_company='" & ComboBox3.SelectedItem & "', sale_model='" & ComboBox4.SelectedItem & "', sale_gear= '" & ComboBox5.SelectedItem & "', sale_lic='" & ComboBox6.SelectedItem & "', sale_price= '" & Label9.Text & "', sale_pricemam='" & Label11.Text
        stquery = stquery & "' where sale_id =" & Val(Label14.Text)
        MsgBox("!ההזמנה בוצעה בהצלחה")
        db.insertUpdateDelete(stquery)
        db.insertUpdateDelete("delete from cars where car_lic ='" & ComboBox6.SelectedItem & "'")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
End Class