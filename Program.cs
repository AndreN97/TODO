using System;
using static System.Console;
using TODO.Domain;

namespace TODO
{
    class Program
    {
        static Task[] taskList = new Task[100];

        static void Main(string[] args)
        {
            bool shouldRun = true;

            while (shouldRun)
            {
                Clear();

                WriteLine("1. Add todo");
                WriteLine("2. List todo");
                WriteLine("3. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:

                        Clear();

                        Write("Title: ");
                        string title = ReadLine();

                        Write("Due date(yyyy-mm-dd hh:mm): ");
                        DateTime dueDate = DateTime.Parse(ReadLine());

                        taskList[GetIndexPosition()] = new Task(title, dueDate);

                        break;

                    case ConsoleKey.D2:
                        break;

                    case ConsoleKey.D3:
                        shouldRun = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static int GetIndexPosition()
        {
            int result = -1;
            for (int i = 0; i < taskList.Length; i++)
            {
                if (taskList[i] != null)
                {
                    continue;
                }
                if (taskList[i] == null)
                {
                    result = i;
                    break;
                }
                if (result == -1)
                {
                    throw new Exception("No avalible position");
                }
            }
            return result;
        }
    }
}
