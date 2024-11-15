// Una matriz (array) es una colección de elementos que comparten el mismo tipo de datos. 
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
