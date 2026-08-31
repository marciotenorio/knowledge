package br.tenorio.ds.graph;

import java.util.Scanner;

public class GraphSolutions {
    public static void main(String[] args) {
        var scan = new Scanner(System.in);

        int t, n;
        String l;
        t = scan.nextInt();

        for (int i = 0; i < t; i++) {
            n = scan.nextInt();
            var v1 = scan.nextLine().split("");
            var v2 = scan.nextLine().split("");

            var mat = new int[2][n];
            for (int j = 0; j < n; j++) {
                mat[0][j] = Integer.parseInt(v1[j]);
                mat[1][j] = Integer.parseInt(v2[j]);
            }

            
        }
    }
}
