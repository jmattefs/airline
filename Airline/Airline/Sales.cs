using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Sales
    {
        Random rnd = new Random();
        public int SmallSales()
        {
            int planeCapacity = 20;
            double percentage = .75;
            double minSales = planeCapacity * percentage;
            int minSales2 = Convert.ToInt32(minSales);
            int totalSales = rnd.Next(minSales2, 21);
            return totalSales;
        }
        public int SmallRevenue(int p)
        {
            int sales = p;
            int ticketPrice = 100;
            int revenue = sales * ticketPrice;
            return revenue;
        }
        public int MediumSales1st()
        {
            int capacity1st = 10;
            double percentage = .75;
            double min1stSales = capacity1st * percentage;
            int min1stSales2 = Convert.ToInt32(min1stSales);
            int totalSales = rnd.Next(min1stSales2, 11);
            return totalSales;
        }
        public int MediumRev1st(int sale)
        {
            int sales = sale;
            int ticketPrice = 200;
            int revenue = sales * ticketPrice;
            return revenue;
        }
        public int MediumSalesCoach()
        {
            int capacityCoach = 30;
            double percentage = .75;
            double minCoachSales = capacityCoach * percentage;
            int minCoachSales2 = Convert.ToInt32(minCoachSales);
            int totalSales = rnd.Next(minCoachSales2, 31);
            return totalSales;
        }
        public int MediumRevCoach(int sale)
        {
            int sales = sale;
            int ticketPrice = 100;
            int revenue = sales * ticketPrice;
            return revenue;
        }
        public int TotalMediumRevenue(int rev1st, int coach)
        {
            int revenue1st = rev1st;
            int revenueCoach = coach;
            int totalRevenue = revenue1st + revenueCoach;
            return totalRevenue;
        }
        public int LargeSales1st()
        {
            int capacity1st = 25;
            double percentage = .75;
            double min1stSales = capacity1st * percentage;
            int min1stSales2 = Convert.ToInt32(min1stSales);
            int totalSales = rnd.Next(min1stSales2, 26);
            return totalSales;
        }
        public int LargeRev1st(int sale)
        {
            int sales = sale;
            int ticketPrice = 250;
            int revenue = sales * ticketPrice;
            return revenue;
        }
        public int LargeSalesCoach()
        {
            int capacityCoach = 50;
            double minCoachSales = capacityCoach * .75;
            int minCoachSales2 = Convert.ToInt32(minCoachSales);
            int totalSales = rnd.Next(minCoachSales2, 51);
            return totalSales;
        }
        public int LargeRevCoach(int sale)
        {
            int sales = sale;
            int ticketPrice = 125;
            int revenue = sales * ticketPrice;
            return revenue;
        }
        public int TotalLargeRevenue(int rev1st, int coach)
        {
            int revenue1st = rev1st;
            int revenueCoach = coach;
            int totalRevenue = revenue1st + revenueCoach;
            return totalRevenue;
        }
    }
}
