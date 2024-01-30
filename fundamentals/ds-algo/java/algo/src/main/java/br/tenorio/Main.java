package br.tenorio;

import br.tenorio.algo.BinarySearch;

import java.time.Duration;
import java.time.Instant;
import java.time.temporal.ChronoUnit;
import java.time.temporal.Temporal;
import java.time.temporal.TemporalUnit;
import java.util.concurrent.ThreadLocalRandom;

public class Main {
    public static void main(String[] args) {
        int[] arr = new int[1_000_000_000];

        for (int i = 0; i < arr.length - 1; i++) {
            arr[i] = i;
        }
        arr[arr.length - 2] = 999_999_99;

        System.out.println("Começando");
        Instant begin = Instant.now();

        int result = BinarySearch.arraySearch(999_999_999, arr);

//        for (int i: arr) if(i == 1_000_000_000) break;

        Instant end = Instant.now();

        System.out.println(Duration.between(begin, end).getNano()* 1_000_000_000L);
        System.out.println(result);

    }
}