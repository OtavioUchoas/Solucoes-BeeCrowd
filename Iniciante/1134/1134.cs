using System; 

class URI {

    static void Main(string[] args) { 


int alcool = 0;
int gasolina = 0;
int diesel = 0;

while (true)
{
    int numero = int.Parse(Console.ReadLine());
    if (numero == 1)
    {
        alcool++;
        continue;
    }
    else if (numero == 2)
    {
        gasolina++;
        continue;
    }
    else if (numero == 3)
    {
        diesel++;
        continue;

    }
    else if (numero == 4)
    {
        break;
    }
}
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {alcool}");
Console.WriteLine($"Gasolina: {gasolina}");
Console.WriteLine($"Diesel: {diesel}");




    

    }

}