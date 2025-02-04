using System; 

class URI {

    static void Main(string[] args) { 

        while (true)
{
    int c = 0;
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    
    long rev = long.Parse(b);
    if (rev == 1)
    {
        Console.WriteLine("0");
        continue;
    }
    while (true)
    {
        if (rev % 2 == 0)
        {
            rev /= 2;
            c++;
        }
        else
        {
            break;
        }
    }
        Console.WriteLine($"{c}");
    
}

    }

}