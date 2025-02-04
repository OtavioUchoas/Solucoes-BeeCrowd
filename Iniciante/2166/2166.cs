using System; 

class URI {

    static void Main(string[] args) { 

    double valor = double.Parse(Console.ReadLine());
if (valor == 0)
{
    Console.WriteLine($"{1:f10}");
}
else
{
    double resposta = 2;
    for (int i = 0; i < valor - 1; i++)
    {
        resposta =  2 + (1 / resposta);
    }
    resposta = 1 + (1 / resposta);
    Console.WriteLine($"{resposta:f10}");
}

    }

}