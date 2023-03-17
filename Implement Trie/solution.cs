public class Trie {
    private TrieNode _head;
    /** Initialize your data structure here. */
    public Trie() {
        _head = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        var current = _head;
        foreach (char c in word) {
            current = current[c] ??= new TrieNode();
        }
        current.Tail = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        var node = ToTail(word);
        return node != null ? node.Tail : false;     
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        return ToTail(prefix) != null;      
    }
    
    private TrieNode ToTail(string prefix) {
        var current = _head;
        foreach (char c in prefix) {
            current = current[c];
            if (current == null)
                return current;
        }
        return current;        
    }
    
    class TrieNode {
        private TrieNode[] _suffixes = new TrieNode[26];
        internal TrieNode this[char c] {
            get => _suffixes[c-'a']; 
            set => _suffixes[c-'a'] = value;
        }
        internal bool Tail { get; set; } = false;
    }
}