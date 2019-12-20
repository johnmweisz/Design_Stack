using System;

namespace DataStructure_Stack
{
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
            var pop = _tail.Val;
            _tail = _tail.Previous;
            if (_tail != null) _tail.Next = null;
            return pop;
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