Imports TelefoniaEntidades
Module VozTest

    Sub Main()

        Dim voz_1 As New Voz(45, 70)
        Console.WriteLine("Consumo: 30")
        voz_1.NuevoConsumo(30)
        mostrar(voz_1)

        Console.WriteLine("Consumo: 30")
        voz_1.NuevoConsumo(30)
        mostrar(voz_1)

        Console.ReadKey()
    End Sub
    Private Sub mostrar(voz As Voz)
        Console.WriteLine("Credito: " & voz.Credito)
        Console.WriteLine("Precio: " & voz.Precio)
        Console.WriteLine("Disponible: " & voz.getDisponible)
        Console.WriteLine("ToString: " & voz.ToString)
        Console.WriteLine()
    End Sub
End Module
