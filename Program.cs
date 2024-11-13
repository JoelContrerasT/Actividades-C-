
//Seleccionar un numero aleatorio

//Random es una clase que se encuentra en el espacio de nombres System. Proporciona métodos para generar números aleatorios

Random dice2 = new Random();

//Next es un método de la clase Random que genera un número entero aleatorio dentro de un rango especificado
int roll = dice2.Next(1, 7);

Console.WriteLine(roll); 


//Para limpiar la consola(Terminal) se puede usar: Console.Clear();

//Ejercicio: Valores devueltos y parámetros de los métodos

Random dice = new Random();

//roll1 no se establece un limite
int roll1 = dice.Next();

//roll2 se establece un limite de 0 hasta 101
int roll2 = dice.Next(101);

//roll3 se establece un limite de 50 hasta 101
int roll3 = dice.Next(50, 101);

Console.WriteLine($"Fist roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

//Selecionar el numero mayor

int firstValue = 500;
int secondValue = 600;

//Con la clase Math.Max busca el numero mas grande entre las dos variables
int largeValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largeValue);
