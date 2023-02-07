using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Parameters
    {
        public static void Start()
        {
            int intRef = 7;
            int[] ary = new int[] { 5, 6 };
            string strByVal = "Fred";
            RefTest clsRT = new RefTest();
            clsRT.x = 1;
            int intValue = 66;
            int[] ary2 = new int[2];
            ary2 = ary;
            ary.CopyTo(ary2, 0); //how to copy elements to prevent array from becomeing same object 

            ByValRefTest(ref intRef, strByVal, ary, clsRT, intValue);
            //Console.WriteLine($"Int ByRef: {intRef}");
            //Console.WriteLine("String byVa; {0}", strByVal);
            //Console.WriteLine("ary2[0]: {0}", ary2[0]);
            //Console.WriteLine("clsRT.x: {0}", clsRT.x);
            //Console.WriteLine($"IntVale: {intValue}" );

            DefaultParam();
            DefaultParam(50);
        }

        static void DefaultParam(int n = 20)
        {
            Console.WriteLine("DeafultParam: {0}", n);
        }
        
        public class RefTest
        {
            public int x;
        }
        
        public static void ByValRefTest(ref int xRef, string sVal, int[] ary, RefTest clsRefTest, int intValue)
        {
            xRef = xRef * xRef;
            sVal = "Fanny";
            ary[0] = 10;
            clsRefTest.x = 88;
            intValue = 42;
        }
    }
}
