using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class IntNode
    {
        private int data;
        private IntNode next;
        public int Data { get => data; set => data = value; }
        internal IntNode Next { get => next; set => next = value; }
        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }
    }
}
