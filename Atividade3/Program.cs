Console.Write("Digite o tamanho do vetor: ");
int tamanho = int.Parse(Console.ReadLine());

int[] fibonacci = new int[tamanho];

for (int i = 0; i < tamanho; i++)
{
    if (i == 0)
    {
        fibonacci[i] = 0;
    }
    else if (i == 1)
    {
        fibonacci[i] = 1;
    }
    else
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
}

Console.WriteLine("\nSequência de Fibonacci gerada:");
for (int i = 0; i < tamanho; i++)
{
    Console.Write(fibonacci[i] + " ");
}