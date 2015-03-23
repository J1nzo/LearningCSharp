using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int sortType;
            List<int> array = new List<int>();

            do
            {
                Console.WriteLine("[#] Enter your array size [5..20]:");
                size = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (size > 20 || size < 5);
            array = ReadArray(size);
            sortType = ReadSortType();
            switch (sortType)
            {
                case 1: BubbleSort(array);
                    break;
                case 2: SelectionSort(array);
                    break;
                case 3: InsertionSort(array);
                    break;
            }
            PrintArray(array);

            Console.WriteLine("press <any> key to exit");
            Console.ReadKey();
        }
        static List<int> ReadArray(int size)
        {
            List<int> array = new List<int>();
            // Fill Array with zeros
            for (int i = 0; i < size; i++)
            {
                array.Add(0);
            }
            // Reading Array elements
            for (int i = 0; i < size; i++)
            { 
                Console.Clear();
                PrintArray(array);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("[INPUT] Enter element #{0}:\t", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            return array;
        }
        static int ReadSortType()
        {
            string options;
            string choice;
            options = "[1] Bubble Sort\n";
            options += "[2] Selection Sort\n";
            options += "[3] Insertion Sort\n";

            do
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(options);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("[INPUT] Choose a sorting Algorithm:\t");
                choice = Console.ReadLine();
                Console.WriteLine("You entered: {0}", choice);
                Console.ReadKey();
            } while (choice!="1" && choice!="2" && choice!="3");
            return Convert.ToInt32(choice);
        }
        static void BubbleSort(List<int> array)
        {
            bool permutation;
            int comparisions = 0;
            int permutations = 0;
            
            do
            {
                permutation = false;
                for (int i = 0; i < array.Count - 1; i++)
                {
                    Console.Clear();
                    PrintArray(array);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    comparisions++;
                    Console.WriteLine("Comparisions: {0}\t Permuations: {1}", comparisions, permutations);
                    if (array[i] < array[i + 1])
                    {
                        array[i] += array[i + 1];
                        array[i + 1] = array[i] - array[i + 1];
                        array[i] -= array[i + 1];
                        permutation = true;
                        permutations++;
                    }
                    System.Threading.Thread.Sleep(100);
                }
            } while (permutation);
        }
        static void SelectionSort(List<int> array)
        {
            int max;
            int permutations = 0;
            int comparisions = 0;
            for (int i = 0; i < array.Count - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < array.Count; j++)
                {
                    Console.Clear();
                    PrintArray(array);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    comparisions++;
                    Console.WriteLine("Comparisions: {0}\t Permuations: {1}", comparisions, permutations);
                    if (array[j]>array[max])
                    {
                        max = j;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                if (array[i] < array[max])
                {
                    array[i] += array[max];
                    array[max] = array[i] - array[max];
                    array[i] -= array[max];
                    permutations++;
                }
            }
        }
        static void InsertionSort(List<int> array)
        {
            int j;
            int comparisions = 0;
            int permutations = 0;

            for (int i = 1; i < array.Count; i++)
            {
                j = i;
                while (j > 0 && array[j]>array[j-1])
                {
                    Console.Clear();
                    PrintArray(array);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    comparisions++;
                    Console.WriteLine("Comparisions: {0}\t Permuations: {1}", comparisions, permutations);
                    array[j-1] += array[j];
                    array[j] = array[j-1] - array[j];
                    array[j-1] -= array[j];
                    j -= 1;
                    permutations++;
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        static void PrintArray(List<int> array)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your array content:");
            foreach (int e in array)
            {
                Console.Write("[{0}]\t", e);
            }
            Console.WriteLine();
        }
    }
}
