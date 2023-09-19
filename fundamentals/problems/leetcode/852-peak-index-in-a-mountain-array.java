/**
 * 852-peak-index-in-a-mountain-array.java
 */
class Solution {
    public int peakIndexInMountainArray(int[] arr) {
        int i = 1;
        for(i=1; i<arr.length; i++){
            if(arr[i] > arr[i-1]
              && arr[i] > arr[i+1]){
                break;
            }
        }
        
        return i;
    }
}