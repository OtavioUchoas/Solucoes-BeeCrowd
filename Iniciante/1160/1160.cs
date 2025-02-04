using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int anos = 0;
int casos = int.Parse(Console.ReadLine());
for (int i = 0; i < casos; i++)
{
    float[] a = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
    float c = a[2] / 100;
    float d = a[3] / 100;
    float totalA = a[0];
    float totalB = a[1];
  
    while (totalA <= totalB)
    {

        float reserva1 = totalA + (totalA * c);
        float reserva2 =  totalB + (totalB * d);
        
        totalA = (int)reserva1;
        totalB = (int)reserva2;
        anos++;
        if(anos > 100)
        {
            break;
        }
    }
    if (anos > 100)
    {
        Console.WriteLine("Mais de 1 seculo.");
        anos = 0;
    }
    else
    {
        Console.WriteLine(anos + " anos.");
        anos = 0;
    }
}

    }

}