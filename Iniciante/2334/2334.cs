using System; 

class URI {

    static void Main(string[] args) { 

   while (true)
{
    decimal numero = decimal.Parse(Console.ReadLine());
    if (numero == -1m)
    {
        break;
    }
    else if (numero == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        Console.WriteLine(numero-1m);
    }
}



    }

}