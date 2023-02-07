using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ValueRefrence
    {
        public static void LetsGo()
        {
            int v1 = 342;
            int v2 = v1;
            v1 = 5;
            Console.WriteLine("v1: {0}, v2: {1}", v1, v2);

            int[] ary1 = new int[] { 1, 2, 3 };
            int[] ary2 = ary1;
            ary1[0] = 5;
            //ary1 and ary2 are pointing to the same array]
            Console.WriteLine("ary1: {0}", String.Join(", ", ary1));
            Console.WriteLine("ary2: {0}", String.Join(", ", ary2));

            Point p1 = new Point(1, 2);
            Point p2 = p1;
            
            p1.X = 222;
            //its red idk why
         //   p1.Write();
         //   p2.Write();

        }
        //struct is like a class but it is a value type instead of refrence type 
        // cant have an empty constructor
        struct Print//or class
        {
            public int x;
            public int y;
        public Print(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Write()
        {
            Console.WriteLine($"{x} - {y}");
        }
    }
    
    }

    
}
