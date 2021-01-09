using System;
using System.Collections.Generic;

namespace Interview
{
    public static class LinkedListQuestion
    {
        public static Node removeDupNodeNaive(Node i_Head)
        {
            if (i_Head == null)
            {
                return i_Head;
            }
            Node temp = new Node(i_Head);
            Node prev = new Node(i_Head);
            Node currentNode;// = new Node(temp.next);
            while (temp.next != null)
            {
                currentNode = temp.next;
                prev = temp;
                while (currentNode !=null)
                {
                    if(temp.data == currentNode.data)
                    {
                        prev.next = currentNode.next;
                    }
                    else
                    {
                        prev = prev.next;
                    }
                    currentNode = currentNode.next;
                }
                temp = temp.next;
            }
            return i_Head;
        }
        public static Node removeDupNodeHashSet(Node i_Head)
        {
            HashSet<int> hs = new HashSet<int>();
            if (i_Head == null || i_Head.next == null)
            {
                return i_Head;
            }
            Node runner = new Node();
            runner = i_Head.next;
            Node prev = new Node(i_Head);
            hs.Add(i_Head.data);
            while (runner !=null)
            {
                if (!hs.Contains(runner.data))
                {
                    hs.Add(runner.data);
                    prev = prev.next;
                }
                else
                {
                    prev.next = runner.next; 
                }
                runner = runner.next;

            }
            return i_Head;
        }
        public static Node theKthFromTheEnd(Node i_Head, int k)
        {
            int counter = 1;
            Node runner = new Node(i_Head);
            while (runner!=null && counter < k)
            {
                runner = runner.next;
                counter++;
            }
            if (runner == null) // the list is shorter than k elemnts
            {
                return null;
            }
            Node result = new Node(i_Head);
            while (runner.next!=null)
            {
                result = result.next;
                runner = runner.next;
            }
            return result;


        }
        public static void removeSpecificNode(Node toRemove)
        {
            // assume that the node is in the list.
            // wrong solution : 
            /*
            while (toRemove.next !=null)
            {
                toRemove.data = toRemove.next.data;
                toRemove = toRemove.next;
                if(toRemove.next.next == null)
                {
                    toRemove.data = toRemove.next.data;
                    toRemove.next = null;
                }
            }*/

            Node next = new Node(toRemove.next);
            toRemove.data = next.data;
            toRemove.next = next.next;
        }

        public static Node partionList(Node i_Head, int i_Value)
        {
            Node head = new Node(); 
            Node tail; 
            Node runner = new Node(i_Head);
            Node newNode = new Node();
            tail = newNode;
            while (runner!= null)
            {
                newNode.data = runner.data;
                
                if  (runner.data < i_Value)
                {
                    

                    newNode.next = head.next;
                    head.next = newNode;

                }
                else
                {
                    tail.next = newNode;
                    if (runner.next == null)
                    {
                        tail.next = null;
                    }
                    else
                    {
                        tail = newNode;
                    }
                }

                newNode = new Node();
                runner = runner.next;
            }
            
            return head.next;
        }
            
        public static bool isPlaindrom(Node i_Head)
        {
            if (i_Head == null)
            {
                return false;
            }

            Node runner = new Node(i_Head);
            Stack<int> st = new Stack<int>();
            int counter = 0;
            
            while (runner !=null)
            {
                counter++;
                st.Push(runner.data);
                runner = runner.next;
            }
            counter /= 2;
            runner = i_Head;
            
            for (int i = 0; i < counter; i++)
            {
                if (st.Pop() != runner.data)
                {
                    return false;
                }
                runner = runner.next;
            }

            return true;
        }
       
        public static int sumLists(Node i_Head)
        {
            Node runner = new Node(i_Head);
            int nodeCounter = 0;
            while (runner !=null)
            {
                nodeCounter++;
                runner = runner.next;
            }
            Node runnerOne = new Node(i_Head);
            Node runnerTwo = new Node(i_Head);
            for (int i = 0; i < nodeCounter/2; i++)
            {
                runnerTwo = runnerTwo.next;
            }
            int sum1 = 0, sum2 = 0,  multiplyer = (int)Math.Pow(10, nodeCounter/2 - 1);
            for (int i = 0; i < nodeCounter/2; i++)
            {
                sum1 += addNewSum(runnerOne.data, multiplyer);
                sum2 += addNewSum(runnerTwo.data, multiplyer);
                runnerOne = runnerOne.next;
                runnerTwo = runnerTwo.next;
                multiplyer /= 10;

            }
            return sum1+sum2;
        }

        private static int addNewSum(int i_Data, int i_Multiplyer)
        {
            return i_Data * i_Multiplyer;
        }

        public static Node reveresList(Node i_Head)
        {
            if (i_Head == null)
            {
                return null;
            }
            Node newHead = new Node();
            Node runner = new Node(i_Head);
            while (runner != null)
            {
                Node newNode = new Node();
                newHead.data = runner.data;
                newNode.next = newHead;
                newHead = newNode;
                runner = runner.next;
            }

            return newHead.next;
        }

        public static int? intersection(Node one, Node two)
        {
            if (one == null || two == null)
            {
                return -1;
            }
            int lOne = 0, lTwo = 0;
            if (getLastValue(one, ref lOne) != getLastValue(two, ref lTwo)) // there is no intersection
            {
                return -1;
            }
            if (lOne > lTwo)
            {
                for (int i = 0; i < lOne - lTwo ; i++)
                {
                    one = one.next;
                }
            }
            else
            {
                for (int i = 0; i < lTwo - lOne; i++)
                {
                    two = two.next;
                }
            }
            int? res = null;
            while (one != null && !(res!=null))
            {
                if (one.data == two.data)
                {
                    res = one.data;
                }
                one = one.next;
                two = two.next;
            }
            return res;
        }

        private static int getLastValue(Node list, ref int counter)
        {
            while (list.next !=null)
            {
                list = list.next;
                counter++;
            }
            return list.data;
        }

        public static int getCircleStart(Node i_Head)
        {
            Node l1, l2;
            l1 = i_Head;
            l2 = i_Head.next;
            while (l1 !=null && l2 != null)
            {
                l1 = l1.next;
                l2 = l2.next.next;
                if (l1.data == l2.data)
                {
                    break;
                }
            }
            if (l1 == null || l2 == null )
            {
                return -1; // no collision and one of the runner reach to end of the list
            }
            while (i_Head.data != l1.data)
            {
                i_Head = i_Head.next;
                l1 = l1.next;
            }
            return i_Head.data;

        }
    }
}
    
