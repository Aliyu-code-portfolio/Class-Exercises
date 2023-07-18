using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Exercises
{
    public class MyTODOList
    {
        public static void AddTask()
        {
            string options = "1. Monday\n2. Tuesday\n3. Wednesday\n4. Thurdays\n5. Friday\n6. Saturday\n7. Sunday\n0. Exit";
            string optionsMessage = "Choose a day to add a task";

            while (true)
            {
                Console.WriteLine(options);
                Console.WriteLine(optionsMessage);
                bool convertable = byte.TryParse(Console.ReadLine(), out byte response);
                if (convertable)
                {
                    switch (response)
                    {
                        case 1:
                            addTask("monday");
                            break;
                        case 2:
                            addTask("tuesday");
                            break;
                        case 3:
                            Console.WriteLine("\nAssessment day\n");
                            break;
                        case 4:
                            addTask("thurday");
                            break;
                        case 5:
                            addTask("friday");
                            break;
                        case 6:
                            Console.WriteLine("\nNo daily task\n");
                            break;
                        case 7:
                            Console.WriteLine("\nNo daily task\n");
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("\nInvalid input\n");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("\nPlease input a number from 1-7\n");
                }
            }
        }
        private static void addTask(string day)
        {
            bool flag = true;
            int count = 1;
            string taskAndTime = "";
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine($"Add task {count} for {day.ToUpper()}");
                taskAndTime += Console.ReadLine();
                Console.WriteLine("What time is the task");
                bool canConvert = false;
                TimeOnly time;
                do
                {
                    Console.WriteLine("Enter a valid time for the task in the format 10:30");
                    canConvert = TimeOnly.TryParse(Console.ReadLine(), out time);
                }
                while (!canConvert);
                taskAndTime += " by " + time + ",";
                count++;
                Console.WriteLine("Add more task?\n\nEnter N to finish or press any key to add new task");
                char add = Console.ReadLine().ToLower().ToCharArray()[0];
                if (add.Equals('n'))
                    flag = false;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Your task for {day} is:\n");
            var dayTask = taskAndTime.Split(',');
            foreach (var task in dayTask)
            {
                Console.WriteLine(task);
            }
        }
    }
}
