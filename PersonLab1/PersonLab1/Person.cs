using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab1
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonId: " + id + "\n" + "First name: " + firstName + "\n" + "Last name: " + lastName + "\n" + "Favorite color: " + favoriteColor + "\n" + "Age: " + age + "\n" + "Is Working: " + isWorking + "\n";

            return formatted;
        }

        public virtual void DisplayPersonInfo()
        {
            Console.WriteLine(id + ": " + firstName + " " + lastName + " favorite color is " + favoriteColor + "\n");
        }

        public virtual void ChangeFavoriteColour()
        {
            favoriteColor = "white";
        }

        public virtual void GetAgeInTenYears()
        {
            age += 10;
            Console.WriteLine(firstName + " " + lastName + "’s Age in 10 years is: " + age + "\n");
            age -= 10;
        }

    }
}
