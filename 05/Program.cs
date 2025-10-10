//5.Cálculo de Desconto em Lista de Preços
//Objetivo: Criar um vetor de 5 preços de produtos (tipo double).
//Tarefas:
//Calcular um novo vetor com 10% de desconto aplicado a cada item.
//Exibir o preço original e o preço com desconto lado a lado.

double[] precosDeProdutos = new double [5];
double[] desconto = new double [5];

for (int i = 0; i < precosDeProdutos.Length; i++)
{
    Console.WriteLine("Digite o preço do produto: ");
    precosDeProdutos[i] = double.Parse(Console.ReadLine()!);
}

for (int i = 0; i < precosDeProdutos.Length; i++)
{
    desconto[i] = precosDeProdutos[i] - (precosDeProdutos[i] * 0.10); 
}

for (int i = 0; i < desconto.Length; i++) 
{
    Console.WriteLine($"O valor do produto é {precosDeProdutos[i]} e com desconto será {desconto[i]}");
}

