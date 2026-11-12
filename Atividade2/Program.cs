int[] numero = new int[5];
int[] numeroreverte = new int[numero.Length];
int[] impar = new int[numero.Length];
int[] par = new int[numero.Length];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"Digite {i + 1} numero inteiro");
    numero[i] = int.Parse(Console.ReadLine());
}

void OrdemDecrescente()
{
    for (int i = 0; i < numero.Length; i++)
    {
        numeroreverte[i] = numero[numero.Length - 1 - i];
    }
}

void ImparPares()
{
    for (int i = 0; i < numero.Length; i++)
    {
        if (numero[i] %  2 == 0)
        {
            par[i] = numero[i];
        }
        else
        {
            impar[i] = numero[i];
        }

    }
}
OrdemDecrescente();
ImparPares();
Console.WriteLine();
Console.WriteLine(string.Join(", ", numero));
Console.WriteLine();
Console.WriteLine(string.Join(", ", numeroreverte));
Console.WriteLine();
Console.WriteLine(string.Join(", ", impar));
Console.WriteLine();
Console.WriteLine(string.Join(", ", par));