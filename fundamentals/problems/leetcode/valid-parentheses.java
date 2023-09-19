class Solution {
    public static boolean isValid(String s) {
        if(s.length() <= 1) return false;

        Stack<Character> stack = new Stack<>();
        List<Character> openBrackets = List.of('(', '[', '{');
        List<Character> closeBrackets = List.of(')', ']', '}');

        for(int i=0; i<s.length(); i++){
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