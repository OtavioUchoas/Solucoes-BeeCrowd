using System; 

class URI {

    static void Main(string[] args) { 

        int input = int.Parse(Console.ReadLine());
int primeiro = 1;
int segundo = 0;
for (int i = 0; i < input; i++)
{
    if (i == input - 1)
    {
        Console.WriteLine(segundo);
    }
    else
    {

    
    Console.Write(segundo + " ");
    int temp = segundo;
    segundo += primeiro;
    primeiro = temp;
}
}

    }

}