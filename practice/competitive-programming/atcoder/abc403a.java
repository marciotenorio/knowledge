//package br.tenorio.algo;

import java.util.Scanner;

public class abc403a {
    public static void main(String[] args) {
        var in = new Scanner(System.in);

        int n = in.nextInt();
        int sum = 0;
        for (int i = 1; i <= n; i++) {
            int a = in.nextInt();
            if((i ^ 1) != (i+1)) sum += a;
        }

        System.out.println(sum);
    }
}
