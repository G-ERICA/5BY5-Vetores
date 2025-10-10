//Crie um programa que gere 10 números aleatorios em um vetor 
//Crie um segundo vetor, que ordene de forma crescente esses números

int[] numeros = new int[10];
int[] ordenacao = new int[numeros.Length];
int auxiliar = 0;

for (int i = 0; i < numeros.Length; i++) 
{ 
    numeros[i] = Random.Shared.Next(0, 100);
    ordenacao[i] = numeros[i];
    Console.Write(numeros[i] + " ");
}

for (int refe = 0; refe < numeros.Length - 1; refe++) 
{
    for (int comp = refe + 1; comp < ordenacao.Length; comp++)
    {
        if (ordenacao[refe] > ordenacao[comp])
        {
            auxiliar = ordenacao[refe];
            ordenacao[refe] = ordenacao[comp];
            ordenacao [comp] = auxiliar;
        }
    }
}

Console.WriteLine(" ");

for (int i = 0; i < ordenacao.Length; i++) 
{
    Console.Write(ordenacao[i] + " ");
}
