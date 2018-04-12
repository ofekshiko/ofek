Public Class Form1
    Dim stquery As String
    Dim ot As Boolean = False
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles id.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(8) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fname.KeyPress
        If (e.KeyChar < "א" Or e.KeyChar > "ת") And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lname.KeyPress
        If (e.KeyChar < "א" Or e.KeyChar > "ת") And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles number.KeyPress
        If number.Text.Length = 0 And e.KeyChar >= "א" And e.KeyChar <= "ת" Then
            e.KeyChar = Chr(vbCancel)
        End If
        If number.Text.Length = 0 And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.KeyChar = Chr(vbCancel)
        End If

        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(8) And number.Text.Length > 0 And ot = True Then
            e.KeyChar = Chr(vbCancel)
        End If
        If number.Text.Length > 0 And e.KeyChar >= "א" And e.KeyChar <= "ת" And ot = False Then
            ot = True


        End If
        If e.KeyChar = Chr(8) And ot = True Then ot = False
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles city.KeyPress
        If (e.KeyChar < "א" Or e.KeyChar > "ת") And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles street.KeyPress
        If (e.KeyChar < "א" Or e.KeyChar > "ת") And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numn.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(8) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numhouse.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(8) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(8) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(8) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = CDate("1/1/1940")
        DateTimePicker1.MaxDate = CDate("1/1/2001")
        db.insertUpdateDelete("insert into customers(cust_fname) values(' ')")
        Dim dt As DataTable

        dt = db.dbselect("select * from customers")
        Label3.Text = dt.Rows(dt.Rows.Count - 1).Item("cust_id")
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9") And Not (e.KeyChar >= "A" And e.KeyChar <= "z") And e.KeyChar <> "_" And e.KeyChar <> "." And e.KeyChar <> Chr(8) Then
            e.KeyChar = Chr(vbCancel)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New MyDate
        Dim ad As New Address
        Dim cust As New customer
        Dim bodek As Boolean = True
        Try
            ad.city = city.Text
        Catch ex As Exception
            ErrorProvider1.SetError(city, ex.Message)
            bodek = False
        End Try
        Try
            ad.street = street.Text
        Catch ex As Exception
            ErrorProvider1.SetError(street, ex.Message)
            bodek = False
        End Try
        Try
            ad.numhouse = number.Text
        Catch ex As Exception
            ErrorProvider1.SetError(number, ex.Message)
            bodek = False
        End Try
        Try
            cust.fname = fname.Text
        Catch ex As Exception
            ErrorProvider1.SetError(fname, ex.Message)
            bodek = False
        End Try
        Try
            cust.lname = lname.Text
        Catch ex As Exception
            ErrorProvider1.SetError(lname, ex.Message)
            bodek = False
        End Try
        Try
            cust.myid = id.Text
        Catch ex As Exception
            ErrorProvider1.SetError(id, ex.Message)
            bodek = False
        End Try
        If email1.Text.Length = 0 Then
            ErrorProvider1.SetError(email1, "לא הוקש צד שמאל של שדה הדואר")
            bodek = False
        End If

        If email2.Text.Length = 0 Then
            ErrorProvider1.SetError(email2, "לא הוקש צד ימין של שדה הדואר")
            bodek = False
        End If
        Try
            dt.day = DateTimePicker1.Value.Day
        Catch ex As Exception

        End Try
        Try
            dt.month = DateTimePicker1.Value.Month
        Catch ex As Exception

        End Try
        Try
            dt.year = DateTimePicker1.Value.Year
        Catch ex As Exception

        End Try
        If ComboBox1.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "עליך לבחור קידומת")
            bodek = False
        End If
        If ComboBox2.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox2, "עליך לבחור קידומת")
            bodek = False
        End If
        If numhouse.Text.Length = 0 Then
            ErrorProvider1.SetError(numhouse, "עליך להקיש מספר טלפון ביתי")
            bodek = False
        End If
        If numn.Text.Length = 0 Then
            ErrorProvider1.SetError(numn, "עליך להקיש מספר טלפון נייד")
            bodek = False
        End If
        If bodek = True Then
            cust.email = email1.Text & "@" & email2.Text
            cust.phonen = ComboBox1.SelectedItem & "-" & numn.Text
            cust.address = ad
            cust.bdate = dt
            stquery = stquery & "update customers set cust_fname='" & cust.fname & "',cust_lname ='" & cust.lname & "',cust_bdate='" & dt.day & "/" & dt.month & "/" & dt.year & "', cust_myid='" & cust.myid & "', cust_city='" & cust.address.city & "', cust_street='" & cust.address.street & "', cust_numhouse='" & cust.address.numhouse & "',cust_email ='" & cust.email
            stquery = stquery & "',cust_phone='" & ComboBox1.SelectedItem & "-" & numn.Text & "',cust_phonenumhome='" & ComboBox2.SelectedItem & "-" & numhouse.Text

            stquery = stquery & "' where cust_id =" & Val(Label3.Text)
            MsgBox(stquery)
            db.insertUpdateDelete(stquery)
        End If


    End Sub

    Private Sub email1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class