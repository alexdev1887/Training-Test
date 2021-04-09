using ARTest.TriangleCategorisation.Helper;
using ARTest.TriangleCategorisation.Shapes.Base;
using System;
using System.Linq;

namespace ARTest.TriangleCategorisation.Shapes
{
    internal class Triangle : ShapeBase
    {
        private HelpType.Triangle TriangleType { get; set; }
        internal Triangle(int sideA, int sideB, int sideC)
        {
            TriangleType = GetTriangleType(sideA, sideB, sideC);
        }

        internal override void ProcessingShape()
        {
            switch (TriangleType)
            {
                case HelpType.Triangle.Error:
                    Console.WriteLine("Errore: le lunghezze dei lati inseriti non è valida!");
                    break;
                case HelpType.Triangle.Equilateral:
                    Console.WriteLine("Triangolo equilatero.");
                    break;
                case HelpType.Triangle.Isosceles:
                    Console.WriteLine("Triangolo isoscele.");
                    break;
                case HelpType.Triangle.Scalene:
                    Console.WriteLine("Triangolo scaleno.");
                    break;
            }

            base.ProcessingShape();
        }

        private HelpType.Triangle GetTriangleType(int sideA, int sideB, int sideC)
        {

            int[] sides = new int[3] { sideA, sideB, sideC };

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return HelpType.Triangle.Error;
            }
            else if (sides.Distinct().Count() == 1) // La distinct produce un solo valore, quindi tutti i lati hanno la stessa lunghezza.
            {
                return HelpType.Triangle.Equilateral;
            }
            else if (sides.Distinct().Count() == 2) // La distinct produce solo due valori, quindi due lati sono uguali e uno no.
            {
                return HelpType.Triangle.Isosceles;
            }
            else if (sides.Distinct().Count() == 3) // La distinct produce tre valori, quindi nessun lato è uguale.
            {
                return HelpType.Triangle.Scalene;
            }
            else
            {
                return HelpType.Triangle.Error;
            }
        }

    }

}
