using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        
        while (true)
{
    int c = 0;  
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    int[] casos = b.Split(' ').Select(int.Parse).ToArray();
    for (int i = 0; i < casos[0]; i++)
    {
        int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        if ((temp[0] == casos[1]) && (temp[1] == 0))
        {
            c++;
        }
    }
    Console.WriteLine(c);
}
        
        
        
        

    }

}