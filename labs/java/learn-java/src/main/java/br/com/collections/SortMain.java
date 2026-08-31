package br.com.collections;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class SortMain {
    public static void main(String[] args) {
        ArrayList<CS2Match> matches = new ArrayList<>();
        matches.add(new CS2Match(LocalDateTime.now().plusDays(1), "de_dust", 87));
        matches.add(new CS2Match(LocalDateTime.now().plusDays(1), "de_astec", 87));
        matches.add(new CS2Match(LocalDateTime.now().plusDays(8), "de_mirage", 46));
        matches.add(new CS2Match(LocalDateTime.now().plusDays(9), "de_astec", 128));

        System.out.println("---- NORMAL ---");
        for (CS2Match match : matches) {
            System.out.println(match);
        }

        System.out.printf("\n--- SORT BY DATE ASC WITH METHOD REFERENCE ---\n");
        matches.sort(Comparator
                .comparing(CS2Match::getDate));
        for (CS2Match match : matches) {
            System.out.println(match);
        }

        System.out.printf("\n--- SORT BY DATE DESC WITH LAMBDA ---\n");
        matches.sort(Comparator
                .comparing((CS2Match o) -> o.getDate())
                .reversed());
        for (CS2Match match : matches) {
            System.out.println(match);
        }

        System.out.printf("\n--- MULTIPLE FIELDS SORTING METHOD REFERENCE ---\n");
        matches.sort(Comparator
            .comparing(CS2Match::getDate)
            .reversed()
            .thenComparing(CS2Match::getMap, String.CASE_INSENSITIVE_ORDER));
        for (CS2Match match : matches) {
            System.out.println(match);
        }

        System.out.printf("\n--- SORTING BY COMPARABLE USING ID ---\n");
        Collections.sort(matches);
        for (CS2Match match : matches) {
            System.out.println(match);
        }

        System.out.printf("\n--- SORTING BY COMPARATOR INTERFACE USING KILLS ---\n");
        Collections.sort(matches, new CS2MatchComparator());
        for (CS2Match match : matches) {
            System.out.println(match);
        }
    }
}
