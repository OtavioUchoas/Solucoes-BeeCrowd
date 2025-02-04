using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       
       int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int inicio = a[0] * 60 + a[1];
int fim = a[2]*60 + a[3];



if (fim <= inicio)
{
    fim += 1440;
}

int minutos_t = (fim)-(inicio);
int horas = (minutos_t / 60);
int minutos = (minutos_t % 60);

Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
       
       
       
       
       
       

    }

}