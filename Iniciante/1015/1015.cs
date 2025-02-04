using System; 

class URI {

    static void Main(string[] args) { 

string[] X = Console.ReadLine().Split(' ');
string[] Y = Console.ReadLine().Split(' ');
double A = double.Parse(X[0]);
double B = double.Parse(X[1]);
double C = double.Parse(Y[0]);
double E = double.Parse(Y[1]);

Console.WriteLine("{0:f4}", Math.Sqrt((C - A) * (C - A) + (E - B) * (E - B)));




    }

}