using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Assignment 01-d-Date");
        Console.WriteLine("Part I");
        Console.WriteLine();
        MyInfo();

        Date date = new Date(2023, 5, 22);

        Console.WriteLine("Original Date: " + date);

        date.Add(5);
        Console.WriteLine("After adding 5 days: " + date);

        date.Add(1, 10);
        Console.WriteLine("After adding 1 month and 10 days: " + date);

        Date otherDate = new Date(1, 1, 1);
        date.Add(otherDate);
        Console.WriteLine("After adding another date: " + date);

        Console.ReadKey();

    }
    public static void MyInfo()
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("*** This program is written by Marjan Jafari **");
        Console.WriteLine("**** My Student ID: 301321020              ****");
        Console.WriteLine("**** Assignment 01-d-Method (Solution)     ****");
        Console.WriteLine("**** Solution for Question 02              ****");
        Console.WriteLine("***********************************************");
    }
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        
        public void Add(int days)
        {
            day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            month += months;
            day += days;
            Normalize();
        }

        public void Add(Date other)
        {
            year += other.year;
            month += other.month;
            day += other.day;
            Normalize();
        }

        private void Normalize()
        {
            int[] monthLengths = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (day > monthLengths[month])
            {
                day -= monthLengths[month];
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }
        public override string ToString()
        {
            string monthName = GetMonthName(month);
            return $"{year}-{monthName}-{day}";
        }

        private string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Aug";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
                default:
                    return "";
            }
        }
    }
}
