//2.Maior e Menor Valor
//Objetivo: Ler 10 números e armazenar em um vetor.
//Tarefas:
//Encontrar e exibir o maior e o menor número do vetor.

double maior = 0, menor = 0;

double[] numeros = new double[10];

for (int i = 0; i < numeros.Length; i++) 
{
    Console.WriteLine("Digite um número: ");
    numeros[i] = Convert.ToDouble(Console.ReadLine()!);   
}

for (int i = 0; i < numeros.Length; i++) 
{
    if (numeros[i] > maior)
    { 
        maior = numeros[i];
    }
}
Console.WriteLine($"O maior número é {maior}");

Console.WriteLine("\n\n");

for (int i = 0; i < numeros.Length; i++) 
{
    if (numeros[i] < menor)
    { 
        menor = numeros[i];
    }
}
Console.WriteLine($"O maior número é {menor}");
