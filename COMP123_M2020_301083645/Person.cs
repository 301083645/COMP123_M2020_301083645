﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace COMP123_M2020_301083645
{
    class Person
    {
        // Private Instance variables (fields)
        private string m_name;
        private int m_age;

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

        //Constructor
        public Person(string name, int age)
        {
            m_name = name;
            m_age = age;
        }
        //Private Methods
        //Public Methods
        public void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello");
        }
        /// <summary>
        /// This method overrides the superclass ToString Method
        /// </summary>
        /// <returns>
        /// This method returns a formatted string that displays class properties
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "\n+++++++++++++++++++++\n";
            outputString += $"Name: {Name} \n";
            outputString += $"Age : {Age}\n";
            outputString += "+++++++++++++++++++++\n";


            return outputString;
        }
    }
}
