public class Solution {
    Dictionary<int, int> cache = new();

    public int ClimbStairs(int n) {
        return climb(n);
    }

    public int climb(int n) {
        if (n <= 2) return n;
        if (cache.ContainsKey(n)) return cache[n];

        int sum = climb(n - 1) + climb(n - 2);
        cache[n] = sum;
        return sum;
    }
}
