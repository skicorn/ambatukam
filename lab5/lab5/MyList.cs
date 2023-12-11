using lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class MyList
    {
        private IntNode first;
        private IntNode last;
        internal IntNode First { get => first; set => first = value; }
        internal IntNode Last { get => last; set => last = value; }
        public MyList()
        {
            first = null;
            last = null;
        }

        //method
        private bool IsEmpty() { return first == null; }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty()) first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (first == null)
                first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        /*public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                x=int.Parse(Console.ReadLine());
                if (x == 0) 
                    return;
                IntNode intNode = new IntNode(x);
                AddFirst(intNode);
            }
            while (true);
        }*/
        public void Input()
        {

            int x;
            do
            {
                do
                {
                    Console.Write("Gia tri (0 ket thuc): ");
                    x = int.Parse(Console.ReadLine());
                    if (x == 0) return;
                    if (SearchNodeX(x) != null)
                    {
                        Console.WriteLine("node da ton tai, nhap lai");
                    }
                    else break;
                } while (true);
                IntNode intNode = new IntNode(x);
                AddFirst(intNode);
            }
            while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        //Search node X

        //Getmax
        public IntNode GetMax()
        {
            IntNode max = first;
            for (IntNode p = first.Next; p != null; p = p.Next)
            {
                if (max.Data < p.Data)
                    max = p;
            }
            return max;
        }
        //Getmin
        public IntNode GetMin()
        {
            IntNode min = first;
            for (IntNode p = first.Next; p != null; p = p.Next)
            {
                if (min.Data > p.Data) min = p;
            }
            return min;
        }
        //Get even node
        public MyList GetEvenList()
        {
            MyList evenList = new MyList();
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data % 2 == 0)
                {
                    evenList.AddFirst(new IntNode(p.Data));
                }
            }
            return evenList;
        }
        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data % 2 != 0)
                {
                    oddList.AddFirst(new IntNode(p.Data));
                }
            }
            return oddList;
        }
        public static MyList JoinList(MyList list1, MyList list2)
        {
            MyList join = new MyList();
            for (IntNode p = list1.First; p != null; p = p.Next)
            {
                join.AddLast(new IntNode(p.Data));
            }
            for (IntNode p = list2.First; p != null; p = p.Next)
            {
                join.AddLast(new IntNode(p.Data));
            }
            return join;
        }
        //sort

        #region "Search"
        public IntNode MinNode(IntNode value)
        {
            IntNode min = value;
            for (IntNode p = value.Next; p != null; p = p.Next)
            {
                if (p.Data < min.Data)
                {
                    min = p;
                }
            }
            return min;
        }
        public IntNode SearchNodeX(int x)
        {
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data == x) return p;
            }
            return null;
        }
        public IntNode PreviosX(IntNode p)
        {
            if (p == first)
                return null;
            IntNode pPre = first;
            while (pPre.Next != p)
            {
                p = pPre.Next;
            }
            return p;
        }
        #endregion
        public int Count()
        {
            int count = 0;
            for (IntNode p = first; p != last; p = p.Next)
            {
                count++;
            }
            return count;
        }
        #region "Delete"
        //Remove X at is
        public void DeletePX(IntNode p)
        {
            if (p == first && p == last)
                first = last = null;
            else if (p == last)
            {
                IntNode pTruoc = PreviosX(p);
                pTruoc.Next = null;
                last = pTruoc;
            }
            else
            {
                IntNode pSau1 = p.Next;
                IntNode pSau2 = pSau1.Next;
                p.Data = pSau1.Data;
                p.Next = pSau2;
                p = pSau1;
            }
            p = null;
        }
        public bool RemoveX(int i)
        {
            IntNode node = SearchNodeX(i);
            if (node == null)
                return false;
            DeletePX(node);
            return true;
        }

        public IntNode NodeXat(int index)
        {
            IntNode p = First;
            if (index < 0 || index > Count())
            {
                return null;
            }
            int i = 0;
            while (i < index)
            {
                p = p.Next;
                i++;
            }
            return p;
        }
        public bool RemoveXat(int index)
        {
            IntNode node = NodeXat(index);
            if (node == null)
                return false;
            DeletePX(node);
            return true;
        }
        #endregion
        #region "add"
        public void InsertAfter(IntNode node, IntNode nodeNew)
        {
            if (node == last) AddLast(nodeNew);
            else
            {
                nodeNew.Next = node.Next;
                node.Next = nodeNew;
            }
        }
        public void InsertBefore(IntNode node, IntNode nodeNew)
        {
            InsertAfter(node, nodeNew);
            Swap(node, nodeNew);
        }
        public void InsertXAfterMin()
        {
            Console.WriteLine("nhap gia tri cho node them: ");
            int x = int.Parse(Console.ReadLine());
            IntNode node = new IntNode(x);
            InsertAfter(GetMin(), node);
        }
        public void InsertXBeforeMax()
        {
            Console.WriteLine("nhap gia tri cho node them: ");
            int x = int.Parse(Console.ReadLine());
            IntNode node = new IntNode(x);
            InsertBefore(GetMax(), node);
        }
        public void InsertXAfterY()
        {
            Console.WriteLine("nhap gia tri node: ");
            int y = int.Parse(Console.ReadLine());
            IntNode node1 = SearchNodeX(y);
            Console.WriteLine("nhap gia tri cho node them: ");
            int x = int.Parse(Console.ReadLine());
            IntNode node = new IntNode(x);
            InsertAfter(node1, node);
        }
        public void InsertBeforeY()
        {
            Console.WriteLine("nhap gia tri node: ");
            int y = int.Parse(Console.ReadLine());
            IntNode node1 = SearchNodeX(y);
            Console.WriteLine("nhap gia tri cho node them: ");
            int x = int.Parse(Console.ReadLine());
            IntNode node = new IntNode(x);
            InsertBefore(node1, node);
        }
        #endregion
        #region "Shift"
        public MyList Shiftleft()
        {
            MyList shiftleft = new MyList();
            for (IntNode p = First.Next; p != null; p = p.Next)
            {
                shiftleft.AddLast(new IntNode(p.Data));
            }
            return shiftleft;
        }
        public MyList RShiftRight()
        {
            MyList shiftleft = new MyList();
            for (IntNode p = First; p != Last; p = p.Next)
            {
                shiftleft.AddLast(new IntNode(p.Data));
            }
            shiftleft.AddFirst(new IntNode(Last.Data));
            return shiftleft;
        }

        #endregion
        #region "Sort"
        public void SelectionSort()
        {
            for (IntNode p = first; p != null; p = p.Next)
            {
                IntNode min = MinNode(p);
                Swap(min, p);
            }
        }
        public void Swap(IntNode n1, IntNode n2)
        {
            int temp = n1.Data;
            n1.Data = n2.Data;
            n2.Data = temp;
        }
        #endregion
    }
}
