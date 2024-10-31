using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal
{
    public static class Condicionales_Anidados
    {
        public static void SubMenu()
        {
            bool stop = false;
            while (!stop)
            {
                Console.Clear();
                Console.WriteLine(@"
       Ejercicios de Condicionales Anidados:
    ---------------------------------------------
        1 - Ejercicio 1     11 - Ejercicio 11
        2 - Ejercicio 2     12 - Ejercicio 12
        3 - Ejercicio 3     13 - Ejercicio 13
        4 - Ejercicio 4     14 - Ejercicio 14
        5 - Ejercicio 5     15 - Ejercicio 15
        6 - Ejercicio 6     16 - Ejercicio 16
        7 - Ejercicio 7     17 - Ejercicio 17
        8 - Ejercicio 8     18 - Ejercicio 18
        9 - Ejercicio 9     19 - Ejercicio 19
        10 - Ejercicio 10   20 - Ejercicio 20
    ---------------------------------------------
        Ingrese S para Salir al Menú Anterior
    ---------------------------------------------
                ");
                Console.Write("   Ingrese la opción del ejercicio a ejecutar: ");
                string? opcion = Console.ReadLine();
                if (opcion == null) opcion = "";
                switch (opcion.ToLower())
                {
                    case "1":
                        Console.Clear();
                        Ejercicio1();
                        break;
                    case "2":
                        Console.Clear();
                        Ejercicio2();
                        break;
                    case "3":
                        Console.Clear();
                        Ejercicio3();
                        break;
                    case "4":
                        Console.Clear();
                        Ejercicio4();
                        break;
                    case "5":
                        Console.Clear();
                        Ejercicio5();
                        break;
                    case "6":
                        Console.Clear();
                        Ejercicio6();
                        break;
                    case "7":
                        Console.Clear();
                        Ejercicio7();
                        break;
                    case "8":
                        Console.Clear();
                        Ejercicio8();
                        break;
                    case "9":
                        Console.Clear();
                        Ejercicio9();
                        break;
                    case "10":
                        Console.Clear();
                        Ejercicio10();
                        break;
                    case "s":
                        stop = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(@"
    ------------------------------------------------------------
    
        Opción incorrecta. Presione una tecla para continuar.

    ------------------------------------------------------------
                        ");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine(@"
                ....VOLVIENDO AL MENÚ PRINCIPAL....
            ");
            Thread.Sleep(1000);
        }


        static void Ejercicio1()
        {
            Console.WriteLine(@"
        4.1.	Escribe un programa que lea una calificación numérica y
        determine la letra correspondiente según el siguiente criterio:
        •	Si la calificación es mayor o igual a 90, imprimir ""A"".
        •	Si la calificación es mayor o igual a 80 pero menor a 90, imprimir ""B"".
        •	Si la calificación es mayor o igual a 70 pero menor a 80, imprimir ""C"".
        •	Si la calificación es mayor o igual a 60 pero menor a 70, imprimir ""D"".
        •	Si la calificación es menor a 60, imprimir ""F""
            ");
            bool validInput = false;
            string? letterGrade = "";
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese la nota (0-100): ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor.Intente nuevamente.");
                    if (!int.TryParse(input, out int grade)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (grade < 0 || grade > 100) throw new ArgumentOutOfRangeException("", "La nota debe estar entre 0 y 100. Intente nuevamente.");
                    if (grade >= 90) letterGrade = "A";
                    else if (grade >= 80) letterGrade = "B";
                    else if (grade >= 70) letterGrade = "C";
                    else if (grade >= 60) letterGrade = "D";
                    Console.WriteLine($"La calificación correspondiente es: {letterGrade}");
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
                }
            }
            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }

        static void Ejercicio2()
        {
            Console.WriteLine(@"
    4.2. Escribe un programa que lea la edad de una persona y determine si puede votar:
    • Si la persona tiene 16 o 17 años, imprimir ""Voto opcional"".
    • Si la persona tiene 18 años o más, imprimir ""Voto obligatorio"".
    • Si la persona tiene menos de 16 años, imprimir ""No puede votar"".
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese la edad: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input, out int age)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (age < 0 || age > 120) throw new ArgumentOutOfRangeException("", "La edad debe estar entre 0 y 120. Intente nuevamente.");
                    if (age >= 18) Console.WriteLine("Voto obligatorio");
                    else if (age >= 16) Console.WriteLine("Voto opcional");
                    else Console.WriteLine("No puede votar");
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
                }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio3()
        {
            Console.WriteLine(@"
    4.3. Escribe un programa que lea la hora (en formato de 24 horas) y determine si es mañana, tarde, noche o madrugada:
    • Mañana: 6 a 11
    • Tarde: 12 a 17
    • Noche: 18 a 23
    • Madrugada: 0 a 5
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese la hora (0-23): ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input, out int hour)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (hour < 0 || hour > 23) throw new ArgumentOutOfRangeException("", "La hora debe estar entre 0 y 23. Intente nuevamente.");
                    if (hour >= 6 && hour <= 11) Console.WriteLine("Mañana");
                    else if (hour >= 12 && hour <= 17) Console.WriteLine("Tarde");
                    else if (hour >= 18 && hour <= 23) Console.WriteLine("Noche");
                    else Console.WriteLine("Madrugada");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }


        static void Ejercicio4()
        {
            Console.WriteLine(@"
    4.4. Escribe un programa que lea un número y determine si es positivo, negativo o cero.
    Si es positivo, determinar si es par o impar.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese un número: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input, out int number)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (number > 0)
                    {
                        Console.Write("Es Positivo");
                        if (number % 2 == 0) Console.WriteLine(" y es par...");
                        else Console.WriteLine(" y es impar...");
                    }
                    else if (number < 0) Console.WriteLine("Es Negativo");
                    else Console.WriteLine("Es Cero");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio5()
        {
            Console.WriteLine(@"
    4.5. Escribe un programa que lea una letra y determine si es una vocal o consonante,
    y si es mayúscula o minúscula.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese una letra: ");
                    char letter = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (!char.IsLetter(letter)) throw new FormatException("No es una letra. Intente nuevamente.");
                    if ("aeiou".Contains(char.ToLower(letter))) Console.WriteLine(char.IsUpper(letter) ? "Es una Vocal Mayúscula" : "Es una Vocal Minúscula");
                    else Console.WriteLine(char.IsUpper(letter) ? "Es una Consonante Mayúscula" : "Es una Consonante Minúscula");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio6()
        {
            Console.WriteLine(@"
    4.6. Escribe un programa que lea el precio de un producto y determine si es caro, barato o regular.
    • Barato: menos de 20
    • Regular: entre 20 y 50
    • Caro: más de 50
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese el precio del producto: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!float.TryParse(input, out float price)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (price < 0) throw new ArgumentOutOfRangeException("", "El precio no puede ser negativo. Intente nuevamente.");
                    if (price < 20) Console.WriteLine("Barato");
                    else if (price <= 50) Console.WriteLine("Regular");
                    else Console.WriteLine("Caro");

                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio7()
        {
            Console.WriteLine(@"
    4.7. Escribe un programa que lea tres números e imprima el mayor de ellos.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Ingrese tres números:");
                    string? input1 = Console.ReadLine();
                    string? input2 = Console.ReadLine();
                    string? input3 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2) || string.IsNullOrWhiteSpace(input3))
                        throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input1, out int num1) || !int.TryParse(input2, out int num2) || !int.TryParse(input3, out int num3))
                        throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    int max = num1;
                    if (num2 > max) max = num2;
                    if (num3 > max) max = num3;
                    Console.WriteLine($"El mayor es: {max}");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio8()
        {
            Console.WriteLine(@"
    4.8. Escribe un programa que lea una palabra y determine si es 'si' o 'no'.
    Si es 'si', determinar si es en minúscula o mayúscula, o combinación de ambas.
    Sino imprimir “no es ni si, ni no”.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese la palabra Si/No/SI/NO/si/no: ");
                    string? word = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(word)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (word.ToLower() == "si")
                        Console.WriteLine(word == "si" ? "Es 'si' en Minúscula" : (word == "SI" ? "Es 'SI' en Mayúscula" : "Es Si mixto"));
                    else if (word.ToLower() == "no") Console.WriteLine("Ingresó no");
                    else Console.WriteLine("No es ni si, ni no");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio9()
        {
            Console.WriteLine(@"
    4.9. Escribe un programa que lea una palabra y determine si es 'programar' o 'codificar'.
    Si es 'programar', imprimir 'Sos programador'.
    Si es 'codificar', imprimir 'Sos ¿codificador?'.
    Si es otra cosa imprimir “Debiste ingresar una de esas. Chau!”.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Te gusta programar o codificar?: ");
                    string? word = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(word)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    word = word.ToLower();
                    if (word == "programar") Console.WriteLine("Sos programador");
                    else if (word == "codificar") Console.WriteLine("Sos ¿codificador?");
                    else Console.WriteLine("Debiste ingresar una de esas. Chau!");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio10()
        {
            Console.WriteLine(@"
    4.10. Escribe un programa que lea el nivel de batería de un dispositivo y determine: 
    • Si la batería es mayor o igual al 80%, imprimir 'Batería alta'.
    • Si la batería es mayor o igual al 50% pero menor al 80%, imprimir 'Batería media'. 
    • Si la batería es mayor o igual al 20% pero menor al 50%, imprimir 'Batería baja'. 
    • Si la batería es menor al 20%, imprimir 'Batería crítica'.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Indique el nivel de batería: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input, out int battery)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (battery >= 80) Console.WriteLine("Batería alta");
                    else if (battery >= 50) Console.WriteLine("Batería media");
                    else if (battery >= 20) Console.WriteLine("Batería baja");
                    else Console.WriteLine("Batería crítica");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio11()
        {
            Console.WriteLine(@"
    4.11. Escribe un programa que lea el puntaje de un examen y
    determine si el estudiante aprobó o reprobó.
    Si aprobó, determinar si obtuvo una mención honorifica (puntaje mayor a 90).
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Indique el puntaje del examen: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input, out int score)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (score >= 60)
                    {
                        Console.Write("Aprobado");
                        if (score > 90) Console.Write(" con mención honorífica");
                        Console.WriteLine();
                    }
                    else Console.WriteLine("Reprobado");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio12()
        {
            Console.WriteLine(@"
    4.12. Escribe un programa que lea un año y determine si es bisiesto.
    Un año es bisiesto si es divisible por 4, pero no por 100,
    excepto que también sea divisible por 400.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Indique el año: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input, out int year)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    Console.WriteLine((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? "Es un año bisiesto" : "No es un año bisiesto");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio13()
        {
            Console.WriteLine(@"
    4.13. Escribe un programa que lea la cantidad de días trabajados en un mes y
    determine el salario mensual de una persona.
    Si los días trabajados son mayores a 20, agregar un bono del 10% al salario base.
    Si los días trabajados son mayores a 30, agregar otro bono del 10% al salario base.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Indique los días trabajados: ");
                    string? inputDays = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputDays)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(inputDays, out int daysWorked)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    Console.Write("Indique el salario base: ");
                    string? inputSalary = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputSalary)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!float.TryParse(inputSalary, out float baseSalary)) throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (daysWorked > 20) { baseSalary += baseSalary * 0.10f; if (daysWorked > 30) baseSalary += baseSalary * 0.10f; }
                    Console.WriteLine($"El salario es: {baseSalary}");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio14()
        {
            Console.WriteLine(@"
    4.14. Escribe un programa que permita leer dos valores y compararlos.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese el primer valor: ");
                    string? input1 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input1)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    Console.Write("Ingrese el segundo valor: ");
                    string? input2 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input2)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input1, out int value1) || !int.TryParse(input2, out int value2))
                        throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    if (value1 > value2) Console.WriteLine("El primer valor es mayor");
                    else if (value1 < value2) Console.WriteLine("El segundo valor es mayor");
                    else Console.WriteLine("Ambos valores son iguales");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio15()
        {
            Console.WriteLine(@"
    4.15. Escribe un programa que permita leer tres valores y
    almacenarlos en las variables A, B y C respectivamente.
    El algoritmo debe imprimir cual es el mayor y cuál es el menor.
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese el primer valor (A): ");
                    string? inputA = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputA)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    Console.Write("Ingrese el segundo valor (B): ");
                    string? inputB = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputB)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    Console.Write("Ingrese el tercer valor (C): ");
                    string? inputC = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputC)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(inputA, out int a) || !int.TryParse(inputB, out int b) || !int.TryParse(inputC, out int c))
                        throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    Console.WriteLine($"El mayor es: {Math.Max(a, Math.Max(b, c))}");
                    Console.WriteLine($"El menor es: {Math.Min(a, Math.Min(b, c))}");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio16()
        {
            Console.WriteLine(@"
    4.16. Escribe un programa que lea una palabra y determine si es 'Java', 'Python', 'C#', 'JavaScript'.
    Si es 'Java', imprimir 'Lenguaje robusto'.
    Si es 'Python', 'Lenguaje versátil'.
    Si es 'C#', 'Es el Java de Microsoft'.
    Si es 'JavaScript', 'Es muy bueno para Web'.
    Y si es otro, 'De ese no puedo opinar'. (considerar las mayúsculas y minúsculas).
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese un lenguaje de programación: ");
                    string? language = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(language)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    language = language.ToLower();
                    if (language == "java") Console.WriteLine("Lenguaje robusto");
                    else if (language == "python") Console.WriteLine("Lenguaje versátil");
                    else if (language == "c#") Console.WriteLine("Es el Java de Microsoft");
                    else if (language == "javascript") Console.WriteLine("Es muy bueno para Web");
                    else Console.WriteLine("De ese no puedo opinar");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio17()
        {
            Console.WriteLine(@"
    4.17. Escribe un programa que lea una cadena de texto y
    pida ingresar si es 'izquierda' o 'derecha'.
    Si es 'izquierda', imprimir 'Gira a la izquierda'.
    Si es 'derecha', imprimir 'Gira a la derecha'.
    Sino indicar 'Debió ingresar una de esas -_-'. (considerar las mayúsculas y minúsculas).
        ");
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese 'izquierda' o 'derecha': ");
                    string? direction = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(direction)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    direction = direction.ToLower();
                    if (direction == "izquierda") Console.WriteLine("Gira a la izquierda");
                    else if (direction == "derecha") Console.WriteLine("Gira a la derecha");
                    else Console.WriteLine("Debió ingresar una de esas -_-");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio18()
        {
            Console.WriteLine(@"
    4.18. Escribe un programa que active un switch ingresando
    la palabra 'ON' y lo apague con 'OFF'. (considerar las mayúsculas y minúsculas).
    Si ingresa 'ON', poner el switch en true y mostrar 'Ha sido encendido'.
    Si ingresa 'OFF' poner el switch en false y mostrar 'Ha sido apagado'.
    Sino mostrar 'No se indicó, por las dudas permanecerá apagado'.
        ");

            bool validInput = false;
            bool switchState = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese 'ON' o 'OFF' para activar o desactivar el switch: ");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    input = input.ToUpper();
                    if (input == "ON")
                    {
                        switchState = true;
                        Console.WriteLine("Ha sido encendido");
                    }
                    else if (input == "OFF")
                    {
                        switchState = false;
                        Console.WriteLine("Ha sido apagado");
                    }
                    else
                    {
                        Console.WriteLine("No se indicó, por las dudas permanecerá apagado");
                    }
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio19()
        {
            Console.WriteLine(@"
    4.19. Escribir un programa que pida ingresar tres números.
    Indicar si los 3 son impares o los 3 son pares.
    Indicar si hay 2 impares y 1 par o viceversa.
        ");

            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese el primer número: ");
                    string? input1 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input1)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    Console.Write("Ingrese el segundo número: ");
                    string? input2 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input2)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    Console.Write("Ingrese el tercer número: ");
                    string? input3 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input3)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input1, out int num1) || !int.TryParse(input2, out int num2) || !int.TryParse(input3, out int num3))
                        throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    int count1 = 0, count2 = 0; // count1: impares, count2: pares
                    if (num1 % 2 == 0) count2++; else count1++;
                    if (num2 % 2 == 0) count2++; else count1++;
                    if (num3 % 2 == 0) count2++; else count1++;
                    if (count2 == 3) Console.WriteLine("Los 3 son pares");
                    else if (count1 == 3) Console.WriteLine("Los 3 son impares");
                    else if (count1 == 2 && count2 == 1) Console.WriteLine("Hay 2 impares y 1 par");
                    else Console.WriteLine("Hay 2 pares y 1 impar");

                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

        static void Ejercicio20()
        {
            Console.WriteLine(@"
    4.20. Escribir un programa que pida ingresar tres números.
    Indicar si los 3 son impares o los 3 son pares.
    Indicar si hay 2 impares y 1 par o viceversa.
    Y, además, indicar si los 3 son positivos o negativos o si son 2 positivos y 1 negativo o viceversa.
        ");

            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("Ingrese el primer número: ");
                    string? input1 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input1)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    Console.Write("Ingrese el segundo número: ");
                    string? input2 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input2)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    Console.Write("Ingrese el tercer número: ");
                    string? input3 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input3)) throw new ArgumentNullException("", "No se ingresó ningún valor. Intente nuevamente.");
                    if (!int.TryParse(input1, out int num1) || !int.TryParse(input2, out int num2) || !int.TryParse(input3, out int num3))
                        throw new FormatException("La entrada no es un número válido. Intente nuevamente.");
                    int count1 = 0, count2 = 0;
                    int positiveCount = 0, negativeCount = 0;
                    if (num1 % 2 == 0) count2++; else count1++;
                    if (num2 % 2 == 0) count2++; else count1++;
                    if (num3 % 2 == 0) count2++; else count1++;
                    if (num1 > 0) positiveCount++; else negativeCount++;
                    if (num2 > 0) positiveCount++; else negativeCount++;
                    if (num3 > 0) positiveCount++; else negativeCount++;
                    if (count2 == 3) Console.WriteLine("Los 3 son pares");
                    else if (count1 == 3) Console.WriteLine("Los 3 son impares");
                    else if (count1 == 2 && count2 == 1) Console.WriteLine("Hay 2 impares y 1 par");
                    else Console.WriteLine("Hay 2 pares y 1 impar");
                    if (positiveCount == 3) Console.WriteLine("Los 3 son positivos");
                    else if (negativeCount == 3) Console.WriteLine("Los 3 son negativos");
                    else if (positiveCount == 2 && negativeCount == 1) Console.WriteLine("Hay 2 positivos y 1 negativo");
                    else Console.WriteLine("Hay 2 negativos y 1 positivo");
                    validInput = true;
                }
                catch (Exception ex) { Console.WriteLine("Ocurrió un error inesperado: " + ex.Message); }
            }
            Console.WriteLine(@"

    ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }

    }
}

