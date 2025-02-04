using System; 

class URI {

    static void Main(string[] args) { 
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine());
if (b < a)
{
    int final = b;
    b = a;
    a = final;
}
for (int i = a+1; i < b; i++)
{
    if (i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}


    }

}