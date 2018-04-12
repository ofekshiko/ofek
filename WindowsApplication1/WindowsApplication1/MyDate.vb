Public Class MyDate
    Private pday As Integer
    Private pmonth As Integer
    Private pyear As Integer
    Public Sub New()

    End Sub
    Public Property day() As Integer
        Set(ByVal value As Integer)
            If value <= 0 Then Throw New Exception("יום לא חוקי")
            Me.pday = value
        End Set
        Get
            Return Me.pday
        End Get
    End Property
    Public Property month() As Integer
        Set(ByVal value As Integer)
            If value <= 0 Then Throw New Exception("חודש לא חוקי")
            Me.pmonth = value
        End Set
        Get
            Return Me.pmonth
        End Get
    End Property
    Public Property year() As Integer
        Set(ByVal value As Integer)
            If value <= 0 Then Throw New Exception("שנה לא חוקי")
            Me.pyear = value
        End Set
        Get
            Return Me.pyear
        End Get
    End Property


End Class
