Public Class Cliente
    'campos
    Private _cuenta As UInteger


    'constructor
    Sub New()
        _cuenta = 0
    End Sub


    'propiedades
    Public Property Cuenta() As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property


    'metodos


End Class
