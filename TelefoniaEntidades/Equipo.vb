Public Class Equipo
    'campos
    Private _serie As String
    Private _fechaVenta As Date
    Private _modelo As Modelo

    'constructor
    Sub New(modelo As Modelo, serie As String)
        Me.Serie = serie
        Me.Modelo = modelo
        _fechaVenta = Nothing
    End Sub


    'propiedades
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If ValidarCadena(value, 15) Then _serie = value
        End Set
    End Property

    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    Public Property Modelo As Modelo
        Get
            Return _modelo
        End Get
        Set(value As Modelo)
            _modelo = value
        End Set
    End Property

    'metodos
    Public Sub Vender(value As Date)
        _fechaVenta = value
    End Sub

    'valida la longitud maxima y minima de un string
    Private Function ValidarCadena(cadena As String, maximo As UShort)
        If cadena.Length > 1 And cadena.Length <= maximo Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function ToString() As String
        Return Serie
    End Function

End Class
