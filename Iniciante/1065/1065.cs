using System; 

class URI {

    static void Main(string[] args) { 

       int n = 0;

for (int i = 0; i < 5; i++)
{
    float p = float.Parse(Console.ReadLine());
    if (p % 2 == 0)
    {
        n++;


    }

}
Console.WriteLine(n + " valores pares");

    }

}