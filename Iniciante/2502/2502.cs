using System; 
using System.Linq;
using System.Text;
class URI {

    static void Main(string[] args) { 

        while (true)
{
    string n = Console.ReadLine();
    if (string.IsNullOrEmpty(n))
    {
        break;
    }
    int[] entrada = n.Split(' ').Select(int.Parse).ToArray();
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    char[] a1 = a.ToCharArray(0, entrada[0]);
    char[] b2 = b.ToCharArray(0, entrada[0]);
    for (int i = 0; i < entrada[1]; i++)
    {
        string nome = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        foreach (char c in nome) 
        {
            int index = Array.IndexOf(a1, char.ToUpper(c));
            if (index >= 0)
            {
                sb.Append(!char.IsLetter(c) || char.IsLower(c) ? char.ToLower(b2[index]) : b2[index]);
                continue;
            }

            index = Array.IndexOf(b2, char.ToUpper(c));
            if (index >= 0)
            {
                sb.Append(!char.IsLetter(c) || char.IsLower(c) ? char.ToLower(a1[index]) : a1[index]);
                continue;
            }
            sb.Append(c);
        }
       
        Console.WriteLine(sb.ToString());
        
    }
    Console.WriteLine();
}
        

    }

}