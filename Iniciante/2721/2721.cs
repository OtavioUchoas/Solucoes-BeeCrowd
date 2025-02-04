using System; 
using System.Linq;
using System.Text;
using System.Collections.Generic;
class URI {

    static void Main(string[] args) { 

    Dictionary<long, string> valores = new Dictionary<long, string>()
{
    [0] = "Dasher",
    [1] = "Dancer",
    [2] = "Prancer",
    [3] = "Vixen",
    [4] = "Comet",
    [5] = "Cupid",
    [6] = "Donner",
    [7] = "Blitzen",
    [8] = "Rudolph",
};
long index = 0;
long[] c = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
long[] matriz = new long[9];   
long b = c.Sum();
if (b > 9)
{
    long x = b / 9;
    long Y = b - x * 9;
    index = Y;
    if (index == 0)
    {
        index = 8;
    }
    else
    {
        index--;
    }
}
Console.WriteLine(valores[index]);
    
    
    
    
    

    }

}