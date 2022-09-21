using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student luke = new Student("Luke", 16, true);
            luke.OutputInfo();

            Console.ReadLine();
        }
    }

    class Student
    {
        public string name;
        public int age;
        private bool atSchool;

        public Student(string name, int age, bool atSchool)
        {
            this.name = name;
            this.age = age;
            this.atSchool = atSchool;
        }

        public void OutputInfo()
        {
            Console.WriteLine($"name: {name}, age: {age}, atSchool: {atSchool}");
        }

        public void ToggleAtSchool()
        {
            atSchool = !atSchool;
        }
    }
}
