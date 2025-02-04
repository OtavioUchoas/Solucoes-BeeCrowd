using System; 

class URI {

    static void Main(string[] args) { 

        
        int soma = 0;
while (true)
{
    int x = int.Parse(Console.ReadLine());
    if (x == 0)
    {
        break;
    }
    else
    {
        for (int i = x; i <= x+9; i++) 
        {
            if (i%2 == 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
        soma = 0;
    }
}
        
        
        
        
        
        
        
        

    }

}