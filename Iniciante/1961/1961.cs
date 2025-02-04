using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] b = Console.ReadLine().Split(' ').Select(int.Parse).Take(a[1]).ToArray();
int contador = 1;
while (true)
{
    if (contador == a[1])
    {
        Console.WriteLine("YOU WIN");
        break;
        
    }
    else if (b[contador-1] > b[contador])
    {
        int diferença = Math.Abs(b[contador] - b[contador-1]);
        if (diferença > a[0])
        {
            Console.WriteLine("GAME OVER");
            break;
        }
        else
        {
            contador++;
        }
    }
    else if (b[contador-1] <= b[contador])
    {
        int diferença1 = b[contador] - b[contador - 1];
        if (diferença1 > a[0]) 
        {
            Console.WriteLine("GAME OVER");
            break;
        }
        else
        {
            contador++;
        }
    }
}
        
        
        
        
        
        
        
      
    }

}