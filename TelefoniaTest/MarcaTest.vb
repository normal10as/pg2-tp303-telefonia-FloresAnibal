Imports TelefoniaEntidades

Module MarcaTest

    Sub Main()
        Dim marca_1 As New Marca("Huawei")
        Mostrar(marca_1)

        Dim marca_2 As New Marca("")
        Mostrar(marca_2)

        Dim marca_3 As New Marca("HuaweiHuaweiHuaweiHuaweiHuaweiHuawei")
        Mostrar(marca_3)

        Console.ReadKey()
    End Sub
    Private Sub Mostrar(Marca As Marca)
        Console.WriteLine("Marca: " & Marca.Nombre)
        Console.WriteLine("ToString: " & Marca.ToString)
        Console.WriteLine()
    End Sub
End Module
