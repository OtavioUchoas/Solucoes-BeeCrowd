using System; 

class URI {

    static void Main(string[] args) { 

        int saida = 0;
int volta = 0;
int jeeps = 0;

while (true)
{
    string c = Console.ReadLine();
    if (c == "ABEND")
    {
        Console.WriteLine(saida - volta);
        Console.WriteLine(jeeps);
        break;
    }
    string[] b = c.Split(' ');
    int n = int.Parse(b[1]);
    if (b[0] == "SALIDA")
    {
        saida += n;
        jeeps++;
    }
    else if (b[0] == "VUELTA")
    {
        volta += n;
        jeeps--;
    }

}

    }

}