using System; 
using System.Linq;
using System.Text;
class URI {

    static void Main(string[] args) { 

       while (true)
{
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    int casos = int.Parse(Console.ReadLine());
    int[] numeros = Console.ReadLine().Split(' ').Take(casos).Select(int.Parse).ToArray();
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < casos; i++)
    {
        sb.Append(b[numeros[i]-1]);
    }
    Console.WriteLine(sb.ToString());
}

    }

}