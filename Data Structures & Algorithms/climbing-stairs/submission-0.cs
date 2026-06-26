public class Solution {
    public int i = 0;

    public int ClimbStairs(int n) {
        int i = 0;
        var cache = new Dictionary<int, int>();

        int climb(int i) {
            if (i == n) return 1;
            if (i > n) return 0;
            if (cache.TryGetValue(i, out int val)) return val;

            int sum = climb(i + 1) + climb(i + 2);
            cache[i] = sum;
            return sum;
        }

        return climb(i);
    }
}
