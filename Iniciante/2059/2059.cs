using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

   int[] valores = Console.ReadLine().Split(' ').Take(5).Select(int.Parse).ToArray();
int somatorio = valores[1]+valores[2];
if (valores[3] == 1 && valores[4] == 1)
{
    Console.WriteLine("Jogador 2 ganha!");
    return;
}
else if (valores[3] == 1 && valores[4] == 0)
{
    Console.WriteLine("Jogador 1 ganha!");
    return;
}
else if (valores[0]== 1 && somatorio%2 == 0)
{
    Console.WriteLine("Jogador 1 ganha!");
    return;
}
else if (valores[0] == 0 && somatorio % 2 != 0)
{
    Console.WriteLine("Jogador 1 ganha!");
    return;
}
else
{
    Console.WriteLine("Jogador 2 ganha!");
    return;
}
    }

}