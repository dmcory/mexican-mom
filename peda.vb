Module peda

    Sub Main()
        Dim cartones As Integer

        Console.WriteLine("¿Cuantos cartones habra?")
        cartones = Console.ReadLine
        Console.WriteLine("¿Habra caguamas y charrones? s/n")
        If Console.ReadLine = "s" Or Console.ReadLine = "S" Then armarPachanga(cartones, True) Else armarPachanga(cartones, False)
    End Sub

    Sub armarPachanga(ByVal cartones As Integer, ByVal comboBronco As Boolean)
        'comboBronco = Charrones y caguamas
        If isWeekend(DateTime.Now) And cartones > 0 Then
            If comboBronco = True Then Console.WriteLine("Vamos a ponernos impertinentes") Else Console.WriteLine("Ya masco la iguana")
        Else
            Console.WriteLine("Que agüite")
        End If

        Console.ReadKey()
    End Sub

    Private Function isWeekend(ByVal dia As DateTime) As Boolean
        'Esta funcion nos devuelve si lo que le mandamos cae en alguno de los dias de abajo
        'Nos regresa un positivo si no, negativo
        Dim weekend() = {DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday}
        Return weekend.Contains(dia.DayOfWeek)
    End Function

End Module
