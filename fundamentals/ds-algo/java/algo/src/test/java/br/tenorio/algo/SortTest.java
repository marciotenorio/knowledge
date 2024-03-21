package br.tenorio.algo;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.*;

class SortTest {
    private Sort sort;

    @BeforeEach
    void setUp() {
        sort = new Sort();
    }

    @Test
    void selection_lastElement_firstElement1AndLast9(){
        int[] arr = new int[] {8, 5, 9, 6, 1, 2};
        sort.selection(arr);

        assertThat(arr[0]).isEqualTo(1);
        assertThat(arr[arr.length - 1]).isEqualTo(9);
    }

    @Test
    void selection_arrWithOneElement_firstElement8(){
        int[] arr = new int[] {8};
        sort.selection(arr);

        assertThat(arr[0]).isEqualTo(8);
    }

    @Test
    void selection_arrWithoutElement_returnArraItself(){
        int[] arr = new int[0];
        sort.selection(arr);

        assertThat(arr).isNotNull();
    }

    @Test
    void selection_arrWithTwoElements_first4Last8(){
        int[] arr = new int[] {8, 4};
        sort.selection(arr);

        assertThat(arr[0]).isEqualTo(4);
        assertThat(arr[1]).isEqualTo(8);
    }

    @Test
    void insertion_arrWithoutElements_returnArrayItself(){
        int[] arr = new int[0];
        sort.insertion(arr);

        assertThat(arr).isNotNull();
    }
}