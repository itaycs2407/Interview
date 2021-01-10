using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    public class PlateStack
    {
        public int currentStack;
        public readonly int stackSize;
        List<Stack<int>> stackList;
        public PlateStack(int i_StackSIZE)
        {
            this.currentStack = 0;
            this.stackSize = i_StackSIZE;
            this.stackList = new List<Stack<int>>();
            stackList.Add(new Stack<int>());
        }

        public void Push(int i_Data)
        {
            if (stackList[currentStack].Count +1 <= stackSize) // has enogth room in the current stack
            {
                stackList[currentStack].Push(i_Data);
            }
            else // current stack is full - need to create another stack 
            {
                Stack<int> newStack = new Stack<int>();
                newStack.Push(i_Data);
                stackList.Add(newStack);
                currentStack++;
            }
        }

        public int? Pop()
        {
            int resultItem;
            if ((stackList.Count==0) || (stackList.Count == 1 && stackList[0].Count == 0))
            {
                return null;
            } 
            else if (stackList[currentStack].Count  < 2)
            {
                resultItem = stackList[currentStack].Pop();
                stackList.Remove(stackList[currentStack]);
                currentStack--;
            }
            else
            {
                resultItem = stackList[currentStack].Pop();
            }
            return resultItem;
        }
        public string WhereMyPosition()
        {
            return string.Format($"Stack : {currentStack}, Elemnt : {stackList[currentStack].Count}");
        }

    }

}
