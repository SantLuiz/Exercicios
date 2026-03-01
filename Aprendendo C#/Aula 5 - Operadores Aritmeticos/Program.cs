using Aula_5___Operadores_Aritmeticos.Models;

Calculadora calc = new Calculadora();

calc.Somar(10,20);
calc.Subtrair(20,10);
calc.Multiplicar(10,20);
calc.Dividir(20,10);
calc.Potencia(3,2);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

int numero = 10;

Console.WriteLine($"O numero é {numero}");
numero++;
Console.WriteLine($"Incremento ++ {numero}");
numero--;
numero--;
Console.WriteLine($"Decremento -- {numero}");
