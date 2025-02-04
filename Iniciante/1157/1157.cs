using System; 

class URI {

    static void Main(string[] args) { 

       int input = int.Parse(Console.ReadLine());
for (int i = 1; i <= input; i++)
{
    if(input%i == 0)
    {
        Console.WriteLine(i);
    }
}

    }

}