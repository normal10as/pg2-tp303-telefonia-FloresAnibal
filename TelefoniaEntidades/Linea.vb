Public Class Linea
    'campos
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As Boolean
    Private _equipo As Equipo
    Private _cliente As Cliente

    'constructor
    Sub New(codigoArea As UShort, numero As UInteger, equipo As Equipo, cliente As Cliente)
        Me.CodigoArea = codigoArea
        Me.Numero = numero
        Me.Equipo = equipo
        _estado = True
        Me.Cliente = cliente
    End Sub


    'propiedades
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value >= 100 And value <= 9999 Then _codigoArea = value
        End Set
    End Property

    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value >= 100000 And value <= 9999999 Then _numero = value
        End Set
    End Property

    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Set(value As Equipo)
            _equipo = value
        End Set
    End Property

    Public ReadOnly Property Estado As String
        Get
            Return If(_estado, "", " - (Suspendida)")
        End Get
    End Property

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            value.addLinea(Me)
            _cliente = value
        End Set
    End Property

    'metodos
    Public Sub Suspender()
        _estado = False
    End Sub

    Public Sub Reactivar()
        _estado = True
    End Sub

    Public Overrides Function ToString() As String
        Return CodigoArea & " - " & Numero & Estado
    End Function

End Class
