using System; 

class URI {

    static void Main(string[] args) { 

     
float a = float.Parse(Console.ReadLine());

if (a >= 0 && a <= 2000)
    Console.WriteLine("Isento");
if (a > 2000 && a <= 3000)
    Console.WriteLine($"R$ {(a - 2000) * 0.08:f2}");
if (a > 3000 && a <= 4500)
    Console.WriteLine($"R$ {1000 * 0.08 + (a - 3000) * 0.18:f2}");
if (a > 4500)
    Console.WriteLine($"R$ {1000 * 0.08 + 1500 * 0.18 + (a - 4500) * 0.28:f2}");

     
     
     
     
     
     
     
     

    }

}