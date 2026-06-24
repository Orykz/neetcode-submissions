public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int count0 = 0;
        int count1 = 0;

        for (int i = 0; i < students.Length; i++) {
            if (students[i] == 0) {
                count0++;
            } else {
                count1++;
            }
        }

        for (int j = 0; j < sandwiches.Length; j++) {
            if (sandwiches[j] == 0) {
                if (count0 <= 0) break;
                count0--;
            } else {
                if (count1 <= 0) break;
                count1--;
            }
        }

        return count0 + count1;
    }
}