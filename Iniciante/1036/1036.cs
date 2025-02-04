using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

 double[] a = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

if (a[0] == 0 || (a[1] * a[1] - 4 * a[0] * a[2]) < 0)
{
    Console.WriteLine("Impossivel calcular");
}

else
{
    Console.WriteLine("R1 = {0:f5}", (-a[1] + Math.Sqrt((a[1] * a[1]) - (4 * a[0] * a[2]))) / (2 * a[0]));
    Console.WriteLine("R2 = {0:f5}", (-a[1] - Math.Sqrt((a[1] * a[1]) - (4 * a[0] * a[2]))) / (2 * a[0]));
    
}

    }
