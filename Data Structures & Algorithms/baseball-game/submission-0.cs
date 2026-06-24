public class Solution {
    public int CalPoints(string[] operations) {
        List<int> records = new();
        int total = 0;

        foreach (string op in operations) {
            int i = records.Count;
            switch (op) {
                case "D":
                    records.Add(records[i-1] * 2);
                    break;
                case "C":
                    records.RemoveAt(i - 1);
                    break;
                case "+":
                    records.Add(records[i-1] + records[i-2]);
                    break;
                default:
                    records.Add(int.Parse(op));
                    break;
            }
        }

        foreach (int n in records) {
            total += n;
        }
        return total;
    }
}