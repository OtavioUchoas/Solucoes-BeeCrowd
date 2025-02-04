using System; 

class URI {

    static void Main(string[] args) { 

       string a = Console.ReadLine();
int b = int.Parse(a);
int horas = b / 3600;
int restohoras = b % 3600;
int minutos = restohoras / 60;
int restominutos = restohoras % 60;
Console.WriteLine(horas + ":" +  minutos + ":" + restominutos);

    }

}