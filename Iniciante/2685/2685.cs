using System; 

class URI {

    static void Main(string[] args) { 

        while (true)
{
    string c = Console.ReadLine();
    if (string.IsNullOrEmpty(c))
    {
        break;
    }
    int b = int.Parse(c);
    if ((b == 360) || (b >= 0 && b < 90))
    {
        Console.WriteLine("Bom Dia!!");
    }
    else if (b >= 90 && b < 180)
    {
        Console.WriteLine("Boa Tarde!!");
  
    }
    else if (b >= 180 && b < 270)
    {
        Console.WriteLine("Boa Noite!!");
    }
    else if (b >= 270 && b < 360)
    {
        Console.WriteLine("De Madrugada!!");
    }

}


    }

}