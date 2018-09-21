Imports TelefoniaEntidades
Module smsTest
    Sub Main()

        Dim sms_1 As New sms(45, 70)
        Console.WriteLine("Consumo: 30")
        sms_1.NuevoConsumo(30)
        mostrar(sms_1)

        Console.WriteLine("Consumo: 30")
        sms_1.NuevoConsumo(30)
        mostrar(sms_1)

        Console.ReadKey()
    End Sub
    Private Sub mostrar(sms As sms)
        Console.WriteLine("Credito: " & sms.Credito)
        Console.WriteLine("Precio: " & sms.Precio)
        Console.WriteLine("Disponible: " & sms.getDisponible)
        Console.WriteLine("ToString: " & sms.ToString)
        Console.WriteLine()
    End Sub
End Module
