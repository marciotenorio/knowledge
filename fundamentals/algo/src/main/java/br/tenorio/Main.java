package br.tenorio;

import br.tenorio.algo.BinarySearch;

import java.time.Duration;
import java.time.Instant;
import java.util.concurrent.ThreadLocalRandom;

public class Main {
    public static void main(String[] args) {
        int[] arr = new int[1_000_000_000];

        for (int i = 0; i < arr.length - 1; i++) {
            arr[i] = i;
        }
        arr[arr.length - 1] = 99;

        System.out.println("Começando");
        Instant begin = Instant.now();

//        BinarySearch.arraySearch(1_000_000_000, arr);

//        for (int i: arr) if(i == 1_000_000_000) break;

        Instant end = Instant.now();

        System.out.println(Duration.between(begin, end));

    }
}