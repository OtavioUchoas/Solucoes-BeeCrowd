using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       while (true)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if (a[0] > a[1])
    {
        Console.WriteLine("Decrescente");
    }
    else if (a[0] < a[1])
    {
        Console.WriteLine("Crescente");
    }
    else
    {
        break;
    }


}
    }

}