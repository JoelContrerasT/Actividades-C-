using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        // Validar el primer número
        if (!int.TryParse(Console.ReadLine(), out int numero1))
        {
            Console.WriteLine("Número inválido. Por favor, ingrese solo números.");
            return;
        }

        Console.WriteLine("Ingrese el segundo número:");
        // Validar el segundo número
        if (!int.TryParse(Console.ReadLine(), out int numero2))
        {
            Console.WriteLine("Número inválido. Por favor, ingrese solo números.");
            return;
        }

        // Realizar las operaciones
        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;

        Console.WriteLine("Resultados:");
        Console.WriteLine($"Suma:\t\t\t{suma}");
        Console.WriteLine($"Resta:\t\t\t{resta}");
        Console.WriteLine($"Multiplicación:\t\t{multiplicacion}");

        // Validar la división por cero
        if (numero2 == 0)
        {
            Console.WriteLine("División:\t\tNo se puede dividir entre 0.");
        }
        else
        {
            int division = numero1 / numero2;
            Console.WriteLine($"División:\t\t{division}");
        }
    }
}
