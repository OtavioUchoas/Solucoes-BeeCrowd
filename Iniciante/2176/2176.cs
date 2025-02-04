using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

 
 string valor = Console.ReadLine();
int c = valor.Count(e => e == '1');
if (c%2 == 0)
{
    Console.WriteLine(valor + "0");
}
else
{
    Console.WriteLine(valor + "1");
}

 
 
    }

}