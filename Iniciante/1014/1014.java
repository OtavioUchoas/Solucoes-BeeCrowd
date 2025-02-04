import java.io.IOException;
import java.util.Scanner; 

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
        double a = nabana.nextDouble();
        double b = nabana.nextDouble();
        System.out.println(String.format("%.3f", a/b) + " km/l");
    }
 
}