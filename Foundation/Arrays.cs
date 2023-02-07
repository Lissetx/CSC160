using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Arrays
    {

        public static void Execute()
        {
            int[] myArray1 = new int[3];
            myArray1[0] = 55;
            myArray1[1] = 125;
            myArray1.SetValue(23, 2);
            //intergers deafult to zero, chars deafualt to empty space
            // other types default to null

            int[] myArray2 = new int[] { 1, 2, 3, 4 };
            int[] myArray3 = { 1, 2, 3, 4 };

            for (int i = 0; i < myArray1.Length; i++)
            {
                //Console.WriteLine($"{myArray1[i]}");
                //Console.WriteLine("{0}", myArray1[i]);
                //Console.WriteLine(myArray1[i]);
            }

            foreach (int i in myArray1)
            {
                // Console.WriteLine(i);
            }

            //everything in c# derived from object type 
            //array with multiple types
            object[] myThings = new object[] { 10, "bob", 10.4f };
            string[,] alphabet = new string[2, 2] { { "A", "B" }, { "C", "D" } };

            for (int row = 0; row < alphabet.GetLength(0); row++)
            {
                for (int colum = 0; colum < alphabet.GetLength(1); colum++)
                {
                    //Console.Write("{0}", alphabet[row, colum]);
                }
              //  Console.WriteLine();
            }
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            //WriteArray(numbers);

            //WriteArray(numbers[..3]);
            //WriteArray(numbers[1..4]);
            //WriteArray(numbers[4..]);

            //Array.Reverse(numbers);
            //WriteArray(numbers);
            Console.WriteLine("Find index of value 3: {0}", Array.IndexOf(numbers, 3));
            WriteArray(Array.FindAll(numbers, LessThanFour));

            //jagged array 
            //could define rows, but colums could be varying sizes
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3, 4 };
            jagged[1] = new int[] { 5, 6, 7 };
            jagged[2] = new int[] { 8, 9, 10, 11, 12, 13 };
            
        } 

        public static bool LessThanFour(int value)
        {
            return value < 4;
        }
        static void WriteArray(int[] values)
        {
            Console.WriteLine(String.Join(",", values));
        }
    }
}


