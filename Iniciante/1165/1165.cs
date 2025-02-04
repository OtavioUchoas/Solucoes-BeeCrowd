using System; 

class URI {

    static void Main(string[] args) { 

        
        int soma = 0;
int repetiçoes = int.Parse(Console.ReadLine());
for (int i = 0; i<repetiçoes; i++)
{
    int imput = int.Parse(Console.ReadLine());
    for (int j = 1; j <= imput; j++)
    {
        if (imput % j == 0)
        {
            soma += j;
        }
    }
    if (imput+1 == soma)
    {
        Console.WriteLine($"{imput} eh primo");
        soma = 0;
    }
    else
    {
        Console.WriteLine($"{imput} nao eh primo");
        soma = 0;
    }
}
        
        
        
        
        
        
        
        

    }

}