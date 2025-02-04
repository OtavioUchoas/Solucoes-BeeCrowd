using System; 

class URI {

    static void Main(string[] args) { 

      char[] numero = Console.ReadLine().ToCharArray();
Array.Reverse(numero);
Console.WriteLine(new string (numero));

    }

}