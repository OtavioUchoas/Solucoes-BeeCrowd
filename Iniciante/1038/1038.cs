using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

      int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
if (a[0] == 1)
{
    Console.WriteLine("Total: R$ {0:f2}", a[1]*4);
}
if (a[0] == 2)
{
    Console.WriteLine("Total: R$ {0:f2}", a[1] * 4.5);
}
if (a[0] == 3)
{
    Console.WriteLine("Total: R$ {0:f2}", a[1] * 5);
}
if (a[0] == 4)
{
    Console.WriteLine("Total: R$ {0:f2}", a[1] * 2);
}
if (a[0] == 5)
{
    Console.WriteLine("Total: R$ {0:f2}", a[1]*1.5);
}


    }

}