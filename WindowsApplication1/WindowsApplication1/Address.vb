Public Class Address
    Private pcity As String
    Private pstreet As String
    Private pnumhouse As Integer
    Public Sub New()

    End Sub
    Public Property city() As String
        Set(ByVal value As String)
            If Value.length = 0 Then Throw New Exception("שדה עיר ריק")
            pcity = value
        End Set
        Get
            Return Me.pcity
        End Get
    End Property
    Public Property street() As String
        Set(ByVal value As String)
            If Value.length = 0 Then Throw New Exception("שדה הרחוב ריק")
            pstreet = Value
        End Set
        Get
            Return Me.pstreet
        End Get
    End Property
    Public Property numhouse() As String
        Set(ByVal value As String)
            If value.Length = 0 Then Throw New Exception("שדה מספר בית ריק")
            pnumhouse = value
        End Set
        Get
            Return Me.pnumhouse
        End Get
    End Property


End Class
