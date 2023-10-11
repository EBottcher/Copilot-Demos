# Copilot-Demos : Code Generation in C# - Basic Scenario
## Step 1
Type //generate boilerplate code for program.cs in the program.cs file

Copilot should complete it for you with something like this line by line:

<pre>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generation_in_C_Sharp___Basic_Scenario
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
</pre>
## Step 2
To remove unused using statements, select all the code in the file, right click and select Copilot --> Fix this, optionally you can type in the fix toolbar that opened: remove unused using statements.

Copilot will open a preview window, accept the changes.

## Step 3
Add a new line after the Program Class closing brackets and type //create an enum for the days of the week

Copilot should complete it for you with something like this:

<pre>
 enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
</pre>

Edit the code provided by giving a value to the day, for example  

<pre>
enum DaysOfTheWeek
    {
        Monday = 1,
</pre>

Copilot should complete it for you with something like this line by line:

<pre>
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
</pre>

## Step 4
Between the brackets of the Main function, add a new line and type //read a line from the console as an integer

Copilot should complete it for you with something like this:

<pre>
int input = int.Parse(Console.ReadLine()); 
</pre>
In the next line type //create a switch statement for the input for all the days of the week

Copilot should complete it for you with something like this:

<pre>
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

</pre>