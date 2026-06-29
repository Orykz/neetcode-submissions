public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int length = m + n;
        var arr = new int[length];
        for (int i = 0; i < length; i++) {
            if (i < m) {
                arr[i] = nums1[i];
            } else {
                arr[i] = nums2[i - m];
            }
        }

        int[] sortedArr = MergeSorting(arr, 0, length - 1);
        for (int i = 0; i < length; i++) {
            nums1[i] = sortedArr[i];
        }
    }

    public static int[] MergeSorting(int[] arr, int l, int r) {
        if (l < r) {
            int m = (l + r) / 2;
            MergeSorting(arr, l, m);
            MergeSorting(arr, m + 1, r);
            MergeHalfs(arr, l, m, r);
        }
        return arr;
    }

    public static void MergeHalfs(int[] arr, int l, int m, int r) {
        int leftLength = m - l + 1;
        int rightLength = r - m;
        var tempLeft = new int[leftLength];
        var tempRight = new int[rightLength];

        for (int a = 0; a < leftLength; a++) {
            tempLeft[a] = arr[l + a];
        }

        for (int b = 0; b < rightLength; b++) {
            tempRight[b] = arr[m + 1 + b];
        }


        int i = 0;
        int j = 0;
        int k = l;

        while (i < leftLength && j < rightLength) {
            if (tempLeft[i] <= tempRight[j]) {
                arr[k] = tempLeft[i];
                i++;
            }
            else {
            arr[k] = tempRight[j];
            j++;
            }
            k++;
        }

        while (i < leftLength) {
            arr[k] = tempLeft[i];
            i++;
            k++;
        }

        while (j < rightLength) {
            arr[k] = tempRight[j];
            j++;
            k++;
        }
    }
}