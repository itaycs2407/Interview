using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static class StackQuestion
    {
        public static Stack<int> SortStack(Stack<int> i_Stack)
        {
            Stack<int> buffer = new Stack<int>();
            int currentMax, currentSorted = 0;
            for (int i = 0; i < i_Stack.Count ; i++)
            {
                currentMax = i_Stack.Pop();
                while (i_Stack.Count > currentSorted)
                {
                    if (i_Stack.Peek() > currentMax)
                    {
                        buffer.Push(currentMax);
                        currentMax = i_Stack.Pop();
                    }
                    else
                    {
                        buffer.Push(i_Stack.Pop());
                    }
                }
                i_Stack.Push(currentMax);
                currentSorted++;
                while (buffer.Count > 0)
                {
                    i_Stack.Push(buffer.Pop());
                } 
            }

            return i_Stack;
        }

       
    }
}
