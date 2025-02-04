using System; 

class URI {

    static void Main(string[] args) { 

double natural = double.Parse(Console.ReadLine());
double primeiro = (Math.Pow((1 + Math.Sqrt(5)) / 2, natural));
double segundo = (Math.Pow((1 - Math.Sqrt(5)) / 2, natural));
double terceiro = primeiro - segundo;
Console.WriteLine($"{Math.Round(terceiro/Math.Sqrt(5), 1):f1}");

    }

}