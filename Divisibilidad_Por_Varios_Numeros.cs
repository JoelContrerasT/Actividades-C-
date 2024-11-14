// Prueba 2: Divisibilidad por varios números

// Escribe un programa que le pida al usuario un número entero y luego verifique lo siguiente:
// Si el número es divisible por 2, imprima "Divisible por 2".
// Si el número es divisible por 3, imprima "Divisible por 3".
// Si el número es divisible por ambos (2 y 3), imprima "Divisible por 2 y 3".
// Si no es divisible ni por 2 ni por 3, imprime "No es divisible ni por 2 ni por 3".

// Le indicamos al usuario que digite un número
Console.WriteLine("Digite el numero");

// El dígito ingresado se almacena en la variable "numero"
int numero = int.Parse(Console.ReadLine());

// Verificamos si el número digitado es divisible entre 2 y 3. Si es así, se imprimirá "Divisible por 2 y 3"
if ((numero % 2 == 0) && (numero % 3 == 0))
{
    Console.WriteLine("Divisible por 2 y 3");
}
// Si el número es divisible por 2, se imprimirá el mensaje "Divisible por 2"
else if (numero % 2 == 0)
{
    Console.WriteLine("Divisible por 2");
}
// Si el número es divisible por 3, se imprimirá el mensaje "Divisible por 3"
else if (numero % 3 == 0)
{
    Console.WriteLine("Divisible por 3");
}
// Si el número no es divisible ni por 2 ni por 3, se imprimirá el mensaje "No es divisible ni por 2 ni por 3"
else
{
    Console.WriteLine("No es divisible ni por 2 ni por 3");
}
