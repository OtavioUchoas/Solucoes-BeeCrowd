using System; 

class URI {

    static void Main(string[] args) { 

        float[,] matriz = new float[12, 12];
int linha = int.Parse(Console.ReadLine());
string operacao = Console.ReadLine();
float soma = 0;

for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        float temp = float.Parse(Console.ReadLine());
        matriz[i, j] = temp;
        
    }
}
if (operacao == "S")
{
    for (int i = 0;i < 12; i++)
    {
        soma += matriz[i, linha];
    }
}
if (operacao == "M")
{
    for (int i = 0; i < 12; i++)
    {
        soma += (matriz[i, linha])/12 ;
    }
}
Console.WriteLine($"{soma:f1}");

    }

}