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
