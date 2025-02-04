using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        
        int[] ntomadas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.WriteLine((ntomadas[0] + ntomadas[1] + ntomadas[2] + ntomadas[3]) - 3);
        
        
        
        

    }

}