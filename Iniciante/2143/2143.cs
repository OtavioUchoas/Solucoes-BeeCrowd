using System; 

class URI {

    static void Main(string[] args) { 

while (true)
{
    int teste = int.Parse(Console.ReadLine());
    if (teste == 0)
    {
        break;
    }
    for(int i = 0; i < teste; i++)
    {
        int temporario = int.Parse(Console.ReadLine());
        if (temporario % 2 == 0)
        {
            Console.WriteLine((temporario*2)-2);
        }
        else
        {
            Console.WriteLine((temporario*2)-1);
        }
    }
}










    }

}