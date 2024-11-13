//Ejercicio: Desarrollo de lógica de decisión con instrucciones if

Random dado = new Random();

int dado1 = dado.Next(1,7);
int dado2 = dado.Next(1,7);
int dado3 = dado.Next(1,7);

int total = dado1 + dado2 + dado3;

Console.WriteLine($"Los numeros que salieron son\t{dado1}\t{dado2}\t{dado3} En total: {total}");

//Los caracteres de barra vertical || son el operador O lógico, que básicamente indica “la expresión a la izquierda O la expresión a la derecha deben ser verdaderas para que toda la expresión booleana sea verdadera”.
if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
{
    //Los caracteres && de Y comercial son el operador Y lógico, que básicamente indica “solo si ambas expresiones son verdaderas, la expresión completa es verdadera".
    if((dado1 == dado2) && (dado2 == dado3))
    {
    Console.WriteLine("Sacas triple par!! +6 puntos");
    total += 6;
    }
    else
    {
    Console.WriteLine("Sacaste par! tienes 2 puntos extra");
    total += 2;
    }
}



//cuando solo queremos que se produzca un resultado, pero tenemos varias condiciones y resultados posibles, usaremos tantas instrucciones else if como queramos

if (total >= 16)
{
    Console.WriteLine("Ganaste un coche nuevo!");
    
}
else if (total >= 10)
    {

        Console.WriteLine("gana un portatil nuevo");
    }
        else if (total == 7)
        {
            Console.WriteLine("Ganaste un viaje");
        }
            else
            {
                Console.WriteLine("Ganste un gatito");
            }
