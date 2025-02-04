using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 1; i <= a[1]; i++)
{
   if (i % a[0] == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.Write(i + " ");
    }

}
       
       
       
       
       

    }

}