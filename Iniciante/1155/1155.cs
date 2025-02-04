using System; 

class URI {

    static void Main(string[] args) { 

    
    float soma = 1;
for (int i = 2; i<=100; i++)
{
    soma += (1f / i);
}
Console.WriteLine($"{soma:f2}");
    
    
    
    }

}