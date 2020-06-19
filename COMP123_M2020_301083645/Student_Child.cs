using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_301083645
{
    class Student_Child : Person
    {

        // Private Instance variables (fields)
       
        private int m_student;

        // Public properties
        

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
        public Student_Child(string name, int age, int studentID)
        :base(name, age)
        {
            StudentID = studentID;
        }
        //Private Methods
        //Public Methods

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
