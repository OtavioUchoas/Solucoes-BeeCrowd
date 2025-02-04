using System; 

class URI {

    static void Main(string[] args) { 

       int qntd = int.Parse(Console.ReadLine());
for (int i = 0; i < qntd; i++)
{
    int numero = int.Parse(Console.ReadLine());
    if (2015 > numero)
    {
        numero = 2015 - numero;
        Console.WriteLine($"{numero} D.C.");
    }
    else
    {
        Console.WriteLine($"{Math.Abs(2015 - numero -1)} A.C.");
    }
}


    }

}