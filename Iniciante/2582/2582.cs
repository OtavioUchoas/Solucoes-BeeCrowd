using System; 
using System.Linq;
using System.Collections.Generic;
class URI {

    static void Main(string[] args) { 

        Dictionary<int, string> valores = new Dictionary<int, string>()
{
    [0] = "PROXYCITY",
    [1] = "P.Y.N.G.",
    [2] = "DNSUEY!",
    [3] = "SERVERS",
    [4] = "HOST!",
    [5] = "CRIPTONIZE",
    [6] = "OFFLINE DAY",
    [7] = "SALT",
    [8] = "ANSWER!",
    [9] = "RAR?",
    [10] = "WIFI ANTENNAS",
};
int c = int.Parse(Console.ReadLine());
for (int i = 0; i < c; i++)
{
    int[] b = Console.ReadLine().Split(' ').Take(2).Select(int.Parse).ToArray();
    b[0] += b[1];
    Console.WriteLine($"{valores[b[0]]}");
}


    }

}