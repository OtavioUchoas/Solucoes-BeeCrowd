using System; 
using System.Linq;
using System.Collections.Generic;
class URI {

    static void Main(string[] args) { 

       Dictionary<string, int> valores = new Dictionary<string, int>()
{
    ["suco"] = 120,
    ["morango"] = 85,
    ["mamao"] = 85,
    ["goiaba"] = 70,
    ["manga"] = 56,
    ["laranja"] = 50,
    ["brocolis"] = 34,
};
while (true)
{
    int quantidade = 0;
    int somas = 0;
    int c = 0;
    int qntd = int.Parse(Console.ReadLine());
    if (qntd == 0)
    {
        break;
    }
    for (int i = 0; i < qntd; i++)
    {
        string[] coisas = Console.ReadLine().Split(' ');
        quantidade = int.Parse(coisas[0]);
        c = valores[coisas[1]];
        somas += c * quantidade;
    }
    if (somas <= 130 && somas >= 110)
    {
        Console.WriteLine(somas + " mg");
    }
    else if (somas > 130)
    {
        Console.WriteLine($"Menos {somas - 130} mg");
        continue;
    }
    else if (somas < 110)
    {
        Console.WriteLine($"Mais {110 - somas} mg");
        continue;
    }
}

    }

}