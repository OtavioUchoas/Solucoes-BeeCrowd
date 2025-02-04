using System; 

class URI {

    static void Main(string[] args) { 

      float soma = 1;
for (int i = 2, j = 3; j<=39; i*=2 , j+=2)
{
    soma += ((float)j / i);
}
Console.WriteLine($"{soma:f2}");
    }

}