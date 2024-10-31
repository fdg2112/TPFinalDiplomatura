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
        1 - Ejercicio 1     6 - Ejercicio 6
        2 - Ejercicio 2     7 - Ejercicio 7
        3 - Ejercicio 3     8 - Ejercicio 8
        4 - Ejercicio 4     9 - Ejercicio 9
        5 - Ejercicio 5     10 - Ejercicio 10
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


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }

        static void Ejercicio5()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }
        static void Ejercicio6()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }
        static void Ejercicio7()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }
        static void Ejercicio8()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }
        static void Ejercicio9()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }
        static void Ejercicio10()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }
        static void Ejercicio11()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }

        static void Ejercicio12()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }

        static void Ejercicio13()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }

        static void Ejercicio14()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }

        static void Ejercicio15()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

            ");
            Thread.Sleep(5000);
        }
        static void Ejercicio16()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio17()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio18()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio19()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
        static void Ejercicio20()
        {
            Console.WriteLine(@"


            ");

            Console.WriteLine(@"

        ....VOLVIENDO AL MENÚ....

        ");
            Thread.Sleep(5000);
        }
    }
}

/*







//4.4.	Escribe un programa que lea un número y determine si es positivo, negativo o cero.
//Si es positivo, determinar si es par o impar.
Console.Write("Ingrese un numero: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.Write("Es Positivo");
    if (number % 2 == 0) Console.WriteLine(" y es par...");
    else Console.WriteLine(" y es impar...");
}
else if (number < 0) Console.WriteLine("Es Negativo");
else Console.WriteLine("Es cero");
Console.ReadKey();
Console.Clear();

//4.5.	Escribe un programa que lea una letra y
//determine si es una vocal o consonante,y si es mayúscula o minúscula.
Console.Write("Ingrese una letra: ");
char letter = Console.ReadKey().KeyChar;
if (char.IsLetter(letter))
{
    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') Console.WriteLine("Es una Vocal Minúscula");
    else if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U') Console.WriteLine("Es una Vocal Mayúscula");
    else if (char.IsUpper(letter)) Console.WriteLine("Es una Consonante Mayúscula");
    else Console.WriteLine("Es una Consonante Minúscula");
}
else Console.WriteLine("No es una letra");
Console.ReadKey();
Console.Clear();

//4.6.	Escribe un programa que lea el precio de un producto y
//determine si es caro, barato o regular. Considerar: 
//•	Barato: menos de 20
//•	Regular: entre 20 y 50
//•	Caro: más de 50
Console.WriteLine("Ingrese el precio del producto:");
float price = float.Parse(Console.ReadLine());
if (price < 20) Console.WriteLine("Barato");
else if (price <= 50) Console.WriteLine("Regular");
else Console.WriteLine("Caro");
Console.ReadKey();
Console.Clear();

//4.7.	Escribe un programa que lea tres números e imprima el mayor de ellos.
Console.WriteLine("Ingrese tres números:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1 >= num2 && num1 >= num3) Console.WriteLine($"El mayor es: {num1}");
else if (num2 >= num1 && num2 >= num3) Console.WriteLine($"El mayor es: {num2}");
else Console.WriteLine($"El mayor es: {num3}");
Console.ReadKey();
Console.Clear();

//4.8.	Escribe un programa que lea una palabra y determine si es "si" o "no".
//Si es "si", determinar si es en minúscula o mayúscula, o combinación de ambas.
//Sino imprimir “no es ni si, ni no”.
Console.Write("Ingrese la palabra Si/No/SI/NO/si/no: ");
string? word = Console.ReadLine();
if (word.ToLower() == "si")
{
    if (word == "si") Console.WriteLine("Es 'si' en Minúscula");
    else if (word == "SI") Console.WriteLine("Es 'SI' en Mayúscula");
    else Console.WriteLine("Es Si mixto");
}
else if (word.ToLower() == "no") Console.WriteLine("Ingresó no");
else Console.WriteLine("No es ni si, ni no");
Console.ReadKey();
Console.Clear();

//4.9.	Escribe un programa que lea una palabra y determine si es "programar" o "codificar".
//Si es "programar", imprimir "Sos programador".
//Si es "codificar", imprimir "Sos ¿codificador?".
//Si es otra cosa imprimir “Debiste ingresar una de esas. Chau!”
Console.Write("Te gusta programar o codificar?: ");
word = Console.ReadLine().ToLower();
if (word == "programar") Console.WriteLine("Sos programador");
else if (word == "codificar") Console.WriteLine("Sos ¿codificador?");
else Console.WriteLine("Debiste ingresar una de esas. Chau!");
Console.ReadKey();
Console.Clear();

//4.10.	Escribe un programa que lea el nivel de bateria de un dispositivo y determine: 
//•	Si la bateria es mayor o igual al 80%, imprimir "Bateria alta".
//•	Si la bateria es mayor o igual al 50% pero menor al 80%, imprimir "Bateria media". 
//•	Si la bateria es mayor o igual al 20% pero menor al 50%, imprimir "Bateria baja". 
//•	Si la bateria es menor al 20%, imprimir "Bateria critica".
Console.Write("Indique el nivel de batería: ");
int battery = int.Parse(Console.ReadLine());
if (battery >= 80) Console.WriteLine("Batería alta");
else if (battery >= 50) Console.WriteLine("Batería media");
else if (battery >= 20) Console.WriteLine("Batería baja");
else Console.WriteLine("Batería crítica");
Console.ReadKey();
Console.Clear();

//4.11.	Escribe un programa que lea el puntaje de un examen y
//determine si el estudiante aprobó o reprobó.
//Si aprobó, determinar si obtuvo una mención honorifica (puntaje mayor a 90).
Console.Write("Indique el puntaje del examen: ");
int score = int.Parse(Console.ReadLine());
if (score >= 60)
{
    Console.WriteLine("Aprobado");
    if (score > 90) Console.Write(" con mención honorífica");
}
else Console.WriteLine("Reprobado");
Console.ReadKey();
Console.Clear();

//4.12.	Escribe un programa que lea un año y determine si es bisiesto.
//Un año es bisiesto si es divisible por 4, pero no por 100,
//excepto que también sea divisible por 400
Console.Write("Indique el año: ");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) Console.WriteLine("Es un año bisiesto");
else Console.WriteLine("No es un año bisiesto");
Console.ReadKey();
Console.Clear();

//4.13.	Escribe un programa que lea la cantidad de dias trabajados en un mes y
//determine el salario mensual de una persona.
//Si los dias trabajados son mayores a 20, agregar un bono del 10% al salario base.
//Si los dias trabajados son mayores a 30, agregar otro bono del 10% al salario base.
Console.Write("Indique los días trabajados: ");
int daysWorked = int.Parse(Console.ReadLine());
Console.Write("Indique el salario base: ");
float baseSalary = int.Parse(Console.ReadLine());
if (daysWorked > 20)
{
    baseSalary += baseSalary * 0.10f;
    if (daysWorked > 30) baseSalary += baseSalary * 0.10f;
}
Console.WriteLine($"El salario es: {baseSalary}");
Console.ReadKey();
Console.Clear();

//4.14.	Escribe un programa que permita leer dos valores y compararlos.
Console.Write("Ingrese el primer valor: ");
int value1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo valor: ");
int value2 = int.Parse(Console.ReadLine());
if (value1 > value2) Console.WriteLine("El primer valor es mayor");
else if (value1 < value2) Console.WriteLine("El segundo valor es mayor");
else Console.WriteLine("Ambos valores son iguales");
Console.ReadKey();
Console.Clear();

//4.15.	Escribe un programa que permita leer tres valores y
//almacenarlos en las variables A, B y C respectivamente.
//El algoritmo debe imprimir cual es el mayor y cuál es el menor.
Console.Write("Ingrese el primer valor (A): ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo valor (B): ");
int b = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer valor (C): ");
int c = int.Parse(Console.ReadLine());
if (a > b && a > c) Console.WriteLine($"El mayor es: {a}");
else if (b > a && b > c) Console.WriteLine($"El mayor es: {b}");
else Console.WriteLine($"El mayor es: {c}");
if (a < b && a < c) Console.WriteLine($"El menor es: {a}");
else if (b < a && b < c) Console.WriteLine($"El menor es: {b}");
else Console.WriteLine($"El menor es: {c}");
Console.ReadKey();
Console.Clear();

//4.16.	Escribe un programa que lea una palabra y determine si es "Java", "Python", “C#”, “JavaScript”.
//Si es "Java", imprimir "Lenguaje robusto".
//Si es "Python", "Lenguaje versátil".
//Si es “C#”, “Es el Java de Microsoft”.
//Si es “JavaScript”, “Es muy bueno para Web”.
//Y si es otro, “De ese no puedo opinar”. (considerar las mayúsculas y minúsculas).
Console.Write("Ingrese un lenguaje de programación: ");
string? language = Console.ReadLine().ToLower();
if (language == "java") Console.WriteLine("Lenguaje robusto");
else if (language == "python") Console.WriteLine("Lenguaje versátil");
else if (language == "c#") Console.WriteLine("Es el Java de Microsoft");
else if (language == "javascript") Console.WriteLine("Es muy bueno para Web");
else Console.WriteLine("De ese no puedo opinar");
Console.ReadKey();
Console.Clear();

//4.17.	Escribe un programa que lea una cadena de texto y
//pida ingresar si es "izquierda" o "derecha".
//Si es "izquierda", imprimir "Gira a la izquierda".
//Si es "derecha", imprimir "Gira a la derecha".
//Sino indicar “Debió ingresar una de esas -_-”. (considerar las mayúsculas y minúsculas).
Console.Write("Ingrese 'izquierda' o 'derecha': ");
string? direction = Console.ReadLine().ToLower();
if (direction == "izquierda") Console.WriteLine("Gira a la izquierda");
else if (direction == "derecha") Console.WriteLine("Gira a la derecha");
else Console.WriteLine("Debió ingresar una de esas -_-");
Console.ReadKey();
Console.Clear();

//4.18.	Escribe un programa que active un switch ingresando
//la palabra “ON” y lo apague con “OFF”. (considerar las mayúsculas y minúsculas).
//Si ingresa “ON”, poner el switch en true y mostrar “Ha sido encendido”.
//Si ingresa “OFF” poner el switch en true y mostrar “Ha sido apagado”.
//Sino mostrar “No se indicó, por las dudas permanecerá apagado”
Console.Write("Ingrese 'ON' o 'OFF' para activar o desactivar el switch: ");
string input = Console.ReadLine().ToUpper();
bool switchState;
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
    switchState = false;
    Console.WriteLine("No se indicó, por las dudas permanecerá apagado");
}
Console.ReadKey();
Console.Clear();

//4.19.	Escribir un programa que pida ingresar tres números.
//Indicar si los 3 son impares o los 3 son pares.
//Indicar si hay 2 impares y 1 par o viceversa.
Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número: ");
num3 = int.Parse(Console.ReadLine());
int count1 = 0, count2 = 0;
if (num1 % 2 == 0) count2++; else count1++;
if (num2 % 2 == 0) count2++; else count1++;
if (num3 % 2 == 0) count2++; else count1++;
if (count2 == 3) Console.WriteLine("Los 3 son pares");
else if (count1 == 3) Console.WriteLine("Los 3 son impares");
else if (count1 == 2 && count2 == 1) Console.WriteLine("Hay 2 impares y 1 par");
else Console.WriteLine("Hay 2 pares y 1 impar");
Console.ReadKey();
Console.Clear();

//4.20.	Escribir un programa que pida ingresar tres números.
//Indicar si los 3 son impares o los 3 son pares.
//Indicar si hay 2 impares y 1 par o viceversa.
//Y, además, indicar si los 3 son positivos o negativos o si son 2 positivos y 1 negativo o viceversa.
Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número: ");
num3 = int.Parse(Console.ReadLine());
count1 = 0; 
count2 = 0; 
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
else if (negativeCount == 3) Console.WriteLine("Los son negtivos");
else if (positiveCount == 2 && negativeCount == 1) Console.WriteLine("Hay 2 positivos y 1 negativo");
else Console.WriteLine("Hay 2 negativos y 1 positivo");
Console.ReadKey();
Console.Clear();*/