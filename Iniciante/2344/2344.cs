using System; 

class URI {

    static void Main(string[] args) { 

    
    int numero = int.Parse(Console.ReadLine());
if (numero == 0)
{
    Console.WriteLine("E");
}
else if (numero > 0 && numero <= 35)
{
    Console.WriteLine("D");
}
else if (numero >= 36 && numero <= 60)
{
    Console.WriteLine("C");
}
else if (numero >= 61 && numero <= 85)
{
    Console.WriteLine("B");
}
else if (numero >= 86 && numero <= 100)
{
    Console.WriteLine("A");
}

    }

}