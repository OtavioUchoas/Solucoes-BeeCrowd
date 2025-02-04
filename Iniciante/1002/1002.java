import java.io.IOException;
import java.util.Scanner; 

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
       double raio = nabana.nextDouble();
       double area = raio*raio*3.14159;
       System.out.println("A=" +String.format("%.4f", area));
    }
 
}