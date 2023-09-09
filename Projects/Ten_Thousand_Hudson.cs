using System;

namespace TenThousandHudson
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempHours;
            bool res;
            double sundayHours, mondayHours, tuesdayHours, wednesdayHours, thursdayHours, fridayHours, saturdayHours, weekHours;
            
            // Get the current system date
            DateTime currentDate = DateTime.Now;
           
            //Change Colors
            Console.BackgroundColor = ConsoleColor.White; 
            Console.ForegroundColor = ConsoleColor.DarkRed;

            // Ask the user to input the planned average hours to practice each day
            Console.Write("Enter the planned average hours to practice each Sunday: ");
            tempHours = Console.ReadLine();
            res = double.TryParse(tempHours, out sundayHours);
            while (res == false)
            {
                Console.Write("Enter the planned average hours to practice each Sunday: ");
                tempHours = Console.ReadLine();
                res = double.TryParse(tempHours, out sundayHours);
            }
            Console.Write("Enter the planned average hours to practice each Monday: ");
            tempHours = Console.ReadLine();
            res = double.TryParse(tempHours, out mondayHours);
            while (res == false)
            {
                Console.Write("Enter the planned average hours to practice each Monday: ");
                tempHours = Console.ReadLine();
                res = double.TryParse(tempHours, out mondayHours);
            }
            Console.Write("Enter the planned average hours to practice each Tuesday: ");
            tempHours = Console.ReadLine();
            res = double.TryParse(tempHours, out tuesdayHours);
            while (res == false)
            {
                Console.Write("Enter the planned average hours to practice each Tuesday: ");
                tempHours = Console.ReadLine();
                res = double.TryParse(tempHours, out tuesdayHours);
            }
            Console.Write("Enter the planned average hours to practice each Wednesday: ");
            tempHours = Console.ReadLine();
            res = double.TryParse(tempHours, out wednesdayHours);
            while (res == false)
            {
                Console.Write("Enter the planned average hours to practice each Wednesday: ");
                tempHours = Console.ReadLine();
                res = double.TryParse(tempHours, out wednesdayHours);
            }
            Console.Write("Enter the planned average hours to practice each Thursday: ");
            tempHours = Console.ReadLine();
            res = double.TryParse(tempHours, out thursdayHours);
            while (res == false)
            {
                Console.Write("Enter the planned average hours to practice each Thursday: ");
                tempHours = Console.ReadLine();
                res = double.TryParse(tempHours, out thursdayHours);
            }
            Console.Write("Enter the planned average hours to practice each Friday: ");
            tempHours = Console.ReadLine();
            res = double.TryParse(tempHours, out fridayHours);
            while (res == false)
            {
                Console.Write("Enter the planned average hours to practice each Friday: ");
                tempHours = Console.ReadLine();
                res = double.TryParse(tempHours, out fridayHours);
            }
            Console.Write("Enter the planned average hours to practice each Saturday: ");
            tempHours = Console.ReadLine();
            res = double.TryParse(tempHours, out saturdayHours);
            while (res == false)
            {
                Console.Write("Enter the planned average hours to practice each Saturday: ");
                tempHours = Console.ReadLine();
                res = double.TryParse(tempHours, out saturdayHours);
            }

            // Calculate the total number of hours practiced per week
            double totalHoursPerWeek = sundayHours+mondayHours+tuesdayHours+wednesdayHours+thursdayHours+fridayHours+saturdayHours;


            // Calculate the number of weeks, months, and years it will take to reach 10,000 hours
            double weeks = 10000 / totalHoursPerWeek;
            double months = weeks / 4;
            double years = months / 12;

            // Print the results
            Console.WriteLine("It will take {0} weeks, {1} months, and {2} years to reach 10,000 hours.", weeks, months, years);

            // Loop the program until the user enters an exit condition
            string exitCondition = "exit";
            while (exitCondition != "exit")
            {
                // Ask the user if they want to exit the program
                Console.WriteLine("Do you want to exit the program? (enter 'exit' to quit): ");
                exitCondition = Console.ReadLine();
            }
        }
    }
}