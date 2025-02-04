using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        while (true)
{
    int dias = 1;
    float vmediar = 0;
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    int n = int.Parse(b);
    
    for (int i = 0; i < n; i++)
    {
        float[] numeros = Console.ReadLine().Split(' ').Take(2).Select(float.Parse).ToArray();
        if (i == 0)
        {
            Console.WriteLine(dias);
            vmediar = numeros[1] / numeros[0];
            dias++;
            continue;
        }
        if (numeros[1] / numeros[0] > vmediar)
        {
            Console.WriteLine(dias);
            vmediar = numeros[1] / numeros[0];
            dias++;
            continue;
        }
        dias++;
    }
}
        
        
        
        
        

    }

}