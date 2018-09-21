Public Class sms
    Inherits Plan
    'campos



    'constructor
    Sub New(credito As UInteger, precio As Decimal)
        MyBase.New()
        MyBase.Credito = credito
        MyBase.Precio = precio
    End Sub


    'propiedades



    'metodos
    Public Overrides Function ToString() As String
        Return getDisponible() & " Mensajes"
    End Function
End Class
