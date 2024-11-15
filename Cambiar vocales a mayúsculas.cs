// Ejercicio 3: Cambiar vocales a mayúsculas
// Definimos un arreglo de caracteres que contiene letras, tanto vocales como consonantes
char[] letras = { 'a', 'b', 'e', 'i', 'o', 'u', 'x', 'z' };

// Recorremos el arreglo de letras usando un bucle foreach
foreach (char letra in letras)
{
    // Comprobamos si la letra es una vocal (a, e, i, o, u)
    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
    {
        // Si la letra es una vocal, la convertimos a mayúscula
        char letraMayuscula = char.ToUpper(letra);

        // Imprimimos la letra convertida a mayúscula
        Console.WriteLine(letraMayuscula);
    }
    else
    {
        // Si no es una vocal, simplemente imprimimos la letra tal cual
        Console.WriteLine(letra);
    }
}
