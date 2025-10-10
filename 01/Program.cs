//1.Soma dos Elementos
//Objetivo: Criar um programa que leia 5 números inteiros e armazene em um vetor.
//Tarefas:
//Calcular e exibir a soma de todos os elementos.
//Exibir também a média.

int contador = 0, soma = 0, media = 0;

int[] numerosInteiros = new int[5];

while (contador < numerosInteiros.Length) 
{
    Console.WriteLine("Digite um número: ");
    numerosInteiros[contador] = int.Parse(Console.ReadLine()!);
    contador++;
}

for (int i = 0; i < numerosInteiros.Length; i++) 
{
    soma += numerosInteiros[i];
    media = soma / numerosInteiros.Length; 
}

Console.WriteLine($"A soma dos elementos é {soma}\n e a média é {media}");


