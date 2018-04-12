Public Class Form10
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt1 As DataTable
        dt1 = db.dbselect("select cars.car_lic as clc from treatment,cars where treatment.car_lic=cars.car_lic and car_maint=true")
        For i As Integer = 0 To dt1.Rows.Count - 1
            ComboBox1.Items.Add(dt1.Rows(i).Item("clc"))
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        db.insertUpdateDelete("update cars set car_maint=false where car_lic='" & ComboBox1.SelectedItem & "'")
        MsgBox("!הרכב הוחזר בחזרה לדף הזמינים")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class