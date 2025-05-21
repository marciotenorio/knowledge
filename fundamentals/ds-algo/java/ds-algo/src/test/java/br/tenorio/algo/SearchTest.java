package br.tenorio.algo;

import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.assertThat;

class SearchTest {
    @Test
    void binary_iterative_valueExistsInArray_returnLastIndex() {
        int[] arr = {1, 4, 6, 8, 9, 16};
        assertThat(Search.binaryIterative(16, arr, arr.length))
                .isEqualTo(arr.length - 1);
    }

    @Test
    void binary_iterative_valueNotExistsInArray_returnMinus1() {
        int[] arr = {1, 4, 6, 8, 9, 16};
        assertThat(Search.binaryIterative(20, arr, arr.length))
                .isEqualTo(-1);
    }

    @Test
    void binaryRecursive_valueExistsInArray_returnLastIndex() {
        int[] arr = {1, 4, 6, 8, 9, 16};
        assertThat(Search.binaryRecursive(16, arr, 0, 5))
                .isEqualTo(arr.length - 1);
    }

    @Test
    void binaryRecursive_valueNotExistsInArray_returnMinus1() {
        int[] arr = {1, 4, 6, 8, 9, 16};
        assertThat(Search.binaryRecursive(20, arr, 0, 5))
                .isEqualTo(-1);
    }
}