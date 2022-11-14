package br.ufrn.imd.concurrentprog.util;

import java.util.StringTokenizer;

public class ArgumentsUtil {

    /**
     * @param args args to the main method
     * @return parameters: ThreadType, Pool size (if are fixed) and number of terms
     */
    public static Parameters processArguments(String[] args){
        if(args.length == 0)
            throw new RuntimeException("No arguments were found!");

        if(args.length > 3 || args.length < 2)
            throw new RuntimeException("Wrong arguments number!");

        StringTokenizer stringTokenizer = new StringTokenizer(args[0], "-");

        Parameters parameters = new Parameters();
        parameters.setThreadPoolType(stringTokenizer.nextToken());

        if(parameters.getThreadPoolType().equals("f") && args.length < 3)
            throw new RuntimeException("Wrong number of parameters for fixed version.");

        if(parameters.getThreadPoolType().equals(ThreadType.FIXED)){
            parameters.setPoolSize(Integer.parseInt(args[1]));
            parameters.setNumberOfTerms(Integer.parseInt(args[2]));
        }
        else{
            parameters.setNumberOfTerms(Integer.parseInt(args[1]));
        }

        return parameters;
    }
}
