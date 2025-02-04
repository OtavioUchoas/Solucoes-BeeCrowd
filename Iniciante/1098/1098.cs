using System; 

class URI {

    static void Main(string[] args) { 

for (float i = 0 , j = 1; i <= 2; i += 0.2f, j+=0.2f )
{
    i = (float)Math.Round(i, 1);
    Console.WriteLine($"I={i} J={Math.Round(j, 1)}");
    Console.WriteLine($"I={i} J={Math.Round(j+1, 1)}");
    Console.WriteLine($"I={i} J={Math.Round(j+2, 1)}");
}

    }

}