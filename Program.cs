using System;

class Program
{
    static void Main()
    {
        //While loops
        int taskNumber = 1;

        while (taskNumber <= 5)
        {
            Console.WriteLine($"Task #{taskNumber} completed");
            taskNumber++;
        }
        //Do While Loops
        int attempt = 1;
        do
        {
            Console.WriteLine($"Attempt {attempt}");
            attempt++;
            
        } 
        while (attempt <= 3);
        //for loops
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"step {i}");
        }
        //loop control
        int number = 1;

        while (number <= 6)
        {
            number++;
            //skip values @ and after 4
            if (number == 4)
            {
                continue;
            }
            //exit loop @ 6
            if (number == 6)
            {
                break;
            }

            Console.WriteLine(number);
        }

    }
}