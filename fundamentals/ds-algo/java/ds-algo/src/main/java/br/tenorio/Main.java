package br.tenorio;

import br.tenorio.ds.graph.Graph;

import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        var g0 = new Graph(0, null);
        var g1 = new Graph(1, null);
        var g2 = new Graph(2, null);
        var g3 = new Graph(3, null);
        var g4 = new Graph(4, null);

        g0.setAdjacent(Arrays.asList(g1, g2, g3));
        g1.setAdjacent(Arrays.asList(g0, g2));
        g2.setAdjacent(Arrays.asList(g0, g1, g4));
        g3.setAdjacent(List.of(g0));
        g4.setAdjacent(List.of(g2));

        var r = Graph.dfsIterativeWithStack(g0, 4);
        System.out.println(r);
    }
}