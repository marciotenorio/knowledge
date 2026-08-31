import java.math.BigInteger;
import java.math.MathContext;
import java.math.RoundingMode;
import java.util.Scanner;

public class Main {

    public static int count = 0;
    
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        var a = scan.nextBigDecimal();
        var b = scan.nextBigDecimal();
       
        var r = a.divide(b, RoundingMode.CEILING);
        System.out.println(r.round(new MathContext(0, RoundingMode.CEILING)));
    }
}