using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       long numero = long.Parse(Console.ReadLine());
long[] a = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
bool[] estrelas = new bool[numero];
long soma = a.Sum();
long carneiros = 0;
for (long i = 0; i < numero && i > -1;)
{
    if (a[i] == 0)
    {
        estrelas[i] = true;
        i--;
        continue;
        

    }
    else if (a[i] % 2 == 0)
    {
        a[i]--;
        carneiros++;
        estrelas[i] = true;
        i--;
        continue;
    }
    else if(a[i] % 2 != 0)
    {
        a[i]--;
        carneiros++;
        estrelas[i] = true;
        i++;
        continue;
    }
}
long atacadas = estrelas.Count(x => x == true);
Console.WriteLine(atacadas + " " + (soma-carneiros));

    }

}