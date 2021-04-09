using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTest.TriangleCategorisation.Helper
{
    internal class HelpType
    {
        internal enum Triangle
        {
            Scalene = 1, // Non esistono due lati della stessa lunghezza 
            Isosceles = 2, // Due lati hanno la stessa lunghezza e uno è diverso
            Equilateral = 3, // Tutti i lati hanno la stessa lunghezza 
            Error = 4 // L'input non può produrre un triangolo 
        }
    }
}
