Imports TelefoniaEntidades

Module EquipoTest
    Sub Main()
        Dim marca_1 As New Marca("Huawei")
        Dim modelo_1 As New Modelo("Honor", marca_1)
        Dim equipo_1 As New Equipo(modelo_1, 12345)
        equipo_1.Vender(Today)

        Console.WriteLine("Serie: " & equipo_1.Serie)
        Console.WriteLine("Modelo: " & equipo_1.Modelo.Nombre)
        Console.WriteLine("Fecha de Venta: " & equipo_1.FechaVenta)
        Console.WriteLine("ToString: " & equipo_1.ToString)

        Console.ReadKey()
    End Sub
End Module
