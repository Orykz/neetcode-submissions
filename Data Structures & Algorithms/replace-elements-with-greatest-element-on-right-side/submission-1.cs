public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int[] res = new int[n];
        int maxNum = -1;
        
        for (int i = n - 1; i >= 0; i--) {
            res[i] = maxNum;
            maxNum = Math.Max(arr[i], maxNum);
        }

        return res;
    }
}