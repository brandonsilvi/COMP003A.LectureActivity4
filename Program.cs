using System;

class Program

namespace COMP003A.LectureActivity4
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
            //skip values @ and after 4
            if (number == 4)
            {
                number++;
                continue;
            }
            //exit loop @ 6
            if (number == 6)
            {
                break;
            }

            Console.WriteLine(number);
            number++;
        }

    }
}

/*
 Reflection: 
 I found the for loop to be the easiest to 
 understand since its entirely defined in one segment
 
 The while loop with the break and continue was the hardest
 to trace since the conditions change the execution
 
 The comments help break up the sections and understand what 
 goes where. They help a lot for a 3rd party to understand 
 reasons for the presented code. 
*/