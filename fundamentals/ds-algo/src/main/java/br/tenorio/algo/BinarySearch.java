package br.tenorio.algo;

public final class BinarySearch {

    private BinarySearch() {
        throw new IllegalStateException("Utility class can't be instantiated");
    }


    /**
     * @param value to be found
     * @param arr collection of values
     * @return index if are found or -1, if not.
     */
    public static int arraySearch(int value, int[] arr){
        int mid;
        int begin = 0;
        int end = arr.length - 1;

        while(begin <= end){
            mid = (begin + end) / 2;

            if(value < arr[mid]) end = mid - 1;
            else if(value > arr[mid]) begin = mid + 1;
            else return mid;
        }
        return -1;
    }
}
