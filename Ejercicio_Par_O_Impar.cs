// Par o Impar
// Escribe un programa que le pida al usuario un número y almacénalo en una variable int. 
// Usa una estructura condicional para verificar si el número es par o impar e imprime el resultado correspondiente.

// Le indicamos al usuario que digite un número
Console.WriteLine("Digite su número:");

// El número digitado queda almacenado en la variable numero
int numero = int.Parse(Console.ReadLine());

// Verificamos si el número es divisible entre 2; si es así, indicará que es par
if (numero % 2 == 0)
{
    Console.WriteLine("El número es par");
}
// Si el número no es divisible entre 2, indicará que es impar
else
{
    Console.WriteLine("El número es impar");
}
