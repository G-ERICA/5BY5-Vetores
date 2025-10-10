//Cria um vetor que recebe números inteiros aleatórios, seu tamanho será define conforme informado pelo usuário.

int i = 0, tamanho = 0;

Console.WriteLine("Informe o tamanho do vetor: ");
tamanho = int.Parse(Console.ReadLine()!);

int[] numeros = new int[tamanho];

while (i < tamanho)
{
    numeros[i] = Random.Shared.Next(1, 100);
    i++;
}

//Imprima na telha: 
//Todos os números que compoem o vetor, e de modo separado, a primeira metade e a segunda metade.

for (i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\n\n");

for (i = 0; i < (numeros.Length / 2); i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\n\n");

for (i = (numeros.Length / 2); i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\n\n");

//Agora faça a impressão das metades ao contrário, do útlimo para o primeiro espaço. 

for (i = (numeros.Length / 2) - 1; i >= 0; i--)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\n\n");

for (i = numeros.Length - 1; i >= (numeros.Length / 2); i--)
{
    Console.Write(numeros[i] + " ");
}