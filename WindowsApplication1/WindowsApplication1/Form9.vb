Public Class Form9
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim stquery As String = ""
    Dim dt1 As DataTable

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Today.Date
        db.insertUpdateDelete("insert into treatment(car_lic) values(' ')")
        Dim dt As DataTable
        dt = db.dbselect("select * from treatment order by treatment_id")
        Label3.Text = dt.Rows(dt.Rows.Count - 1).Item("treatment_id")
        Dim dt1 As DataTable
        dt1 = db.dbselect("select * from cars")
        For i As Integer = 0 To dt1.Rows.Count - 1
            ComboBox2.Items.Add(dt1.Rows(i).Item("car_lic"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        stquery = stquery & "update treatment set car_lic='" & ComboBox2.SelectedItem & "', tratment_date='" & DateTimePicker1.Value.Date & "', treatment_type='" & ComboBox1.SelectedItem & "', treatment_remarks='" & RichTextBox1.Text
        stquery = stquery & "' where treatment_id =" & Val(Label3.Text)
        MsgBox("!הרכב נשלח לטיפול בהצלחה")
        db.insertUpdateDelete(stquery)
        db.insertUpdateDelete("update cars set car_maint=true where car_lic='" & ComboBox2.SelectedItem & "'")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class