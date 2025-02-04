using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 


while (true)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if (a[0] == 0)
    {
        break;
    }
    int metros = a[0] * a[1];

    Console.WriteLine((int)Math.Floor(Math.Sqrt(metros * 100 / a[2])));

}
    


    }

}