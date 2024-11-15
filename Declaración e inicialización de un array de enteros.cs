// Declaración e inicialización de un array de enteros.
// Este array representa las cantidades de objetos en diferentes secciones ("bins") del inventario.
int[] inventario = { 200, 450, 700, 175, 250 };

// Declaramos una variable llamada 'suma' e inicializamos su valor en 0.
// Esta variable almacenará el total de los objetos en el inventario.
int suma = 0;

// Declaramos una variable llamada 'bin' e inicializamos su valor en 0.
// Esta variable se usará como contador para identificar el número de bin (sección) procesado.
int bin = 0;

// Usamos un bucle 'foreach' para recorrer todos los elementos del array 'inventario'.
// En cada iteración, el valor actual del elemento del array se asigna a la variable 'objetos'.
foreach (int objetos in inventario)
{
    // Sumamos el valor actual (representado por 'objetos') a la variable 'suma'.
    suma += objetos;

    // Incrementamos el contador 'bin' para identificar el bin actual.
    bin++;

    // Imprimimos un mensaje detallado para cada bin:
    // - El número del bin.
    // - La cantidad de objetos en ese bin.
    // - La suma acumulada hasta ese punto.
    Console.WriteLine($"Bin {bin} = {objetos} items (Running total: {suma})");
}

// Finalmente, imprimimos el valor total acumulado en 'suma'.
// Este mensaje indica cuántos objetos hay en total en todo el inventario.
Console.WriteLine($"We have {suma} items in inventory.");
