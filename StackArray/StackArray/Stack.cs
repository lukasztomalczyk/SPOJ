using System;

namespace stos
{
    class Stack
    {
        private int[] StackArray;
        private int index = 0;

        public Stack()
        {
            StackArray = new int[index];
        }

        public void Push(int item)
        {
            index++;
            Array.Resize(ref StackArray, index);
            StackArray[index-1] = item;
            Console.WriteLine("\nAdd item: {0}, on stack.", item);
        }

        public void Pop()
        {

            int x = StackArray[0];
            int[] tempArray = new int[index-1];
            
            for (int i = 0; i < index-1; i++)
            {
                tempArray[i] = StackArray[i+1];
            }
            
            Array.Resize(ref StackArray, --index);
            tempArray.CopyTo(StackArray, 0);

            Console.WriteLine("\nPop is: {0}", x);
        }

        public void ShowStack()
        {
            if(StackArray.Length>0)
            {
                Console.WriteLine("\nItem in stack: ");
                foreach (var item in StackArray)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Empty Array!");
            }
        }

    }
}