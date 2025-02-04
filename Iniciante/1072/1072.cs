using System; 

class URI {

    static void Main(string[] args) { 

        
int quantidade = int.Parse(Console.ReadLine());
int dnt = 0;
int fora = 0;
for (int i = 0 ; i < quantidade ; i++) 
{
    int p = int.Parse(Console.ReadLine());
    if (p >= 10 && p <= 20)
    {
        dnt++;

    }
    else
    {
        fora++;
    }

}
Console.WriteLine(dnt + " in");
Console.WriteLine(fora + " out");

    }

}