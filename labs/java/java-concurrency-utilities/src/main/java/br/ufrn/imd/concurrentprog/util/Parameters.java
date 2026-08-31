package br.ufrn.imd.concurrentprog.util;

public class Parameters {

    private String threadPoolType;

    private int numberTerms;

    private int poolSize;

    public String getThreadPoolType() {
        return threadPoolType;
    }

    public void setThreadPoolType(String threadPoolType) {
        this.threadPoolType = threadPoolType;
    }

    public int getNumberOfTerms() {
        return numberTerms;
    }

    public void setNumberOfTerms(int numberOfTerms) {
        this.numberTerms = numberOfTerms;
    }

    public int getPoolSize() {
        return poolSize;
    }

    public void setPoolSize(int poolSize) {
        this.poolSize = poolSize;
    }
}
