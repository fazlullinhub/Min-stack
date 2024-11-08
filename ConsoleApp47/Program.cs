using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    public class MinStack
    {
        private Stack<int> stack;
        private Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int value)
        {
            stack.Push(value);

            if (minStack.Count == 0 || value <= minStack.Peek())
            {
                minStack.Push(value);
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            int value = stack.Pop();

            if (value == minStack.Peek())
            {
                minStack.Pop();
            }
            return value;
        }

        public int Top()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return stack.Peek();
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return minStack.Peek();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();

            minStack.Push(3);
            minStack.Push(5);
            Console.WriteLine("Минимальный элемент: " + minStack.GetMin());
            minStack.Push(2);
            minStack.Push(1);
            Console.WriteLine("Минимальный элемент: " + minStack.GetMin());
            minStack.Pop();
            Console.WriteLine("Минимальный элемент: " + minStack.GetMin());
            minStack.Pop();
            Console.WriteLine("Вершина стека: " + minStack.Top()); 
            Console.WriteLine("Минимальный элемент: " + minStack.GetMin());
        }
    }
}
