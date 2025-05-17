import java.math.BigInteger;
import java.util.Scanner;

public class abc406a {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        long n, k;
        n = scan.nextLong();
        k = scan.nextLong();

        BigInteger calc = BigInteger.ONE;
        long in;

        for (int i = 0; i < n; i++) {
            in = scan.nextLong();
            calc = calc.multiply(BigInteger.valueOf(in));

            if(calc.toString().length() > k) {
                calc = BigInteger.ONE;
            }
        }

        System.out.println(calc.toString());
    }
}