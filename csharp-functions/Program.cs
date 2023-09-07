using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                Console.WriteLine("Stampo l'array tramite funzione:");
                PrintArray(array);
            }
            Console.WriteLine();
            {
                int num = 100;
                Console.WriteLine("Numero al quadrato:");
                Console.WriteLine(SquaredNumber(num));
            }
            Console.WriteLine();
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

                Console.WriteLine("Array originale: ");
                PrintArray(array);
                Console.WriteLine();

                Console.WriteLine("elementi array al quadrato:");
                PrintArray(SquaringAllElementsOfAnArray(array));
                Console.WriteLine();

                Console.WriteLine("Array originale...qualche clonazione dopo:");
                PrintArray(array);
            }
            Console.WriteLine();
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                Console.WriteLine($"La somma di tutti gli elementi presenti nell'array è: { SummingAllElementsOfAnArray(array)}");
            }

            {
                Console.Write("Quanti numeri vuoi inserire nell'array? ");
                int userArrayLength = int.Parse(Console.ReadLine());

                int[] userArray = new int[userArrayLength];

                for (int i = 0; i < userArrayLength; i++)
                {
                    Console.Write($"Inserisci il {i + 1}° numero: ");
                    userArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                Console.WriteLine("Il tuo array originale:");
                PrintArray(userArray);
                Console.WriteLine();

                Console.WriteLine("Elementi del tuo array al quadrato:");
                PrintArray(SquaringAllElementsOfAnArray(userArray));
                Console.WriteLine();

                Console.WriteLine("Il tuo array originale...qualche clonazione dopo:");
                PrintArray(userArray);
                Console.WriteLine();

                Console.WriteLine($"La somma di tutti gli elementi presenti nel tuo array è: {SummingAllElementsOfAnArray(userArray)}");
            }
            


            // FUNZIONI

            //Stampa il contenuto di un array
            void PrintArray(int[] array)
            {
                Console.Write("[");

                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                }

                Console.WriteLine("]");
            }

            //Restituisce il quadrato del numero passato come parametro
            int SquaredNumber(int number)
            {
                int squared = number * number;
                return squared;
            }

            //Dato un array, ne retituisce uno nuovo con tutti gli elementi elevati al quadrato
            int[] SquaringAllElementsOfAnArray(int[] array)
            {
                int[] clonedAndSquared = (int[]) array.Clone();

                for (int i = 0; i < array.Length; i++)
                {
                    clonedAndSquared[i] = array[i] * array[i];
                }
                return clonedAndSquared;
            }

            //Restituisce la sommma totale di tutti gli elementi in un array
            int SummingAllElementsOfAnArray(int[] array)
            {
                int sum = 0;
                foreach (int element in array)
                {
                    sum += element;
                }
               
                return sum;
            }
        }
    }
}