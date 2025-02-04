using System; 

class URI {

    static void Main(string[] args) { 

        int[] impar = new int[5];
int[] par = new int[5];
int contadorpar = 0;
int contadorimpar = 0;
for (int i = 0; i<15; i++)
{
    int valor = int.Parse(Console.ReadLine());
    if (valor % 2 == 0)
    {
        par[contadorpar++] = valor;
        if (contadorpar > 4)
        {
            contadorpar = 0;
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"par[{j}] = {par[j]}");
            } 
        }
    }
    else
    {
        impar[contadorimpar++] = valor;
        if (contadorimpar > 4)
        {
            contadorimpar = 0;
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"impar[{j}] = {impar[j]}");
            }
        }
    }
}
for (int i = 0; i < contadorimpar; i++)
{
    Console.WriteLine($"impar[{i}] = {impar[i]}");
}
for (int i = 0; i < contadorpar; i++)
{
    Console.WriteLine($"par[{i}] = {par[i]}");
}
        
        
        
        
        
        
        
        
        
        
        
        
        
        

    }

}