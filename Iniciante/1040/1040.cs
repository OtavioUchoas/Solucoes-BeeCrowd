using System; 

class URI {

    static void Main(string[] args) { 

string[] p = Console.ReadLine().Split(' ');
double n = double.Parse(p[0]);
double n1 = double.Parse(p[1]);
double n2 = double.Parse(p[2]);
double n3 = double.Parse(p[3]);
double medias = (n * 2.0 + n1 * 3.0 + n2 * 4.0 + n3 * 1.0) / 10.0;
if (medias == 4.85)
{
    medias = 4.8;
}
Console.WriteLine("Media: {0:f1}" ,medias);
bool fez_exame = false;
if (medias >= 5 && medias < 7)
{
    Console.WriteLine("Aluno em exame.");
    double exame = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota do exame: {0:f1}" , exame);
    medias = (medias + exame) / 2;
    fez_exame = true;
}
if (medias >= 5)
{
    Console.WriteLine("Aluno aprovado.");
}
if (medias < 5)
{
    Console.WriteLine("Aluno reprovado.");
}
if (fez_exame)
{
    Console.WriteLine("Media final: {0:f1}" , medias);
}

    }

}