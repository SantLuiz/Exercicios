// Array - Estrutura de dados que armazena uma coleção de elementos do mesmo tipo, acessados por índice. Sempre tem um tamanho fixo, definido no momento da criação. Exemplo: int[] numeros = new int[5]; // Cria um array de inteiros com 5 elementos.

//Exemplo

int[] numeros = new int[5]; // Cria um array de inteiros com 5 elementos.

//Para alterar a quantidade de elementos, podemos usar a classe Array, com o metodo Resize, que permite redimensionar o array, criando um novo array com o tamanho desejado e copiando os elementos do array original para o novo array. Exemplo: Array.Resize(ref numeros, 10); // Redimensiona o array para 10 elementos.

Array.Resize(ref numeros, 10); // Redimensiona o array para 10 elementos.
//Usa ref para passar o array por referência para apontar o endereço de memora do Array, permitindo que a referência do array seja atualizada para apontar para o novo array criado durante o redimensionamento.

numeros[0] = 10; // Atribui o valor 10 ao primeiro elemento do array
numeros[1] = 20; // Atribui o valor 20 ao segundo
numeros[2] = 30; // Atribui o valor 30 ao terceiro
numeros[3] = 40; // Atribui o valor 40 ao quarto
numeros[4] = 50; // Atribui o valor 50 ao quinto
numeros[5] = 60; // Atribui o valor 60 ao sexto
numeros[6] = 70; // Atribui o valor 70 ao s étimo

for (int i = 0; i < numeros.Length; i++)// Percorre o array usando um loop for e imprime cada elemento
{
    Console.WriteLine($"Elemento no índice {i}: {numeros[i]}");
}

foreach (int numero in numeros)// Percorre cada elemento do array e imprime seu valor
{
    Console.WriteLine($"Número: {numero}");
}

//Listas - Estrutura de dados que armazena uma coleção de elementos do mesmo tipo, acessados por índice. Diferente dos arrays, as listas são dinâmicas, ou seja, podem crescer ou diminuir de tamanho conforme necessário. Exemplo: List<int> numeros = new List<int>(); // Cria uma lista de inteiros vazia.
//Alem disso, as listas possuem diversos métodos para manipulação dos elementos, como Add, Remove, Clear, etc. Exemplo: numeros.Add(10); // Adiciona o número 10 à lista.
List<string> nomes = new List<string>(); // Cria uma lista de strings vazia.

nomes.Add("João"); // Adiciona o nome "João" à lista
nomes.Add("Maria"); // Adiciona o nome "Maria" à lista
nomes.Add("Pedro"); // Adiciona o nome "Pedro" à lista

foreach (string nome in nomes) // Percorre cada elemento da lista e imprime seu valor
{
    Console.WriteLine($"Nome: {nome}");
}