import java.io.IOException;
import java.util.Arrays;
import java.util.Scanner;
 

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
        double[] a = Arrays.stream(nabana.nextLine().split(" ")).mapToDouble(Double::parseDouble).toArray();
        double[] b = Arrays.stream(nabana.nextLine().split(" ")).mapToDouble(Double::parseDouble).toArray();
        System.out.println(String.format("%.4f", conta(a[0],a[1],b[0],b[1])));
    }
    public static double conta (double x1,double y1,double x2,double y2){
    double l = Math.sqrt(Math.pow(x1-x2, 2) + Math.pow(y1-y2, 2));
    return l;
    }
}