using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       while (true)
{
    string c = Console.ReadLine();
    if (string.IsNullOrEmpty(c))
    {
        break;
    }
    float b = float.Parse(c);
    double horas = (b / 15);
    int horasInteiras = (int)horas;
    double minutosDecimais = (horas - horasInteiras) * 60;
    int minutos = (int)minutosDecimais;
    double segundosDecimais = (minutosDecimais - minutos) * 60;
    int segundos = (int)Math.Round(segundosDecimais);
    if (segundos == 60)
    {
        segundos = 0;
        minutos++;
    }
    if (minutos == 60)
    {
        minutos = 0;
        horas++;
    }
    if ((b == 360) || (b >= 0 && b < 90))
    {
        Console.WriteLine("Bom Dia!!");
        Console.WriteLine($"{6+horasInteiras:00}:{minutos:00}:{segundos:00}");
    }
    else if (b >= 90 && b < 180)
    {
        Console.WriteLine("Boa Tarde!!");
        Console.WriteLine($"{6 + horasInteiras:00}:{minutos:00}:{segundos:00}");

    }
    else if (b >= 180 && b < 270)
    {
        Console.WriteLine("Boa Noite!!");
        Console.WriteLine($"{6 + horasInteiras:00}:{minutos:00}:{segundos:00}");
    }
    else if (b >= 270 && b < 360)
    {
        Console.WriteLine("De Madrugada!!");
        Console.WriteLine($"{6 + horasInteiras - 24:00}:{minutos:00}:{segundos:00}");
    }

}

    }

}