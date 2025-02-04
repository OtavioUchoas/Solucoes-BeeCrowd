import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
       double a1 = nabana.nextDouble();
       double a2 = nabana.nextDouble();
       a1 *= 3.5;
       a2 *= 7.5;
       System.out.println("MEDIA = " + String.format("%.5f", (a1+a2)/11));
    }
 
}