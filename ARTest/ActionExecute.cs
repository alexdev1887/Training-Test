using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ARTest.LinkedListTraversal;
using ARTest.LinkedListTraversal.Base;
using ARTest.TriangleCategorisation.Shapes;
using ARTest.TriangleCategorisation.Shapes.Base;
using ARTest.WordReversal;
using ARTest.WordReversal.Base;

namespace ARTest.TriangleCategorisation.Action
{
    internal static class ActionExecute
    {
        internal static void StartTriangleCategorisation()
        {
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;
            bool isNumber;

            Console.WriteLine("Inserisci lunghezza lato A (numero intero):");
            isNumber = int.TryParse(Console.ReadLine(), out int intResult_A);
            if (isNumber)
            {
                sideA = intResult_A;
            }

            Console.WriteLine("Inserisci lunghezza lato B (numero intero):");
            isNumber = int.TryParse(Console.ReadLine(), out int intResult_B);
            if (isNumber)
            {
                sideB = intResult_B;
            }

            Console.WriteLine("Inserisci lunghezza lato C (numero intero):");
            isNumber = int.TryParse(Console.ReadLine(), out int intResult_C);
            if (isNumber)
            {
                sideC = intResult_C;
            }

            ShapeBase shape = new Triangle(sideA, sideB, sideC);
            shape.ProcessingShape();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("TriangleCategorisation -> Terminato!");
        }
        internal static void StartWordReversal()
        {
            Console.WriteLine("Inserisci una parola:");
            string inputWord = Console.ReadLine();
            if (string.IsNullOrEmpty(inputWord))
            {
                Console.WriteLine("Errore: parola non valida!");
                return;
            }

            WordBase word = new Word(inputWord);
            word.ProcessingWord();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("WordReversal -> Terminato!");
        }
        internal static void StartLinkedListTraversal()
        {
            Console.WriteLine("Inserisci una lista di numeri INTERI separati dalla virgola (Esempio: 1,2,3,4):");
            string numbers = Console.ReadLine();
            var numberList = numbers.Trim().Split(',').ToList();

            if (numberList.Count < 5)
            {
                Console.WriteLine("Errore: la lista inserita non è valida, deve contenere almeno 5 numeri.");
                return;
            }

            LinkedList<int> linkedList = new();

            numberList.ForEach(number=> {
                number = number.Trim();
                bool isNumber = int.TryParse(number, out int intResult);
                if (isNumber)
                {
                    linkedList.AddLast(intResult);
                }
                else
                {
                    Console.WriteLine($"Attenzione: il numero {number} non valido, verrà ignorato.");
                    
                }
            });

            if (linkedList.Count < 5)
            {
                Console.WriteLine("Errore: la lista non è valida, dopo l'esclusione degli elementi ignorati non viene raggiunta la soglia minima di almeno 5 elementi numerici.");
                return;
            }

            LinkedListTraversalBase linkedListTraversal = new SingleLinkedListTraversal(linkedList,4);
            linkedListTraversal.ProcessingLinkedListTraversal();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("StartLinkedListTraversal -> Terminato!");
        }
    }
}
