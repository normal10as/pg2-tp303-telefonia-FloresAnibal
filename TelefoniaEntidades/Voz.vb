Public Class Voz
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
        Return getDisponible() & " Minutos"
    End Function
End Class
