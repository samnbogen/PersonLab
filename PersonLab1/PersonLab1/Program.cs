using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", 30, "red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "blue", true);
            Person person4 = new Person (4, "Mary", "Beals", 28, "yellow", true);

            person2.DisplayPersonInfo();

            Console.WriteLine(person3.ToString());

            person2.ChangeFavoriteColour();

            person2.DisplayPersonInfo();

            person4.GetAgeInTenYears();

            List<double> agelist = new List<double>() { person1.Age, person2.Age, person3.Age, person4.Age };

            List<Person> personlist = new List<Person>() { person1, person2, person3, person4 };    

            double ageavrg = agelist.Sum() / 4;

            Console.WriteLine("Average age is: " + ageavrg + "\n");

            var nameresult = from x in personlist
                         where x.FirstName.Substring(0, 1) == "M"
                         select x;

            foreach (var person in nameresult)
                Console.WriteLine(person.ToString());

            var colorresult = from x in personlist
                             where x.FavoriteColor == "blue"
                             select x;

            foreach (var person in colorresult)
                Console.WriteLine(person.ToString());

            Console.ReadKey();

        }
    }
}
