package br.tenorio.algo;

import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.assertThat;

class SortTest {

    @Test
    void selection_lastElement_firstElement1AndLast9() {
        int[] arr = new int[]{8, 5, 9, 6, 1, 2};
        Sort.selection(arr);

        assertThat(arr[0]).isEqualTo(1);
        assertThat(arr[arr.length - 1]).isEqualTo(9);
    }

    @Test
    void selection_arrWithOneElement_firstElement8() {
        int[] arr = new int[]{8};
        Sort.selection(arr);

        assertThat(arr[0]).isEqualTo(8);
    }

    @Test
    void selection_arrWithoutElement_returnArraItself() {
        int[] arr = new int[0];
        Sort.selection(arr);

        assertThat(arr).isNotNull();
    }

    @Test
    void selection_arrWithTwoElements_first4Last8() {
        int[] arr = new int[]{8, 4};
        Sort.selection(arr);

        assertThat(arr[0]).isEqualTo(4);
        assertThat(arr[1]).isEqualTo(8);
    }

    @Test
    void insertion_lastElement_firstElement1AndLast9() {
        int[] arr = new int[]{8, 5, 9, 6, 1, 2};
        int[] arrSorted = new int[]{1, 2, 5, 6, 8, 9};
        Sort.insertion(arr);

        for (int i = 0; i < arrSorted.length; i++) {
            assertThat(arr[i]).isEqualTo(arrSorted[i]);
        }
    }

    @Test
    void insertion_arrWithOneElement_firstElement8() {
        int[] arr = new int[]{8};
        Sort.insertion(arr);

        assertThat(arr[0]).isEqualTo(8);
    }

    @Test
    void insertion_arrWithoutElement_returnArraItself() {
        int[] arr = new int[0];
        Sort.insertion(arr);

        assertThat(arr).isNotNull();
    }

    @Test
    void insertion_arrWithTwoElements_first4Last8() {
        int[] arr = new int[]{8, 4};
        Sort.insertion(arr);

        assertThat(arr[0]).isEqualTo(4);
        assertThat(arr[1]).isEqualTo(8);
    }

    @Test
    void bubble_arrWithTwoElements_First4Last8() {
        int[] arr = new int[]{8, 4};
        Sort.bubble(arr);

        assertThat(arr[0]).isEqualTo(4);
        assertThat(arr[1]).isEqualTo(8);
    }

    @Test
    void bubble_lastElement_firstElement1AndLast9() {
        int[] arr = new int[]{8, 5, 9, 6, 1, 2};
        Sort.selection(arr);

        assertThat(arr[0]).isEqualTo(1);
        assertThat(arr[arr.length - 1]).isEqualTo(9);
    }

    @Test
    void bubble_arrWithOneElement_firstElement8() {
        int[] arr = new int[]{8};
        Sort.selection(arr);

        assertThat(arr[0]).isEqualTo(8);
    }

    @Test
    void bubble_arrWithoutElement_returnArraItself() {
        int[] arr = new int[0];
        Sort.bubble(arr);

        assertThat(arr).isNotNull();
    }

    @Test
    void merge_arrWithTwoElements_First4Last8() {
        int[] arr = new int[]{8, 4};
        Sort.merge(arr, 0, arr.length - 1);

        assertThat(arr[0]).isEqualTo(4);
        assertThat(arr[1]).isEqualTo(8);
    }

    @Test
    void merge_lastElement_firstElement1AndLast9() {
        int[] arr = new int[]{8, 5, 9, 6, 1, 2};
        Sort.merge(arr, 0, arr.length - 1);

        assertThat(arr[0]).isEqualTo(1);
        assertThat(arr[arr.length - 1]).isEqualTo(9);
    }

    @Test
    void merge_arrWithOneElement_firstElement8() {
        int[] arr = new int[]{8};
        Sort.merge(arr, 0, arr.length - 1);

        assertThat(arr[0]).isEqualTo(8);
    }

    @Test
    void merge_arrWithoutElement_returnArraItself() {
        int[] arr = new int[0];
        Sort.merge(arr, 0, arr.length - 1);

        assertThat(arr).isNotNull();
    }
}