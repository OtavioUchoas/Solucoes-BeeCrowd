using System; 

class URI {

    static void Main(string[] args) { 

  int funcionario = int.Parse(Console.ReadLine());
      int horas = int.Parse(Console.ReadLine());
  float h_trabalho = float.Parse(Console.ReadLine());
  Console.WriteLine("NUMBER = " + funcionario);
 Console.WriteLine("SALARY = U$ {0:f2}" ,  (horas*h_trabalho ));




    }

}