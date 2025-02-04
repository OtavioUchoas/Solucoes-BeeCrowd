import java.io.IOException;
import java.util.Scanner;
import java.util.Arrays;

 
public class Main {
 
    public static void main(String[] args) throws IOException {
 
        
        Scanner nabana = new Scanner(System.in);


        double[] n1 = Arrays.stream(nabana.nextLine().split(" "))
                .mapToDouble(Double::parseDouble)
                .toArray();
        double[] n2 = Arrays.stream(nabana.nextLine().split(" "))
                .mapToDouble(Double::parseDouble)
                .toArray();
        System.out.println("VALOR A PAGAR: R$ " + String.format("%.2f", (n1[1]*n1[2])+(n2[1]*n2[2])));
    }