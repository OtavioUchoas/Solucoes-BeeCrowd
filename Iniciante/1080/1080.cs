using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 



int[] numeros = new int[100];
for (int i = 0; i < 100; i++)
{
   int b= int.Parse(Console.ReadLine());
   numeros[i] = b;
  
   
}
int maior = numeros.Max();
int index = Array.IndexOf(numeros, maior) + 1;
Console.WriteLine(maior);
Console.WriteLine(index);








    }

}