using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Converting
    {

        public static void DoIt()
        {
            //Implicit conversion 
            //automatic
            //Conveting interger to a long
            int i = 234342;
            long l = i;
            Console.WriteLine(l);
            Console.WriteLine("type: {0}", l.GetType());
            
            char c = 'C';
            var v = c;
            Console.WriteLine("type: {0}", v.GetType());

            //Excplicit conversion
            //casting
            //if conversion cannnot be made without loss of data the complier will require an excilpit coneversion
            //your saying you know this can be a problem btu you accept the risks
            double d = 334221.22;
            i = 33;
            i = (int)d;
            Console.WriteLine(i);

            string s = "fsfdsa";
            // i = s; wrong
            //parsing
            bool isSuccess = int.TryParse(s, out i); //out means it will be passed by reference
            Console.WriteLine(s + " converts to int?" + isSuccess + " " + i);
            
           


        }

        public static bool isNumeric(string s)
        {
            double dolIsNumber;
            return double.TryParse(s, out dolIsNumber);
        }
    }
}
