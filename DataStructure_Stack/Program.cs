using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            // stack.Push(null);
            // stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Clear();
            // stack.Pop();
        }
    }

    class Node
    {
        public object Val { get; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(object val)
        {
            this.Val = val ?? throw new InvalidOperationException("Node value cannot be null");
        }

    }

    class Stack
    {
        private Node _tail;

        public Stack()
        {
            _tail = null;
        }

        public Stack(object val)
        {
            _tail = new Node(val);
        }

        public void Push(object val)
        {
            var newNode = new Node(val);
            if (_tail == null) _tail = newNode;
            else
            {
                newNode.Previous = _tail;
                _tail.Next = newNode;
                _tail = _tail.Next;
            }
        }

        public object Pop()
        {
            if (_tail == null) throw new InvalidOperationException("Stack is empty");
            var pop = _tail;
            _tail = _tail.Previous;
            if (_tail != null) _tail.Next = null;
            return pop.Val;
        }

        public void Clear()
        {
            while (_tail != null)
            {
                _tail.Next = null;
                _tail = _tail.Previous;
            }
        }
    }
}
