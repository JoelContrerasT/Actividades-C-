// Crear una instancia de la clase Random para generar números aleatorios
Random random = new Random();

// Generar un número aleatorio entre 0 y 11 para representar los días hasta la expiración
int dayUntilExpiration = random.Next(12);

// Inicializar el porcentaje de descuento en 0
int discountPercentage = 0;

// Imprimir el número de días hasta la expiración
Console.WriteLine(dayUntilExpiration);

// Evaluar cuántos días faltan para la expiración de la suscripción y aplicar lógica según el caso
if (dayUntilExpiration == 0) // Si faltan 0 días
{
    Console.WriteLine("Your subscription has expired.");
}
else if (dayUntilExpiration == 1) // Si falta 1 día
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20; // Asignar un 20% de descuento
}
else if (dayUntilExpiration <= 5) // Si faltan entre 2 y 5 días
{
    Console.WriteLine($"Your subscription expires in {dayUntilExpiration} days.");
    discountPercentage = 10; // Asignar un 10% de descuento
}
else if (dayUntilExpiration <= 10) // Si faltan entre 6 y 10 días
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// Verificar si hay un descuento y mostrar el mensaje de ahorro
if (discountPercentage > 0) // Si el descuento es mayor que 0
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
