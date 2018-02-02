using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class CharacterAndLocation
    {
        public char Character { get; set; }
        public int Position { get; set; }

        public CharacterAndLocation(char character, int position)
        {
            Character = character;
            Position = position;
        }
    }
    public class Week1
    {
        private const string Success = "Success";

        public string IsBalanced(string text)
        {
            var charLocArray = ReadStrigToBracketsArray(text);
            Stack stack = new Stack();
            PushChar(charLocArray[0].Character, ref stack);
            int location = 0;

            for (int i = 1; i < charLocArray.Length; i++)
            {
                if (stack.Count > 0 && ((Convert.ToChar(stack.Peek()) == '(' && charLocArray[i].Character == ')') ||
                    (Convert.ToChar(stack.Peek()) == '{' && charLocArray[i].Character == '}') ||
                    (Convert.ToChar(stack.Peek()) == '[' && charLocArray[i].Character == ']')))
                {
                    stack.Pop();
                }
                else
                {
                    var closingBrackets = ")}]";
                    if (closingBrackets.Contains(charLocArray[i].Character))
                    {
                        location = charLocArray[i].Position;
                        break;
                    }
                    PushChar(charLocArray[i].Character, ref stack);
                }
            }
            return stack.Count == 0 ? Success : (location + 1).ToString();
        }

        private CharacterAndLocation[] ReadStrigToBracketsArray(string text)
        {
            var charLocArray = new CharacterAndLocation[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                charLocArray[i] = new CharacterAndLocation(text[i], i);
            }

            return charLocArray;
        }

        private static void PushChar(char character, ref Stack stack)
        {
            var validBrackets = "(){}[]";
            if (validBrackets.Contains(character.ToString()))
            {
                stack.Push(character);
            }
        }

    }
}
