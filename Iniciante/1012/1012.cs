using System; 

class URI {

    static void Main(string[] args) { 

      string[] numeros = Console.ReadLine().Split(' ');
double A = double.Parse(numeros[0]);
double B = double.Parse(numeros[1]);
double C = double.Parse(numeros[2]);
Console.WriteLine("TRIANGULO: {0:f3}", (A*C/2d));
Console.WriteLine("CIRCULO: {0:f3}", (3.14159 * C * C));
Console.WriteLine("TRAPEZIO: {0:f3}", ((A+B)*C/2d));
Console.WriteLine("QUADRADO: {0:f3}", (B * B));
Console.WriteLine("RETANGULO: {0:f3}", (A * B));
    }

}