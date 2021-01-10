using Interview;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            /*
                Node n1 = null;
                Node n2 = new Node(5, n1);
                Node n3 = new Node(4, n2);
                Node n4 = new Node(3, n3);
                Node n5 = new Node(2, n4);
                Node n6 = new Node(1, n5);
                n1 = new Node(6, n6);
                Node n7 = new Node(0, n6); // one
                Node n8 = new Node(9, n3);
                Node n9 = new Node(8, n8);
                Node n10 = new Node(7, n9); // two
                Node n11 = new Node(6, n10);
                Node n12 = new Node(8, n11);
            // Node res = LinkedListQuestion.removeDupNodeNaive(n6);
            // Node res1 = LinkedListQuestion.removeDupNodeHashSet(n6);
            // Console.WriteLine(res1);
            // Console.WriteLine(LinkedListQuestion.theKthFromTheEnd(n6,8));
            // Console.WriteLine(LinkedListQuestion.partionList(n12, 6));
            // LinkedListQuestion.removeSpecificNode(n3);
            // Console.WriteLine(LinkedListQuestion.isPlaindrom(n11));
            // Console.WriteLine(LinkedListQuestion.sumLists(n6));
            // Console.WriteLine(LinkedListQuestion.reveresList(n6));
            // Console.WriteLine(LinkedListQuestion.partionList(n7,5));
            //Console.WriteLine(LinkedListQuestion.intersection(n7,n10));
            Console.WriteLine(LinkedListQuestion.getCircleStart(n6));*/
            #endregion
            #region String
            // Console.WriteLine(StringQuestion.stringCompression("aaabbccccccvfffg"));
            // Console.WriteLine(StringQuestion.isPolyndromPermutation("tactpoop coa"));
            // Console.WriteLine(StringQuestion.oneAway("pale", "ple"));
            // Console.WriteLine(StringQuestion.oneAway("pales", "pale"));
            // Console.WriteLine(StringQuestion.oneAway("pale", "bae"));
            // Console.WriteLine(StringQuestion.oneAway("apple", "aplh"));
            #endregion
            #region Mathematics
            // Console.WriteLine(mathematics.findNextSqure(15241383936));
            // Console.WriteLine(Mathematics.withoutConsecutiveOnes(5));
            #endregion
            #region Stacks
            /*
             
                superStack s = new superStack();
                s.Push(5);
                s.Push(4);
                Console.WriteLine(s.Min().ToString());
                s.Push(3);
                s.Push(1);
                s.Push(8);
                Console.WriteLine(s.Min().ToString());
                s.Push(2);
                s.Push(0);
                Console.WriteLine(s.Min().ToString());
                s.Pop();
                Console.WriteLine(s.Min().ToString());
            *//*
            PlateStack ps = new PlateStack(3);
            ps.Push(5);
            ps.Push(4);
            Console.WriteLine(ps.WhereMyPosition());
            ps.Push(3);
            ps.Push(1);
            Console.WriteLine(ps.WhereMyPosition());
            ps.Push(8);
            ps.Push(2);
            ps.Push(0);
            Console.WriteLine(ps.WhereMyPosition());
            ps.Pop();
            Console.WriteLine(ps.WhereMyPosition());*/
            /*
            Stack<int> st = new Stack<int>();
            st.Push(9);
            st.Push(2);
            st.Push(4);
            st.Push(1);
            st.Push(0);
            Console.WriteLine(StackQuestion.SortStack(st));
            */
            #endregion
            
            Console.ReadLine();
        }
    }


}
