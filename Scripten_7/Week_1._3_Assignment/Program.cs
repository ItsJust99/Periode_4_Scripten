using System;
using System.Collections.Generic;
using System.Text;

namespace Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            class Student
        {
            // 01. Create a Student.cs class
            /*
             * The class has fields and properties for :
             *   - Name (string)
             *   - Year of birth (int)
             *   - Hobby (string)
             *   - Alive (bool)
             */
            private string name;
            private int yearOfBirth;
            private string hobby;
            private bool alive;
            /*
         * The class has GETTERS for : 
         *   - Name
         *   - Year of birth
         */
            public string Name
            {
                get { return this.name; }
            }

            public int YearOfBirth
            {
                get { return this.yearOfBirth; }
            }

            /*
             * The class has GETTERS and SETTERS for : 
             *   - Hobby
             *   - Alive
             */
            public string Hobby
            {
                get { return this.hobby; }
                set { this.hobby = value; }
            }

            public bool Alive
            {
                get { return this.alive; }
                set { this.alive = value; }
            }

            /*
             * The class has a default and custom Constructor 
             */
            // default constructor
            public Student()
            {
                name = "John Doe";
                yearOfBirth = 2003;
                hobby = "None";
                alive = true;
            }

            // custom constructor
            public Student(string name, int yearOfBirth, string hobby, bool alive)
            {
                this.name = name;
                this.yearOfBirth = yearOfBirth;
                this.hobby = hobby;
                this.alive = alive;
            }

            /*
             * The class has a method which : 
             *   - Checks if the student is alive and returns the correct string
             *   - "alive" 
             *   - or "not alive"
             */
            // class method
            public string isAlive()
            {
                if (this.alive == true)
                {
                    return "alive";
                }
                else
                {
                    return "not alive";
                }
            }
        }
        }
    }
}
