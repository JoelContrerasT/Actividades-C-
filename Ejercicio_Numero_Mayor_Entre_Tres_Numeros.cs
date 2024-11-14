// Prueba 4: Número mayor entre tres números

// Escribe un programa que le pida al usuario tres números y luego imprima el mayor de los tres. 
// Si dos o más números son iguales y son los mayores, debe imprimir "Hay empate entre los números mayores".

// Le indicamos al usuario que digite los tres números y los almacenamos en variables
Console.WriteLine("Digita el primer numero:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digita el segundo numero:");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digita el tercer numero:");
int numero3 = int.Parse(Console.ReadLine());

// Verificamos si los tres números son iguales
if (numero1 == numero2 && numero2 == numero3)
{
    Console.WriteLine("Hay empate entre los números mayores");
}
// Verificamos si hay empate entre los mayores
else if ((numero1 == numero2 && numero1 > numero3) || (numero1 == numero3 && numero1 > numero2) || (numero2 == numero3 && numero2 > numero1))
{
    Console.WriteLine("Hay empate entre los números mayores");
}
// Verificamos si numero1 es el mayor
else if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"El número mayor es {numero1}");
}
// Verificamos si numero2 es el mayor
else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine($"El número mayor es {numero2}");
}
// Si ninguna de las anteriores es verdadera, numero3 es el mayor
else
{
    Console.WriteLine($"El número mayor es {numero3}");
}
