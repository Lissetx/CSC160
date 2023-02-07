using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Strings
    {
        public static void DoIt()
        {
            ////3 different ways to format strings
            //Console.WriteLine("What is your name? ");
            //string strName = Console.ReadLine();
            //Console.WriteLine("V1 - Hello " + strName + " glad to meet you!"); //string concatination
            //Console.WriteLine("V2 - Hello {0} {1} glad to meet you!", strName, "Freebert"); //string interpolation
            //Console.WriteLine($"V3 - Hello {strName} glad to meet you!"); //string injection 

            string strNeu = "Neumont College of Computer Science";
            Console.WriteLine(strNeu);

            Console.WriteLine("length: {0}", strNeu.Length);
            Console.WriteLine($"Contains 'of': {strNeu.Contains("of")}");
            int indexof = strNeu.IndexOf("of");
            Console.WriteLine("IndexOf:  postion: {0}", indexof != -1 ? indexof.ToString() : "Not Found"); //if true does stuff after question mark if finds it return string, if -1 return not found

            Console.WriteLine("Remove: {0}", strNeu.Remove(indexof, 3)); //starting at 16 remove 3 more

            //StringBuilder for speed
            StringBuilder sb = new StringBuilder();
            sb.Append(strNeu);
            sb.Append(" ");
            sb.Append(" is really");
            sb.Append(" swell!");
            Console.WriteLine($"StringBuilder: {sb.ToString()}");

            
        }
    }
}
