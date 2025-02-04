using System; 

class URI {

    static void Main(string[] args) { 

      
      while (true)
{
    int a = int.Parse(Console.ReadLine());
    if (a == 0)
    {
        break;
    }

    for (int i = 1; i <= a; i++)
    {
        
        if (i < a)
        {
            Console.Write(i + " ");
        }
        else
            Console.WriteLine(i);

    }
    
}
      
      
      
      
      
    }

}