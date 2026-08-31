package br.com.collections;

import java.util.Comparator;

public class CS2MatchComparator implements Comparator<CS2Match> {
    @Override
    public int compare(CS2Match m1, CS2Match m2) {
        return m1.getTotalKills().compareTo(m2.getTotalKills());
    }
}
