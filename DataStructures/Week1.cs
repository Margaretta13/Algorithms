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

    public class Node
    {
        public int Key { get; set; }
        private List<int> _children = new List<int>();

        public List<int> Children => _children;

        public Node(int key)
        {
            Key = key;
        }

        public void AddChildren(int key)
        {
            _children.Add(key);
        }
    }
    public class Week1
    {
        public int ComputeHeight(string numNodes, string parents)
        {
            string[] charArray = parents.Split(" ");
            
            return 0;
        }



        public int ComputeHeightWithoutUsingTree(string numNodes, string parents)
        {
            string[] parentsArray = parents.Split(" ").OrderBy(e => e).ToArray();
            string previous = parentsArray[0];
            int height = 1;

            for (int i = 1; i < parentsArray.Length; i++)
            {
                if (parentsArray[i] != previous)
                {
                    previous = parentsArray[i];
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
