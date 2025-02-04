using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

    int soma = 0;

int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int index = 1;
int n = a[index];
while (n <= 0)
{
    index++;
    n = a[index];
}
for (int i = 0; i < n; i++)
{
    soma += i + a[0];
} 
Console.WriteLine(soma);

    }

}