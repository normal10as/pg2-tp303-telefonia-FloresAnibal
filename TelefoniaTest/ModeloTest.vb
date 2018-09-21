Imports TelefoniaEntidades

Module ModeloTest
    Sub Main()
        Dim marca_1 As New Marca("Huawei")
        Dim modelo_1 As New Modelo("Honor", marca_1)

        mostrar(modelo_1)

        Console.ReadKey()
    End Sub

    Private Sub mostrar(valor As Modelo)
        Console.WriteLine("Modelo: " & valor.Nombre)
        Console.WriteLine("Marca: " & valor.Marca.Nombre)
        Console.WriteLine("ToString: " & valor.ToString)
        Console.WriteLine()
    End Sub
End Module
