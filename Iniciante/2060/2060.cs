using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

int quantidade =  int.Parse(Console.ReadLine());
int multiplos2 = 0, multiplos3 = 0, multiplos4 = 0, multiplos5 = 0;
int index = 0;
int[] valores = Console.ReadLine().Split(' ').Take(quantidade).Select(int.Parse).ToArray();
while (true)
{
    if (valores[index] % 2 == 0)
    {
        multiplos2++;
    }
    if (valores[index] % 3 == 0)
    {
        multiplos3++;
    }
    if (valores[index] %4 == 0)
    {
        multiplos4++;
    }
    if (valores[index] % 5 == 0)
    {
        multiplos5++;
    }
    if (index == quantidade - 1)
    {
        break;
    }
    index++;
}
Console.WriteLine($"{multiplos2} Multiplo(s) de 2");
Console.WriteLine($"{multiplos3} Multiplo(s) de 3");
Console.WriteLine($"{multiplos4} Multiplo(s) de 4");
Console.WriteLine($"{multiplos5} Multiplo(s) de 5");





    }

}