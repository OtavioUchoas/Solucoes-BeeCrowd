using System; 

class URI {

    static void Main(string[] args) { 

      for (int i = 1 , j = 8; i < 10; i += 2, j+=2 )
{
    Console.WriteLine($"I={i} J={j-1}");
    Console.WriteLine($"I={i} J={j-2}");
    Console.WriteLine($"I={i} J={j-3}");
}

    }

}