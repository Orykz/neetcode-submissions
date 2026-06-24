public class Solution {
    public bool IsValid(string s) {
        Stack<char> brackets = new();
        var pairs = new Dictionary<char, char> {
            {'(',')'},
            {'[',']'},
            {'{','}'},
        };

        foreach (char c in s) {
            if (pairs.ContainsKey(c)) {
                brackets.Push(c);
            } else {
                if (brackets.Count <= 0 || c != pairs[brackets.Peek()]) {
                    return false;
                }
                brackets.Pop();
            }
        }
        return brackets.Count == 0;
    }
}
