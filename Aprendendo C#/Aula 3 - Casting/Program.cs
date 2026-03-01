//No C#, é seguida a ordem comum da matemetica para resolução de equações, exceto se for utilizado parantesis
//Cast - Casting | Converte um tipo para outro tipo

int a = Convert.ToInt32("5");//Utilizado para converter um tipo para outro - Transforma null para 0
int b = int.Parse("10");//Parse pode ser utilizado para converter um tipo para outro - Levanta uma exceção e encerra o programa se não tratada
//Para evitar problemas, podemos usar o TryParse, que caso apresente algum problema, a execução do programa continua

Console.WriteLine(a);
Console.WriteLine(b);

int inteiro = 5;
string c = inteiro.ToString();//Converte um valor qualquer para String, herdado em todos os tipos da classe Object

//Casting Implicito

int d = int.MaxValue;
double e = d; //Converte o valor int para double implicitamente, por que Int cabe sem problemas em Double, mas o contrario não é verdadeiro

Console.WriteLine(e);   




