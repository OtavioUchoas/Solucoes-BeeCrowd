using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

    while (true)
{
    string a = Console.ReadLine();
    if (string.IsNullOrEmpty(a))
    {
        break;
    }
    int[] b = a.Split(' ').Select(int.Parse).ToArray();
    DateTime data = new DateTime(2016, b[0], b[1]);
    DateTime natal = new DateTime(2016, 12, 25);
    if (data > natal)
    {
        Console.WriteLine("Ja passou!");
        continue;
    }
    else if (data == natal)
    {
        Console.WriteLine("E natal!");
        continue;
    }
    else if (data.Month == 12 && data.Day == 24)
    {
        Console.WriteLine("E vespera de natal!");
        continue;
    }
    else
    {
        Console.WriteLine($"Faltam {(natal - data).Days} dias para o natal!");
        continue;
    }
}

    }

}