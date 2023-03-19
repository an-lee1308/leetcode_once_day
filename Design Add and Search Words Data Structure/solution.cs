public class WordDictionary {

    TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        var temp = root;
        foreach(char ch in word)
        {
            if(temp.Nodes.ContainsKey(ch))
            {
                temp = temp.Nodes[ch];
            }
            else
            {
                var newNode = new TrieNode();
                temp.Nodes.Add(ch, newNode);
                temp = newNode;
            }
        }
        
        temp.IsWordEnd = true;
    }
    
    public bool Search(string word) {
        return SearchTrie(root, word, 0);
    }
    
    private bool SearchTrie(TrieNode root, string word, int index)
    {
        TrieNode temp = root;
        
        if(index == word.Length)
        {
            return temp.IsWordEnd;
        }
                
        if(word[index] != '.')
        {
            if(!temp.Nodes.ContainsKey(word[index]))
            {
                return false;
            }
            
            temp = temp.Nodes[word[index]];
            return SearchTrie(temp, word, index + 1);
        }        
        else
        {
            foreach(var node in temp.Nodes)
            {
                if(SearchTrie(node.Value, word, index + 1))
                {
                    return true;
                }
            }
        }
        
        return false;
    }
}

public class TrieNode
{
    public bool IsWordEnd;
    public Dictionary<char, TrieNode> Nodes;
    
    public TrieNode()
    {
        IsWordEnd = false;
        Nodes = new Dictionary<char, TrieNode>();
    }
}


/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */