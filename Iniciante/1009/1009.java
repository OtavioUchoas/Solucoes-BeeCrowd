import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
       String nomes = nabana.next();
       double a1 = nabana.nextDouble();
       double a2 = nabana.nextDouble();

        System.out.println("TOTAL = R$ " + String.format("%.2f", a1 + (a2*0.15)));
 
    }
 
}