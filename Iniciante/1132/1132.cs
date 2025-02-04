using System; 

class URI {

    static void Main(string[] args) { 

       int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine());
int soma = 0;
if (b < a)
{
    int final = b;
    b = a;
    a = final;
}
for (int i = a; i <= b; i++)
{
    if (i % 13 > 0)
    {
        soma+=i;
    }
}
Console.WriteLine(soma);
       
       
       
       
       
       
    }

}