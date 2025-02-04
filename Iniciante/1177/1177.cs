using System; 

class URI {

    static void Main(string[] args) { 

      int contagem = int.Parse(Console.ReadLine());
for (int i = 0, j=0; i < 1000; i++, j++)
{
    if (j == contagem)
    {
        j = 0;
        Console.WriteLine($"N[{i}] = {j}");
    }
    else
    {
        Console.WriteLine($"N[{i}] = {j}");
    }
}
      
      
      
      
      
      
      
      
      
      

    }

}