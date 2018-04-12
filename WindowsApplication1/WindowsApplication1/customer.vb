Public Class customer
    Private pfname As String
    Private plname As String
    Private pbdate As MyDate
    Private pmyid As String
    Private paddress As Address
    Private pemail As String
    Private numn As String
    Public Sub New()

    End Sub
    Public Property fname() As String
        Set(ByVal value As String)
            If value.length = 0 Then Throw New Exception("שדה שם פרטי ריק")
            pfname = value
        End Set
        Get
            Return Me.pfname
        End Get
    End Property
    Public Property lname() As String
        Set(ByVal value As String)
            If Value.length = 0 Then Throw New Exception("שדה שם משפחה ריק")
            plname = Value
        End Set
        Get
            Return Me.plname
        End Get
    End Property
    Public Property bdate() As MyDate
        Set(ByVal value As MyDate)
            Me.pbdate = value
        End Set
        Get
            Return Me.pbdate
        End Get
    End Property

    Public Property myid() As String
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה תעודת זהות ריק")
            pmyid = value
        End Set
        Get
            Return Me.pmyid
        End Get
    End Property
    Public Property address() As Address
        Set(ByVal value As Address)
            Me.paddress = value
        End Set
        Get
            Return Me.paddress
        End Get
    End Property
    Public Property email() As String
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה אימייל ריק")
            pemail = value
        End Set
        Get
            Return Me.pemail
        End Get
    End Property
    Public Property phonen() As String
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה טלפון נייד ריק")
        End Set
        Get
            Return Me.numn
        End Get
    End Property

End Class
