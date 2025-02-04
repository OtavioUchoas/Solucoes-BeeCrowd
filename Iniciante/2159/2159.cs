using System; 

class URI {

    static void Main(string[] args) { 

double entrada = int.Parse(Console.ReadLine());
double minimo = entrada / Math.Log(entrada);
double maximo = 1.25506 * minimo;
Console.Write($"{minimo:f1} ");
Console.WriteLine($"{maximo:f1}");



    }

}