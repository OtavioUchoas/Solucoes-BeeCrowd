import java.io.IOException;
import java.util.Arrays;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
       
               Scanner nabana = new Scanner(System.in);
        int[] d = Arrays.stream(nabana.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int n = maior(d[0], d[1]);
        n = maior(n,d[2]);
        System.out.println(n + " eh o maior");






    }
    public static int maior (int n1, int n2){
        int l = (n1+n2 + Math.abs(n1-n2))/2;
        return l;


    }
       
    
    }