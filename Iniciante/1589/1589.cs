using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

      int casos = int.Parse(Console.ReadLine());
for (int i = 0; i < casos; i++)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Console.WriteLine(a[0] + a[1]);
}
      
      
      
      
      
      
    }

}