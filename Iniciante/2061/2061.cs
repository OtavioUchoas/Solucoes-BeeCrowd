using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int[] valores = Console.ReadLine().Split(' ').Take(2).Select(int.Parse).ToArray();

for (int i = 0; i < valores[1]; i++)
{
    string variavel = Console.ReadLine();
    if (variavel == "fechou")
    {
        valores[0] += 1;
    }
    else
    {
        valores[0] -= 1;
    }
}
Console.WriteLine(valores[0]);

    

    }

}