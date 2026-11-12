char[] caracter = new char[6];

for (int i = 0; i < caracter.Length; i++)
{
    Console.WriteLine($"Digite {i + 1} caracter");
    caracter[i] = char.Parse(Console.ReadLine());
}

void Exibir()
{
    for (int i = 0; i < caracter.Length; i++)
    {
        Console.WriteLine($"Mostrando cada caracter na ordem {caracter[i]}");
    }
}

void ExibirReverse()
{
    for (int i = caracter.Length -1; i >= 0; i--)
    {
        Console.WriteLine($"Mostrando cada caracter na ordem decrescente {caracter[i]}");
    }
}

Console.WriteLine();
Exibir();
Console.WriteLine();
ExibirReverse();