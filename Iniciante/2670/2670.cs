using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

   int andar0 = int.Parse(Console.ReadLine());
int andar1 = int.Parse(Console.ReadLine());
int andar2 = int.Parse(Console.ReadLine());
int[] array1 = {andar0, andar1, andar2};
int c = array1.Max();
int n = Array.IndexOf(array1, c);
int teste = array1.Sum();
if (c > teste-c)
{
    if (n == 0)
    {
        andar2 *= 4;
        andar1 *= 2;
        Console.WriteLine(andar2 + andar1);
    }
    else if (n == 1)
    {
        andar2 *= 2;
        andar0 *= 2;
        Console.WriteLine(andar2 + andar0);
    }
    else
    {
        andar0 *= 4;
        andar1 *= 2;
        Console.WriteLine(andar0 + andar1);
    }
}
else
{
    array1[0] *= 2;
    array1[2] *= 2;
    Console.WriteLine(array1[0] + array1[2]);
}
    }

}