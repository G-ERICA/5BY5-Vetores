//3.Inversão de Vetor
//Objetivo: Ler 6 números inteiros e armazená-los em dois novos vetores.
//Tarefas:
//Um vetor de números pares
//Um vetor de números ímpares


int i = 0, contadorPar = 0, contadorImpar = 0;

int[] lidos = new int[6];
int[] pares = new int[6];
int[] impares = new int[6];

for (i = 0; i < lidos.Length; i++) 
{
    Console.WriteLine("Digite um número");
    lidos[i] = int.Parse(Console.ReadLine()!);
}

for(i = 0; i < lidos.Length; i++)
{
    if (lidos[i] % 2 == 0)
    {
        pares[contadorPar] = lidos[i];
        contadorPar++;
    }
    else
    {
        impares[contadorImpar] = lidos[i];
        contadorImpar++;
    }
}


for (i = 0; i < contadorPar; i++) 
{
    Console.Write($"{pares[i]} ");
}

Console.WriteLine("\n");

for (i = 0; i < contadorImpar; i++) 
{
    Console.Write($"{impares[i]} ");
}