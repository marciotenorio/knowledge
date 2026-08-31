package br.tenorio.algo;

/**
 * Searching algorithms<br><br>
 *
 * @author Márcio Tenório
 * @since 20/05/2025
 */
public final class Search {

    private Search() {
        throw new IllegalStateException("This class can't be instantiated.");
    }

    /**
     * Binary search in a given array (iterative approach).<br>
     * TimeComplexity: O(Log<sub>n</sub>)
     *
     * @param value to be found
     * @param arr array of values
     * @return index if are found or -1, if not.
     */
    public static int binaryIterative(int value, int[] arr, int len){
        int mid;
        int begin = 0;
        int end = len - 1;

        while(begin <= end) {
            mid = (begin + end) / 2;

            if(value < arr[mid]) end = mid - 1;
            else if(value > arr[mid]) begin = mid + 1;
            else return mid;
        }
        return -1;
    }


    /**
     * Binary search in a given array (recursive approach).<br>
     * O(Log<sub>n</sub>)
     *
     * @param el to be found
     * @param ar array
     * @param lo start index
     * @param hi last index
     * @return index if are found or -1, if not.
     */
    public static int binaryRecursive(int el, int[] ar, int lo, int hi) {
        if(hi < lo) return -1;

        int mid = (lo + hi) / 2;
        if(el > ar[mid]) lo = mid + 1;
        if(el < ar[mid]) hi = mid - 1;
        if(el == ar[mid]) return mid;

        return binaryRecursive(el, ar, lo, hi);
    }
}
