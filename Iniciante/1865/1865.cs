using System; 

class URI {

    static void Main(string[] args) { 

      int numero = int.Parse(Console.ReadLine());
for (int i = 0; i < numero; i++)
{
    string[] seletor= Console.ReadLine().Split(' ');
    if (seletor[0] == "Thor") 
    {
        Console.WriteLine("Y");
    }
    if (seletor[0] != "Thor")
    {
        Console.WriteLine("N");
    }
}

    }

}