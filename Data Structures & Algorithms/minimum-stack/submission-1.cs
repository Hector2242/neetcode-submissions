public class MinStack {

    private Stack<int> stack;

    public MinStack() {
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        Stack<int> tmp = new Stack<int>();

        int mini = stack.Peek();

        while(stack.Count > 0){
            int last = stack.Pop();

            if(last < mini){
                mini = last;
            }

            tmp.Push(last);
        }

        while(tmp.Count > 0){
            int value = tmp.Pop();
            stack.Push(value);
        }

       return mini;
    }
}
