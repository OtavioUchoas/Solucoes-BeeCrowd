import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
       int a1 = nabana.nextInt();
       int a2 = nabana.nextInt();
       int a3 = nabana.nextInt();
        int a4 = nabana.nextInt();


        System.out.println("DIFERENCA = " + ((a1*a2)-(a3*a4)));
 
    }
 
}