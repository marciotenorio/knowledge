package br.com.collections;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class IteratorMain {
    public static void main(String[] args) {
        ArrayList<String> strings = new ArrayList<>(List.of("HI", "Oi", "Hola"));
        Iterator<String> it = strings.iterator();

        while(it.hasNext()) {
            String next = it.next();
            System.out.println(next);
        }
    }
}
