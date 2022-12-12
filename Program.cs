using System;
using System.Linq;

namespace Arrays_sort_random_scanner_etc
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[,] matrix = new int[10, 10];
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(0, 100);

                }

            }

            // #0 odd numbers from 1 to 99
            int[] oddMatrix = new int[100];
            Console.WriteLine("\nThe list of odd values from 1 to 99 is:\n");
            PrintOddNumbers(oddMatrix);


            // #1 reverse an array from 1 to 5
            int[] fiveMatrix = { 1, 2, 3, 4, 5 };
            PrintReverseMatrix(fiveMatrix);


            // #2 sum of all elements between 1 and user's value
            Console.Write("Insert a value to find a sum of all elements\nentered in an array before a certain value:\t"); // #3
            ulong userIput = Convert.ToUInt64(Console.ReadLine()); ;
            uint[] matrixResult = new uint[userIput];
            SumOfElemensByUserInput(matrixResult);


            // #3 check if an array contains a certain value - same as Exists()
            Console.Write("Enter a value to check if an array contains it :\t"); // #5
            int userValue = int.Parse(Console.ReadLine());
            int[] matrixRandValue = new int[10];
            for (int i = 0; i < matrixRandValue.Length; i++)
            {
                matrixRandValue[i] = rnd.Next(0, 100);
                Console.Write(matrixRandValue[i] + "\t");

            }
            Console.WriteLine();
            if (matrixRandValue.Contains(userValue))
            {
                Console.WriteLine("The array contains a value {0}", userValue);

            }
            else Console.WriteLine("Sorry, the array does NOT contain a certain value {0}\n", userValue);


            // #4 Arithmetic mean, Max and Min, an array sized by user input
            Console.Write("Insert number of elements in the array:\t");
            int elementCounter = int.Parse(Console.ReadLine());
            int[] userMatrix = new int[elementCounter];
            MatrixLengthByUserInput(userMatrix);
            Console.WriteLine("Arithmetic mean is: {0}\nMinimum value is: {1}\nMaximum value is: {2}", userMatrix.Average(), userMatrix.Min(), userMatrix.Max());


            // #5 get 2 arrays, print it in console in two separate lines:
            int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[] { 6, 7, 8, 9, 10 };
            Console.WriteLine("Array #1 : {0} \nArray #2 : {1}", string.Join(" ", numbers1), string.Join(" ", numbers2));

            // #6 Fibonacci Sequence from 11 to 0
            int n = 11;
            Fibonacci(n);

            // #7 every second index in an array is equal to 0 , alt method Array.Clear() 
            int[] everySecondIsNotZero = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MakeEverySecondZero(everySecondIsNotZero);

            // #8 sort an array
            string[] myClass = { "Aaron", "Johan", "Albin", "Maria", "Bengt", "Daniella", "Volodia" };
            SortMyString(myClass);

        }

        static void PrintOddNumbers(int[] oddMatrix)
        {

            for (int i = 0; i <= oddMatrix.Length - 1; i++)
            {
                oddMatrix[i] = i;
                if (i % 2 != 0 && i != 0) Console.Write(oddMatrix[i] + "\t");
            }

            Console.WriteLine();

        }

        static void PrintReverseMatrix(int[] fiveMatrix) //Same as Array.Reverse();
        {
            Console.Write("\nReverse matrix: \n");

            for (int i = fiveMatrix.Length - 1; i >= 0; i--)
            {
                Console.Write(fiveMatrix[i] + "\t");
            }
            Console.WriteLine();

        }

        static void SumOfElemensByUserInput(uint[] matrixResult)
        {
            Console.Write("\nThere are all the values of an array:\n");

            uint sum = 0;

            for (uint i = 1; i < matrixResult.Length; i++)
            {
                matrixResult[i] = i;
                Console.Write(matrixResult[i]);
                if (i < matrixResult.Length - 1)
                {
                    Console.Write(",");
                }
            }
            
            foreach (uint obj in matrixResult)
            {
                sum += matrixResult[obj];
            }
            Console.WriteLine("\nSum of all elements before your index is:\n" + sum);
            Console.WriteLine();
        }

        static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1; 
            int c = 0;
            Console.Write("\nFibonacci series: {0} {1} ", a, b );
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0} ", c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
            

        
        static void MatrixLengthByUserInput(int[] userMatrix) 
        {
            var rnd = new Random();
            Console.Write("\n\nYour array:" + "\t");


            for (int i = 0; i < userMatrix.Length; i++)
            {
                userMatrix[i] = rnd.Next(0, 100);
                Console.Write(userMatrix[i] + "\t");
            }
            Console.WriteLine();

        }

        static void MakeEverySecondZero(int[] everySecondIsNotZero)
        {
            Console.WriteLine("\nArray before mutation: {0}\n", string.Join(" ", everySecondIsNotZero));
            for (int i = 0; i < everySecondIsNotZero.Length; i++)
            {
                if (everySecondIsNotZero[i] % 2 != 0)
                {
                    everySecondIsNotZero[i] = 0;
                }

            }
            Console.WriteLine("\nArray after mutation: {0}\n", string.Join(" ", everySecondIsNotZero));
        }

        

        static void SortMyString(string[] myClass)
        {
            Console.WriteLine("\nYour name-list before sorting: {0}", string.Join(" ", myClass));
            Array.Sort(myClass);
            Console.WriteLine("\nYour name-list after sorting: {0}", string.Join(" ", myClass));
        }

        

    }
}


    
