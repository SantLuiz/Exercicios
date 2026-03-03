using AprendendoC.Common.Models; 

Pessoa pessoa1 = new Pessoa(); 
DateTime dataAtual = DateTime.Now;

pessoa1.Nome = "José"; 
pessoa1.Idade = 25; 
Console.WriteLine($"Hoje é {dataAtual.ToString("dd/MMM/yyyy")} e são {dataAtual.ToString("HH:mm:ss")}");
pessoa1.Apresentar();