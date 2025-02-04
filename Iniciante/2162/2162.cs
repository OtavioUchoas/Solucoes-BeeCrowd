using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

 int numeros = int.Parse(Console.ReadLine());
int[] valores = Console.ReadLine().Split(' ').Take(numeros).Select(int.Parse).ToArray();
int index = 1;
if (valores[0] == valores[1])
{
    Console.WriteLine("0");
    return;
}
if (valores[0] < valores[1])
{
    // vale, pico
    for (int i = 0; i < numeros && index < numeros; i++, index++)
    {
        if (i % 2 == 0)
        {
            if (valores[index] > valores[i])
            {
                continue;
            }
            else
            {
                Console.WriteLine("0");
                return;
            }
        }
        else
        {
            if (valores[index] < valores[i])
            {
                continue;
            }
            else
            {
                Console.WriteLine("0");
                return;
            }
        }
    }
    Console.WriteLine("1");
}
if (valores[0] > valores[1])
{
    // pico, vale
    for (int i = 0; i < numeros && index < numeros; i++, index++)
    {
        
        if (i % 2 == 0)
        {
            if (valores[index] < valores[i])
            {
                continue;
            }
            else
            {
                Console.WriteLine("0");
                return;
            }
        }
        else
        {
            if (valores[index] > valores[i])
            {
                continue;
            }
            else
            {
                Console.WriteLine("0");
                return;
            }
        }
    }
    Console.WriteLine("1");
}


    }

}