package br.tenorio.algo;

import static org.assertj.core.api.Assertions.assertThat;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class SearchTest {
    private Search search;

    @BeforeEach
    void setUp() {
        this.search = new Search();
    }

    @Test
    void binary_valueExistsInArray_returnLastIndex() {
        int[] arr = {1,4,6,8,9,16};
        assertThat(search.binary(16, arr, arr.length)).isEqualTo(arr.length - 1);
    }

    @Test
    void binary_valueNotExistsInArray_returnMinus1() {
        int[] arr = {1,4,6,8,9,16};
        assertThat(search.binary(20, arr, arr.length)).isEqualTo(-1);
    }
}