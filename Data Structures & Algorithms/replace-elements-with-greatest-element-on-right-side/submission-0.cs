public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxNum = 0;
        
        for (int i = 0; i < arr.Length - 1; i++) {
            for (int j = i+1; j < arr.Length; j++) {
                if (arr[j] > maxNum) {
                    maxNum = arr[j];
                }
            }
            arr[i] = maxNum;
            maxNum = 0;
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }
}