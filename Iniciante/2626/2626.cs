using System; 
using System.Linq;
using System.Collections.Generic;
class URI {

    static void Main(string[] args) { 

     
     Dictionary<string, string > valores = new Dictionary<string, string>()
{
    ["pedra"] = "tesoura",
    ["papel"] = "pedra",
    ["tesoura"] = "papel",
};
while (true)
{
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    int ganhadorPartida = 0;
    string[] c = b.Split(' ');
    int ganhadores = 0;
    for (int i = 0; i < c.Length; i++)
    {
        int ganhador = 0;
        for (int j = 0; j < c.Length; j++)
        {
            if (i == j)
            {
                continue;
            }
            string jogada_win = valores[c[i]];
            string jogada_lose = valores[c[j]];
            if (jogada_win == c[j])
            {
                ganhador = i + 1;
            }
            else if (c[i] == jogada_lose)
            {
                ganhador = 0;
                break;
            }
        }
        if (ganhador > 0)
        {
            ganhadores++;
            ganhadorPartida = ganhador;
        }
    }
    if (ganhadores != 1)
    {
        Console.WriteLine("Putz vei, o Leo ta demorando muito pra jogar...");
    }
    else if (ganhadorPartida == 1)
    {
        Console.WriteLine("Os atributos dos monstros vao ser inteligencia, sabedoria...");
    }
    else if (ganhadorPartida == 2)
    {
        Console.WriteLine("Iron Maiden's gonna get you, no matter how far!");
    }
    else
    {
        Console.WriteLine("Urano perdeu algo muito precioso...");
    }
}

     
     
     
     
     
     
     
     
    }

}