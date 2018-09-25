Imports TelefoniaEntidades

Module LineaTest
    Sub Main()

        Dim marca_1 As New Marca("Huawei")
        Dim modelo_1 As New Modelo("Honor", marca_1)
        Dim equipo_1 As New Equipo(modelo_1, 12345)

        Dim cliente_1 As Cliente
        cliente_1 = New Persona(1212, "Gomez", "Alejandra", 12345678)
        cliente_1.Cuenta = 1212

        Dim linea_1 As New Linea(376, 4565656, equipo_1, cliente_1)

        Mostrar(linea_1)

        linea_1.Suspender()
        Mostrar(linea_1)

        linea_1.Reactivar()
        Mostrar(linea_1)

        Dim linea_2 As New Linea(376, 4444444, equipo_1, cliente_1)
        Mostrar(linea_2)

        Console.ReadKey()
    End Sub

    Private Sub Mostrar(linea As Linea)
        Console.WriteLine("Cuenta de Cliente: " & linea.Cliente.Cuenta)
        Console.WriteLine("Codigo de Area: " & linea.CodigoArea)
        Console.WriteLine("Numero: " & linea.Numero)
        Console.WriteLine("ToString: " & linea.ToString)
        Console.WriteLine()
    End Sub

End Module
