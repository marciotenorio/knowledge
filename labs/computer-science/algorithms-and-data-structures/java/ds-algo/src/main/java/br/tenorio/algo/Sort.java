package br.tenorio.algo;

/**
 * Sorting algorithms<br><br>
 *
 * @author Márcio Tenório
 * @since 07/03/2024
 */
public final class Sort {

    private Sort() {
        throw new IllegalStateException("This class can't be instantiated.");
    }

    /**
     * Take the smaller than swap.<br><br>
     *
     * Time Complexity:<br>
     * Worst: O(N<sup>2</sup>)<br>
     * Best: Ω(N<sup>2</sup>)<br>
     * Stable: No<br>
     *
     * @param arr array to be sorted
     */
    public static void selection(int[] arr) {
        for(int i = 0; i < arr.length; i++) {
            int lowestIndex = i;

            for (int j = i+1; j < arr.length; j++) {
                if(arr[j] < arr[lowestIndex])
                    lowestIndex = j;
            }

            int tmp = arr[i];
            arr[i] = arr[lowestIndex];
            arr[lowestIndex] = tmp;
        }
    }

    /**
     * 1. Take an element to insert in first unsorted segment<br>
     * 2. Keep switching to shift to right.
     * Example take the '1', like: 3561 -> 3566 -> 3556 -> 3356 -> 1356,
     * and then shift others until reach the place which it was taken.<br><br>
     *
     * Time Complexity:<br>
     * Worst: O(N<sup>2</sup>) - when the array has inverse order<br>
     * Best: Ω(N<sup>2</sup>) - already sorted<br>
     * Stable: Yes<br>
     *
     * @param arr to be sorted
     */
    public static void insertion(int[] arr) {
        for(int i = 1; i < arr.length; i++) {
            int notOrdered = arr[i];
            int lastOrderedIdx = i - 1;

            while ((lastOrderedIdx >= 0) && (notOrdered < arr[lastOrderedIdx])) {
                arr[lastOrderedIdx + 1] = arr[lastOrderedIdx];
                lastOrderedIdx--;
            }
            arr[lastOrderedIdx + 1] = notOrdered;
        }
    }

    /**
     * Always get the first element as the current<br>
     * then compare with the next one, if is greater: swap<br> and keep,
     * if is smaller or equal, the next is the current and keep until the end.<br>
     * At each interaction you decrease the inner loop by one (the already sorted element).<br>
     * If no swap are made, end the sort.<br><br>
     *
     * Time Complexity:<br>
     * Worst: O(N<sup>2</sup>) - when the array has inverse order<br>
     * Best: Ω(N) - already sorted<br>
     * Stable: Yes<br>
     *
     * @param arr to be sorted
     */
    public static void bubble(int[] arr) {
        for (int i = 0; i < arr.length - 1; ++i) {
            boolean notSwapped = true;

            for (int j = 0; j < arr.length - 1 - i; j++) {
                if(arr[j] > arr[j+1]){
                    int tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                    notSwapped = false;
                }
            }

            if(notSwapped) return;
        }
    }

    /**
     * Divide-conquer -> until have all items split by one,<br>
     * then by getting the left and right of the split arrays<br>
     * merge them preserving the order, <br>
     * recursively do this until you have the original array divided by two and each side sorted.<br>
     * Finally, merge this array.<br><br>
     *
     * Time Complexity:<br>
     * Worst: O(nLog<sub>10</sub>n)<br>
     * Best: Ω(nLog<sub>10</sub>n)<br>
     * Stable: Yes<br>
     *
     * @param arr to be sorted
     */
    public static void merge(int[] arr, int begin, int end) {
        if(begin < end) {
            int mid = (begin + end) / 2;
            merge(arr, begin, mid);
            merge(arr, mid + 1, end);
            merge(arr, begin, mid, end);
        }
    }

    private static void merge(int[] arr, int begin, int mid, int end) {
        int i = begin;
        int j = mid + 1;
        int k = 0;
        int[] tmp = new int[end - begin + 1];

        while (i <= mid && j <= end) {
            if (arr[i] < arr[j]) {
                tmp[k] = arr[i];
                ++i;
            } else {
                tmp[k] = arr[j];
                ++j;
            }
            ++k;
        }

        while (i <= mid) {
            tmp[k] = arr[i];
            ++i;
            ++k;
        }

        while (j <= end) {
            tmp[k] = arr[j];
            ++j;
            ++k;
        }

        System.arraycopy(tmp, 0, arr, begin, tmp.length);
    }
}
