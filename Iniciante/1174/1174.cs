using System; 

class URI {

    static void Main(string[] args) { 

        
        for (int i = 0; i <= 99; i++)
{
    float imput = float.Parse(Console.ReadLine());
    if (imput <= 10)
    {
        Console.WriteLine($"A[{i}] = {imput:f1}");
    }
    else
    {
        continue;
    }
}

        
        
        
        

    }

}