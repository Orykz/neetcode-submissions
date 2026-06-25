public class MyStack {
    Queue<int> storage;
    Queue<int> temp;

    public MyStack() {
        storage = new Queue<int>();
        temp = new Queue<int>();
    }
    
    public void Push(int x) {
        temp.Enqueue(x);
        while (storage.Count > 0) {
            temp.Enqueue(storage.Dequeue());
        }
        storage = temp;
        temp = new Queue<int>();
    }
    
    public int Pop() {
        return storage.Dequeue();
    }
    
    public int Top() {
        return storage.Peek();
    }
    
    public bool Empty() {
        return storage.Count <= 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */