int tamanho = 3;
char[] vetor1 = new char[tamanho];
string[] vetor2 = new string[tamanho*2];

void PopularVetor(char[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine("Informe a letra desejada: ");
        vetor[i] = char.Parse(Console.ReadLine());

    }
}

int ConverterASCII(char letra)
{
    return (int)letra;
}

void CriarVetorASCII()
{
    for (int i = 0; i < vetor1.Length; i+=2)
    {
        vetor2[i] = vetor1[i/2].ToString();
        vetor2[i+1] = ConverterASCII(vetor1[i/2]).ToString();
    }
}

void ExibirVetor(string[] vetor)
{
    for(int i = 0;i < vetor.Length; i++)
    {
        Console.WriteLine($"[{vetor[i]}] ");
    }
    Console.Write("\n");
}

PopularVetor(vetor1);

string[] temp = new string[vetor1.Length];

for (int i = 0; i < vetor1.Length; i++)
{
    temp[i] = vetor1[i].ToString(); 
}

ExibirVetor(temp);
CriarVetorASCII();
ExibirVetor(vetor2);