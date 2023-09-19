class Solution {
    public int[] twoSum(int[] nums, int target) {
        int i = 0;
        int j = 0;
        boolean ctrl = false;

        for(i=0; i<nums.length; i++){
            for(j=0; j<nums.length; j++){
                if((nums[i] + nums[j] == target) && i != j){                    
                    ctrl = true;
                    break;
                }
            }

            if(ctrl) break;
        }
        return new int[]{i, j};
    }
}