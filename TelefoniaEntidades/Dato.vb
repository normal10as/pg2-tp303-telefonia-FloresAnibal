Public Class Dato
    Inherits Plan
    'campos
    Private _totalBytes As UInteger


    'constructor
    Sub New(credito As UInteger, precio As Decimal)
        MyBase.New()
        MyBase.Credito = credito
        MyBase.Precio = precio
        TotalByte = 0
    End Sub


    'propiedades
    Private Property TotalByte As UInteger
        Get
            Return _totalBytes
        End Get
        Set(value As UInteger)
            _totalBytes = value
        End Set
    End Property


    'metodos
    Public Overrides Function ToString() As String
        Return getDisponible() & " Megabytes"
    End Function

    Public Overrides Sub NuevoConsumo(valor As UInteger)
        '1048576 bytes = 1 MB
        TotalByte += valor  'acumulo el valor en byte recibido mas lo ya consumido anteriormente

        'Si el valor acumulado en bytes llega al mega envio la funcion
        'y retorna el valor etero en megas que debo guardar
        If TotalByte >= 1048576 Then
            MyBase.NuevoConsumo(calcularMegas(TotalByte))
        End If
    End Sub

    Private Function calcularMegas(bytes As UInteger)
        'el resto de la division es el nuevo restante de bytes que debo almacenar
        TotalByte = bytes Mod 1048576
        'con la division devuelvo los megas que debo registrar
        Return Math.Truncate(bytes / 1048576)
    End Function

    'Public Overrides Sub NuevoConsumo(valor As UInteger)
    '    '1048576 bytes = 1 MB
    '    valor += TotalByte 'acumulo el valor en byte recibido mas lo ya consumido anteriormente

    '    'Si el valor acumulado en bytes llega al mega envio la funcion
    '    'y retorna el valor etero en megas que debo guardar
    '    If valor >= 1048576 Then
    '        MyBase.NuevoConsumo(calcularMegas(valor))
    '    End If
    'End Sub

    'Private Function calcularMegas(bytes As UInteger)
    '    'el resto de la division es el nuevo restante de bytes que debo almacenar
    '    TotalByte = bytes Mod 1048576
    '    'con la division devuelvo los megas que debo registrar
    '    Return bytes / 1048576
    'End Function
End Class
