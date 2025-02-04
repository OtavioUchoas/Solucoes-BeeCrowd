using System; 

class URI {

    static void Main(string[] args) { 

while (true)
{
   string entrada = Console.ReadLine();
   if (string.IsNullOrEmpty(entrada))
   {
        break;
   }
   int valor = int.Parse(entrada);
    Console.WriteLine(valor-1);
}






    }

}