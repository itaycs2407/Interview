using System.Collections.Generic;

namespace Interview
{
    public class QueueViaStack 
    {
        public Stack<int> s1, s2;
        public QueueViaStack()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }
        public int? Pop()
        {
            if (s1.Count == 0)
            {
                return null;
            }
            
            while (s1.Count > 0 )
            {
                s2.Push(s1.Pop());
            }
            int result = s2.Pop();
            while (s2.Count > 0 )
            {
                s1.Push(s2.Pop());
            }
            return result;

        }
        public void Push(int i_Data)
        {
            s1.Push(i_Data);
        }
    }


}
