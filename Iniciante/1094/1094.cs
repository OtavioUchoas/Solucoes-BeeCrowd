using System; 

class URI {

    static void Main(string[] args) { 

     int qntcobaias = 0;
int coelhos = 0;
int ratos = 0;
int sapos = 0;
int loops = int.Parse(Console.ReadLine());

for (int i = 0; i < loops; i++)
{
    string[] valores = Console.ReadLine().Split();
    int numero = int.Parse(valores[0]);
    string animal = valores[1];
    qntcobaias += numero;
    if (animal == "C")
    {
        coelhos += numero;

    }
    if (animal == "R")
    {
        ratos += numero;

    }
    if (animal == "S")
    {
        sapos += numero;

    }

}
Console.WriteLine($"Total: {qntcobaias} cobaias");
Console.WriteLine($"Total de coelhos: {coelhos}");
Console.WriteLine($"Total de ratos: {ratos}");
Console.WriteLine($"Total de sapos: {sapos}");
Console.WriteLine($"Percentual de coelhos: {(float)coelhos / qntcobaias * 100:f2} %");
Console.WriteLine($"Percentual de ratos: {(float)ratos / qntcobaias * 100:f2} %");
Console.WriteLine($"Percentual de sapos: {(float)sapos / qntcobaias * 100:f2} %");

    }

}