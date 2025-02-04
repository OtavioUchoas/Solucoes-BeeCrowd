using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       
       int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
if (a[0] % a[1] ==0 || (a[1] % a[0]) == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}
       
       
       
       
    }

}