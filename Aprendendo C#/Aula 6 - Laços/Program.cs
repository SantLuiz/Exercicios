using System.ComponentModel;

Console.WriteLine($"COM FOR");
int num = 10;

for (int i = 0; i<=10; i++){
    Console.WriteLine($"{num} X {i} = {num* i}");
}


// Console.WriteLine($"COM WHILE");
// int contador = 1;
// int numero = 5;
// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução - {numero} X {contador} = {numero* contador}");
//     contador++;
// }

Console.WriteLine($"COM  DO WHILE");
int soma = 0;
int numero = 0;
int cont = 1;
do
{
    Console.WriteLine($"Digite um numero [0 - sair]");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
    Console.WriteLine($"[{cont}° Execução] - TOTAL: [{soma}]");
    cont++;
}while (numero != 0);
