using System;
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
        public int ComputeHeightWithoutUsingTree(string numNodes, string parents)
        {
            string[] charArray = parents.Split(" ").OrderBy(e=> e).ToArray();
            string previous = charArray[0];
            int height = 1;

            for (int i=1;i<charArray.Length; i++)
            {
                if (charArray[i] != previous)
                {
                    previous = charArray[i];
                    height++;
                }
            }
            return height;
        }













        private const string Success = "Success";

        public string IsBalanced(string text)
        {
            var charLocArray = ReadStrigToBracketsArray(text);
            Stack<CharacterAndLocation> stack = new Stack<CharacterAndLocation>();
            PushChar(charLocArray[0], ref stack);
            int location = 0;

            for (int i = 1; i < charLocArray.Length; i++)
            {
                if (stack.Count > 0 && ((Convert.ToChar(stack.Peek().Character) == '(' && charLocArray[i].Character == ')') ||
                    (Convert.ToChar(stack.Peek().Character) == '{' && charLocArray[i].Character == '}') ||
                    (Convert.ToChar(stack.Peek().Character) == '[' && charLocArray[i].Character == ']')))
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
                    PushChar(charLocArray[i], ref stack);
                }
            }

            return stack.Count == 0 ? Success :
                location > 0 ? (location + 1).ToString() : (stack.Pop().Position + 1).ToString();
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

        private static void PushChar(CharacterAndLocation charLoc, ref Stack<CharacterAndLocation> stack)
        {
            var validBrackets = "(){}[]";
            if (validBrackets.Contains(charLoc.Character.ToString()))
            {
                stack.Push(charLoc);
            }
        }

       
    }
}
