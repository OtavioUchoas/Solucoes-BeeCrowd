using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       while (true)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int somas = 0;
    if (a[0] <= 0 || a[1] <= 0)
    {
        break;
    }
    if (a[1] > a[0])
    {
        int trocatemp = a[1];
        a[1] = a[0];
        a[0] = trocatemp;
    }
    for (int numero = a[1]; numero <= a[0]; numero++)
    {
        somas += numero;
        Console.Write(numero + " ");
        
    }
    Console.WriteLine($"Sum={somas}");
}

    }

}