namespace LeetCode;

public class ValidParentheses20 {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0){
            return false;
        }
        
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '{' or '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count <= 0)
                {
                    return false;
                }
                
                var lastBracket = stack.Pop();
                var isValid = lastBracket is '(' && c == ')'
                              || lastBracket is '{' && c == '}'
                              || lastBracket is '[' && c == ']';
                if (!isValid)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}