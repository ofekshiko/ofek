Public Class CarType
    Private pcompany As String
    Private pmodel As String
    Private pcountrey As String
    Private pdegree As String
    Private pprice As String
    Public Sub New()

    End Sub
    Public Property company() As String
        Get
            Return Me.pcompany
        End Get
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה חברת הרכב ריק")
            Me.pcompany = value
        End Set
    End Property
    Public Property model() As String
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה דגם רכב ריק")
            Me.pmodel = value
        End Set
        Get
            Return Me.pmodel
        End Get
    End Property
    Public Property countrey() As String
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה המדינה ריק")
            Me.pcountrey = value
        End Set
        Get
            Return Me.pcountrey
        End Get
    End Property
    Public Property degree() As String
        Set(ByVal value As String)
            Me.pdegree = value
        End Set
        Get
            Return Me.pdegree
        End Get
    End Property
    Public Property price() As String
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה המחיר ריק")
            Me.pprice = value
        End Set
        Get
            Return Me.pprice
        End Get
    End Property
End Class
