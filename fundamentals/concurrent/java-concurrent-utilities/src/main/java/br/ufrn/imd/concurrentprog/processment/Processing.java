package br.ufrn.imd.concurrentprog.processment;

import br.ufrn.imd.concurrentprog.util.Parameters;
import br.ufrn.imd.concurrentprog.util.ThreadType;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.*;

public class Processing {

    private ExecutorService  executorService;

    private List<BigDecimal> terms;

    public Processing() {
        this.terms = new ArrayList<>();
    }

    /**
     * @param parameters
     * @return Euler number with the number of terms used as precision/scale
     */
    public BigDecimal process(Parameters parameters) {

        switch (parameters.getThreadPoolType()) {
            case ThreadType.FIXED:
                this.executorService = Executors.newFixedThreadPool(parameters.getPoolSize());

                concurrentComputation(parameters);

                System.out.println("Active threads: " + Thread.activeCount());
                this.executorService.shutdown();
                return terms.stream().reduce(BigDecimal.ZERO, BigDecimal::add);

            case ThreadType.CACHED:
                this.executorService = Executors.newCachedThreadPool();

                concurrentComputation(parameters);

                System.out.println("Active threads: " + Thread.activeCount());
                this.executorService.shutdown();
                return terms.stream().reduce(BigDecimal.ZERO, BigDecimal::add);

            case ThreadType.WORK_STEALING:
                this.executorService = Executors.newWorkStealingPool();

                concurrentComputation(parameters);

                System.out.println("Active threads: " + Thread.activeCount());
                this.executorService.shutdown();
                return terms.stream().reduce(BigDecimal.ZERO, BigDecimal::add);

            default:
                return new BigDecimal(-1);
        }
    }

    /**
     * @param parameters
     */
    private void concurrentComputation(Parameters parameters) {
        for (int i=0; i<parameters.getNumberOfTerms(); i++) {
            Callable<BigDecimal> computation = new FactorialCalculation(i, parameters.getNumberOfTerms());
            Future<BigDecimal> factorial = executorService.submit(computation);
            try {
                terms.add(factorial.get());
            } catch (InterruptedException | ExecutionException e) {
                throw new RuntimeException(e);
            }
        }
    }

}
