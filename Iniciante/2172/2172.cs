using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

 while (true)
{
    long[] n = Console.ReadLine().Split(' ').Take(2).Select(long.Parse).ToArray();
    if (n[0] == 0 && n[1] == 0)
    {
        break;
    }
    else
    {
        Console.WriteLine(n[0] * n[1]);
    }
}


    }

}