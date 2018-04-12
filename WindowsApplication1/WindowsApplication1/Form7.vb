Public Class Form7
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dtt As DataTable
    Dim dt1 As DataTable
    Dim dt As DataTable
    Dim stquery As String = ""
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Today.Date
        DateTimePicker2.MinDate = Today.Date
        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ToolTip1.ShowAlways = True
        ToolTip1.SetToolTip(Me.Label2, "m - גיר ידני" & vbCrLf & "a - גיר אוטומט")
        dt = db.dbselect("select * from customers")
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(New Itdat(dt.Rows(i).Item("cust_myid"), dt.Rows(i).Item("cust_fname") & " " & dt.Rows(i).Item("cust_lname") & "(" & dt.Rows(i).Item("cust_myid") & ")"))
        Next
        ComboBox1.DisplayMember = "name"
        Dim dt4 As New DataTable
        db.insertUpdateDelete("insert into orders(order_custid) values(0)")
        dt4 = db.dbselect("select * from orders order by order_id")
        order1.Text = dt4.Rows(dt4.Rows.Count - 1).Item("order_id")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        dt = db.dbselect("select distinct cartype_company from car_types where cartype_degree='" & ComboBox2.SelectedItem & "'")
        ComboBox3.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ComboBox3.Items.Add(dt.Rows(i).Item("cartype_company"))
        Next
        com.Visible = True
        ComboBox3.Visible = True

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        dt = db.dbselect("select * from car_types where cartype_company='" & ComboBox3.SelectedItem & "' and cartype_degree='" & ComboBox2.SelectedItem & "'")
        ComboBox5.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ComboBox5.Items.Add(dt.Rows(i).Item("cartype_model"))
        Next
        Label3.Visible = True
        ComboBox5.Visible = True
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        dt = db.dbselect("select distinct car_gear from car_types,cars where car_types.cartype_id=cars.car_typeid and  cartype_company='" & ComboBox3.SelectedItem & "' and cartype_degree='" & ComboBox2.SelectedItem & "' and cartype_model='" & ComboBox5.SelectedItem & "'")
        ComboBox4.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ComboBox4.Items.Add(dt.Rows(i).Item("car_gear"))
        Next
        Label1.Visible = True
        Label2.Visible = True
        ComboBox4.Visible = True
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        dt = db.dbselect("select * from car_types,cars where car_types.cartype_id=cars.car_typeid and  cartype_company='" & ComboBox3.SelectedItem & "' and cartype_degree='" & ComboBox2.SelectedItem & "' and cartype_model='" & ComboBox5.SelectedItem & "' and car_gear= '" & ComboBox4.SelectedItem & "' and car_rent=false and car_maint=false and car_sale=false")
        ComboBox6.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ComboBox6.Items.Add(dt.Rows(i).Item("car_lic"))
        Next
        Label4.Visible = True
        ComboBox6.Visible = True
    End Sub
    Private Sub DateTimePicker2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.LostFocus
        days.Text = (DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date))
    End Sub


    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateAdd(DateInterval.Day, 1, DateTimePicker1.Value.Date)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = db.dbselect("select * from car_types where cartype_model= '" & ComboBox5.SelectedItem & "'")
        GroupBox1.Visible = True
        pr.Visible = True
        pr1.Visible = True
        Label6.Visible = True
        Label7.Visible = True

        pr1.Text = dt.Rows(0).Item("cartype_price") * Val(days.Text)
        Label7.Text = (pr1.Text) * (1.17)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim bodek As Boolean = True
        If ComboBox1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "עלייך לבחור פרטי לקוח")
            bodek = False
        End If
        If ComboBox2.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox2, "עלייך לבחור קטגוריית רכב")
            bodek = False
        End If
        If ComboBox3.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox3, "עלייך לבחור את חברת הרכב")
            bodek = False
        End If
        If ComboBox5.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox5, "עלייך לבחור את דגם הרכב")
            bodek = False
        End If
        If ComboBox4.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox4, "עלייך לבחור את הגיר הרצוי")
            bodek = False
        End If
        If ComboBox6.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox6, "עלייך לבחור את מזהה הרכב הזמין במלאי")
            bodek = False
        End If
        If bodek = True Then
            stquery = stquery & "update orders set order_custid='" & ComboBox1.SelectedItem.id & "',order_dates='" & DateTimePicker1.Value.Date & "', order_datef='" & DateTimePicker2.Value.Date & "', order_category='" & ComboBox2.SelectedItem & "',order_company='" & ComboBox3.SelectedItem & "', order_model='" & ComboBox5.SelectedItem & "', order_gear= '" & ComboBox4.SelectedItem & "', order_lic='" & ComboBox6.SelectedItem & "', order_price= '" & pr1.Text & "', order_pricemam='" & Label7.Text
            stquery = stquery & "' where order_id =" & Val(order1.Text)
            MsgBox("!ההזמנה בוצעה בהצלחה")
            db.insertUpdateDelete(stquery)
            db.insertUpdateDelete("update cars set car_rent=true where car_lic='" & ComboBox6.SelectedItem & "'")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class