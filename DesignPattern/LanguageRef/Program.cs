using System;
using System.Linq;
using System.Diagnostics;

[Flags]
public enum Days
{
    None = 0b_0000_0000,  // 0
    Monday = 0b_0000_0001,  // 1
    Tuesday = 0b_0000_0010,  // 2
    Wednesday = 0b_0000_0100,  // 4
    Thursday = 0b_0000_1000,  // 8
    Friday = 0b_0001_0000,  // 16
    Saturday = 0b_0010_0000,  // 32
    Sunday = 0b_0100_0000,  // 64
    Weekend = Saturday | Sunday
}

public class FlagsEnumExample
{

    public int Age {get; set;}
    public static void Main()
    {

#pragma checksum "file.cs" "{406EA660-64CF-4C82-B6F0-42D48172A799}" "ab007f1d23d9" // New checksum

        Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
        Console.WriteLine(meetingDays);
        // Output:
        // Monday, Wednesday, Friday

        Days workingFromHomeDays = Days.Thursday | Days.Friday;
        Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
        // Output:
        // Join a meeting by phone on Friday

        bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
        Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
        // Output:
        // Is there a meeting on Tuesday: False

        var a = (Days)37;
        Console.WriteLine(a);

        
        var d = 0.234;
             Console.WriteLine($"{d}");

        // Data source.
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        // Create the query with two predicates in where clause.
        var queryLowNums2 =
            from num in numbers
            where num < 5 && num % 2 == 0
            select num;

        // Execute the query
        foreach (var s in queryLowNums2)
        {
            Console.Write(s.ToString() + " ");
        }
        Console.WriteLine();

        // Create the query with two where clause.
        var queryLowNums3 =
            from num in numbers
            where num < 5
            where num % 2 == 0
            select num;

        // Execute the query
        foreach (var s in queryLowNums3)
        {
            Console.Write(s.ToString() + " ");
        }

        Console.Error.WriteLine("34534645645");
        // Output:
        // Monday, Wednesday, Saturday
        Trace.WriteLine("345345");

        int x = 5000;
        int y = 9;
        int s1 = x * y;
        Trace.Assert(x == 5000, "Fail");
        for (int i = 0; i < x; i++)
        {
          //  Console.Error.WriteLine($"{i}");
        }
    }
}
