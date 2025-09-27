package br.com.strings;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Desafio {
    public static void main(String[] args) {
//        var list = Arrays.asList(1,4,2,3,5);
//        var ans = findSecurityLevel(list, 100);
//        System.out.println(ans);


        var list2 = Arrays.asList(3,1,2);
        var ans = minimizeVariation(list2);
        System.out.println(ans);
    }

    public static long findSecurityLevel(List<Integer> pid, int k) {
        long sum = 0;
        long total = 0;

        for (int i = 0; i < pid.size(); i++) {
            for (int j = 0; j <= i; j++) {
                sum += pid.get(j);

                if((sum % k) == (i+1)) {
                    ++total;
                }
            }
            sum = 0;
        }

        return total;
    }

    public static long minimizeVariation(List<Integer> productSize) {
        long smallest = Long.MAX_VALUE;
        int idx = 0;
        var newOrder = new ArrayList<Integer>();
        newOrder.add(0);

        for (int i = 0; i < productSize.size(); i++) {
            for (int j = i+1; j < productSize.size(); j++) {
                long curr = Math.abs(productSize.get(i) - productSize.get(j));
                if(curr < smallest) {
                    smallest = curr;
                    idx = j;
                }
            }
            newOrder.add(idx);
            idx = 0;
        }

        long sum = 0;
        long min = Long.MAX_VALUE;
        long max = Long.MIN_VALUE;
        for (int i = 0; i < productSize.size(); i++) {
            if(productSize.get(newOrder.get(i)) < min) min = productSize.get(newOrder.get(i));
            if(productSize.get(newOrder.get(i)) > max) max = productSize.get(newOrder.get(i));

            sum += max - min;
        }

        return sum;
    }
}
