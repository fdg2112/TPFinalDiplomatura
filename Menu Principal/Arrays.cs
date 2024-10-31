using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal
{
    public static class Arrays
    {
    }
}
/*
 

// Ejercicio 1
//string texto = "Producto: \tPrecio: \nPan \t\t$1.50 \nLeche \t\t$0.99 \nHuevos \t\t$2.00";
//Console.WriteLine(texto);

// Ejercicio 2
//string texto = "Personaje 1: \"Hola! como estas?\" \nPersonaje 2: \"¡Estoy bien, gracias! ¿Y tú?\"";
//Console.WriteLine(texto);

//// Ejercicio 3
//string texto = """
//    En este film velado en blanca noche
//    el hijo tenaz de tu enemigo
//    el muy verdugo cena distinguido
//    una noche de cristal que se hace añicos
//    """;
//Console.WriteLine(texto);

//Ejercicio 4
//string texto = """C:\User\Franco\Documents\file1.txt""";
//Console.WriteLine(texto);

//Ejercicio 5
//Console.WriteLine("Texto 1: ");
//string? texto1 = Console.ReadLine();
//Console.WriteLine("Texto 2: ");
//string? texto2 = Console.ReadLine();
//Console.WriteLine("Texto 3: ");
//string? texto3 = Console.ReadLine();
//Console.WriteLine(texto1 + " " + texto2 + " " + texto3);

//Ejercicio 6
//Console.WriteLine("Apellido: ");
//string? apellido = Console.ReadLine();
//Console.WriteLine("Nombre: ");
//string? nombre = Console.ReadLine();
//Console.WriteLine(apellido + ", " + nombre);

// Ejercicio 7
//Console.Write("Ingresa tu nombre: ");
//string nombre = Console.ReadLine();
//Console.Write("Ingresa tu edad: ");
//int edad = int.Parse(Console.ReadLine());
//Console.WriteLine($"Hola {nombre}, tienes {edad} años.");

//// Ejercicio 8
//Console.Write("Ingresa el primer número: ");
//double num1 = double.Parse(Console.ReadLine());
//Console.Write("Ingresa el segundo número: ");
//double num2 = double.Parse(Console.ReadLine());
//Console.Write("Ingresa el tercer número: ");
//double num3 = double.Parse(Console.ReadLine());
//double promedio = (num1 + num2 + num3) / 3;
//Console.WriteLine($"Se ingresó: {num1}, {num2}, {num3}. El promedio de los tres es: {promedio}");

//Ejercicio 9
//Console.WriteLine("Ingrese una palabra o frase:");
//string entrada = Console.ReadLine();
//Console.WriteLine($"La frase ingresada tiene {entrada.Length} caracteres (incluyendo espacios).");

//Ejercicio 10
//Console.WriteLine("Ingrese su nombre:");
//string? nombre = Console.ReadLine();
//Console.WriteLine("Ingrese su apellido:");
//string? apellido = Console.ReadLine();
//Console.WriteLine($"La longitud de su nombre es: {nombre.Length} caracteres.");
//Console.WriteLine($"La longitud de su apellido es: {apellido.Length} caracteres.");
//Console.WriteLine($"La longitud total (sin espacios) es: {nombre.Length + apellido.Length} caracteres.");

//Ejercicio 11
//Console.WriteLine("Ingrese una oración:");
//string? oracion = Console.ReadLine();
//Console.WriteLine($"La oración en mayúsculas es: {oracion.ToUpper()}");

//Ejercicio 12
//Console.WriteLine("Ingrese una palabra:");
//string? palabra = Console.ReadLine();
//Console.WriteLine($"La palabra en minúsculas es: {palabra.ToLower()}");

//Ejercicio 13
//Console.WriteLine("Ingrese la primera palabra:");
//string? palabra1 = Console.ReadLine();
//Console.WriteLine("Ingrese la segunda palabra:");
//string? palabra2 = Console.ReadLine();
//if (palabra1 == palabra2) Console.WriteLine("Las palabras son exactamente iguales.");
//else Console.WriteLine("Las palabras son diferentes.");

//Ejercicio 14
//Console.WriteLine("Ingrese la primera cadena:");
//string? cadena1 = Console.ReadLine();
//Console.WriteLine("Ingrese la segunda cadena:");
//string? cadena2 = Console.ReadLine();
//if (cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase))
//    Console.WriteLine("Las cadenas son iguales (ignorando mayúsculas y minúsculas).");
//else Console.WriteLine("Las cadenas son diferentes.");

//Ejercicio 15
//Console.WriteLine("Ingrese una oración:");
//string? oracion = Console.ReadLine();
//if (oracion.Contains("programación", StringComparison.OrdinalIgnoreCase))
//    Console.WriteLine("La oración contiene la palabra 'programación'.");
//else
//    Console.WriteLine("La oración no contiene la palabra 'programación'.");

//Ejercicio 16
//Console.WriteLine("Ingrese una oración:");
//string? oracion2 = Console.ReadLine();
//Console.WriteLine("Ingrese el carácter a buscar:");
//char? caracter = Console.ReadKey().KeyChar;
//Console.WriteLine();
//if (oracion2.Contains(caracter.ToString()))
//    Console.WriteLine($"La oración contiene el carácter '{caracter}'.");
//else
//    Console.WriteLine($"La oración no contiene el carácter '{caracter}'.");

////Ejercicio 17
//Console.WriteLine("Ingrese una palabra:");
//string? palabra = Console.ReadLine();

//if (!string.IsNullOrEmpty(palabra) && palabra.StartsWith("a", StringComparison.OrdinalIgnoreCase) ||
//    palabra.StartsWith("e", StringComparison.OrdinalIgnoreCase) ||
//    palabra.StartsWith("i", StringComparison.OrdinalIgnoreCase) ||
//    palabra.StartsWith("o", StringComparison.OrdinalIgnoreCase) ||
//    palabra.StartsWith("u", StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("La palabra comienza con una vocal.");
//}
//else
//{
//    Console.WriteLine("La palabra no comienza con una vocal.");
//}

//Ejercicio 17
//Console.WriteLine("Ingrese una palabra:");
//string? palabra = Console.ReadLine();
//if (!string.IsNullOrEmpty(palabra) && "aeiouAEIOU".Contains(palabra.Substring(0, 1)))
//{
//    Console.WriteLine("La palabra comienza con una vocal.");
//}
//else
//{
//    Console.WriteLine("La palabra no comienza con una vocal.");
//}


////Ejercicio 18
//Console.WriteLine("Ingrese una URL:");
//string? url = Console.ReadLine();
//if (!string.IsNullOrEmpty(url) && (url.EndsWith(".io") || url.EndsWith(".net")))
//{
//    Console.WriteLine("La URL termina en '.io' o '.net'.");
//}
//else
//{
//    Console.WriteLine("La URL no termina en '.io' ni en '.net'.");
//}

////Ejercicio 19
//Console.WriteLine("Ingrese una oración:");
//string? oracion = Console.ReadLine();
//if (!string.IsNullOrEmpty(oracion))
//{
//    int indiceEspacio = oracion.IndexOf(' '); // Encontrar el primer espacio
//    if (indiceEspacio == -1)
//    {
//        Console.WriteLine($"La primera palabra es: {oracion}"); // Si no hay espacios, toda la oración es una palabra
//    }
//    else
//    {
//        string primeraPalabra = oracion.Substring(0, indiceEspacio);
//        Console.WriteLine($"La primera palabra es: {primeraPalabra}");
//    }
//}
//else Console.WriteLine("No se encontró una palabra.");

//Ejercicio 20
//Console.WriteLine("Ingrese una dirección de correo electrónico:");
//string? correo = Console.ReadLine();
//int indiceArroba = correo.IndexOf('@');
//if (indiceArroba != -1)
//{
//    string nombreUsuario = correo.Substring(0, indiceArroba);
//    Console.WriteLine($"El nombre de usuario es: {nombreUsuario}");
//}
//else
//{
//    Console.WriteLine("El correo ingresado no es válido.");
//}

//Ejercicio 21
//Console.WriteLine("Ingrese una palabra:");
//string? palabra = Console.ReadLine();
//int posicion = palabra.IndexOf('a');
//Console.WriteLine($"La primera aparición de la letra 'a' está en la posición: {posicion}");

//Ejercicio 22
//Console.WriteLine("Ingrese una oración:");
//string? oracion = Console.ReadLine();
//Console.WriteLine("Ingrese un carácter para buscar:");
//char caracter = Console.ReadKey().KeyChar;
//int ultimaPosicion = oracion.LastIndexOf(caracter);
//Console.WriteLine($"\nLa última aparición del carácter '{caracter}' está en la posición: {ultimaPosicion}");

//Ejercicio 23
//Console.WriteLine("Ingrese su nombre:");
//string? nombre = Console.ReadLine();
//nombre.Insert(0,"Sr. ");
//Console.WriteLine($"El nombre con prefijo es: {nombre}");

////Ejercicio 24
//Console.WriteLine("Ingrese una palabra:");
//string? palabra2 = Console.ReadLine();
//Console.WriteLine("Ingrese una letra para insertar:");
//char letra = Console.ReadKey().KeyChar;
//int mitad = palabra2.Length / 2;
//string palabraConLetra = palabra2.Insert(mitad, letra.ToString());
//Console.WriteLine($"\nLa palabra con la letra insertada es: {palabraConLetra}");

////Ejercicio 25
//Console.WriteLine("Ingrese una oración:");
//string? oracion2 = Console.ReadLine();
//string oracionModificada = oracion2.Replace("malo", "bueno");
//Console.WriteLine($"La oración modificada es: {oracionModificada}");

////Ejercicio 26
//Console.WriteLine("Ingrese una fecha en formato 'dd/mm/yyyy':");
//string? fecha = Console.ReadLine();
//string fechaModificada = fecha.Replace("/", "-");
//Console.WriteLine($"La fecha con guiones es: {fechaModificada}");

////Ejercicio 27
//Console.WriteLine("Ingrese una frase:");
//string? frase = Console.ReadLine();
//Console.WriteLine("Ingrese una letra a reemplazar:");
//char letraReemplazar = Console.ReadKey().KeyChar;
//Console.WriteLine("\nIngrese el carácter de reemplazo:");
//char nuevoCaracter = Console.ReadKey().KeyChar;
//string fraseMayusculas = frase.ToUpper();
//string fraseModificada = fraseMayusculas.Replace(letraReemplazar, nuevoCaracter);
//Console.WriteLine($"\nLa frase modificada es: {fraseModificada}");

////Ejercicio 28
//Console.WriteLine("Ingrese la primera palabra:");
//string? palabra1 = Console.ReadLine();
//Console.WriteLine("Ingrese la segunda palabra:");
//string? palabra2 = Console.ReadLine();
//if (palabra1.Equals(palabra2, StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("Las palabras son iguales.");
//}
//else
//{
//    string palabrasConcatenadas = palabra1 + palabra2;
//    Console.WriteLine($"Las palabras concatenadas son: {palabrasConcatenadas}");
//}

////Ejercicio 29
//Console.WriteLine("Ingrese una dirección de correo electrónico:");
//string? correo = Console.ReadLine();
//int indiceArroba = correo.IndexOf('@');
//if (indiceArroba != -1)
//{
//    string dominio = correo.Substring(indiceArroba + 1);
//    if (dominio.StartsWith("gmail"))
//    {
//        Console.WriteLine("El dominio comienza con 'gmail'.");
//    }
//    else
//    {
//        Console.WriteLine("El dominio no comienza con 'gmail'.");
//    }
//}
//else
//{
//    Console.WriteLine("No es una dirección de correo válida.");
//}

////Ejercicio 30
//Console.WriteLine("Ingrese una oración:");
//string? oracion = Console.ReadLine();
//if (oracion.Contains("C#"))
//{
//    string oracionModificada = "¡Aprendiendo! " + oracion;
//    Console.WriteLine($"Oración modificada: {oracionModificada}");
//}
//else
//{
//    Console.WriteLine("La oración no contiene 'C#'.");
//}


 */