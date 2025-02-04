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
    int[] alturas = b.Split(' ').Take(3).Select(int.Parse).ToArray();
    for (int i = 0; i < alturas[0]; i++)
    {
        int n = int.Parse(Console.ReadLine());
        if (n>= alturas[1] && n <= alturas[2])
        {
            c++;
        }
    }
    Console.WriteLine(c);
    
}
       
       
       

    }

}