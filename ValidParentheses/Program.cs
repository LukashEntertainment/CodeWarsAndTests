using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    public class Parentheses
    {
        public bool ValidParentheses(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            if ( (0 > input.Length) && (input.Length > 100))
                return false;
            if (!input.Contains("(") && !input.Contains(")"))
                return false;

            Stack<char> brackets = new Stack<char>();

            foreach (var character in input)
            {
                if (character == '(')
                {
                    brackets.Push(character);
                }
                else if (character == ')')
                {
                    if (brackets.Count <= 0)
                    {
                        return false;
                    }
                    var open = brackets.Pop();

                    if (character == ')' && open != '(')
                        return false;
                }
            }

            if (brackets.Count > 0)
                return false;
            
            return true;
        }
        
        public static void Main(string[] args)
        {
            Parentheses parentheses = new Parentheses();
            Console.WriteLine(parentheses.ValidParentheses("(())"));
        }
    }
}