Public Class Itdat
    Dim pid As String
    Dim pname As String

    Public Sub New(ByVal id As String, ByVal name As String)
        Me.pid = id
        Me.pname = name
    End Sub
        Property id() as string
        Get
            Return Me.pid
        End Get
        Set(ByVal value As String)
            Me.pid = value
        End Set
    End Property
    Property name() As String
        Get
            Return Me.pname
        End Get
        Set(ByVal value As String)
            Me.pname = value
        End Set
    End Property



End Class
