using System; 

class URI {

    static void Main(string[] args) { 

     int soma = 0;
int repetiçoes = int.Parse(Console.ReadLine());
for (int i = 0;i < repetiçoes; i++)
{
    int numero = int.Parse(Console.ReadLine());
    for (int j = 1;j < numero; j++)
    {
        if (numero % j == 0)
        {
            soma += j;
        }
        else
        {
            continue;
        }
    }
    if (soma == numero)
    {
        Console.WriteLine($"{numero} eh perfeito");
        soma = 0;
    }
    else
    {
        Console.WriteLine($"{numero} nao eh perfeito");
        soma = 0;
    }
}

     
     
     
     
     
     
    }

}