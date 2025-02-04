using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        float[] a = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
if (a[0] == 0 && a[1] == 0)
{
    Console.WriteLine("Origem");
}
if (a[0] == 0 && (a[1] > 0 || a[1] < 0))
{
    Console.WriteLine("Eixo Y");
}
if ((a[0] > 0 || a[0] < 0) && a[1] == 0)
{
    Console.WriteLine("Eixo X");
}
if (a[0] > 0 && a[1] > 0)
{
    Console.WriteLine("Q1");
}
if (a[0] < 0 && a[1] > 0)
{
    Console.WriteLine("Q2");
}
if (a[0] < 0 && a[1] < 0)
{
    Console.WriteLine("Q3");
}
if (a[0] > 0 && a[1] < 0)
{
    Console.WriteLine("Q4");
}
        
        
        
        
        
        
        
        
    
    }

}