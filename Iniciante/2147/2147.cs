using System; 

class URI {

    static void Main(string[] args) { 

     int entrada = int.Parse(Console.ReadLine());
for (int i = 0; i < entrada; i++)
{
    string digito = Console.ReadLine();
    float quantidade = digito.Length;
    Console.WriteLine($"{0.01 * quantidade:f2}");
}

    }

}