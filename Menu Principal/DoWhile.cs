using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal
{
    public static class DoWhile
    {
        public static void SubMenu()
        {
            bool stop = false;
            while (!stop)
            {
                Console.Clear();
                Console.WriteLine(@"
       Ejercicios de Repetir - Hasta:
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



    }
}

/*
//6.1.Escribe un programa que imprima los números del 1 al 10.
int number = 1;
do
{
    Console.WriteLine(number);
    number++;
}
while (number <= 10);
Console.ReadKey();
Console.Clear();

//6.2.Escribe un programa que sume los números ingresados hasta
//introducir uno impar. Mostrar el resultado.
int sum = 0;
number = 0;
do
{
    Console.Write("Ingrese un número: ");
    number = int.Parse(Console.ReadLine());
    if (number % 2 == 0) sum += number;
}
while (number % 2 == 0);
Console.WriteLine($"La suma es: {sum}");
Console.ReadKey();
Console.Clear();

//6.3.Escribe un programa que sume los números impares y multiplique
//los pares del 1 hasta el 100. Mostrar los resultados.
int sumImpar = 0;
int productPar = 1;
number = 1;
do
{
    if (number % 2 == 0) productPar *= number;
    else sumImpar += number;
    number++;
}
while (number <= 100);
Console.WriteLine($"La suma de impares es: {sumImpar}");
Console.WriteLine($"El producto de pares es: {productPar}");
Console.ReadKey();
Console.Clear();
//6.4.Escribe un programa que muestre las palabras indicadas y pida
//nuevas hasta indicar que debe “parar” o “salir”.
string word;
do
{
    Console.Write("Ingrese una palabra (o 'parar'/'salir' para terminar): ");
    word = Console.ReadLine().ToLower();
    if (word != "parar" && word != "salir") Console.WriteLine($"La palabra ingresada fue: {word}");
}
while (word != "parar" && word != "salir");
Console.WriteLine("El programa ha terminado.");
Console.ReadKey();
Console.Clear();
//6.5.Escribe un programa que imprima los números del 1 hasta el 20,
//pero sólo los impares. Debe acumular los números pares y mostrar el resultado.
sum = 0;
number = 1;
do
{
    if (number % 2 != 0) Console.WriteLine(number);
    else sum += number;
    number++;
}
while (number <= 20);
Console.WriteLine($"La suma de los números pares es: {sum}");
Console.ReadKey();
Console.Clear();
//6.6.Escribe un programa que sume los números ingresados,
//pero sólo los múltiplos de 3.El programa debe seguir pidiendo números
//hasta que se le indique que pare. Mostrar el resultado.
sum = 0;
string input;
do
{
    Console.Write("Ingrese un número (o 'stop' para terminar): ");
    input = Console.ReadLine().ToLower();
    if (input != "stop")
    {
        number = int.Parse(input);
        if (number % 3 == 0) sum += number;
    }
}
while (input != "stop");
Console.WriteLine($"La suma de los múltiplos de 3 es: {sum}");
Console.ReadKey();
Console.Clear();
//6.7.Escribe un programa que sume los números impares ingresados y los divida por 2.
//Los números pares deben sumarse y dividirse por 3. El programa frenará cuando uno
//de los resultados supere los 100. Mostrar los resultados
int sum1 = 0, sum2 = 0;
do
{
    Console.Write("Ingrese un número: ");
    number = int.Parse(Console.ReadLine());
    if (number % 2 != 0) sum1 += number / 2;
    else sum2 += number / 3;

}
while (sum1 <= 100 && sum2 <= 100);
Console.WriteLine($"La suma de impares/2 es: {sum1}");
Console.WriteLine($"La suma de pares/3 es: {sum2}");
Console.ReadKey();
Console.Clear();
//6.8.Escribe un programa que imprima los números ingresados, pero sólo los que
//sean múltiplos de 3 o 5 hasta que su suma supere los 50. Después debe imprimir
//los números ingresados que sean múltiplos de 2 hasta indicar que debe parar con
//la instrucción “stop”. Sumar los resultados de ambos listados y mostrarlos.
sum = 0;
int sumMultiples = 0;
input = "";
do
{
    Console.Write("Ingrese un número: ");
    number = int.Parse(Console.ReadLine());
    if ((number % 3 == 0 || number % 5 == 0) && sumMultiples <= 50)
    {
        Console.WriteLine(number);
        sumMultiples += number;
    }
}
while (sumMultiples <= 50);
Console.WriteLine("Ingrese números múltiplos de 2 hasta que ingrese 'stop':");
do
{
    Console.Write("Ingrese un número (o 'stop' para terminar): ");
    input = Console.ReadLine().ToLower();
    if (input != "stop")
    {
        number = int.Parse(input);
        if (number % 2 == 0)
        {
            Console.WriteLine(number);
            sum += number;
        }
    }
}
while (input != "stop");
Console.WriteLine($"La suma de ambos listados es: {sum + sumMultiples}");
Console.ReadKey();
Console.Clear();

//6.9.Escribe un programa que multiplique los números del 1 al 30, pero sólo los que
//sean múltiplos de 3 o 5. Debe sumar los múltiplos de 2 del 31 al 50. Debe dividir
//por 3 cada par entre 50 y 100 y sumarlos. Mostrar el resultado.
int productMultiples = 1;
sumMultiples = 0;
int sumDivided = 0;
number = 1;
//do
//{
//    if (number % 3 == 0 || number % 5 == 0) productMultiples *= number;
//    number++;
//}
//while (number <= 30);
//number++;
//do
//{
//    if (number % 2 == 0) sumMultiples += number;
//    number++;
//}
//while (number <= 50);
//number++;
//do
//{
//    if (number % 2 == 0) sumDivided += number / 3;
//    number++;
//}
//while (number <= 100);
do
{
    if ((number <= 30) && (number % 3 == 0 || number % 5 == 0)) productMultiples *= number;
    if ((number > 30) && (number <= 50) && (number % 2 == 0)) sumMultiples += number;
    if ((number > 50) && (number <= 100) && (number % 2 == 0)) sumDivided += number / 3;
    number++;
}
while (number <= 100);
Console.WriteLine($"Producto de múltiplos de 3 o 5 (1 al 30): {productMultiples}");
Console.WriteLine($"Suma de múltiplos de 2 (31 al 50): {sumMultiples}");
Console.WriteLine($"Suma de pares divididos por 3 (50 al 100): {sumDivided}");
Console.ReadKey();
Console.Clear();
//6.10.Escribe un programa que sume los números del 1 al 50, pero sólo
//los que sean múltiplos de 4 o 6 y los guarde en una variable.
//Una vez finalizado el ciclo, preguntar por sí o por no, si se quiere volver a ejecutarlo.
//Una vez finalizado sumar todos los resultados y mostrarlos.
sum = 0;
string repeat;
do
{
    int localSum = 0;
    number = 1;
    do
    {
        if (number % 4 == 0 || number % 6 == 0) localSum += number;
        number++;
    }
    while (number <= 50);
    sum += localSum;
    Console.WriteLine($"La suma de múltiplos de 4 o 6 en este ciclo es: {localSum}");
    Console.Write("¿Desea volver a ejecutar el programa? (si/no): ");
    repeat = Console.ReadLine().ToLower();
}
while (repeat == "si");
Console.WriteLine($"La suma total de todos los ciclos es: {sum}");
Console.ReadKey();
Console.Clear();
//6.11.Escribe un programa que imprima caracteres, excepto números o símbolos.
//Una vez ingresado una letra debe parar y mostrar qué se ingresó.
char inputchar;
do
{
    Console.Write("Ingresa un caracter (no números, ni símbolos): ");
    inputchar = Console.ReadKey().KeyChar;
}
while (!char.IsLetter(inputchar));
Console.WriteLine($"Ingresaste la letra: {inputchar}");

//6.12.Escribe un programa que sume de dos en dos los números impares en un rango
//de datos ingresado y los duplique. Se debe verificar que el rango ingresado sea válido.
//Mostrar el resultado.
int startRange, endRange;
sum = 0;
do
{
    Console.Write("Ingrese el inicio del rango: ");
    startRange = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el fin del rango: ");
    endRange = int.Parse(Console.ReadLine());
    if (startRange >= endRange)
        Console.WriteLine("Rango inválido. El inicio debe ser menor que el final.");
}
while (startRange >= endRange);
number = startRange;
do
{
    if (number % 2 != 0) sum += number * 2; // Si es impar, lo sumamos y lo duplicamos
    number += 2; // Suma de dos en dos
}
while (number <= endRange);
Console.WriteLine($"La suma de los números impares duplicados es: {sum}");
Console.ReadKey();
Console.Clear();
//6.13.Escribe un programa que imprima los números del 1 al 50, 
//pero sólo los que sean múltiplos de 2, 3 o 5.
//Este programa se debe repetir hasta que el usuario lo indique.
//Al final mostrar la suma de los resultados de todos los ciclos.
sum = 0;
string userResponse;
do
{
    int partialSum = 0;
    number = 1;
    do
    {
        if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
        {
            Console.WriteLine(number);
            partialSum += number;
        }
        number++;
    }
    while (number <= 50);
    sum += partialSum;
    Console.WriteLine($"La suma de los múltiplos en este ciclo es: {partialSum}");
    Console.Write("¿Desea repetir el programa? (S/N): ");
    userResponse = Console.ReadLine().ToUpper();
}
while (userResponse == "S");
Console.WriteLine($"La suma total de todos los ciclos es: {sum}");
Console.ReadKey();
Console.Clear();

//6.14.Escribe un programa que acumule los números ingresados,
//y divida por 2 aquellos que sean múltiplos de 4. El bucle debe repetirse
//hasta llegar a superar los 100 o si el numero acumulado es divisible por 5.
//Indicar porqué criterio se finalizó el bucle.
int accumulated = 0;
string exitReason = "";
do
{
    Console.Write("Ingrese un número: ");
    number = int.Parse(Console.ReadLine());
    if (number % 4 == 0) accumulated += number / 2;
    else accumulated += number;
    if ((accumulated > 100) && (accumulated % 5 == 0)) exitReason = "el acumulado superó los 100 y es divisible por 5";
    else if (accumulated % 5 == 0) exitReason = "el acumulado es divisible por 5";
    else if (accumulated > 100) exitReason = "el acumulado superó los 100";
}
while (accumulated <= 100 && accumulated % 5 != 0);
Console.WriteLine($"El programa finalizó porque: {exitReason}");
Console.WriteLine($"El acumulado final es: {accumulated}");
Console.ReadKey();
Console.Clear();

//6.15.Escribir un programa que pida ingresar letras. Debe contarse cada vocal ingresada
//y mostrarse al final. El programa debe finalizar cuando una vocal se llegue a 4 veces ingresada.
int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;
char letter;
exitReason = "";
do
{
    Console.Write("Ingrese una letra: ");
    letter = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
    switch (letter)
    {
        case 'a': aCount++; break;
        case 'e': eCount++; break;
        case 'i': iCount++; break;
        case 'o': oCount++; break;
        case 'u': uCount++; break;
    }
    if (aCount == 4) exitReason = "La vocal 'a' fue ingresada 4 veces";
    else if (eCount == 4) exitReason = "La vocal 'e' fue ingresada 4 veces";
    else if (iCount == 4) exitReason = "La vocal 'i' fue ingresada 4 veces";
    else if (oCount == 4) exitReason = "La vocal 'o' fue ingresada 4 veces";
    else if (uCount == 4) exitReason = "La vocal 'u' fue ingresada 4 veces";
}
while (aCount < 4 && eCount < 4 && iCount < 4 && oCount < 4 && uCount < 4);
Console.WriteLine($"El programa finalizó porque: {exitReason}");
Console.WriteLine($"Conteo de vocales - a: {aCount} e: {eCount}, i: {iCount}, o: {oCount}, u: {uCount}");
Console.ReadKey();
Console.Clear();

//6.16.Escribe un programa que imprima los números del 1 al 100, pero sólo
//los que sean múltiplos de 4 o 5, pero no de 20. Acumular la suma de los números
//impresos e indicar cuantas veces el programa debe repetirse. Mostrar el total de
//la suma de los ciclos.
int totalSum = 0;
int repeatCount = 0;
Console.Write("¿Cuantas veces desea repetir el programa?: ");
int cycleCount = int.Parse(Console.ReadLine());
do
{
    int cycleSum = 0;
    do
    {
        if ((number % 4 == 0 || number % 5 == 0) && number % 20 != 0)
        {
            Console.WriteLine(number);
            cycleSum += number;
        }
    } while (number <= 100);
    totalSum += cycleSum;
    repeatCount++;
    Console.WriteLine($"La suma de este ciclo es: {cycleSum}");
}
while (repeatCount <= cycleCount);
Console.WriteLine($"La suma total de todos los ciclos es: {totalSum}");
Console.ReadKey();
Console.Clear();

//6.17.Escribe un programa que sume los números del 1 al 100, pero sólo los que sean
//múltiplos de 5, pero no de 10. Se debe indicar al principio cuantas veces se ejecutará
//el programa. Al finalizar mostrar el resultado de cada ciclo y la suma del total.
totalSum = 0;
int repetitions;
Console.Write("¿Cuántas veces desea ejecutar el programa?: ");
repetitions = int.Parse(Console.ReadLine());
do
{
    sum = 0;
    number = 1;
    do
    {
        if (number % 5 == 0 && number % 10 != 0) sum += number;
        number++;
    }
    while (number <= 100);
    totalSum += sum;
    Console.WriteLine($"Suma de este ciclo: {sum}");
    repetitions--;
}
while (repetitions > 0);
Console.WriteLine($"La suma total es: {totalSum}");
Console.ReadKey();
Console.Clear();

//6.18.Escribe un programa que pida ingresar palabras. Al finalizar debe mostrar
//la primera. Para finalizar escribir “s”
string firstWord = "";
bool isFirst = true;
do
{
    Console.Write("Ingrese una palabra (escriba 's' para salir): ");
    word = Console.ReadLine();
    if (isFirst && word.ToLower() != "s")
    {
        firstWord = word;
        isFirst = false;
    }
}
while (word.ToLower() != "s");
Console.WriteLine($"La primera palabra ingresada fue: {firstWord}");
Console.ReadKey();
Console.Clear();

//6.19.Escribe un programa que acumule los números del 1 al X, pero sólo
//los que sean múltiplos de 3, y de 4 o 6, pero no de 8 o de 9.
int x;
sum = 0;
Console.Write("Ingrese un valor para X: ");
x = int.Parse(Console.ReadLine());
number = 1;
do
{
    if ((number % 3 == 0) && (number % 4 == 0 || number % 6 == 0) 
                          && !(number % 8 == 0 || number % 9 == 0))
    {
        sum += number;
    }
    number++;
}
while (number <= x);
Console.WriteLine($"La suma de los números es: {sum}");
Console.ReadKey();
Console.Clear();

//6.20.Escribe un programa que multiplique los números impares ingresados
//y al final muestre el resultado. El programa debe indicar que cuando se ingrese
//la letra “S” o “s” el programa debe terminará.
int product = 1;
do
{
    Console.Write("Ingrese un número impar (escriba 's' para salir): ");
    input = Console.ReadLine();
    if (input.ToLower() != "s")
    {
        number = int.Parse(input);
        if (number % 2 != 0) product *= number;
    }
}
while (input.ToLower() != "s");
Console.WriteLine($"El producto de los números impares es: {product}");
Console.ReadKey();
Console.Clear();
*/