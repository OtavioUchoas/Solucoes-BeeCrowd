using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       while (true)
{
    int[] a = Console.ReadLine().Split(' ').Take(2).Select(int.Parse).ToArray();
    int notas = 0;
    int resto = 0;
    if (a[0] == 0 && a[1] == 0)
    {
        break;
    }
    int troco = a[1] - a[0];
    if (troco > 200)
    {
        Console.WriteLine("impossible");
        continue;
    }
    else if (troco == 100 || troco == 20 || troco == 10)
    {
        Console.WriteLine("possible");
        continue;
    }
    else
    {
        if (troco > 100)
        {
            notas += (troco / 100);
            troco %= 100;
        }
        if (troco >= 50)
        {
            notas += (troco / 50);
            troco %= 50;
        }
        if (troco >= 20)
        {
            notas += (troco / 20);
            troco %= 20;
        }
        if (troco >= 10)
        {
            notas += (troco / 10);
            troco %= 10;
        }
        if (troco >= 5)
        {
            notas += (troco / 5);
            troco %= 5;
        }
        if (troco >= 2)
        {
            notas += (troco / 2);
        }
        if (notas > 2 || notas < 2)
        {
            Console.WriteLine("impossible");
            continue;
        }
        if (notas == 2)
        {
            Console.WriteLine("possible");
        }
    }
}

    }

}