import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
         Scanner nabana = new Scanner(System.in);
        int c = nabana.nextInt();
        System.out.println(conta(c) + " minutos");
    }
    public static int conta (int x1){
    int l = x1*2;
    return l;
    }

    }
 