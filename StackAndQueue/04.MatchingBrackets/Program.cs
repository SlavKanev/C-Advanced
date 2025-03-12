﻿namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openIndex = stack.Pop();
                    Console.WriteLine(input.Substring(openIndex,i - openIndex + 1));
                }
            }
        }
    }
}
