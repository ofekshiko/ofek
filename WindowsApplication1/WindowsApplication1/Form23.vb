Public Class Form23
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dtt As DataTable
    Dim stquery As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = db.dbselect("select * from treatment, cars where cars.car_lic=treatment.car_lic and car_maint=true")
        For i As Integer = 0 To dt.Rows.Count - 1
            If DateDiff(DateInterval.Day, dt.Rows(i).Item("tratment_date"), Today.Date) > 7 Then

                MsgBox(dt.Rows(i).Item("treatment_id"))
            End If
        Next
    End Sub

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class