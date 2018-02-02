using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    //public class Bracket
    //{
    //    public char Type { get; set; }
    //    public int Position { get; set; }

    //    public Bracket(char type, int position)
    //    {
    //        Type = type;
    //        Position = position;
    //    }
    //}
    public class Week1
    {
        private const string Success = "Success";

        public string IsBalanced(string text)
        {
            char[] inputCharArray = text.ToCharArray();
            Stack stack = new Stack();
            PushChar(inputCharArray[0], ref stack);

            for (int i = 1; i < inputCharArray.Length; i++)
            {
                if (stack.Count > 0 && ((Convert.ToChar(stack.Peek()) == '(' && inputCharArray[i] == ')') ||
                    (Convert.ToChar(stack.Peek()) == '{' && inputCharArray[i] == '}') ||
                    (Convert.ToChar(stack.Peek()) == '[' && inputCharArray[i] == ']')))
                {
                    stack.Pop();
                }
                else
                {
                    //stack.Push(inputCharArray[i]);
                    PushChar(inputCharArray[i], ref stack);
                }
            }

            return stack.Count == 0 ? Success : "";
        }

        private static void PushChar(char character, ref Stack stack)
        {
            //var validBrackets = new char[] {'(', ')', '{', '}', '[', ']'};
            var validBrackets = "(){}[]";
            if (validBrackets.Contains(character.ToString()))
            {
                stack.Push(character);
            }
        }

    }
}
