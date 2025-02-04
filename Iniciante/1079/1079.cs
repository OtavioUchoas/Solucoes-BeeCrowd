using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        
        
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    float[] a = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
    
    Console.WriteLine("{0:f1}", (a[0] * 2.0 + a[1] * 3.0 + a[2] * 5) / 10.0);

}

    }

}