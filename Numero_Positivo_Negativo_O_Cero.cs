// Prueba 1: Número positivo, negativo o cero

// Escribe un programa que le pida al usuario un número y luego imprima:
// "El número es positivo" si el número es mayor que 0.
// "El número es negativo" si el número es menor que 0.
// "El número es cero" si el número es igual a 0.

// Le indicamos al usuario que digite un número
Console.WriteLine("Digite un número:");

// Al digitar un número, se almacena en la variable "numero"
int numero = int.Parse(Console.ReadLine());

// Si el número es mayor que 0, imprimirá que es positivo
if (numero > 0)
{
    Console.WriteLine("El número es positivo");
}
// Si el número es menor que 0, imprimirá que es negativo
else if (numero < 0)
{
    Console.WriteLine("El número es negativo");
}
// Si el número no es ni positivo ni negativo, entonces es 0
else 
{
    Console.WriteLine("El número es cero");
}
