using System;

namespace DataStructure_Stack
{
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
}