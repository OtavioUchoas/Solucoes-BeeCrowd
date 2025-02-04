using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

float[] a = Console.ReadLine().Split(' ').Take(2).Select(float.Parse).ToArray();
Console.WriteLine($"{a[0] / a[1]:f2}");



    }

}