Public Class Form6
    Dim dt As DataTable
    Dim stquery As String
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        dt = db.dbselect("select * from car_types where cartype_model='" & ComboBox1.SelectedItem & "'")
        com2.Text = dt.Rows(0).Item("cartype_company")
        model2.Text = dt.Rows(0).Item("cartype_model")
        cou1.Text = dt.Rows(0).Item("cartype_countrey")
        cat1.SelectedItem = dt.Rows(0).Item("cartype_degree")
        pr1.Text = dt.Rows(0).Item("cartype_price")
        GroupBox1.Visible = True

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = db.dbselect("select cartype_model from car_types")
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i).Item("cartype_model"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bodek As Boolean = True
        Dim car As New CarType
        If cat1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cat1, "עליך לבחור קטגוריה")
            bodek = False
        End If
        Try
            car.company = com2.Text
        Catch ex As Exception
            ErrorProvider1.SetError(com2, ex.Message)
            bodek = False
        End Try
        Try
            car.model = model2.Text
        Catch ex As Exception
            ErrorProvider1.SetError(model2, ex.Message)
            bodek = False
        End Try
        Try
            car.countrey = cou1.Text
        Catch ex As Exception
            ErrorProvider1.SetError(cou1, ex.Message)
            bodek = False
        End Try
        Try
            car.price = pr1.Text
        Catch ex As Exception
            ErrorProvider1.SetError(pr1, ex.Message)
            bodek = False
        End Try
        If bodek = True Then
            stquery = stquery & "update car_types set cartype_company='" & car.company & "', cartype_model='" & car.model & "', cartype_countrey='" & car.countrey & "',cartype_degree='" & cat1.SelectedItem & "',cartype_price=" & car.price & " where cartype_model ='" & ComboBox1.SelectedItem & "'"
            MsgBox(stquery)
            db.insertUpdateDelete(stquery)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class