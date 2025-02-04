using System; 

class URI {

    static void Main(string[] args) { 

        
        int ini = int.Parse(Console.ReadLine());
int fim = int.Parse(Console.ReadLine());
int final = 0;



if (fim < ini)
{
    int fimtemp = fim;
    fim = ini;
    ini = fimtemp;
}
for (int i = ini+1; i < fim; i++) 
{

    if (i % 2 != 0)
    {
        final += i;

    }
    
}
Console.WriteLine(final);

        
        
        
        
        
        
        
        
        

    }

}