// Prueba 3: Edad para votar

// Escribe un programa que le pida al usuario su edad y le diga si puede votar o no:
// Si la edad es 18 o mayor, imprime "Puedes votar".
// Si la edad es menor de 18, imprime "No puedes votar".
// Si la edad es exactamente 18, imprime "Es tu primer año de voto".

// Le indicamos al usuario que digite su edad
Console.WriteLine("Digite su edad:");

// El usuario al digitar la edad, se guarda en la variable "edad"
int edad = int.Parse(Console.ReadLine());

// Verificamos si la edad es exactamente 18
if (edad == 18)
{
    Console.WriteLine("Es tu primer año de voto");
}
// Verificamos si la edad es mayor que 18
else if (edad > 18)
{
    Console.WriteLine("Puedes votar");
}
// Si la edad es menor a 18, imprimimos "No puedes votar"
else
{
    Console.WriteLine("No puedes votar");
}
