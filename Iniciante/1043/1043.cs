using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       
double[] a = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

if ((a[0]) < (a[1] + a[2]) && (a[1]) < (a[0] + a[2]) && (a[2]) < (a[0] + a[1]))
{
    Console.WriteLine("Perimetro = {0:f1}" , (a[0] + a[1] + a[2]));
}
else
{
    Console.WriteLine("Area = {0:f1}" , (a[0] + a[1]) * (a[2] / 2));
}







    }

}