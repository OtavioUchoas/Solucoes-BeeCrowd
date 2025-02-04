using System; 

class URI {

    static void Main(string[] args) { 

     string a = Console.ReadLine(); 
int dias = int.Parse(a);
int anos = dias / 365;
int restoanos = dias % 365;
int meses = restoanos / 30;
int restomeses = restoanos % 30;
Console.WriteLine(anos + " ano(s)");
Console.WriteLine(meses + " mes(es)");
Console.WriteLine(restomeses + " dia(s)");

    }

}