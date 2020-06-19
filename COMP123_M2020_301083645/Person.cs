using System;
using System.Collections.Generic;
using System.Text;

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
        Person(string name, int age)
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
    }
}
