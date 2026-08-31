package br.tenorio;

import java.util.*;

public class Main {
    public static void main(String[] args) {
//        System.out.println(fib(100));
        System.out.println(coinProblem(10));
    }

    public static Map<Long, Long> map = new HashMap<>();
    public static List<Integer> coins = Arrays.asList(1, 3, 4);

    public static long fib(long n) {
        if(n <= 1)
            return n;

        Long l = map.get(n);
        if(l != null)
            return l;

        var ans = fib(n - 1) + fib(n - 2);
        map.put(n, ans);
        return ans;
    }

    public static int coinProblem(Integer n) {
        if(n < 0)
            return 1_000_000;
        if(n == 0)
            return 0;

        Integer best = 1_000_000;
        for (var coin : coins) {
            best = Math.min(best, coinProblem(n - coin) + 1);
        }

        return best;
    }
}