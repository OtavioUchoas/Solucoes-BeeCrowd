using System; 

class URI {

    static void Main(string[] args) { 

        decimal contagem = decimal.Parse(Console.ReadLine());
for (decimal i = 0, j = contagem; i < 100; i++, j /= 2)
{
    Console.WriteLine($"N[{i}] = {Math.Round(j, 4,MidpointRounding.ToEven)}");
}    
    }

}