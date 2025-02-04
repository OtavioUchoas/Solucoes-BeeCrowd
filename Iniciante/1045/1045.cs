using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        float[] a = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
Array.Sort(a);
Array.Reverse(a);
bool n_triangulo = false;
if (a[0] >= (a[1] + a[2]))
{
    Console.WriteLine("NAO FORMA TRIANGULO");
}
else
{
    if (a[0] * a[0] == a[1] * a[1] + a[2] * a[2])
    {
        Console.WriteLine("TRIANGULO RETANGULO");
    }
    if ((a[0] * a[0]) > (a[1] * a[1] + a[2] * a[2]))
    {
        Console.WriteLine("TRIANGULO OBTUSANGULO");
    }
    if ((a[0] * a[0]) < (a[1] * a[1] + a[2] * a[2]))
    {
        Console.WriteLine("TRIANGULO ACUTANGULO");
    }
    if (a[0] == a[1] && a[1] == a[2])
    {
        Console.WriteLine("TRIANGULO EQUILATERO");
    }
    else if (a[0] == a[1] || a[0] == a[2] || a[1] == a[2])
    {
        Console.WriteLine("TRIANGULO ISOSCELES");
    }
}

    }

}