using System;

namespace ExceptionStack1
{
    class StackException : Exception
    {
        public StackException() : base(String.Format("Stack Overflow or Underflow")) { }
    }

    class StackOperations
    {
        int[] stack;
        int topOfStack, sizeOfStack;

        public StackOperations(int size)
        {
            this.sizeOfStack = size;
            this.stack = new int[sizeOfStack];
            this.topOfStack = -1;
        }

        public void Push(int value)
        {
            if (this.topOfStack == this.sizeOfStack - 1)
                throw new StackException();
            else
                this.stack[++this.topOfStack] = value;
        }

        public void Pop()
        {
            if (this.topOfStack == -1)
                throw new StackException();
            else
            {
                Console.WriteLine("{0} popped...", this.stack[this.topOfStack]);
                this.topOfStack--;
            }
        }

        public void DisplayStack()
        {
            Console.WriteLine("\nValues in Stack: ");
            if (topOfStack > -1)
            {
                for (int i = 0; i <= topOfStack; i++)
                {
                    Console.Write("{0} ", stack[i]);
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Stack Empty...");
        }

        static void main()
        {
            Console.WriteLine("Enter the size of the stack");
            int size = Convert.ToInt32(Console.ReadLine());
            int ch = 0;

            StackOperations obj = new StackOperations(size);

            do
            {
                Console.WriteLine("\n1. Push\n2. Pop\n3. Display Stack\n4. Exit\n");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter a value to be pushed...");
                        int value = Convert.ToInt32(Console.ReadLine());
                        obj.Push(value);
                        break;
                    case 2:
                        obj.Pop();
                        break;
                    case 3:
                        obj.DisplayStack();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;
                }
            }
            while (ch != 4);
        }
    }
}