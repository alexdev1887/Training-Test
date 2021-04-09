using ARTest.TriangleCategorisation.Action;
using System;

namespace ARTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("##### Menu: premere il numero corrispondente per accedere al test ######");
            Console.WriteLine("Premi 0 - Uscita");
            Console.WriteLine("Premi 1 - Triangle Categorisation.");
            Console.WriteLine("Premi 2 - Word Reversal.");
            Console.WriteLine("Premi 3 - Linked List Traversal.");
            Console.WriteLine(Environment.NewLine);

            bool isNumber = int.TryParse(Console.ReadLine(), out int intResult);
            if (isNumber)
            {
                Console.Clear();
                switch (intResult)
                {
                    case 0:
                        Console.WriteLine("Uscita");
                        return;
                    case 1:
                        Console.WriteLine("##### Triangle Categorisation #####");
                        Console.WriteLine(Environment.NewLine);
                        ActionExecute.StartTriangleCategorisation();                      
                        break;
                     
                    case 2:
                        Console.WriteLine("##### Word Reversal #####");
                        Console.WriteLine(Environment.NewLine);
                        ActionExecute.StartWordReversal();
                        break;

                    case 3:
                        Console.WriteLine("##### Linked List Traversal #####");
                        Console.WriteLine(Environment.NewLine);
                        ActionExecute.StartLinkedListTraversal();
                        break;

                }
                Console.WriteLine("Premi un pulsante qualsiasi per tornare al menu.");
                Console.ReadKey();
                Main(args);
            }
            else
            {
                Console.WriteLine("Errore: scelta non valida!");
            }


        }


    }
}
