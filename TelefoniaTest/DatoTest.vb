Imports TelefoniaEntidades
Module DatoTest

    Sub Main()
        Dim dato_1 As New Dato(50, 150)
        mostrar(dato_1)

        dato_1.NuevoConsumo(524288) '1/2 MB
        mostrar(dato_1)

        dato_1.NuevoConsumo(262144) '1/4 MB
        mostrar(dato_1)

        dato_1.NuevoConsumo(1048576) '1 MB
        mostrar(dato_1)

        dato_1.NuevoConsumo(3145728) '3 MB
        mostrar(dato_1)

        dato_1.NuevoConsumo(524288) '1/2 MB
        mostrar(dato_1)

        dato_1.NuevoConsumo(786432) '3/4 MB
        mostrar(dato_1)

        Console.ReadKey()
    End Sub
    Private Sub mostrar(dato As Dato)
        Console.WriteLine("Credito: " & dato.Credito)
        Console.WriteLine("Precio: " & dato.Precio)
        Console.WriteLine("Disponible: " & dato.getDisponible)
        Console.WriteLine("ToString: " & dato.ToString)
        ' Console.WriteLine("TotalByte: " & dato.TotalByte)
        Console.WriteLine()
    End Sub
End Module
