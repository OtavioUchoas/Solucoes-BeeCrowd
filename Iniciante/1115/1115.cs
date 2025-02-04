using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        while (true)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if (a[0] > 0 && a[1] > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (a[0] < 0 && a[1] > 0)
    {
        Console.WriteLine("segundo");
    }
    else if (a[0] < 0 && a[1] < 0)
    {
        Console.WriteLine("terceiro");
    }
    else if (a[0] > 0 && a[1] < 0)
    {
        Console.WriteLine("quarto");
    }
    else if (a[0] == 0 || a[1] == 0)
    {
        break;
    }

}
        
        
        
        
        

    }

}