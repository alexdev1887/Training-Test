using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTest.TriangleCategorisation.Shapes.Base
{
    internal class ShapeBase
    {
        internal virtual void ProcessingShape()
        {
            Console.WriteLine("Elaborazione forma eseguita.");
        }
    }
}
