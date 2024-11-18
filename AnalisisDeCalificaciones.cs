// Ejercicio: Análisis de Calificaciones

// Arreglo de números enteros que representa las calificaciones de los estudiantes
int[] calificaciones = { 2, 3, 4, 5, 3, 1, 2, 5 };

// Verificar si hay calificaciones para analizar
// (Esta validación fue añadida por ChatGPT para evitar errores si el arreglo está vacío)
if (calificaciones.Length == 0)
{
    Console.WriteLine("No hay calificaciones disponibles.");
    return; // Salir del programa si no hay datos
}

// Declaramos variables para los cálculos
int sumaNotas = 0;
int promedio = 0;
int estudiantesSuperiores = 0;

// Sumar todas las calificaciones
foreach (int calificacion in calificaciones)
{
    sumaNotas += calificacion; 
}

// Calcular el promedio
promedio = sumaNotas / calificaciones.Length;

// Mostrar el promedio de las calificaciones
Console.WriteLine($"El promedio de las calificaciones es: {promedio}");

// Contar y mostrar las calificaciones superiores al promedio
Console.WriteLine("Calificaciones iguales o superiores al promedio:");
foreach (int calificacion in calificaciones)
{
    if (calificacion >= promedio)
    {
        estudiantesSuperiores++;
        Console.WriteLine($" - {calificacion}");
    }
}

// Mostrar el total de estudiantes con calificaciones superiores al promedio
// (Mensaje refinado por ChatGPT para ser más descriptivo y claro)
Console.WriteLine($"Cantidad de estudiantes con calificaciones iguales o superiores al promedio: {estudiantesSuperiores}");
