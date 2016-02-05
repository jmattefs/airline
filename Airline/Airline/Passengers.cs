using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Passengers
    {
        Random rnd = new Random();
        string name;
        int bday;
        

        public Passengers(string name, int bday)
        {
            this.name = name;
            this.bday = bday;
        }

        public string genFirstName()
        {
            string[] firstNames = new string[] { "John", "Mary", "Bill", "Sally", "Bob", "Erin", "Steve", "Molly", "Charles", "Carly", "Tom", "Melanie", "Paul", "Victoria", "George", "Elizabeth", "Peter", "Pamela", "Roger", "Joan", "Frank", "Denise", "Dennis", "Angela", "Michael", "Jan", "Dwight", "Kathleen", "Antwan", "Megan", "Aaron", "Jordan", "Bruce", "Diane", "OJ", "Alice", "Chad", "Sue", "Clark", "Cindy", "Cameron", "Hannah", "Jack", "Lena", "Sam", "Deborah", "Suzy", "Mai", "Dan", "Jake", "Ryan", "Tyler", "Blake", "Kenny", "Cath", "Catherine", "Jill", "Juan", "Andrew", "Connie", "Rebecca", "Marina", "Samantha", "David", "Dave", "Trent", "Jacob", "Mike", "Ester", "Kim", "Jimmy", "Louis", "Louise", "DeQuan", "Dejay", "Carlos", "Park", "Tim", "Jackie", "Jet", "Donnie", "Denzel", "Tito", "Jermaine", "Janet", "Marlon" };
            string name1;
            name1 = firstNames[rnd.Next(0, firstNames.Length)];
            return name1;

        }
        public string genLastName()
        {
            string[] lastNames = new string[] { "Smith", "Jones", "Wilson", "Thompson", "Nelson", "Adams", "Rodgers", "Jackson", "Coleman", "Harrison", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Moore", "Taylor", "Anderson", "Thomas", "White", "Harris", "Freeman", "Gonzalez", "Robinson", "Simpson", "Black", "West", "Wayne", "Kent", "Allen", "Jefferson", "Washington", "Ochocinco", "Rooney", "McCarthy", "Kuhn", "James", "Bryant", "Pitt", "Cruise", "McQueen", "Stewart", "Grant", "Walker", "Newton", "Chan", "Li", "Lee", "Yang", "Sanchez", "Mars", "Hughs", "Woods", "Price", "Foster", "Powell", "Russel", "Jenkins", "Diaz", "Long", "Cook", "Myers", "Perry", "Reynolds", "Griffin", "Wells", "Alvarez", "Mendoza", "Burns", "Shaw", "Crawford", "Mason", "Schmidt", "Fernandez", "Ferfusan", "Daniels", "Castro", "Hoffman", "Knight", "Ray", "Duncan", "Lane", "Mathews", "Silva", "Vargas", "Larson", "Carlson", "Harper", "Watkins", "Carr", "Oliver", "Weber", "Hanson", "Bishop", "Austin", "Harvey", "Howell", "Chen", "Fields", "Schneider", "Vick"  };
            string name2;
            name2 = lastNames[rnd.Next(0, lastNames.Length)];
            return name2;
        }
        public string genFullName()
        {
            string fullName;
            string firstName;
            string lastName;
            firstName = genFirstName();
            lastName = genLastName();
            fullName = firstName + " " + lastName;
            return fullName;
        }
        public int genMonth()
        {
            int month;
            month = rnd.Next(1, 13);
            return month;
        }
        public int genDay()
        {
            int day;
            day = rnd.Next(1, 30);
            return day;
        }
        public int genYear()
        {
            int year;
            year = rnd.Next(41, 99);
            return year;
        }
        public string genBday()
        {
            string bday;
            int month;
            int day;
            int year;
            month = genMonth();
            day = genDay();
            year = genYear();
            bday = month.ToString() + "-" + day.ToString() + "-" + year.ToString();
            return bday;
        }
        public string genPerson()
        {
            string name = genFullName();
            string bday = genBday();
            return String.Format("{0, -20}  | {1, 9}", "|" + name, bday + "|");
        }
    }
}
