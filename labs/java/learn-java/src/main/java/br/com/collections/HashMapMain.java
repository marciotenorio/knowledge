package br.com.collections;

import java.util.TreeMap;

public class HashMapMain {
    public static void main(String[] args) {
        var hashMap = new TreeMap<Integer, String>();
        hashMap.put(1, "Márcio");
        hashMap.put(1, "Lorena");
        //1, Lorena replaces the first one
        //TODO How to store a list when they have the same key?
        System.out.println(hashMap);
    }
}
