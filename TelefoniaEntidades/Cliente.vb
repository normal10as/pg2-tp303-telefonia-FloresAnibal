Public MustInherit Class Cliente
    'campos
    Private _cuenta As UInteger
    Private _lineas As List(Of Linea)

    'constructor
    Sub New(cuenta As UInteger)
        cuenta = cuenta
        _lineas = New List(Of Linea)
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
    Friend Sub addLinea(linea As Linea)
        'linea.Cliente = Me  'asigno este cliente a la linea
        _lineas.Add(linea)
    End Sub

    Friend Sub removeLinea(linea As Linea)
        'linea.Cliente = Nothing 'quito a este cliente de la linea recibida
        _lineas.Remove(linea)
    End Sub

    Public Function getAllLineas() As List(Of Linea)
        Return _lineas
    End Function


End Class
