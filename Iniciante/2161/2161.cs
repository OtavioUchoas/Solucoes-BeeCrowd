using System; 

class URI {

    static void Main(string[] args) { 

   double valor = double.Parse(Console.ReadLine());
if (valor == 0)
{
    Console.WriteLine($"{3:f10}");
}
else
{
    double resposta = 6;
    for ( int i = 0; i < valor-1; i++)
    {
        resposta = 6 + (1 / resposta);
    }
    resposta = 3 + (1 / resposta);
    Console.WriteLine($"{resposta:f10}");
}
   

    }

}