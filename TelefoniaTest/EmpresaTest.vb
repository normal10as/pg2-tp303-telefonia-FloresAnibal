Imports TelefoniaEntidades
Module EmpresaTest
    Sub Main()
        Dim empresa_1 As New Empresa("Guillermo S.A.", "12-12345678-0")
        empresa_1.Cuenta = 54321

        Console.WriteLine("Razon Social: " & empresa_1.RazonSocial)
        Console.WriteLine("CUIT: " & empresa_1.Cuit)
        Console.WriteLine("ToString: " & empresa_1.ToString)

        Console.ReadKey()
    End Sub
End Module
