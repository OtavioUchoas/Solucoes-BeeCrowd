using System;
using System.Linq;
class URI {

    static void Main(string[] args) { 

        
int a = int.Parse(Console.ReadLine().Replace("Dia ", ""));
int[] b = Console.ReadLine().Split(new[] { " : " }, StringSplitOptions.None).Select(int.Parse).ToArray();
int c = int.Parse(Console.ReadLine().Replace("Dia ", ""));
int[] d = Console.ReadLine().Split(new[] { " : " }, StringSplitOptions.None).Select(int.Parse).ToArray();
int n0 = b[0] * 3600;
int n1 = b[1] * 60;
int d0 = d[0] * 3600;
int d1 = d[1] * 60;
int segundos_inicio = a * 86400 + n0 + n1 + b[2];
int segundos_fim = c * 86400 + d0 + d1 + d[2];
int difdias = segundos_fim - segundos_inicio;
int dia = difdias / 86400;
int restodias = difdias % 86400;
int horas = restodias / 3600;
int restohoras = restodias % 3600;
int minutos = restohoras / 60;
int segundos = restohoras % 60;
Console.WriteLine(dia + " dia(s)");
Console.WriteLine(horas + " hora(s)");
Console.WriteLine(minutos + " minuto(s)");
Console.WriteLine(segundos + " segundo(s)");
        
        
        
        
    }

}