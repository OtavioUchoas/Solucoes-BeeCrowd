using System; 

class URI {

    static void Main(string[] args) { 

        
        
        int quantidade = int.Parse(Console.ReadLine());
int dnt = 0;
int fora = 0;
for (int i = 0 ; i <= quantidade ; i++) 
{
    if (i % 2 == 0 && i != 0)
    {
        Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
    }

}

        
        
        
        
        
        

    }

}