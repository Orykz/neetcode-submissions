public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> records = new();
        int sum = 0;

        foreach (string op in operations) {
            switch (op) {
                case "D":
                    int doubled = records.Peek() * 2;
                    records.Push(doubled);
                    sum += doubled;
                    break;
                case "C":
                    sum -= records.Pop();
                    break;
                case "+":
                    int top = records.Pop();
                    int second = records.Peek();
                    int score = top + second;
                    records.Push(top);
                    records.Push(score);
                    sum += score;
                    break;
                default:
                    int n = int.Parse(op);
                    records.Push(n);
                    sum += n;
                    break;
            }
        }
        return sum;
    }
}