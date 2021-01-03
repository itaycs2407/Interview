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
            return new Node();
        }
    }
}
    
