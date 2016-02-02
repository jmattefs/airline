using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Passengers
    {
        Random rnd = new Random();
        string name;
        int bday;
        int ticketNumber;
        string destination;

        public Passengers(string name, int bday, int ticketNumber, string destination)
        {
            this.name = name;
            this.bday = bday;
            this.ticketNumber = ticketNumber;
            this.destination = destination;
        }

        public string genFirstName()
        {
            string[] firstNames = new string[] { "John", "Mary", "Bill", "Sally", "Bob", "Erin", "Steve", "Molly", "Charles", "Carly", "Tom", "Melanie", "Paul", "Victoria", "George", "Elizabeth", "Peter", "Pamela", "Roger", "Joan", "Frank", "Denise", "Dennis", "Angela", "Michael", "Jan", "Dwight", "Kathleen", "Antwan", "Megan", "Aaron", "Jordan" };
            string name1;
            name1 = firstNames[rnd.Next(0, firstNames.Length)];
            return name1;
           
        }
        public string genLastName()
        {
            string[] lastNames = new string[] { "Smith", "Jones", "Wilson", "Thompson", "Nelson", "Adams", "Rodgers", "Jackson", "Coleman", "Harrison", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Moore", "Taylor", "Anderson", "Thomas", "White", "Harris", "Freeman", "Gonzalez"};
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
            string info;
            info = "Name/Date of Birth: " + name + "; " + bday;
            Console.WriteLine(info);
            return info;
        }
    }
}
