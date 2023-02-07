using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Generics
    {
        public static void Engage()
        {
            int first = 20;
            int second = 30;

            Swap(ref first, ref second);
            Console.WriteLine("first: "+ first);
            Console.WriteLine("second: " + second);

            float hamburger = 3.66f;
            float cheeseburger = 5.77f;

            Swap<float>(ref hamburger, ref cheeseburger);
            Console.WriteLine("hamburger: " + hamburger);
            Console.WriteLine("cheeseburger: "+ cheeseburger);

            Swap<int>(ref first, ref second);

            List<int> list = new List<int>();

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        static void Swap<G>(ref G first, ref G second)
        {
            G temp = first; //generic type , can swap G with anything like <pizza>
            first = second;
            second = temp;
        }
    }

    class Stack<T>
    {
        int index = 0;
        T[] elements = new T[100];

        public void Push(T element)
        {
            elements[index++] = element;
        }

        //Generic class alows us to use any type 
        //Push and pop any item on and of the list
        //First in last out 
        public T Pop()
        {
            if (index > 0)
            {
                return elements[--index];
            }
            return default(T);
        }
    }
}
