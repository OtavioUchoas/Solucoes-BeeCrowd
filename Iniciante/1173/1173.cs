using System; 

class URI {

    static void Main(string[] args) { 

       int imput = int.Parse(Console.ReadLine());
for (int i = 0; i <= 9; i++)
{
    Console.WriteLine($"N[{i}] = {imput}");
    imput = imput * 2;
}
    }

}