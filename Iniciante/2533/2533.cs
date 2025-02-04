using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

while (true)
{
    float soma1 = 0;
    float soma2 = 0;
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    int casos = int.Parse(b);
    for (int i = 0; i < casos; i++)
    {
        float[] numeros = Console.ReadLine().Split(' ').Take(2).Select(float.Parse).ToArray();
        soma1 += (numeros[0] * numeros[1]);
        soma2 += (numeros[1]);
    }
    Console.WriteLine($"{soma1 / (soma2 * 100):f4}");

}
   
   
   
   
   

    }

}