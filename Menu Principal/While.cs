using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal
{
    public static class While
    {
    }
}

/*
//5.1.Escribe un programa que imprima los números del 10 al 100 de 10 en 10.
int number = 10;
while (number <= 100)
{
    Console.WriteLine(number);
    number += 10;
}
Console.ReadKey();
Console.Clear();

//5.2.Escribe un programa que imprima los números pares del 2 al 200.
number = 2;
while (number <= 200)
{
    Console.WriteLine(number);
    number += 2;
}
Console.ReadKey();
Console.Clear();

//5.3.Escribe un programa que sume los números impares del 1 al 100.
//Debe imprimir el texto “La suma es:” y el valor de la suma.
number = 1;
int sum = 0;
while (number <= 100)
{
    if (number % 2 != 0) sum += number;
    number++;
}
Console.WriteLine($"La suma es: {sum}");
Console.ReadKey();
Console.Clear();

//5.4.Escribe un programa que lea palabras hasta que se ingrese "fin"
//(debe indicarse esto al usuario). Imprimir todas las palabras ingresadas
//con un mensaje “La palabra ingresada fue” y la palabra.
//Al final indicar que el programa se finalizó por haberlo indicado. 
string? word = "";
while (word != "fin")
{
    Console.Write("Ingrese una palabra (escriba 'fin' para salir): ");
    word = Console.ReadLine();
    if (word != "fin") Console.WriteLine($"La palabra ingresada fue: {word}");
}
Console.WriteLine("El programa se ha finalizado.");
Console.ReadKey();
Console.Clear();

//5.5.Escribe un programa que imprima la suma de los números ingresados,
//pero sólo de los impares. Cuando se ingrese uno par, el programa debe parar
//y mostrar el resultado.
number = 0;
sum = 0;
Console.Write("Ingrese un número: ");
number = int.Parse(Console.ReadLine());
while (number % 2 != 0)
{
    sum += number;
    Console.Write("Ingrese un número: ");
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine("La suma de los números impares es: " + sum);
Console.ReadKey();
Console.Clear();

//number = 0;
//sum = 0;
//while (true)
//{
//    Console.Write("Ingrese un número: ");
//    number = int.Parse(Console.ReadLine());
//    if (number % 2 == 0) break;
//    if (number % 2 != 0) sum += number;
//}
//Console.WriteLine("La suma de los números impares es: " + sum);

//5.6.Escribe un programa que sume los números del 1 al 20,
//pero sólo los múltiplos de 3. Mostrar el resultado.
number = 1;
sum = 0;
while (number <= 20)
{
    if (number % 3 == 0) sum += number;
    number++;
}
Console.WriteLine($"La suma de los múltiplos de 3 es: {sum}");
Console.ReadKey();
Console.Clear();

//5.7.Escribe un programa que sume los números del 1 al 40,
//pero sólo los múltiplos de 4, y al final que los divida por 2.
//Mostrar el resultado.
number = 1;
sum = 0;
while (number <= 40)
{
    if (number % 4 == 0) sum += number;
    number++;
}
Console.WriteLine($"La suma de los múltiplos de 4 es: {sum}");
Console.WriteLine($"La suma dividida por 2 es: {sum/2}");
Console.ReadKey();
Console.Clear();

//5.8.Escribe un programa que pida ingresar números
//que sean múltiplos de 3 y 5, los sume, y muestre el resultado al final.
//El programa debe correr hasta que la suma sea igual o mayor a 50.
number = 0;
sum = 0;
while (sum < 50)
{
    Console.Write("Ingrese un número múltiplo de 3 Y 5: ");
    number = int.Parse(Console.ReadLine());
    if (number % 3 == 0 && number % 5 == 0) sum += number;
}
Console.WriteLine($"La suma total es: {sum}");
Console.ReadKey();
Console.Clear();

//5.9.Escribe un programa que multiplique los números ingresados.
//Debe preguntar si desea ingresar un número y correr hasta ingresar “no”.
//(Tomar en cuenta mayúsculas y minúsculas).
number = 0;
int product = 1;
string? response = "";
while (response.ToLower() != "no")
{
    Console.Write("Desea ingresar un número (si/no): ");
    response = Console.ReadLine();
    if (response.ToLower() != "no")
    {
        Console.Write("Ingrese un número: ");
        number = int.Parse(Console.ReadLine());
        product *= number;
    }
}
Console.WriteLine($"El producto de los números ingresados es: {product}");
Console.ReadKey();
Console.Clear();

//5.10.Escribe un programa que sume los números ingresados que sean múltiplos de 4 o 6.
//Y que multiplique aquellos que sean múltiplos de 3.
//El programa debe correr hasta que el resultado de la suma o la multiplicación sea mayor a 50.
//Mostrar el resultado de la suma y/o de la multiplicación dependiendo si salieron del bucle.
sum = 0;
product = 1;
number = 0;
while (sum <= 50 && product <= 50)
{
    Console.Write("Ingrese un número: ");
    number = int.Parse(Console.ReadLine());
    if (number % 4 == 0 || number % 6 == 0) sum += number;
    if (number % 3 == 0) product *= number;
}
if (sum > 50) Console.WriteLine($"La suma es mayor a 50: {sum}");
if (product > 50) Console.WriteLine($"El producto es mayor a 50: {product}");
Console.ReadKey();
Console.Clear();

//5.11.Escribe un programa que sume los números del 1 al 50 y los duplique,
//pero sólo los que sean múltiplos de 4 y 6. Mostrar el resultado.
sum = 0;
number = 1;
while (number <= 50)
{
    if (number % 4 == 0 && number % 6 == 0) sum += number;
    number++;
}
Console.WriteLine($"El resultado es: {sum * 2}");
Console.ReadKey();
Console.Clear();

//5.12.Escribe un programa que imprima los números del 1 al 50,
//pero sólo los que sean múltiplos de 2, 3 o 5.
number = 1;
while (number <= 50)
{
    if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) Console.WriteLine(number);
    number++;
}
Console.ReadKey();
Console.Clear();

//5.13.Escribe un programa que divida por 3 los números ingresados y los sume,
//pero sólo los que sean múltiplos de 3 y no de 6. Mostrar el resultado al final.
//Debe preguntar si desea ingresar un número y correr hasta ingresar “no”.
//(Tomar en cuenta mayúsculas y minúsculas).
sum = 0;
response = "si";
number = 0;
while (response.ToLower() != "no")
{
    Console.Write("¿Desea ingresar un número? (si/no): ");
    response = Console.ReadLine();
    if (response.ToLower() == "si")
    {
        Console.Write("Ingrese el número: ");
        number = int.Parse(Console.ReadLine());
        if (number % 3 == 0 && number % 6 != 0) sum += number / 3;
    }
}
Console.WriteLine($"El resultado es: {sum}");
Console.ReadKey();
Console.Clear();

//5.14.Escribe un programa que imprima los números del 1 al 100,
//pero sólo los que sean múltiplos de 4 o 5, pero no de 20.
//Al finalizar debe mostrar la suma.
sum = 0;
number = 1;
while (number <= 100)
{
    if ((number % 4 == 0 || number % 5 == 0) && number % 20 != 0)
    {
        Console.WriteLine(number);
        sum += number;
    }
    number++;
}
Console.WriteLine($"La suma es: {sum}");
Console.ReadKey();
Console.Clear();

//5.15.Escribe un programa que sume los números del 1 al 100,
//pero sólo los que sean múltiplos de 7 o 11, pero no de 5.
//Al finalizar debe mostrar la división por 3 de la suma de todos los resultados.
//Mostrar el resultado.
sum = 0;
number = 1;
while (number <= 100)
{
    if ((number % 7 == 0 || number % 11 == 0) && number % 5 != 0) sum += number;
    number++;
}
Console.WriteLine($"El resultado final es: {sum / 3}");
Console.ReadKey();
Console.Clear();

//5.16.Escribe un programa que multiplique los números del 1 al 100,
//pero sólo los que sean múltiplos de 3 y de 5 o de 7, pero no de 15.
//Mostrar el resultado.
int result = 1;
number = 1;
while (number <= 100)
{
    if (((number % 3 == 0 && number % 5 == 0) || number % 7 == 0) && number % 15 != 0)
        result *= number;
    number++;
}
Console.WriteLine($"El resultado de la multiplicación es: {result}");
Console.ReadKey();
Console.Clear();

//5.17.Escribe un programa que sume los números pares ingresados
//y al final muestre el resultado. El programa debe indicar que
//cuando se ingrese la letra “S” o “s” el programa debe terminará.
sum = 0;
string input = "";
number = 0;
while (input != "S" && input != "s")
{
    Console.Write("Ingrese un número par (o 'S' para salir): ");
    input = Console.ReadLine();
    if (int.TryParse(input, out number) && number % 2 == 0)
        sum += number;
}
Console.WriteLine($"La suma de los números pares ingresados es: {sum}");
Console.ReadKey();
Console.Clear();

//5.18.Escribe un programa que lea una palabra y determine
//si es "programar" o "codificar". Si es "programar", imprimir "¡genial!".
//Si es "codificar", imprimir "¡bravo!". Si es otra cosa imprimir
//“Debes ingresar una de esas dos ¡Inténtalo de nuevo!”
word = "";
while (word != "programar" && word != "codificar")
{
    Console.Write("Ingrese una palabra ('programar' o 'codificar'): ");
    word = Console.ReadLine().ToLower();
    if (word == "programar")
        Console.WriteLine("¡Genial!");
    else if (word == "codificar")
        Console.WriteLine("¡Bravo!");
    else
        Console.WriteLine("Debes ingresar una de esas dos ¡Inténtalo de nuevo!");
}
Console.ReadKey();
Console.Clear();

//5.19.Escribe un programa que active un switch ingresando
//la palabra “ON” y lo apague con “OFF”. (considerar las mayúsculas y minúsculas).
//Si ingresa “ON”, poner el switch en true y mostrar “Ha sido encendido”.
//Si ingresa “OFF” poner el switch en true y mostrar “Ha sido apagado”.
//Sino mostrar “No se puede ir hasta tomar una decisión”.
bool isSwitchOn = false;
string command = "";
while (command != "ON" && command != "OFF")
{
    Console.Write("Ingrese 'ON' para encender o 'OFF' para apagar: ");
    command = Console.ReadLine().ToUpper();
    if (command == "ON")
    {
        isSwitchOn = true;
        Console.WriteLine("Ha sido encendido.");
    }
    else if (command == "OFF")
    {
        isSwitchOn = false;
        Console.WriteLine("Ha sido apagado.");
    }
    else
        Console.WriteLine("No se puede ir hasta tomar una decisión.");
}
Console.ReadKey();
Console.Clear();
//5.20.Escribe un programa que lea una cadena de texto y pida ingresar
//si es "izquierda" o "derecha". Si es "izquierda", imprimir "Gira a la izquierda".
//Si es "derecha", imprimir "Gira a la derecha". Sino indicar: “¡Debe doblar sí o sí,
//sino chocaremos!”. (considerar las mayúsculas y minúsculas).
string direction = "";
while (direction != "izquierda" && direction != "derecha")
{
    Console.Write("Ingrese una dirección ('izquierda' o 'derecha'): ");
    direction = Console.ReadLine().ToLower();
    if (direction == "izquierda")
        Console.WriteLine("Gira a la izquierda.");
    else if (direction == "derecha")
        Console.WriteLine("Gira a la derecha.");
    else
        Console.WriteLine("¡Debe doblar sí o sí, sino chocaremos!");
}
Console.ReadKey();
Console.Clear();


*/
