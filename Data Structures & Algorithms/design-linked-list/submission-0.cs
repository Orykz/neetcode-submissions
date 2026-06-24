public class ListNode {
    public int Value { get;set; }
    public ListNode Prev { get;set; }
    public ListNode Next { get;set; }

    public ListNode(int value = 0) {
        Value = value;
    }
}

public class MyLinkedList {
    ListNode _head;
    ListNode _tail;
    int _length;

    public MyLinkedList() {
        _head = new ListNode(0);
        _tail = new ListNode(0);
        _head.Next = _tail;
        _tail.Prev = _head;
        _length = 0;
    }
    
    public int Get(int index) {
        if (index < 0 || index >= _length) return -1;

        var curNode = Traverse(index);
        return curNode.Value;
    }
    
    public void AddAtHead(int val) {
        AddAtIndex(0, val);
    }
    
    public void AddAtTail(int val) {
        AddAtIndex(_length, val);
    }
    
    public void AddAtIndex(int index, int val) {
        if (index < 0 || index > _length) return;

        var nextNode = Traverse(index);
        var prevNode = nextNode.Prev;
        var newNode = new ListNode(val);

        newNode.Next = nextNode;
        newNode.Prev = prevNode;
        prevNode.Next = newNode;
        nextNode.Prev = newNode;
        _length++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= _length) return;
        
        var nodeToDel = Traverse(index);
        var nextNode = nodeToDel.Next;
        var prevNode = nodeToDel.Prev;

        nextNode.Prev = prevNode;
        prevNode.Next = nextNode;
        _length--;
    }

    private ListNode Traverse(int index) {
        if (index == _length) return _tail;

        ListNode curr;

        if (index < _length / 2) {
            curr = _head.Next;
            for (int i = 0; i < index; i++) {
                curr = curr.Next;
            }
        } else {
            curr = _tail.Prev;
            for (int i = _length - 1; i > index; i--) {
                curr = curr.Prev;
            }
        }

        return curr;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */