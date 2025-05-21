package br.tenorio.ds.graph;

import java.util.*;

public class Graph {
    private int value;

    private boolean isVisited = false;

    private List<Graph> adjacent;

    public Graph(int value, List<Graph> adjacent) {
        this.value = value;
        this.adjacent = adjacent;
    }

    public Graph() { }

    public int getValue() {
        return value;
    }

    public void setValue(int value) {
        this.value = value;
    }

    public boolean isVisited() {
        return isVisited;
    }

    public void setVisited(boolean visited) {
        isVisited = visited;
    }

    public List<Graph> getAdjacent() {
        return adjacent;
    }

    public void setAdjacent(List<Graph> adjacent) {
        this.adjacent = adjacent;
    }

    @Override
    public String toString() {
        return "Graph{" +
                "value=" + value +
                ", isVisited=" + isVisited +
                '}';
    }

    public static Graph dfsRecursiveWithoutStack(Graph g, int value) {
        g.isVisited = true;

        if(g.value == value) return g;

        for (Graph adj : g.getAdjacent()) {
            if(!adj.isVisited()) {
                dfsRecursiveWithoutStack(adj, value);
            }
        }

        return null;
    }

    public static Graph dfsIterativeWithStack(Graph g, int value) {
        if(g.value == value) return g;

        var stack = new ArrayDeque<Graph>();
        var hashmap = new HashMap<Integer, Graph>();

        stack.push(g);
        while (!stack.isEmpty()) {
            var current = stack.pop();

            if(current.value == value) return current;

            if (!hashmap.containsKey(current.getValue())) {
                hashmap.put(current.getValue(), current);

                for (Graph adj : current.getAdjacent()) {
                    stack.push(adj);
                }
            }
        }

        return null;
    }

    public static Graph bfsRecursive(Graph g, int value) {
        var queue = new ArrayDeque<Graph>();

        return new Graph();
    }
}
