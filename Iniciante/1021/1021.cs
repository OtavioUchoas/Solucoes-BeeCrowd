using System; 

class URI {

    static void Main(string[] args) { 

string a = Console.ReadLine();
double b = double.Parse(a);
int cem = (int)(b / 100);
double resto1 = b % 100;
int cinquenta = (int)(resto1 / 50);
double resto2 = resto1 % 50;
int vinte = (int)(resto2 / 20);
double resto3 = resto2 % 20;
int dez = (int)(resto3 / 10);
double resto4 = resto3 % 10;
int cinco = (int)(resto4 / 5);
double resto5 = resto4 % 5;
int dois = (int)(resto5 / 2);
double moeda = resto5 % 2;

int moedas1 = (int)(moeda / 1);
double moedaresto1 = moeda % 1.0;
int moeda50 = (int)(moedaresto1 / 0.5);
double moedaresto50 = (moedaresto1 % 0.5);
int moeda25 = (int)(moedaresto50 / 0.25);
double moedaresto25 = (moedaresto50 % 0.25);
int moeda10 = (int)(moedaresto25/ 0.1);
double moedaresto10 = (moedaresto25 % 0.1);
int moeda5 = (int)(moedaresto10 / 0.05);
double moedaresto5 = (moedaresto10 % 0.05);
int moeda01 = (int)(Math.Round(moedaresto5, 2) / 0.01);


Console.WriteLine("NOTAS:");
Console.WriteLine(cem + " nota(s) de R$ 100.00");
Console.WriteLine(cinquenta + " nota(s) de R$ 50.00");
Console.WriteLine(vinte + " nota(s) de R$ 20.00");
Console.WriteLine(dez + " nota(s) de R$ 10.00");
Console.WriteLine(cinco + " nota(s) de R$ 5.00");
Console.WriteLine(dois + " nota(s) de R$ 2.00");
Console.WriteLine("MOEDAS:");
Console.WriteLine(moedas1 + " moeda(s) de R$ 1.00");
Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");
Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");


    }

}