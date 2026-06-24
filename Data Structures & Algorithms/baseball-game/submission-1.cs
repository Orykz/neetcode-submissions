public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> records = new();
        
        foreach (string op in operations) {
            switch (op) {
                case "D":
                    records.Push(records.Peek() * 2);
                    break;
                case "C":
                    records.Pop();
                    break;
                case "+":
                    int last = records.Pop();
                    int score = last + records.Peek();
                    records.Push(last);
                    records.Push(score);
                    break;
                default:
                    records.Push(int.Parse(op));
                    break;
            }
        }

        int total = 0;
        foreach (int n in records) {
            total += n;
        }
        return total;
    }
}