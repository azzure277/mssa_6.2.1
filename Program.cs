namespace mssa_6._2._1
{
    internal class Program
    {
        
        ////stack using an array
        
        class ArrayStack
        {
            private int[] stack;
            private int top;
            private int capacity;

            public ArrayStack(int size)
            {
                capacity = size;
                stack = new int[capacity];
                top = -1;
            }

            public bool Push(int item)
            {
                if (top >= capacity - 1)
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
                stack[++top] = item;
                return true;
            }

            public int? Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return null;
                }
                return stack[top--];
            }

            public void Print()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                Console.Write("Stack elements: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.Write(stack[i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            ArrayStack stack = new ArrayStack(5);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Print();

            Console.WriteLine($"Popped: {stack.Pop()}");
            stack.Print();

            stack.Push(40);
            stack.Push(50);
            stack.Push(60); // Should show overflow
            stack.Print();

            // Pop all elements
            while (stack.Pop() != null) { }
            stack.Print();
        }
    }
}
