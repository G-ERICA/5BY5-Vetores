//4.Contar Ocorrências
//Objetivo: Criar um programa que leia 10 números inteiros e um número de busca.
// Tarefas:
//Contar quantas vezes o número informado aparece no vetor.
//Exibir o total de ocorrências.

int[] leitorDeNumeros = new int[10];
int busca = 0, encontrado = 0;

for (int i = 0; i <leitorDeNumeros.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    leitorDeNumeros[i] = int.Parse(Console.ReadLine()!);

}

Console.WriteLine("\n");

Console.WriteLine("Digite um número para busca: ");
busca = int.Parse(Console.ReadLine()!);

Console.WriteLine("\n");

for (int i = 0; i < leitorDeNumeros.Length; i++)
{
    if (leitorDeNumeros[i] == busca)
    {
        encontrado++;
    }
}

Console.WriteLine($"O número foi encontrado {encontrado} vezes");