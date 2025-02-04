import java.io.IOException;
import java.util.Arrays;
import java.util.Scanner;
 
 
 
 
public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner nabana = new Scanner(System.in);
        double[] a = Arrays.stream(nabana.nextLine().split(" ")).mapToDouble(Double::parseDouble).toArray();
        float media = (float)(a[0]*2 + a[1]*3 + a[2]*4 + a[3])/10;
        System.out.println("Media: " + String.format("%.1f", media));

        if (media < 5) {
            System.out.println("Aluno reprovado.");
        }
        else if (media >= 5 && media < 7) {
            System.out.println("Aluno em exame.");
            String linha = nabana.nextLine();
            double c = Double.parseDouble(linha);
            System.out.println("Nota do exame: " + String.format("%.1f", c));
            double mediaFinal = (media + c) / 2;
            if (mediaFinal >= 5) {
                System.out.println("Aluno aprovado.");
            } else {
                System.out.println("Aluno reprovado.");
            }
            System.out.println("Media final: " + String.format("%.1f", mediaFinal));
        } else {
            System.out.println("Aluno aprovado.");
        }
        
        
        
        
        
 
    }
 
}