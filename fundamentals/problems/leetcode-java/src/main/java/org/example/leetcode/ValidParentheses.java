package org.example.leetcode;

import java.util.HashMap;
import java.util.Stack;

/**
 * https://leetcode.com/problems/valid-parentheses/
 */
public class ValidParentheses {
    public boolean isValid(String s) {
        var stack = new Stack<Character>();

        var mapRegular = new HashMap<Character, Character>();
        mapRegular.put('[', ']');
        mapRegular.put('(', ')');
        mapRegular.put('{', '}');

        var mapOpposite = new HashMap<Character, Character>();
        mapOpposite.put(']', '[');
        mapOpposite.put(')', '(');
        mapOpposite.put('}', '{');

        for (Character letter : s.toCharArray()) {
            if(!mapOpposite.containsKey(letter)) {
                stack.push(letter);
            }
            else {
                if(stack.isEmpty()) return false;
                Character top = stack.pop();
                Character letterMatch = mapRegular.get(top);

                if(!letter.equals(letterMatch)) return false;
            }
        }

        return stack.empty();
    }

    public static void main(String[] args) {
        ValidParentheses e = new ValidParentheses();

        System.out.println("Resultado é:" + e.isValid("]"));
    }
}
