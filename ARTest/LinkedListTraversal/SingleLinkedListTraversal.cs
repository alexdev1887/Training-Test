using ARTest.LinkedListTraversal.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ARTest.LinkedListTraversal
{
    internal class SingleLinkedListTraversal : LinkedListTraversalBase
    {
        private int ResultNumber { get; set; }
        internal SingleLinkedListTraversal(LinkedList<int> linkedList, int atIndex)
        {
            LinkedList = linkedList;
            ResultNumber = GetLinkedListLastElement(atIndex);
        }

        private int GetLinkedListLastElement(int atIndex)
        {
            int result = LinkedList.Reverse().ElementAtOrDefault(atIndex);
            
            return result;
        }

        internal override void ProcessingLinkedListTraversal()
        {
            Console.WriteLine($"Il quinto numero intero a partire dalla fine è: {ResultNumber}");
            base.ProcessingLinkedListTraversal();
        }
    }
}
