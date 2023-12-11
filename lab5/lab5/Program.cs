
using lab5;
using System.Security.Cryptography.X509Certificates;

namespace DSLKDon
{
    class Program
    {
        static void TestInput()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine($"count: {list.Count()}, DSLK so nguyen:");
            list.ShowList();
        }
        static void TestSearchnode()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            Console.WriteLine("node can tim: ");
            int node = int.Parse(Console.ReadLine());
            IntNode result = list.SearchNodeX(node);
            if (result == null)
            {
                Console.WriteLine($">>node k ton tai {node}");
            }
            else
            {
                Console.WriteLine($">>node ton tai");
            }
        }
        static void TestMax()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            IntNode result = list.GetMax();
            Console.WriteLine($"Node max: {result.Data}");
        }
        static void TestMin()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            IntNode result = list.GetMin();
            Console.WriteLine($"Node min: {result.Data}");
        }
        static void TestEvenlist()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            MyList result = list.GetEvenList();
            Console.WriteLine(">>dslk so chan:");
            result.ShowList();
        }
        static void TestOddList()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            MyList result = list.GetOddList();
            Console.WriteLine(">>dslk so le:");
            result.ShowList();
        }
        static void TestJoinList()
        {
            Console.WriteLine(">>list1");
            MyList list1 = new MyList();
            list1.Input();
            Console.WriteLine("DSLK so nguyen:");
            list1.ShowList();
            Console.WriteLine(">>list2");
            MyList list2 = new MyList();
            list2.Input();
            Console.WriteLine("DSLK so nguyen:");
            list2.ShowList();
            MyList list3 = MyList.JoinList(list1, list2);
            Console.WriteLine(">>dslk list 3");
            list3.ShowList();
        }
        static void TestRemove()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            Console.WriteLine("nhap node can xoa: ");
            int node = int.Parse(Console.ReadLine());
            bool kq = list.RemoveX(node);
            if (kq == false)
            {
                Console.WriteLine($"node co gia tri:{node} khong ton tai");
            }
            else
            {
                Console.WriteLine("DSLK so nguyen sau khi xoa :");
                list.ShowList();
            }
        }
        static void TestRemoveIndex()
        {

            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            Console.WriteLine("nhap index cua node can xoa: ");
            int node = int.Parse(Console.ReadLine());
            bool kq = list.RemoveXat(node);
            if (kq == false)
            {
                Console.WriteLine($"index co gia tri:{node} khong ton tai");
            }
            else
            {
                Console.WriteLine("DSLK so nguyen sau khi xoa :");
                list.ShowList();
            }
        }
        static void TestThemsauMin()
        {

            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            list.InsertXAfterMin();
            Console.WriteLine("sau khi them: ");
            list.ShowList();
        }
        static void TestThemtruocMax()
        {

            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            list.InsertXBeforeMax();
            Console.WriteLine("sau khi them: ");
            list.ShowList();
        }
        static void TestThemsauY()
        {

            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            list.InsertXAfterY();
            Console.WriteLine("sau khi them: ");
            list.ShowList();
        }
        static void TestThemtruocY()
        {

            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            list.InsertBeforeY();
            Console.WriteLine("sau khi them: ");
            list.ShowList();
        }
        static void TestShiftleft()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            MyList list2 = list.Shiftleft();
            Console.WriteLine("Sau khi shiftleft");
            list2.ShowList();

        }
        static void TestShiftRight()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            MyList list2 = list.RShiftRight();
            Console.WriteLine("Sau khi shiftright");
            list2.ShowList();

        }
        static void Main(string[] args)
        {
            //TestInput();
            //TestSearchnode();
            //TestMax();
            //TestMin();
            //TestEvenlist();
            // TestOddList();
            //TestJoinList();
            //TestRemove();
            //TestRemoveIndex();
            //TestThemsauMin();
            //TestThemtruocMax();
            //TestThemsauY();
            //TestThemtruocY();
            // TestShiftleft();
            TestShiftRight();
        }
    }
}