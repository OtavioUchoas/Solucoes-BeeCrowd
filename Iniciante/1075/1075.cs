using System; 

class URI {

    static void Main(string[] args) { 

      
      
      int quantidade = int.Parse(Console.ReadLine());


for (int i = 1; i < 10000; i++)
{
   if (i % quantidade == 2)
    {
        Console.WriteLine(i);
    }
}

      
      
      
      

    }

}