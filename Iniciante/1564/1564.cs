using System; 

class URI {

    static void Main(string[] args) { 

        
        while (true)
{
    string entrada = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(entrada))
    {
        break;
    }
    int numero = int.Parse(entrada);
    if (numero > 0)
    {
        Console.WriteLine("vai ter duas!");
    }
    if (numero == 0)
    {
        Console.WriteLine("vai ter copa!");
    }

}

        
        
        
        
        
        

    }

}