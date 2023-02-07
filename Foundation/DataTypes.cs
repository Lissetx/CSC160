using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class DataTypes
    {
        public static void Execute()
        {
            uint myuint = 32767; //16 bits
            int myInt = 10; //32 bits
            uint myuInt = 44; //32 bits , unsigned interger , no negative UNSIGINED NO SIGN CANT GO NEGEATIVE
            long myLong = 444; //64 bits
            float myFLoat = 9939.5f; //4 bytes
            double myDouble = 821.3; //8 bytes 
            decimal myDecimal = 403.23M; //16 bytes 

            Console.WriteLine("uint min: {0}", uint.MinValue);
            Console.WriteLine("uint max: {0}", uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("int min: {0}", int.MinValue);
            Console.WriteLine("int max: {0}", int.MaxValue);
            Console.WriteLine();

            Console.WriteLine("uint min: {0}", uint.MinValue);
            Console.WriteLine("uint max: {0}", uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("long min: {0}", long.MinValue);
            Console.WriteLine("long max: {0}", long.MaxValue);
            Console.WriteLine();

            Console.WriteLine("float min: {0}", float.MinValue);
            Console.WriteLine("float max: {0}", float.MaxValue);
            Console.WriteLine();

            Console.WriteLine("double min: {0}", double.MinValue);
            Console.WriteLine("double max: {0}", double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("decimal min: {0}", decimal.MinValue);
            Console.WriteLine("decimal max: {0}", decimal.MaxValue);
            Console.WriteLine();

            char c = 'a';
            Console.WriteLine("Char is: {0}", c);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c));

        }

    }
}
