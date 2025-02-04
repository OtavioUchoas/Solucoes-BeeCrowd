using System; 

class URI {

    static void Main(string[] args) { 

       int qntd = 1;
int X = int.Parse(Console.ReadLine());
int Z = int.Parse(Console.ReadLine());
int soma = X;
while (Z <= X)
{
    Z = int.Parse(Console.ReadLine());
}
while (soma <= Z)
{
    X += 1;
    soma += X;
    qntd += 1;

}
Console.WriteLine(qntd);

    }

}