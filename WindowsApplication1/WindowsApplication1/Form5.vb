Public Class Form5
    Dim dt As DataTable
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st As String = "?האם אתה בטוח שברצונך למחוק את דגם הרכב" & vbCrLf & dt.Rows(0).Item(1) & vbCrLf & dt.Rows(0).Item(2)
        Dim result As Integer = MsgBox(st, MsgBoxStyle.OkCancel + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight)
        If result = DialogResult.OK Then
            db.insertUpdateDelete("DELETE * from car_types where cartype_model ='" & combobox1.selecteditem & "'")
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = db.dbselect("select distinct cartype_model from car_types")
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i).Item("cartype_model"))
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        dt = db.dbselect("select * from car_types where cartype_model='" & ComboBox1.SelectedItem & "'")
       
            com1.Text = dt.Rows(0).Item("cartype_company")
        cat1.Text = dt.Rows(0).Item("cartype_degree")
        Label6.Text = dt.Rows(0).Item("cartype_price")
        gear1.Text = dt.Rows(0).Item("cartype_countrey")
            GroupBox1.Visible = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class