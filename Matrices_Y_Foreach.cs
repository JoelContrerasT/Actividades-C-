/*// Una matriz (array) es una colección de elementos que comparten el mismo tipo de datos. 
// Puedes acceder a cada elemento mediante un índice numérico.

// Declaración y asignación de valores a un array.
string[] fraudulentOrderIDs = { "A123", "B456", "C789" }; // Usamos la sintaxis simplificada para inicializar el array.

// Acceso a los elementos del array mediante sus índices (los índices comienzan en 0).
Console.WriteLine($"First: {fraudulentOrderIDs[0]}"); // Imprime el primer elemento.
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}"); // Imprime el segundo elemento.
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}"); // Imprime el tercer elemento.

// Reasignación de valores en un array.
// Puedes cambiar el valor de un elemento específico accediendo a su índice.
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}"); // Imprime el nuevo valor del primer elemento.

// Uso de la propiedad 'Length' para obtener la cantidad de elementos en el array.
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Uso de un bucle 'foreach' para recorrer todos los elementos de un array.
// El bucle 'foreach' es muy útil cuando no necesitas modificar los elementos del array.
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name); // Imprime cada nombre en el array.
}
*/

/*// Declaración e inicialización de un array de enteros.
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
*/

// Desafío de pedido fraudulento
// Declaramos e inicializamos un array de cadenas (strings) que contiene los identificadores de los pedidos fraudulentos.
string[] pedidosFraudulentos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// Inicializamos una variable llamada 'pedidosB' en 0 para contar cuántos pedidos comienzan con "B".
int pedidosB = 0;

// Usamos un bucle 'foreach' para recorrer todos los identificadores de pedidos en el array 'pedidosFraudulentos'.
foreach (string pedidos in pedidosFraudulentos)
{
    // Verificamos si el identificador de pedido empieza con la letra "B" usando el método 'StartsWith'.
    if (pedidos.StartsWith("B"))
    {
        // Si el pedido empieza con "B", incrementamos el contador 'pedidosB' y mostramos el identificador del pedido.
        pedidosB++; 
        Console.WriteLine($"Estos son los pedidos fraudulentos: {pedidos}");
    }
}

// Al finalizar el bucle, mostramos cuántos pedidos fraudulentos fueron detectados con la letra "B".
Console.WriteLine($"Son {pedidosB} pedidos fraudulentos que comienzan con 'B'.");

