import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
        double r = nabana.nextDouble();
        System.out.println("VOLUME = " + String.format("%.3f", (3.14159*r*r*r) * 4 / 3));
        
        
        
        
        
        
    }
 
}