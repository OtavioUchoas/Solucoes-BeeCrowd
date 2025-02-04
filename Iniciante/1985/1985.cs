using System; 
using System.Collections.Generic;
using System.Linq;
class URI {

    static void Main(string[] args) { 

     
     Dictionary<int, double> valores = new Dictionary<int, double>()
{
    [1001] = 1.50,
    [1002] = 2.50,
    [1003] = 3.50,
    [1004] = 4.50,
    [1005] = 5.50,
};
double somas = 0;
int ciclos = int.Parse(Console.ReadLine());
for (int i = 0; i < ciclos; i++)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    somas += (a[1] * valores[a[0]]);

}
Console.WriteLine($"{somas:f2}");
     
     
     

    }

}