using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Classes
    {
        public static void Engage()
        {
            ExmapleProps ep = new ExmapleProps();
            ep.prop2 = "stuff";
            string s2 = ep.prop2;
            ep.Prop3 = "prop 3 stuff";
            string s3 = ep.Prop3;

            Student milton = new Student();
            milton.Name = "Milton";
            Console.WriteLine("Students name is : {0}", milton.Name);

            milton.GPA = 3.657383f;
            Console.WriteLine("Miltions gpa: {0:0.00}", milton.GPA);

            Student aaron = new Student("Aaron", 37, 3.7f);
            milton.HowManyStudnets();

            Math math = new Math();
            float circ;
            circ = Math.CalcCirc(4);
        }




    }

    class Math
    {
        public const float PI = 3.14159f;

        public static float CalcCirc(float raidus)
        {

            return 2 * PI * raidus;

        }
    }

    class ExmapleProps
    {
        public string prop2;// QUICK AND EASY
        private string prop3;//BETTER = CONTROL THE SET/GET , SAFER 
        public string Prop3
        {
            get { return prop3; }
            set { prop3 = value; }
        }
    }

    class Student
    {
        protected string name;
        protected int cohort = 37;
        protected float gpa;
        static int numberOfStudents = 0;
        public int age { get; set; } = 21; //auto implemented properity

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4.0)
                {
                    gpa = value;
                }
            }
        }

        public Student()
        {
            age = 26;
            numberOfStudents++;
            name = "deafult name";
        }

        public Student(string name, int cohort, float gpa = 2.5f)
        {
            Name = name;
            GPA = gpa;
            this.cohort = cohort;
            numberOfStudents++;
        }

        public void HowManyStudnets()
        {
            Console.WriteLine($"Number of students: {numberOfStudents}");
        }
    }
}
