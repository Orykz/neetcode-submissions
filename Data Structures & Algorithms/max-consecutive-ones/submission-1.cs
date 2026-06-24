public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxNum = 0, count = 0;

        foreach (int num in nums) {
            if (num == 1) {
                count++;
            } else  {
                count = 0;
            }

            if (maxNum < count) {
                maxNum = count;
            }
        }
        return maxNum;
    }
}