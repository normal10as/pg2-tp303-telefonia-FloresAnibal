Public Class Modelo
    'campos
    Private _nombre As String
    Private _marca As Marca


    'constructor
    Sub New(nombre As String, marca As Marca)
        Me.Nombre = nombre
        Me.Marca = marca
    End Sub


    'propiedades
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value, 50) Then _nombre = value
        End Set
    End Property

    Public Property Marca As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property


    'metodos
    'valida la longitud maxima y minima de un string
    Private Function ValidarCadena(cadena As String, maximo As UShort)
        If cadena.Length > 1 And cadena.Length <= maximo Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
