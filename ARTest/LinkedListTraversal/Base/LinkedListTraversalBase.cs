using System;
using System.Collections.Generic;

namespace ARTest.LinkedListTraversal.Base
{
    internal class LinkedListTraversalBase
    {
        protected LinkedList<int> LinkedList { get; set; }
        internal virtual void ProcessingLinkedListTraversal()
        {
            Console.WriteLine("Elaborazione linked list eseguita.");
        }
    }
}
