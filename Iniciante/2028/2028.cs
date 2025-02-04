using System; 
using System.Text;
class URI {

    static void Main(string[] args) { 

        int casos = 1;
int valor = 1;  

while (true)
{
    string entrada = Console.ReadLine();
    if (string.IsNullOrEmpty(entrada))
    {
        break;
    }
    int a = int.Parse(entrada);
    int somatorio = 1;
    for (int i = a; i >= 0; i--)
    {
        somatorio+= i;
    }
    if (a == 0)
    {
        Console.WriteLine($"Caso {casos}: {somatorio} numero");
        Console.WriteLine("0");
        Console.WriteLine();
        casos++;
        somatorio = 1;
    }
    else
    {
        Console.WriteLine($"Caso {casos}: {somatorio} numeros");
        Console.Write("0" + " ");
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < valor; j++)
            {
                if (i == a-1 && j == valor - 1)
                {
                    sb.AppendLine($"{valor}");
                    /*Console.WriteLine(valor);
                    Console.WriteLine();*/
                    break;
                }
                else
                {
                    sb.Append($"{valor} ");
                    // Console.Write(valor + " ");
                }
            }
            
            valor++;
        }
        Console.WriteLine(sb.ToString());

        casos++;
        valor = 1;
    }


}
    }

}