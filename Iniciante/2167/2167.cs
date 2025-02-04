using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

int quantidade = int.Parse(Console.ReadLine());
int index = 1;
int[] n = Console.ReadLine().Split(' ').Take(quantidade).Select(int.Parse).ToArray();
for (int i = 0; i < quantidade && index < quantidade; i++, index++)
{
    if (n[index]>= n[i])
    {
        continue;
    }
    else if (n[index] < n[i])
    {
        Console.WriteLine(index+1);
        return;
    }
}
Console.WriteLine("0");



    }

}