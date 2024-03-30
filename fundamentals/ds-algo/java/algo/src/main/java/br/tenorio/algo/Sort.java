package br.tenorio.algo;

/**
 * Sorting algorithms
 * @author Márcio Tenório
 * @since 07/03/2024
 */
public class Sort {

    /**
     * @param arr to be sorted
     * Time Complexicity:
     * Worst: N^2
     * Best: N^2
     * Stable: No
     */
    public void selection(int[] arr){
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
     * @param arr to be sorted
     * Time Complexicity:
     * Worst: N^2
     * Best: N^2
     * Stable: Yes
     */
    public void insertion(int[] arr){
        for(int i = 1; i < arr.length; i++) {
            int firstNotOrdered = arr[i];
            int lastOrdered = i - 1;

            while ((lastOrdered >= 0) && (firstNotOrdered < arr[lastOrdered])) {
                arr[lastOrdered + 1] = arr[lastOrdered];
                lastOrdered--;
            }
            arr[lastOrdered + 1] = firstNotOrdered;
        }
    }
}
