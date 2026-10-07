public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<string> stack = new Stack<string>();

        int result = 0;

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                // It's a number
                stack.Push(token);
            }
            else
            {
                // It's an operator
                int num2 = int.Parse(stack.Pop());
                int num1 = int.Parse(stack.Pop());

                switch (token)
                {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    // code for -
                    result = num1 - num2;
                    break;

                case "*":
                    // code for *
                    result = num1 * num2;
                    break;

                case "/":
                    // code for /
                    result = num1 / num2;
                    break;

                default:
                    // if none of the cases match
                    break;
                }

                stack.Push(result.ToString());
            }

                
        }

        return int.Parse(stack.Pop());
    }
}
