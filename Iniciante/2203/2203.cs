using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

while (true)
{
    string valores = Console.ReadLine();
    if (string.IsNullOrEmpty(valores))
    {
        break;
    }
    int[] num = valores.Split(' ').Select(int.Parse).ToArray();
    double distancia = (Math.Sqrt(Math.Pow(num[2] - num[0], 2) + Math.Pow(num[3] - num[1], 2)));
    distancia += 1.5 * num[4];
    if (distancia <= num[5] + num[6])
    {
        Console.WriteLine("Y");
    }
    else
    {
        Console.WriteLine("N");
    }
}


    }

}