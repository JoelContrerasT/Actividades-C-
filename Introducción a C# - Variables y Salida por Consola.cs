using System;  // 1. Importamos la librería 'System' para usar funciones como Console.WriteLine

class Program  // 2. Definimos la clase 'Program', que contiene todo nuestro código
{
    static void Main(string[] args)  // 3. El método Main, que es el punto de inicio de nuestro programa
    {
        // 4. Declaramos nuestras variables
        string nombre = "Joel Andrey Contreras Toloza";  // Variable de tipo string para el nombre
        int edad = 20;  // Variable de tipo int para la edad
        string actividad = "Me gusta jugar videojuegos";  // Variable de tipo string para la actividad

        // 5. Imprimimos el mensaje en la consola usando Console.WriteLine con interpolación de cadenas
        Console.WriteLine($"Hola me llamo {nombre}, tengo {edad} y {actividad}");
    }
}
