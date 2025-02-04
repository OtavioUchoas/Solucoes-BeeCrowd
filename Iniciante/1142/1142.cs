using System; 

class URI {

    static void Main(string[] args) { 

      int c = int.Parse(Console.ReadLine());
int n = c * 4;

for (int i = 1; i <= n; i++)
{
    if (i % 4 != 0)
    {
        Console.Write(i + " ");
    }
    else if (i % 4 == 0)
    {
        Console.WriteLine("PUM");
    }
}
      
      
      
      
      
      
      
      
      
      
      
    }

}