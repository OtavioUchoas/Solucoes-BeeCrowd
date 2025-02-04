using System; 

class URI {

    static void Main(string[] args) { 

       while (true)
{
    string entrada = Console.ReadLine();
    if (string.IsNullOrEmpty(entrada))
    {
        break;
    }
    double volume = double.Parse(entrada);
    double raio = double.Parse(Console.ReadLine());
    raio /= 2;
    double altura = volume / (3.14 * raio * raio);
    Console.WriteLine($"ALTURA = {altura:f2}");
    Console.WriteLine($"AREA = {(3.14 * raio*raio):f2}");
}


    }

}