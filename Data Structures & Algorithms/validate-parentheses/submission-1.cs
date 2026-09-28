public class Solution {
    public bool IsValid(string s) {

        Stack<char> myStack = new Stack<char>();
        Dictionary<char, char> pairs = new Dictionary<char, char>{
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        if(s.Length == 0){
            return true;
        }
        
        foreach(char c in s){
            
            if(pairs.ContainsKey(c)){
                if((myStack.Count == 0) || (pairs[c] != myStack.Peek())){
                    return false;
                } else {
                    myStack.Pop();
                }
            } else {
                myStack.Push(c);
            }

            // if(pairs[c]  ==  myStack.Peek()){
            //     myStack.Pop();
            // } else {
            //     myStack.Push(c);
            // }
           
        }

        if (myStack.Count > 0)
        {
            return false;
        }

        return true;

    }
}
