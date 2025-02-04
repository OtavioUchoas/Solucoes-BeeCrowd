using System; 

class URI {

    static void Main(string[] args) { 

   string A = Console.ReadLine();
  double B = double.Parse(Console.ReadLine());
  double C = double.Parse(Console.ReadLine());
  Console.WriteLine("TOTAL = R$ {0:f2}", (B + C * 0.15));


    }

}