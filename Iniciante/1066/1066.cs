using System; 

class URI {

    static void Main(string[] args) { 

     
     int n = 0;
int impar = 0;
int positivo = 0;
int negativo = 0;

for (int i = 0; i < 5; i++)
{
    float p = float.Parse(Console.ReadLine());
    if (p % 2 == 0)
    {
        n++;

    }
    else
    {
        impar++;
    }
    if (p > 0)
    {
        positivo++;
    }
    if (p < 0)
    {
        negativo++;
    }


}
Console.WriteLine(n + " valor(es) par(es)");
Console.WriteLine(impar + " valor(es) impar(es)");
Console.WriteLine(positivo + " valor(es) positivo(s)");
Console.WriteLine(negativo + " valor(es) negativo(s)");

     
     
     
     
     
     
     
    }

}