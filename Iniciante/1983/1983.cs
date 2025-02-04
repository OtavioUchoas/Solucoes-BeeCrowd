using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int qntd = int.Parse(Console.ReadLine());
float valornota_max = 0;
float valormatricula = 0;
for (int i = 0; i < qntd; i++)
{
    float[] a = Console.ReadLine().Split(' ').Take(2).Select(float.Parse).ToArray();
    if (a[1] > valornota_max)
    {
        valornota_max = a[1];
        valormatricula = a[0];
    }
}
if (valornota_max < 8)
{
    Console.WriteLine("Minimum note not reached");
}
else
{
    Console.WriteLine(valormatricula);
}

     

    }

}