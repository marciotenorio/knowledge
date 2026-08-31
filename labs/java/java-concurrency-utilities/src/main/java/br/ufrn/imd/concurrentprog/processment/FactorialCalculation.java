package br.ufrn.imd.concurrentprog.processment;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.concurrent.Callable;

public class FactorialCalculation implements Callable<BigDecimal> {

    private int numberOfTerm;

    private int scale;

    /**
     * @param numberOfTerm
     * @param scale
     */
    public FactorialCalculation(int numberOfTerm, int scale) {
        this.numberOfTerm = numberOfTerm;
        this.scale = scale;
    }

    /**
     *
     * @param factorial Factorial to be generated
     * @return Generated factorial
     */
    public static BigDecimal factorial(int factorial){
        if(factorial == 0 || factorial == 1)
            return BigDecimal.ONE;

        BigDecimal result = BigDecimal.ONE;

        for(int i=1; i<=factorial; i++){
            result   =  result.multiply(BigDecimal.valueOf(i));
        }
        return result;
    }

    @Override
    public BigDecimal call() {
        BigDecimal term = new BigDecimal(1);
        return term.divide(factorial(this.numberOfTerm), this.scale, RoundingMode.HALF_UP);
    }
}
