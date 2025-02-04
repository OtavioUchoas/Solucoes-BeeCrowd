using System; 
using System.Linq;
using System.Text.RegularExpressions;
class URI {

    static void Main(string[] args) { 

        string pattern = @"^[A-Z]{3}-\d{4}$";
string c = Console.ReadLine();
int n = int.Parse(c);
for (int i = 0; i < n; i++)
{
    string b = Console.ReadLine();
    if (Regex.IsMatch(b, pattern))
    {
        char o = b[7];
        if (o == '1' || o == '2')
        {
            Console.WriteLine("MONDAY");
        }
        else if (o == '3' || o == '4')
        {
            Console.WriteLine("TUESDAY");
        }
        else if (o == '5' || o == '6')
        {
            Console.WriteLine("WEDNESDAY");
        }
        else if (o == '7' || o == '8')
        {
            Console.WriteLine("THURSDAY");
        }
        else if (o == '9' || o == '0')
        {
            Console.WriteLine("FRIDAY");
        }
        else
        {
            Console.WriteLine("FAILURE");
        }
    }
    else
    {
        Console.WriteLine("FAILURE");
    }
}

        

    }

}