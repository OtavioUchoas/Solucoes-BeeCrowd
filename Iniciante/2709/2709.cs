using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       while (true)
{
    int quebrou = 0;
    long soma = 0;
    string c = Console.ReadLine();
    if (string.IsNullOrEmpty(c))
    {
        break;
    }
    long real = int.Parse(c);
    long[] numeros = new long[real];
    for (int i = 0; i < real; i++)
    {
        numeros[i] = int.Parse(Console.ReadLine());
    }
    long saltos = int.Parse(Console.ReadLine());
    for (long i = real-1; i > -1; i -= saltos)
    {
        soma += numeros[i];

    }
    if (soma == 2 || soma == 3 || soma == 5 || soma == 7 || soma == 11 || soma == 13 || soma == 17)
    {
        Console.WriteLine("You’re a coastal aircraft, Robbie, a large silver aircraft.");
        continue;
    }
    if (soma == 1)
    {
        Console.WriteLine("Bad boy! I’ll hit you.");
        continue;
    }
    for (long i = 2; i < soma; i++) 
    {
        if (soma % i == 0)
        {
            Console.WriteLine("Bad boy! I’ll hit you.");
            quebrou++;
            break;

        }
    }
    if (quebrou == 1)
    {
        continue;
    }
    else
    {
        Console.WriteLine("You’re a coastal aircraft, Robbie, a large silver aircraft.");
    }
}

       
       
       
       

    }

}