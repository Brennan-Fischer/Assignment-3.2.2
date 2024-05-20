using System.Drawing;

namespace Assignment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Input preffered length of square array up to 5");

            size = Convert.ToInt32(Console.ReadLine());
            int[,] myArray1 = new int[size, size];
            int[,] myArray2 = new int[size, size];
            int[,] myArray3 = new int[size, size];

            Console.WriteLine("The following prompts are to set the values in Array 1");
            myArray1 = myMethods.setArray(size);
            Console.WriteLine("The following prompts are to set the values in Array 2");
            myArray2 = myMethods.setArray(size);
            Console.WriteLine("Array 1 is set to the following values:");
            myMethods.printArray(size, myArray1);
            Console.WriteLine("Array 2 is set to the following values:");
            myMethods.printArray(size, myArray1);
            myArray3 = myMethods.addArray(size, myArray1, myArray2);
            Console.WriteLine("Array 1 + Array 2 is equal to:");
            myMethods.printArray(size, myArray3);


        }

        public class myMethods
        {
            public static int[,] setArray(int size)
            {
                int[,] myArray = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.WriteLine($"Input element [{i}] [{j}] for Array");
                        myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return myArray;

            }
            public static void printArray(int size, int[,] myArray)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(myArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                return;

            }
            public static int[,] addArray(int size, int[,] myArray1, int[,] myArray2)
            {
                int[,] myArray3 = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        myArray3[i, j] = myArray1[i, j] + myArray2[i, j];
                    }

                }
                return myArray3;


            }
        }
    }
}

    

