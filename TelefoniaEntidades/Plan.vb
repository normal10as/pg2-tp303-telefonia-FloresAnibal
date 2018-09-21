Public MustInherit Class Plan
    'campos
    Private _credito As UInteger
    Private _precio As Decimal
    Private _consumo As UInteger

    'constructor
    Sub New()
        Credito = 0
        Precio = 0
        _consumo = 0
    End Sub


    'propiedades
    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Private ReadOnly Property Consumo As UInteger
        Get
            Return _consumo
        End Get
    End Property

    'metodos
    Public Overridable Sub NuevoConsumo(valor As UInteger)
        If _consumo + valor <= Credito Then _consumo += valor
    End Sub

    Public Function getDisponible()
        Return Credito - Consumo
    End Function
End Class
