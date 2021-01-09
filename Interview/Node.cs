using System;
namespace Interview
{
    public class Node
    {/*
        public override string ToString()
        {
            Node runner = new Node(this);
            while (runner.next != null)
            {
                Console.Write(string.Format($"{runner.data.ToString()} -> "));
                runner = runner.next;
            }
            Console.WriteLine(runner.data.ToString());

            return string.Empty;
        }
        */
        public int data;
        public Node next;
        public Node()
        { }
        public Node(Node node)
        {
            this.data = node.data;
            this.next = node.next;
        }
        public Node(int i_data)
        {
            this.data = i_data;
            this.next = null; 
        }
        public Node(int i_data, Node nextNode)
        {
            this.data = i_data;
            this.next = nextNode;
        }
    }
}
    
