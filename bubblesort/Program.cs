using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace bubblesort
{
    public class Program
    {
        static void Main()
        {
            
            List<int> numbers = new List<int>();
            int count = 0;
            bool LoopRunner = false;

            Console.WriteLine("Enter a number, type 'EXIT' to quit and 'NEXT' to sorting:");

            while (!(LoopRunner))
            {
                string inputString = Console.ReadLine();

                if (inputString.ToLower() == "next")
                {

                    Stopwatch stopwatch = Stopwatch.StartNew();
                    BubbleSortAscending(numbers, count);

                    Console.WriteLine("Ascending Order:");
                    PrintList(numbers, count);

                    BubbleSortDescending(numbers, count);

                    Console.WriteLine("Descending Order:");
                    PrintList(numbers, count);
                    stopwatch.Stop();
                    Console.WriteLine("The total time: " + stopwatch.Elapsed.Ticks + " Ticks");
                    Console.ReadLine();
                    LoopRunner = true;
                }

                if (inputString.ToLower() == "exit")
                {
                    Console.WriteLine("Elements in the list:");
                    PrintList(numbers, count);
                    Console.ReadLine();
                    LoopRunner = true;
                }

                if (int.TryParse(inputString, out int inputNumber))
                {
                    if (numbers.Contains(inputNumber))
                    {
                        Console.WriteLine("The number you entered is already there. Enter a different number.");
                    }
                    else
                    {
                        numbers.Add(inputNumber);
                        count++;
                        Console.WriteLine("Number added to the list.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or type 'exit' to quit.");
                }
            }

            
        }

        public static void BubbleSortAscending(List<int> list, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortDescending(List<int> list, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length  - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintList(List<int> list, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
