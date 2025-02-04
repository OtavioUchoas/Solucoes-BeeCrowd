using System; 

class URI {

    static void Main(string[] args) { 

string a = Console.ReadLine();
int b = int.Parse(a);
int cem = b / 100;
int resto1 = b % 100;
int cinquenta = resto1 / 50;
int resto2 = resto1 % 50;
int vinte = resto2 / 20;
int resto3 = resto2 % 20;
int dez = resto3 / 10;
int resto4 = resto3 % 10;
int cinco = resto4 / 5;
int resto5 = resto4 % 5;
int dois = resto5 / 2;
int resto6 = resto5 % 2;
int um = resto6 / 1;
Console.WriteLine(b);
Console.WriteLine(cem + " nota(s) de R$ 100,00");
Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
Console.WriteLine(vinte + " nota(s) de R$ 20,00");
Console.WriteLine(dez + " nota(s) de R$ 10,00");
Console.WriteLine(cinco + " nota(s) de R$ 5,00");
Console.WriteLine(dois + " nota(s) de R$ 2,00");
Console.WriteLine(um + " nota(s) de R$ 1,00");

    }

}