using System; 

class URI {

    static void Main(string[] args) { 

       int valores = int.Parse(Console.ReadLine());

long primeiro = 1;
long segundo = 0;

for (int i = 0; i < valores; i++)
{
    int valor1 = int.Parse(Console.ReadLine());
    for (int j = 0; j <= valor1; j++)
    {

        if (j == valor1)
        {
            Console.WriteLine($"Fib({j}) = {segundo}");
        }
        else
        {
            long tempo = segundo;
            segundo += primeiro;
            primeiro = tempo;
        }

    }
    primeiro = 1;
    segundo = 0;
}

    }

}