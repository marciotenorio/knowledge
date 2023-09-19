import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Stack;

public class Main {
    public static void main(String[] args) {
        String test = "(])";
        System.out.println(isValid(test));
    }

    public static boolean isValid(String s) {
        Stack<Character> stack = new Stack<>();
        HashMap<Character, Character> brackets = Map.of('(', ')', '[', ']', '{', '}');

        for(int i=0; i<s.length(); i++){
            if(brackets.get(brackets))

            if(openBrackets.contains(s.charAt(i))){
                stack.push(s.charAt(i));
            }
            if(closeBrackets.contains(s.charAt(i))){
                if(stack.empty()) return false;

                Character current = stack.peek();

                if(current == '(' && s.charAt(i) == ')') stack.pop();
                else if(current == '[' && s.charAt(i) == ']') stack.pop();
                else if(current == '{' && s.charAt(i) == '}') stack.pop();                
                else return false;
            }                        
        }        
        return stack.empty();
    }
}