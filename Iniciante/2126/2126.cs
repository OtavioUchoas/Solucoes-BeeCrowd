using System; 

class URI {

    static void Main(string[] args) { 

   int caso = 1;
while (true)
{ 
    string numero = Console.ReadLine();
    if (string.IsNullOrEmpty(numero))
    {
        break;
    }
    int tamanho1 = numero.Length;
    string numero2 = Console.ReadLine();
    int index = numero2.LastIndexOf(numero);
    int tamanho2 = numero2.Length;
    if (index == -1)
    {
        Console.WriteLine($"Caso #{caso}:");
        Console.WriteLine("Nao existe subsequencia");
        caso++;
        Console.WriteLine();
    }
    else
    {
        int subseq = numero2.Split(new[] {numero}, StringSplitOptions.None).Length-1;
        Console.WriteLine($"Caso #{caso}:");
        Console.WriteLine($"Qtd.Subsequencias: {subseq}");
        Console.WriteLine($"Pos: {index+1}");
        Console.WriteLine();
        caso++;


    }
}

    }

}