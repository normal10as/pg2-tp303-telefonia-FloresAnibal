Public Class Persona
    Inherits Cliente
    'campos
    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger


    'constructor
    Sub New(apellido As String, nombre As String, documento As UInteger)
        Me.Apellido = apellido
        Me.Nombre = nombre
        Me.Documento = documento
    End Sub


    'propiedades
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If ValidarCadena(value, 30) Then _apellido = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value, 50) Then _nombre = value
        End Set
    End Property

    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
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
        Return Apellido & " " & Nombre & " - " & Cuenta
    End Function
End Class
