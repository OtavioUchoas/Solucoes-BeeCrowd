using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

float entrada = float.Parse(Console.ReadLine());
for (int c = 0; c < entrada; c++)
{
    float[] a = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
    if (a[1] == 0)
    {
        Console.WriteLine("divisao impossivel");
        continue;
    }
    Console.WriteLine($"{a[0] / a[1]:f1}");
}

    }

}