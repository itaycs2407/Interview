using Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Program
    {
        static void Main(string[] args)
        {
            # region LinkedList
                Node n1 = new Node(4, null);
                Node n2 = new Node(3, n1);
                Node n3 = new Node(2, n2);
                Node n4 = new Node(1, n3);
                Node n5 = new Node(3, n4);
                Node n6 = new Node(34, n5);
                Node n7 = new Node(9, n6);
                Node n8 = new Node(0, n7);
                Node n9 = new Node(7, n8);
                Node n10 = new Node(-1, n9);
                Node n11 = new Node(6, n10);
                Node n12 = new Node(8, n11);
            // Console.WriteLine(n6);
            //Node res = LinkedListQuestion.removeDupNodeNaive(n6);
            // Node res1 = LinkedListQuestion.removeDupNodeHashSet(n6);
            //Console.WriteLine(res1);
            //Console.WriteLine(LinkedListQuestion.theKthFromTheEnd(n6,8));
            Console.WriteLine(n12);
            Console.WriteLine(LinkedListQuestion.partionList(n12, 6));
            Console.WriteLine(n12);
           // LinkedListQuestion.removeSpecificNode(n3);
            //Console.WriteLine(n6);


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
            #endregion


            Console.ReadLine();
        }
    }
}
