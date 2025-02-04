using System; 

class URI {

    static void Main(string[] args) { 

        double[,] matriz = new double[12, 12];
string operacao = Console.ReadLine();
double soma = 0;
int media = 0;
for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        double temp = double.Parse(Console.ReadLine());
        matriz[i, j] = temp;
        
    }
}
if (operacao == "S")
{
    for (int i = 0;i <= 4; i++)
    {
        for(int j =i+1 ;j <=10-i ; j++)
        {

            soma += matriz[i,j];
        }
    }
    Console.WriteLine($"{soma:f1}");
}
if (operacao == "M")
{
    for (int i = 0; i <= 4; i++)
    {
        for (int j = i+1; j <= 10-i; j++)
        {
            soma += matriz[i, j];
            media++;
        }
    }
    Console.WriteLine($"{soma / media:f1}");
}

    }

}