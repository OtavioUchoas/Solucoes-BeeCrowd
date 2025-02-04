using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       int numero = int.Parse(Console.ReadLine());
for (int i = 0; i < numero; i++)
{
    string[] dados = Console.ReadLine().Split(' ');
    int a = Console.ReadLine().Split(' ').Select(int.Parse).Sum();
    if (dados[1] == "PAR" && a%2 == 0)
    {
        Console.WriteLine(dados[0]);
    }
    else if(dados[1] == "IMPAR" && a%2!=0)
    {
        Console.WriteLine(dados[0]);
    }
    else
    {
        Console.WriteLine(dados[2]);
    }

}

    }

}