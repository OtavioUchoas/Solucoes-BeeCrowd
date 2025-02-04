using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int c = int.Parse(Console.ReadLine());
int[] tempos = Console.ReadLine().Split(' ').Take(2).Select(int.Parse).ToArray();
if (tempos.Sum() > c)
{
    Console.WriteLine("Deixa para amanha!");
}
else
{
    Console.WriteLine("Farei hoje!");
}
        
        
        
        
        
        
        
       

    }

}