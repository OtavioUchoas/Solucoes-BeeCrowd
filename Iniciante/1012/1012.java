import java.util.Scanner;
import java.util.Arrays;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
        double[] d = Arrays.stream(nabana.nextLine().split(" ")).mapToDouble(Double::parseDouble).toArray();
        System.out.println("TRIANGULO: " + String.format("%.3f", (d[0]*d[2])/2));
        System.out.println("CIRCULO: " + String.format("%.3f", (3.14159*d[2]*d[2])));
        System.out.println("TRAPEZIO: " + String.format("%.3f", ((d[0]+d[1])*d[2])/2));
        System.out.println("QUADRADO: " + String.format("%.3f", (d[1]*d[1])));
        System.out.println("RETANGULO: " + String.format("%.3f", (d[0]*d[1])));
 
    }
 
}