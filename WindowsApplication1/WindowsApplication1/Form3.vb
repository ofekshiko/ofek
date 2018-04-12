Public Class Form3
    Dim stquery As String
    Dim dt As DataTable
    Dim db As New Database("d:\אופק2018\מסד נתונים.accdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st() As String
        dt = db.dbselect("select * from customers where cust_myid='" & TextBox1.Text & "'")
        If dt.Rows.Count = 0 Then
            MsgBox("הלקוח אינו קיים במערכת")
        Else
            TextBox2.Text = dt.Rows(0).Item("cust_fname")
            lname2.Text = dt.Rows(0).Item("cust_lname")
            DateTimePicker1.Value = dt.Rows(0).Item("cust_bdate")
            id2.Text = dt.Rows(0).Item("cust_myid")
            city2.Text = dt.Rows(0).Item("cust_city")
            street2.Text = dt.Rows(0).Item("cust_street")
            num2.Text = dt.Rows(0).Item("cust_numhouse")
            st = dt.Rows(0).Item("cust_email").split("@")
            email4.Text = st(0)
            email2.Text = st(1)
            st = dt.Rows(0).Item("cust_phone").split("-")
            numn3.SelectedItem = st(0)
            numn2.Text = st(1)
            st = dt.Rows(0).Item("cust_phonenumhome").split("-")
            numh3.SelectedItem = st(0)
            numh2.Text = st(1)
            GroupBox1.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dt As New MyDate
        Dim ad As New Address
        Dim cust As New customer
        Dim bodek As Boolean = True
        Try
            ad.city = city2.Text
        Catch ex As Exception
            ErrorProvider1.SetError(city2, ex.Message)
            bodek = False
        End Try
        Try
            ad.street = street2.Text
        Catch ex As Exception
            ErrorProvider1.SetError(street2, ex.Message)
            bodek = False
        End Try
        Try
            ad.numhouse = num2.Text
        Catch ex As Exception
            ErrorProvider1.SetError(num2, ex.Message)
            bodek = False
        End Try
        Try
            cust.fname = TextBox2.Text()
        Catch ex As Exception
            ErrorProvider1.SetError(TextBox2, ex.Message)
            bodek = False
        End Try
        Try
            cust.lname = lname2.Text
        Catch ex As Exception
            ErrorProvider1.SetError(lname2, ex.Message)
            bodek = False
        End Try
        Try
            cust.myid = id2.Text
        Catch ex As Exception
            ErrorProvider1.SetError(id2, ex.Message)
            bodek = False
        End Try
        If email2.Text.Length = 0 Then
            ErrorProvider1.SetError(email2, "לא הוקש צד שמאל של שדה הדואר")
            bodek = False
        End If

        If email4.Text.Length = 0 Then
            ErrorProvider1.SetError(email4, "לא הוקש צד ימין של שדה הדואר")
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
        If numn3.SelectedIndex = -1 Then
            ErrorProvider1.SetError(numn3, "עליך לבחור קידומת")
            bodek = False
        End If
        If numh3.SelectedIndex = -1 Then
            ErrorProvider1.SetError(numh3, "עליך לבחור קידומת")
            bodek = False
        End If
        If numh2.Text.Length = 0 Then
            ErrorProvider1.SetError(numh2, "עליך להקיש מספר טלפון ביתי")
            bodek = False
        End If
        If numn.Text.Length = 0 Then
            ErrorProvider1.SetError(numn, "עליך להקיש מספר טלפון נייד")
            bodek = False
        End If
        If bodek = True Then
            cust.email = email4.Text & "@" & email2.Text
            cust.phonen = numn3.SelectedItem & "-" & numn.Text
            cust.address = ad
            cust.bdate = dt
            stquery = stquery & "update customers set cust_fname='" & TextBox2.Text & "',cust_lname ='" & lname2.Text & "',cust_bdate='" & dt.day & "/" & dt.month & "/" & dt.year & "', cust_myid='" & id2.Text & "', cust_city='" & cust.address.city & "', cust_street='" & cust.address.street & "', cust_numhouse='" & cust.address.numhouse & "',cust_email ='" & cust.email
            stquery = stquery & "',cust_phone='" & numn3.SelectedItem & "-" & numn2.Text & "',cust_phonenumhome='" & numh3.SelectedItem & "-" & numh2.Text
            stquery = stquery & "' where cust_myid ='" & TextBox1.Text & "'"
            MsgBox(stquery)
            db.insertUpdateDelete(stquery)
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim form12 As New Form12()
        form12.ShowDialog()
        Me.Close()
    End Sub
End Class