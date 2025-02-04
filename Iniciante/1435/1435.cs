using System; 

class URI {

    static void Main(string[] args) { 

       
       while (true)
{
    int tamanho = int.Parse(Console.ReadLine());
    
    if (tamanho == 0)
    {
        break;
    }
    int[,] matriz = new int [tamanho, tamanho];
    for (int i = 0; i < tamanho; i++)
    {
        int contador = 0;
        for (int j = 0; j < tamanho; j++)
        {
            if (i >= j)
                contador ++;
            if (i + j >= tamanho)
                contador--;
            matriz[i,j] = contador;
        } 
    }
    for (int i = 0; i < tamanho; i++) 
    {
        for (int j = 0; j < tamanho; j++) 
        { 
            if (j == 0)
            {
                Console.Write($"{matriz[i, j]}".PadLeft(3));
            }
            else
            {
                Console.Write($"{matriz[i, j]}".PadLeft(4));
            }
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
       
       
       
       
       

    }

}