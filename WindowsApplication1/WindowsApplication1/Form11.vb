Public Class Form11
    Dim stquery As String
    Dim dt As DataTable
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt1 As DataTable
        dt = db.dbselect("select * from cars,car_types where cars.car_typeid=car_types.cartype_id")
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            If DateDiff(DateInterval.Year, dt.Rows(i).Item("car_bdate"), Today.Date) > 3 Then
                db.insertUpdateDelete("insert into carsforsale(carsforsale_lic, carsforsale_company, carsforsale_model, carsforsale_gear, carsforsale_km) values('" & dt.Rows(i).Item("car_lic") & "','" & dt.Rows(i).Item("cartype_company") & "','" & dt.Rows(i).Item("cartype_model") & "','" & dt.Rows(i).Item("car_gear") & "','" & dt.Rows(i).Item("car_km") & "')")
                db.insertUpdateDelete("update cars set car_sale=true where car_lic='" & dt.Rows(i).Item("car_lic") & "'")
            End If

        Next
        dt1 = db.dbselect("select * from carsforsale")
        DataGridView1.DataSource = dt1
        db.insertUpdateDelete("delete from carsforsale where 1=1")
    End Sub

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class