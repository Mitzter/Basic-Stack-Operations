using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // N -> number of elements needed to be pushed
            // S - > number of elements needed to be popped
            // X -> needs to be found in the stack
            int[] numbers = Console.ReadLine() 
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            List<int> numbersList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbersList[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(x))
            {
                Console.WriteLine(stack.Min());

            }
            
        }
    }
}
