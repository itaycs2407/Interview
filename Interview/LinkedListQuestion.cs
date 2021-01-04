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
            Node tail = head;
            Node runner = new Node(i_Head);
            while (runner.next != null)
            {
                Node newNode = new Node();
                newNode.data = runner.data;
                
                if  (runner.data < i_Value)
                {
                    newNode.next = head;
                    head = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }

                runner = runner.next;
            }
            return head;
        }
            
       
    }
}
    
