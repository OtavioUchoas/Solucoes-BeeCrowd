using System; 

class URI {

    static void Main(string[] args) { 

        int c = int.Parse(Console.ReadLine());

for (int i = 1; i <= c; i++)
{
    Console.Write(i + " " + Math.Pow(i , 2) + " " + Math.Pow(i , 3));
    Console.WriteLine();
    Console.WriteLine(i + " " + (Math.Pow(i, 2) + 1) + " " + (Math.Pow(i, 3)+1));
}

        
        
        
        
        
        
        

    }

}