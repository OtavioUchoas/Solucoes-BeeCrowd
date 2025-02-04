using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

int[] valores = Console.ReadLine().Split(' ').Take(3).Select(int.Parse).ToArray();
if (valores[0] + valores[1] + valores[2] > 23)
{
    Console.WriteLine((valores[0] + valores[1] + valores[2]) - 24);
}
else if (valores[0] + valores[1] + valores[2] < 0)
{
    Console.WriteLine(24 - Math.Abs((valores[0] + valores[1] + valores[2])));
}
else
{
    Console.WriteLine(valores[0] + valores[1] + valores[2]);

}






    }

}