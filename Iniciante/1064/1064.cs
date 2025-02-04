using System; 

class URI {

    static void Main(string[] args) { 

       

int n = 0;
float n2 = 0;

for (int i = 0; i < 6; i++)
{
    float p = float.Parse(Console.ReadLine());
    if (p > 0)
    {
        n++;
        n2 += p;


    }

}
Console.WriteLine(n + " valores positivos");
Console.WriteLine($"{n2/n:f1}");
    }

}