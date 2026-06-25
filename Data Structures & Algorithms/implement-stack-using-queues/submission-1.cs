public class MyStack {
    Queue<int> storage;

    public MyStack() {
        storage = new Queue<int>();
    }
    
    public void Push(int x) {
        storage.Enqueue(x);
        for (int i = 0; i < storage.Count - 1; i++) {
            storage.Enqueue(storage.Dequeue());
        }
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