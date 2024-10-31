using Menu_Principal;

bool stop = false;
while (!stop)
{
    try
    {
        Console.Clear();
        Console.WriteLine(@"
              Ejercicios de la Dilplonatura:
    --------------------------------------------------
       1 - Condicionales Anidados   4 - Bucle For
       2 - Bucle While              5 - Strings
       3 - Bucle Do...While         6 - Arrays
    --------------------------------------------------
        Presione Tecla S - Para salir del programa
    --------------------------------------------------
    ");
        Console.Write("   Ingrese la opción del ejercicio a ejecutar: ");
        string? opcion = Console.ReadLine();
        if (opcion == null) opcion = "";

        switch (opcion.ToUpper())
        {
            case "1":
                Console.Clear();
                Condicionales_Anidados.SubMenu();
                break;
            case "2":
                Console.Clear();
                // Acá podrías llamar a otro método para el ejercicio de While
                break;
            case "3":
                Console.Clear();
                // Llamada al ejercicio de Do...While
                break;
            case "4":
                Console.Clear();
                // Llamada al ejercicio de For
                break;
            case "5":
                Console.Clear();
                // Llamada al ejercicio de Strings
                break;
            case "6":
                Console.Clear();
                // Llamada al ejercicio de Arrays
                break;
            case "S":
                stop = true;
                break;
            default:
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Opción incorrecta. Presione una tecla para continuar.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }
}
Console.WriteLine(@"
                ....SALIENDO....
    ");
Thread.Sleep(3000);
