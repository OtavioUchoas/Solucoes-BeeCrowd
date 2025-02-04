using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

 int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] n = a.ToArray();
Array.Sort(n);

for (int i = 0; i < n.Length; i++)
{
    Console.WriteLine(n[i]);
}
Console.WriteLine("");
for (int i = 0;i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}

        
        
        
        
        
        
    }

}