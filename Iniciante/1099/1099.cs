using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        
        int duração = int.Parse(Console.ReadLine());


for (int i = 0; i < duração; i++)
{
    int[] rodadas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int soma = 0;
    if (rodadas[1] > rodadas[0])
    {
        int troca = rodadas[0];
        rodadas[0] = rodadas[1];
        rodadas[1] = troca;
    }
    for (int cebola = rodadas[1]+1; cebola < rodadas[0]; cebola++)
    {
        if (cebola % 2 != 0)
        {
            soma += cebola;
            
        }
        
    }
    Console.WriteLine(soma);
}
        
        
        
        
        
        
        
        

    }

}