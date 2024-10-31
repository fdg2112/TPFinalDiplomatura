using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal
{
    public static class Strings
    {
    }
}
/*
 //Stack<int> pilaDeNumeros = new Stack<int>(); // Crear una pila de números enteros

//// Operación Push: agregar elementos
//pilaDeNumeros.Push(10);
//pilaDeNumeros.Push(20);
//pilaDeNumeros.Push(30);

//// Mostrar el elemento superior (Peek)
//Console.WriteLine($"Elemento superior: {pilaDeNumeros.Peek()}"); // Muestra 30

//// Operación Pop: quitar elementos
//Console.WriteLine($"Elemento removido: {pilaDeNumeros.Pop()}"); // Muestra 30

//bool existe = pilaDeNumeros.Contains(20); // Devuelve true si el valor 20 está en la pila

//// Mostrar cantidad de elementos
//Console.WriteLine($"Cantidad de elementos: {pilaDeNumeros.Count()}"); // Muestra 2

//pilaDeNumeros.Clear(); // Vacía la pila.

//int[] elementos = pilaDeNumeros.ToArray(); // Convierte la pila en un arreglo.

//pilaDeNumeros.TrimExcess(); // Optimiza el uso de memoria reduciendo la capacidad de la pila.

//Queue<int> colaDeNumeros = new Queue<int>(); // Crea la cola de numeros

//// Operación Enqueue: agregar elementos
//colaDeNumeros.Enqueue(10);
//colaDeNumeros.Enqueue(20);
//colaDeNumeros.Enqueue(30);

//// Mostrar el primer elemento en la cola (Peek)
//Console.WriteLine($"Primer elemento en la cola: {colaDeNumeros.Peek()}"); // Muestra 10

//// Operación Dequeue: quitar el primer elemento
//Console.WriteLine($"Elemento removido: {colaDeNumeros.Dequeue()}"); // Muestra 10

//bool existe = colaDeNumeros.Contains(20); // Devuelve true si el valor 20 está en la cola

//// Mostrar cantidad de elementos
//Console.WriteLine($"Cantidad de elementos: {colaDeNumeros.Count()}"); // Muestra 2

//colaDeNumeros.Clear(); // Vacía la cola.

//int[] elementos = colaDeNumeros.ToArray(); // Convierte la cola en un arreglo.

//colaDeNumeros.TrimExcess(); // Optimiza el uso de memoria reduciendo la capacidad de la cola.

// Ejercicio 1: Declaración e Inicialización
Console.WriteLine("""
    Ejercicio 1: Declaración e Inicialización
    • Declarar un arreglo de enteros que pueda almacenar 5 elementos.
    • Inicializar el arreglo con los valores {10, 20, 30, 40, 50}.
    • Mostrar en pantalla los valores del arreglo.
    ________________________________________
    """);
int[] numbers1 = new int[5] { 10, 20, 30, 40, 50 };
foreach (var number in numbers1)
{
    Console.WriteLine($"Elemento  {number}");
}

// Ejercicio 2: Acceso y Modificación
Console.WriteLine("""
    Ejercicio 2: Acceso y Modificación
    • Declarar un arreglo de 4 nombres {Juan, Pedro, Fulano, Mengano}.
    • Acceder al segundo nombre y cambiar por otro nombre nuevo.
    • Mostrar en pantalla los nombres del arreglo después del cambio.
    ________________________________________
    """);
string[] names = new string[4] { "Juan", "Pedro", "Fulano", "Mengano" };
names[1] = "Lucas"; // Cambiamos "Pedro" por "Lucas"
Console.WriteLine("Nombres del arreglo: " + string.Join(", ", names));

// Ejercicio 3: Recorrer un Arreglo
Console.WriteLine("""
    Ejercicio 3: Recorrer un Arreglo
    • Declarar un arreglo de enteros con 6 elementos.
    • Utilizar un bucle for para recorrer el arreglo y mostrar la suma de todos los elementos.
    • Luego, utilizar foreach para mostrar todos los elementos del arreglo uno por uno.
    ________________________________________
    """);
int[] numbers2 = new int[6] { 1, 2, 3, 4, 5, 6 };
int sum = 0;
Console.WriteLine("Elementos del arreglo:");
foreach (var number in numbers2)
{
    Console.WriteLine(number);
}
for (int i = 0; i < numbers2.Length; i++)
{
    sum += numbers2[i];
}
Console.WriteLine("Suma de los elementos: " + sum);

// Ejercicio 4: Buscar Elementos
Console.WriteLine("""
    Ejercicio 4: Buscar Elementos
    • Declarar un arreglo de 6 enteros.
    • Pedir al usuario ingresar un número.
    • Verificar si el número ingresado se encuentra en el arreglo usando un bucle for. 
      Mostrar el índice donde se encuentra o un mensaje diciendo que no está presente.
    • Hacer lo mismo utilizando Array.IndexOf.
    ________________________________________
    """);
int[] numbers3 = new int[6] { 1, 2, 3, 4, 5, 6 };
Console.Write("Ingrese un número: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
bool found = false;
for (int i = 0; i < numbers3.Length; i++)
{
    if (numbers3[i] == inputNumber)
    {
        Console.WriteLine("Número encontrado en el índice: " + i);
        found = true;
        break;
    }
}
if (!found)
{
    Console.WriteLine("Número no encontrado.");
}

int index = Array.IndexOf(numbers3, inputNumber);
if (index >= 0)
{
    Console.WriteLine("Número encontrado en el índice (Array.IndexOf): " + index);
}
else
{
    Console.WriteLine("Número no encontrado (Array.IndexOf).");
}

// Ejercicio 5: Ordenar Arreglo
Console.WriteLine("""
    Ejercicio 5: Ordenar Arreglo
    • Declarar un arreglo de 7 enteros desordenados.
    • Usar Array.Sort para ordenarlos de menor a mayor.
    • Luego, invertir el arreglo utilizando Array.Reverse y mostrar el resultado.
    ________________________________________
    """);
int[] numbers4 = new int[7] { 5, 2, 8, 1, 4, 7, 3 };
Array.Sort(numbers4);
Console.WriteLine("Arreglo ordenado: " + string.Join(", ", numbers4));

Array.Reverse(numbers4);
Console.WriteLine("Arreglo invertido: " + string.Join(", ", numbers4));

// Ejercicio 6: Copiar Arreglos
Console.WriteLine("""
    Ejercicio 6: Copiar Arreglos
    • Declarar un arreglo con los valores {5, 10, 15, 20, 25}.
    • Crear un nuevo arreglo y copiar los valores del primer arreglo usando Array.Copy.
    • Mostrar los elementos del nuevo arreglo en pantalla.
    ________________________________________
    """);

int[] numbers5 = new int[5] { 5, 10, 15, 20, 25 };
int[] copyOfNumbers = new int[numbers5.Length];
Array.Copy(numbers5, copyOfNumbers, numbers5.Length);
Console.WriteLine("Elementos del nuevo arreglo: " + string.Join(", ", copyOfNumbers));

// Ejercicio 7: Vaciar un Arreglo
Console.WriteLine("""
    Ejercicio 7: Vaciar un Arreglo
    • Declarar un arreglo de 5 enteros y asignar valores iniciales, {5, 10, 15, 20, 25}.
    • Usar Array.Clear para reiniciar todos los valores del arreglo a 0.
    • Mostrar el arreglo antes y después de vaciarlo.
    ________________________________________
    """);

int[] numbers6 = new int[5] { 5, 10, 15, 20, 25 };
Console.WriteLine("Arreglo antes de vaciar: " + string.Join(", ", numbers6));
Array.Clear(numbers6, 0, numbers6.Length);
Console.WriteLine("Arreglo después de vaciar: " + string.Join(", ", numbers6));

// Ejercicio 8: Redimensionar un Arreglo
Console.WriteLine("""
    Ejercicio 8: Redimensionar un Arreglo
    • Declarar un arreglo de 3 elementos: {2, 4, 6}.
    • Usar Array.Resize para redimensionarlo a 5 elementos.
    • Agregar dos nuevos valores y mostrar el arreglo resultante.
    ________________________________________
    """);

int[] numbers7 = new int[3] { 2, 4, 6 };
Array.Resize(ref numbers7, 5);
numbers7[3] = 8;
numbers7[4] = 10;
Console.WriteLine("Arreglo redimensionado: " + string.Join(", ", numbers7));

// Ejercicio 9: Ingresar valores en un arreglo hasta llenarlo
Console.WriteLine("""
    Ejercicio 9: Ingresar valores en un arreglo hasta llenarlo
    • Crear un programa que pida al usuario ingresar valores enteros uno por uno hasta llenar un arreglo de tamaño 10. 
    • El programa debe mostrar un mensaje cada vez que se agregue un número al arreglo indicando cuántos espacios libres quedan.
    • Cuando el arreglo esté lleno, mostrar todos los valores ingresados.
    ________________________________________
    """);

int[] numbers8 = new int[10];
for (int i = 0; i < numbers8.Length; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    numbers8[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Espacios libres: {numbers8.Length - (i + 1)}");
}

Console.WriteLine("Valores ingresados: " + string.Join(", ", numbers8));

// Ejercicio 10: Separar números pares e impares en arreglos distintos
Console.WriteLine("""
    Ejercicio 10: Separar números pares e impares en arreglos distintos
    • Pedir al usuario que ingrese 10 números enteros.
    • Crear dos arreglos: uno para almacenar los números pares y otro para los impares.
    • Al final, mostrar los números pares y los impares por separado.
    ________________________________________
    """);

int[] numbers9 = new int[10];
int[] evenNumbers = new int[10];
int[] oddNumbers = new int[10];
int evenIndex = 0, oddIndex = 0;

for (int i = 0; i < numbers9.Length; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    numbers9[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers9[i] % 2 == 0)
    {
        evenNumbers[evenIndex++] = numbers9[i];
    }
    else
    {
        oddNumbers[oddIndex++] = numbers9[i];
    }
}

Console.WriteLine("Números pares: " + string.Join(", ", evenNumbers.Take(evenIndex)));
Console.WriteLine("Números impares: " + string.Join(", ", oddNumbers.Take(oddIndex)));

// Ejercicio 11: Promedio de valores y mostrar los mayores al promedio
Console.WriteLine("""
    Ejercicio 11: Promedio de valores y mostrar los mayores al promedio
    • Crear un programa que pida al usuario ingresar 8 valores numéricos.
    • Calcular el promedio de los valores ingresados.
    • Mostrar en pantalla todos los números que sean mayores al promedio.
    ________________________________________
    """);

int[] numbers10 = new int[8];
int total = 0;

for (int i = 0; i < numbers10.Length; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    numbers10[i] = Convert.ToInt32(Console.ReadLine());
    total += numbers10[i];
}

double average = total / (double)numbers10.Length;
Console.WriteLine("Promedio: " + average);
Console.WriteLine("Números mayores al promedio:");

foreach (var number in numbers10)
{
    if (number > average)
    {
        Console.WriteLine(number);
    }
}

// Ejercicio 12: Mostrar elementos de un arreglo
Console.WriteLine("""
    Ejercicio 12: Mostrar elementos de un arreglo
    • Declarar un arreglo de 5 elementos y pedir al usuario que ingrese los valores.
    • Mostrar los valores del arreglo de derecha a izquierda o viceversa, según lo que ingrese el usuario.
    ________________________________________
    """);

int[] array12 = new int[5];
for (int i = 0; i < array12.Length; i++)
{
    Console.Write($"Ingrese el valor para el índice {i}: ");
    array12[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("¿Mostrar de derecha o izquierda? (ingresar 'derecha' o 'izquierda'): ");
string direction = Console.ReadLine();

if (direction == "derecha")
{
    Array.Reverse(array12);
}

Console.WriteLine("Valores del arreglo:");
foreach (var value in array12)
{
    Console.WriteLine(value);
}

// Ejercicio 13: Encontrar el valor máximo y cuántas veces aparece
Console.WriteLine("""
    Ejercicio 13: Encontrar el valor máximo y cuántas veces aparece
    • Pedir al usuario que ingrese 10 números enteros.
    • Encontrar el valor máximo y mostrar cuántas veces aparece.
    ________________________________________
    """);

int[] array13 = new int[10];
for (int i = 0; i < array13.Length; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    array13[i] = Convert.ToInt32(Console.ReadLine());
}

int maxValue = array13[0];
int countMax = 0;

foreach (var number in array13)
{
    if (number > maxValue)
    {
        maxValue = number;
        countMax = 1; // Resetear el contador
    }
    else if (number == maxValue)
    {
        countMax++;
    }
}

Console.WriteLine($"El valor máximo es {maxValue} y aparece {countMax} veces.");

// Ejercicio 14: Contar cantidad de números positivos, negativos y ceros
Console.WriteLine("""
    Ejercicio 14: Contar cantidad de números positivos, negativos y ceros
    • Pedir al usuario ingresar 10 números enteros.
    • Contar cuántos son positivos, negativos y ceros.
    ________________________________________
    """);

int[] array14 = new int[10];
int positiveCount = 0, negativeCount = 0, zeroCount = 0;

for (int i = 0; i < array14.Length; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    array14[i] = Convert.ToInt32(Console.ReadLine());

    if (array14[i] > 0) positiveCount++;
    else if (array14[i] < 0) negativeCount++;
    else zeroCount++;
}

Console.WriteLine($"Cantidad de positivos: {positiveCount}");
Console.WriteLine($"Cantidad de negativos: {negativeCount}");
Console.WriteLine($"Cantidad de ceros: {zeroCount}");

// Ejercicio 15: Ordenar un arreglo de forma ascendente o descendente
Console.WriteLine("""
    Ejercicio 15: Ordenar un arreglo de forma ascendente o descendente
    • Crear un programa que pida al usuario ingresar 5 palabras.
    • Ordenar alfabéticamente según la elección del usuario.
    ________________________________________
    """);

string[] words = new string[5];

for (int i = 0; i < words.Length; i++)
{
    Console.Write($"Ingrese la palabra {i + 1}: ");
    words[i] = Console.ReadLine();
}

Console.Write("¿Ordenar de 'AZ' o 'ZA'? ");
string order = Console.ReadLine();

if (order.ToUpper() == "AZ")
{
    Array.Sort(words);
}
else if (order.ToUpper() == "ZA")
{
    Array.Sort(words);
    Array.Reverse(words);
}

Console.WriteLine("Palabras ordenadas:");
foreach (var word in words)
{
    Console.WriteLine(word);
}

// Ejercicio 16: Alternar números de dos arreglos
Console.WriteLine("""
    Ejercicio 16: Alternar números de dos arreglos
    • Pedir al usuario ingresar 5 palabras para un arreglo y 5 palabras para otro.
    • Crear un tercer arreglo de tamaño 10 que contenga las de ambos arreglos alternadas.
    ________________________________________
    """);

string[] arrayA = new string[5];
string[] arrayB = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingrese la palabra para el arreglo A {i + 1}: ");
    arrayA[i] = Console.ReadLine();
}

for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingrese la palabra para el arreglo B {i + 1}: ");
    arrayB[i] = Console.ReadLine();
}

string[] arrayC = new string[10];

for (int i = 0; i < 5; i++)
{
    arrayC[i * 2] = arrayA[i];
    arrayC[i * 2 + 1] = arrayB[i];
}

Console.WriteLine("Arreglo resultante alternado:");
foreach (var word in arrayC)
{
    Console.WriteLine(word);
}

// Ejercicio 17: Buscar y reemplazar un valor en un arreglo
Console.WriteLine("""
    Ejercicio 17: Buscar y reemplazar un valor en un arreglo
    • Pedir al usuario ingresar 7 números en un arreglo.
    • Pedir un valor a buscar y un valor de reemplazo.
    ________________________________________
    """);

int[] array17 = new int[7];

for (int i = 0; i < array17.Length; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    array17[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Ingrese el valor a buscar: ");
int searchValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el valor de reemplazo: ");
int replaceValue = Convert.ToInt32(Console.ReadLine());

bool founded = false;

for (int i = 0; i < array17.Length; i++)
{
    if (array17[i] == searchValue)
    {
        array17[i] = replaceValue;
        founded = true;
    }
}

if (founded)
{
    Console.WriteLine("Arreglo actualizado:");
    foreach (var number in array17)
    {
        Console.WriteLine(number);
    }
}
else
{
    Console.WriteLine("Valor no encontrado en el arreglo.");
}

// Ejercicio 18: Comparar dos arreglos
Console.WriteLine("""
    Ejercicio 18: Comparar dos arreglos
    • Pedir al usuario que ingrese 5 números en dos arreglos distintos.
    • Comparar ambos arreglos y mostrar si son iguales o no.
    ________________________________________
    """);

int[] array18A = new int[5];
int[] array18B = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingrese el número {i + 1} para el arreglo A: ");
    array18A[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingrese el número {i + 1} para el arreglo B: ");
    array18B[i] = Convert.ToInt32(Console.ReadLine());
}

bool areEqual = array18A.SequenceEqual(array18B);

if (areEqual)
{
    Console.WriteLine("Los arreglos son iguales.");
}
else
{
    Console.WriteLine("Los arreglos son diferentes.");
}







 */