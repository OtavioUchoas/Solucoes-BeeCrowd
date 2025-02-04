using System; 

class URI {

    static void Main(string[] args) { 

      
int quantidade = int.Parse(Console.ReadLine());


for (int i = 0; i < quantidade; i++)
{
    int p = int.Parse(Console.ReadLine());
    if (p % 2 == 0 && p > 0)
    {
        Console.WriteLine("EVEN POSITIVE");
    }
    if (p % 2 == 0 && p < 0)
    {
        Console.WriteLine("EVEN NEGATIVE");
    }
    if (p % 2 != 0 && p > 0)
    {
        Console.WriteLine("ODD POSITIVE");
    }
    if (p % 2 != 0 && p < 0)
    {
        Console.WriteLine("ODD NEGATIVE");
    }
    if (p == 0)
    {
        Console.WriteLine("NULL");
    }
}
    }

}