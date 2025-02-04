using System; 
using System.Linq;
using System.Collections.Generic;
class URI {

    static void Main(string[] args) { 

     List<string> list = new List<string>();
while (true)
{
    string c = Console.ReadLine();
    if (string.IsNullOrEmpty(c))
    {
        break;
    }
   list.Add(c);
}
int qtd = list.Distinct().Count();
Console.WriteLine(qtd);

    }

}