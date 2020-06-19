using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_301083645
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom", 40);

            tom.SaysHello();

            string personString = tom.ToString();

            Console.WriteLine(personString);

            Console.WriteLine();

            Person jackey = new Person("Jacky", 22);
            jackey.SaysHello();
            Console.WriteLine(jackey.ToString());
            Console.WriteLine();


            Student joss = new Student("Joss", 22, 123456);
            joss.SaysHello();
            joss.Studies();
            Console.WriteLine(joss.ToString());
            Console.WriteLine();


            Student_Child Bess = new Student_Child("Bess", 33, 234678);
            Bess.SaysHello();
            Bess.Studies();
            Console.WriteLine(Bess.ToString());

            // wait for user to enter anything
            Console.ReadLine();

        }
    }
}
