using System; 

class URI {

    static void Main(string[] args) { 

int qntdmedia = 0;
int valores = 0;
for (int i = 0; i >= 0; i++)
{
    int temp = int.Parse(Console.ReadLine());
    if (temp < 0)
    {
        break;
    }
    else
    {
        valores += temp;
        qntdmedia++;
    }
    
}
Console.WriteLine($"{(float)valores/qntdmedia:f2}");

    }

}