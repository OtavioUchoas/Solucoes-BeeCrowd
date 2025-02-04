using System; 

class URI {

    static void Main(string[] args) { 

       int numero = int.Parse(Console.ReadLine());
for (int i = 0; i < numero; i++)
{
    int a = int.Parse(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine("0");
    }
    if (a % 2 != 0)
    {
        Console.WriteLine("1");
    }
}
    }

}