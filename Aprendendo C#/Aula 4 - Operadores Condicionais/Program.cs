int quantidadeEstoque = 3;

int quantidadeCompra = 0;
bool vendaPossivel = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em Estoque {quantidadeEstoque}");
Console.WriteLine($"Quantidade do Pedido {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {vendaPossivel}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda Invalida - Quantidade não pode ser igual a 0");
}

else if (vendaPossivel)
{
    
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Não temos a quantidade desejada em Estoque");
}

Console.WriteLine("Digite uma letra: ");

string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Consoante");
        break;
}