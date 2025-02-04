using System; 

class URI {

    static void Main(string[] args) { 

       
float a = float.Parse(Console.ReadLine());

if (a >= 0 && a <= 400)
{
    Console.WriteLine("Novo salario: {0:f2}", ((a * 1.15)));
    Console.WriteLine("Reajuste ganho: {0:f2}", (a*0.15));
    Console.WriteLine("Em percentual: 15 %");
}
if (a > 400 && a <= 800)
{
    Console.WriteLine("Novo salario: {0:f2}", (a * 1.12));
    Console.WriteLine("Reajuste ganho: {0:f2}", (a*0.12));
    Console.WriteLine("Em percentual: 12 %");
}
if (a > 800 && a <= 1200)
{
    Console.WriteLine("Novo salario: {0:f2}", ((a * 1.1)));
    Console.WriteLine("Reajuste ganho: {0:f2}", (a*0.1));
    Console.WriteLine("Em percentual: 10 %");
}
if (a > 1200 && a <= 2000)
{
    Console.WriteLine("Novo salario: {0:f2}" , ((a * 1.07)));
    Console.WriteLine("Reajuste ganho: {0:f2}", (a*0.07));
    Console.WriteLine("Em percentual: 7 %");
}
if (a > 2000)
{
    Console.WriteLine("Novo salario: {0:f2}" , ((a * 1.04)));
    Console.WriteLine("Reajuste ganho: {0:f2}", (a*0.04));
    Console.WriteLine("Em percentual: 4 %");
}  
       
       
       

    }

}