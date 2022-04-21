using System;

namespace ConsoleApplication
{
    class Stack
    {
        private int[] ele;
        private int top;
        private int max;
        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
               throw new StackOverFlowException("Stack Over flow");
                
            }
            else
            {
                ele[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
               throw new StackUnderFlowException("Stack Under flow");
                
            }

            else
            {
                Console.WriteLine("Poped values are: " + ele[top]);
                return ele[top--];
            }
        }

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Value[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }

	public class StackOverFlowException : Exception
    {
        public StackOverFlowException(string msg) : base(msg)
        {

        }
    }
    public class StackUnderFlowException : Exception
    {
        public StackUnderFlowException(string msg) : base(msg)
        {

        }
    }

    class Program
    {
        static void Main()
        {
            Stack S = new Stack(5);

            S.push(100);
            S.push(200);
            S.push(300);
            S.push(400); 
            S.push(500);
            

            Console.WriteLine("Values are : ");
            S.printStack();

            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();

        }
    }
}
