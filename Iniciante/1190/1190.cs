using System; 

class URI {

    static void Main(string[] args) { 

        float[,] matriz = new float[12, 12];
string operacao = Console.ReadLine();
float soma = 0;
int media = 0;
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
    for (int i = 1;i <= 5; i++)
    {
        for(int j =12-i ;j <=11 ; j++)
        {

            soma += matriz[i,j];
        }
        if (i == 5)
        {
            for (i = 10 ;i >=6 ; i--)
            {
                for (int j =i+1 ;j <=11 ; j++)
                {
                    soma += matriz[i, j];
                }
            }
        }
    }
    
    Console.WriteLine($"{soma:f1}");
}
if (operacao == "M")
{
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 12-i; j <= 11; j++)
        {
            soma += matriz[i, j];
            media++;
        }
        if (i == 5)
        {
            for (i = 10; i >= 6; i--)
            {
                for (int j = i+1; j <= 11; j++)
                {
                    soma += matriz[i, j];
                    media++;
                }
            }
        }
    }
    Console.WriteLine($"{soma / media:f1}");
}
        
        
        
        
        
        
    }

}