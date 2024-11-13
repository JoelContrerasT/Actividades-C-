// Temperatura ideal
// Crea un programa que pregunte al usuario por la temperatura en grados Celsius y la almacene en una variable de tipo int.
// Si la temperatura es mayor o igual a 30, el programa debe imprimir "Hace calor"; si es menor a 15, imprime "Hace frío",
// y en cualquier otro caso imprime "La temperatura es agradable".

// Aquí le preguntamos al usuario cuál es la temperatura actual
Console.Write("¿Cuál es la temperatura actual?: ");

// El usuario ingresa la temperatura, y este dato se almacena en la variable "temperatura"
int temperatura = int.Parse(Console.ReadLine());

// Si el dato ingresado es mayor o igual a 30, le dirá al usuario que hace calor
if (temperatura >= 30)
{
    Console.WriteLine("Hace calor");
}

// Si el dato ingresado es menor de 15, le dirá al usuario que hace frío
else if (temperatura < 15)
{
    Console.WriteLine("Hace frío");
}

// Si la temperatura no es mayor o igual que 30 ni menor que 15, le mostrará al usuario que la temperatura es agradable
else
{
    Console.WriteLine("La temperatura es agradable");
}
