// Ejercicio 2: Sumar elementos de un arreglo

// Declaramos un arreglo de enteros con los números a sumar
int[] arreglo = { 3, 5, 7, 2, 8 };

// Inicializamos la variable para almacenar la suma total
int sumaTotal = 0;

// Recorremos cada número del arreglo usando un bucle foreach
foreach (int numero in arreglo)
{
    // Sumamos el valor actual del arreglo a la variable sumaTotal
    sumaTotal += numero;
}

// Imprimimos el resultado final de la suma total
Console.WriteLine($"La suma total de los números es: {sumaTotal}");
