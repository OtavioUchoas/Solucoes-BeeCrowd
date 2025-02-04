using System; 

class URI {

    static void Main(string[] args) { 

      int quantidade = int.Parse(Console.ReadLine());
for (int i = 0; i < quantidade; i++)
{
    string jogador01 = Console.ReadLine();
    string jogador02 = Console.ReadLine();
    if (jogador01 == "ataque" && jogador02 == "ataque")
    {
        Console.WriteLine("Aniquilacao mutua");
        continue;
    }
    else if (jogador01 == "papel" && jogador02 == "papel")
    {
        Console.WriteLine("Ambos venceram");
        continue;
    }
    else if (jogador01 == "pedra" && jogador02 == "pedra")
    {
        Console.WriteLine("Sem ganhador");
        continue;
    }
    else if (jogador01 == "ataque")
    {
        Console.WriteLine("Jogador 1 venceu");
        continue;
    }
    else if (jogador02 == "ataque")
    {
        Console.WriteLine("Jogador 2 venceu");
        continue;
    }
    else if (jogador01 == "papel" && jogador02 == "pedra")
    {
        Console.WriteLine("Jogador 2 venceu");
        continue;
    }
    else if (jogador01 == "pedra" && jogador02 == "papel")
    {
        Console.WriteLine("Jogador 1 venceu");
        continue;
    }
}
      
      
      
      

    }

}