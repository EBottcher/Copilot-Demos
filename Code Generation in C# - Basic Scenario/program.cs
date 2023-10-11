//generate boilerplate code for program.cs

using System;


namespace Code_Generation_in_C_Sharp___Basic_Scenario
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a line from the console as an integer
            int input = int.Parse(Console.ReadLine());

            //create a switch statement for the input for all the days of the week
            switch (input)
            {
                case 1:
                    Console.WriteLine(DaysOfTheWeek.Monday);
                    break;
                case 2:
                    Console.WriteLine(DaysOfTheWeek.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(DaysOfTheWeek.Wednesday);
                    break;
                case 4:
                    Console.WriteLine(DaysOfTheWeek.Thursday);
                    break;
                case 5:
                    Console.WriteLine(DaysOfTheWeek.Friday);
                    break;
                case 6:
                    Console.WriteLine(DaysOfTheWeek.Saturday);
                    break;
                case 7:
                    Console.WriteLine(DaysOfTheWeek.Sunday);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
    //create an enum for the days of the week
    enum DaysOfTheWeek
    {
        Monday =1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }

}
