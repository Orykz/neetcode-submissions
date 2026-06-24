public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxNum = 0;

        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                count += 1;
                if (maxNum < count) {
                    maxNum = count;
                }
            } else {
                count = 0;
            }
        }
        return maxNum;
    }
}