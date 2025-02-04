using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

  while (true)
{
    string entrada = Console.ReadLine();
    if (string.IsNullOrEmpty(entrada))
    {
        break;
    }
    int[] a = entrada.Split(':').Select(int.Parse).ToArray();


    int horapsegundo = 3600 * a[0];
    int minutohora = 60 * a[1];
    if ((horapsegundo + minutohora) < 25260)
    {
        Console.WriteLine("Atraso maximo: 0");
    }
    else
    {
        float diferença = (horapsegundo + minutohora) - 25260;
        Console.WriteLine($"Atraso maximo: {diferença / 60 + 1}");

    }
}
  
  
  
  
  
  
  
  
    }

}