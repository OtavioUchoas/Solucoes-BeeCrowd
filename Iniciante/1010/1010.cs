using System; 

class URI {

    static void Main(string[] args) { 

 string[] numeros_1 = Console.ReadLine().Split(' ');
int A = int.Parse(numeros_1[0]);
int B = int.Parse(numeros_1[1]);
double C = double.Parse(numeros_1[2]);


string[] numeros_2 = Console.ReadLine().Split(' ');
int D = int.Parse(numeros_2[0]);
int E = int.Parse(numeros_2[1]);
double F = double.Parse(numeros_2[2]);

Console.WriteLine("VALOR A PAGAR: R$ {0:f2}", (B * C + E * F));

    }

}