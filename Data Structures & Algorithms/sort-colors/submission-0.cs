public class Solution {
    public void SortColors(int[] nums) {
        int[] counts = {0, 0, 0};

        for (int i = 0; i < nums.Length; i++) {
            counts[nums[i]]++;
        }

        int p = 0;
        for (int i = 0; i < counts.Length; i++) {
            for (int j = 0; j < counts[i]; j++) {
                nums[p] = i;
                p++;
            }
        }
    }
}