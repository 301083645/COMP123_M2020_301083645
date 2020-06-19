using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_301083645
{
    class Student
    {

        // Private Instance variables (fields)
        private string m_name;
        private int m_age;
        private int m_student;

        // Public properties
        public string Name
        {
            get //accessor
            {
                return this.m_name;
            }
            set // mutator
            {
                m_name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.m_age;
            }
            set
            {
                m_age = value;
            }
        }

        public int StudentID
        {
            get
            {
                return this.m_student;
            }
            set
            {
                m_student = value;
            }
        }

        //Constructor
        public Student(string name, int age, int studentID)
        {
            m_name = name;
            m_age = age;
            m_student = studentID;
        }
        //Private Methods
        //Public Methods
        public void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello");
        }

        public void Studies()
        {
            Console.WriteLine($"{Name} is studying.");
        }


        /// <summary>
        /// This method overrides the superclass ToString Method
        /// </summary>
        /// <returns>
        /// This method returns a formatted string that displays class properties
        /// </returns>
        /// 
        public override string ToString()
        {
            string outputString = "";

            outputString += "\n+++++++++++++++++++++\n";
            outputString += $"Name       : {Name} \n";
            outputString += $"Age        : {Age}\n";
            outputString += $"Student ID : {StudentID}\n";
            outputString += "+++++++++++++++++++++\n";


            return outputString;
        }
    }
}
