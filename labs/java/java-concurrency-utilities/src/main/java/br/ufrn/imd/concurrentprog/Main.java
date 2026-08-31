package br.ufrn.imd.concurrentprog;


import br.ufrn.imd.concurrentprog.processment.Processing;
import br.ufrn.imd.concurrentprog.util.ArgumentsUtil;
import br.ufrn.imd.concurrentprog.util.Parameters;

import java.math.BigDecimal;

public class Main {
    public static void main(String[] args) {
        /**
         * Arguments:
         * To fixed pool: -f poolSize numberOfTerms
         * To cached: -c numberOfTerms
         * To work stealing: -ws numberOfTerms
         */
        Parameters parameters = ArgumentsUtil.processArguments(args);
        Processing processment = new Processing();

        BigDecimal result = processment.process(parameters);

        System.out.println("Result with " + parameters.getNumberOfTerms() + " terms: " + result);
    }
}