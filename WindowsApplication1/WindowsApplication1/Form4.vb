Public Class Form4
    Dim stquery As String
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Private Sub company1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles company1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") And Not (e.KeyChar >= "A" And e.KeyChar <= "z") And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) And e.KeyChar <> "-" Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub model1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles model1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") And Not (e.KeyChar >= "A" And e.KeyChar <= "z") And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) And e.KeyChar <> "-" Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub cou1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cou1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") And Not (e.KeyChar >= "A" And e.KeyChar <= "z") And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub pr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pr1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(8) And e.KeyChar <> "." Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bodek As Boolean = True
        Dim car As New cartype
        If cat1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cat1, "עליך לבחור קטגוריה")
            bodek = False
        End If
        Try
            car.company = company1.Text
        Catch ex As Exception
            ErrorProvider1.SetError(company1, ex.Message)
            bodek = False
        End Try
        Try
            car.model = model1.Text
        Catch ex As Exception
            ErrorProvider1.SetError(model1, ex.Message)
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
            stquery = stquery & "update car_types set cartype_company='" & car.company & "', cartype_model='" & car.model & "', cartype_countrey='" & car.countrey & "',cartype_degree='" & cat1.SelectedItem & "',cartype_price=" & car.price & " where cartype_id=" & Val(id1.Text)
            MsgBox(stquery)
            db.insertUpdateDelete(stquery)
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        db.insertUpdateDelete("insert into car_types(cartype_company) values(' ')")
        Dim dt As DataTable
        dt = db.dbselect("select * from car_types order by cartype_id")
        id1.Text = dt.Rows(dt.Rows.Count - 1).Item("cartype_id")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class