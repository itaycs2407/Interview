using System.Collections.Generic;

namespace Interview
{
    public  class superStack
    {
        public  Stack<int> mainStack = new Stack<int>();
        public  Stack<int> minStack = new Stack<int>();
        public  int? Pop()
        {
            if (mainStack.Count > 0)
            {
                if (minStack.Peek() == mainStack.Peek())
                {
                    minStack.Pop();
                }
                if (mainStack.Count >0 )
                {
                    return mainStack.Pop();
                }
            }
            return null;
        }
        public  void Push(int i_Data)
        {
            if (minStack.Count == 0 || minStack.Peek() > i_Data)  /**/
            {
                minStack.Push(i_Data);
            }
            mainStack.Push(i_Data);
        }
        public  int? Min()
        {
            if (minStack.Count >0)
            {
                return minStack.Peek();
            }
            return null;
        }

    }
}
