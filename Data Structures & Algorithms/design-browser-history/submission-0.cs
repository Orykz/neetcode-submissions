public class BrowserHistory {
    Node _current;

    public BrowserHistory(string homepage) {
        _current = new Node(homepage);
    }
    
    public void Visit(string url) {
        var newUrl = new Node(url);
        _current.Next = newUrl;
        newUrl.Prev = _current;
        _current = newUrl;
    }
    
    public string Back(int steps) {
        for (int i = steps; i > 0; i--) {
            if (_current.Prev == null) break;
            _current = _current.Prev;
        }

        return _current.Value;
    }
    
    public string Forward(int steps) {
        for (int i = 0; i < steps; i++) {
            if (_current.Next == null) break;
            _current = _current.Next;
        }

        return _current.Value;
    }
}

public class Node {
    public string Value { get;set; }
    public Node Next { get;set; }
    public Node Prev { get;set; }

    public Node(string value) {
        Value = value;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */