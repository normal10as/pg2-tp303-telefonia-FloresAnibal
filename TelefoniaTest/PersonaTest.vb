Imports TelefoniaEntidades
Module PersonaTest
    Sub Main()

        Dim persona_1 As New Persona("Gonzales", "Ramon", 12345678)
        persona_1.Cuenta = 12345

        Console.WriteLine("Nombre: " & persona_1.Nombre)
        Console.WriteLine("Apellido: " & persona_1.Apellido)
        Console.WriteLine("Documento: " & persona_1.Documento)
        Console.WriteLine("ToString: " & persona_1.ToString)

        Console.ReadKey()

    End Sub
End Module
