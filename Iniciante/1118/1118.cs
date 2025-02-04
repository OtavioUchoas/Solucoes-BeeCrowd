using System; 

class URI {

    static void Main(string[] args) { 

     
while (true)
{
    float entrada1 = float.Parse(Console.ReadLine());
    if (entrada1 > 10 || entrada1 < 0)
    {
        Console.WriteLine("nota invalida");
        continue;
    }
    while (true)
    {
        float entrada2 = float.Parse(Console.ReadLine());
        if (entrada2 > 10 || entrada2 < 0)
        {
            Console.WriteLine("nota invalida");
            continue;
        }
        Console.WriteLine($"media = {(entrada1 + entrada2) / 2:f2}");
        
            
        break;
    }
    string resp = "";
    while (resp != "1" && resp != "2")
    {
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        resp = Console.ReadLine();
    }
    if (resp == "1")
    {
        continue;
    }
    else
    {
        break;
    }
}

     
     
     
     
     

    }

}