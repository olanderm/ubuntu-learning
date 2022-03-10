using System;
using System.Linq;
using System.Diagnostics;
using System.Diagnostics;
using System.Collections;

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

    public int Age { get; set; }
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

        ArrayList arrInts = new ArrayList();
        arrInts.Add(1);
        arrInts.Add(2);
        int tempI = (int)arrInts[0];

        Animals dogs = new Animals();

        dogs.Add(new Animal("PiPi"));

        foreach (Animal dog in dogs)
        {
            Console.WriteLine(dog.Name.ToString());
        }

        BaseClass bc = new BaseClass();
        DerivedClass dc = new DerivedClass();
        BaseClass bcdc = new DerivedClass();

        bc.Method1();
        bc.Method2();
        dc.Method1();
        dc.Method2();
        bcdc.Method1();
        bcdc.Method2();

        /*        
        Base - Method1
        Base - Method2
        Base - Method1
        Derived - Method2
        Base - Method1
        Base - Method2*/

        /*
         Base - Method1
Base - Method2
Base - Method1
Derived - Method2
Base - Method1
Derived - Method2
         */

        CountNumber cnum = new CountNumber();

        foreach(int s in cnum)
        {

            Console.WriteLine($"{s}");
        }
    }

    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }

    class Animal
    {
        private string _name;
        public Animal(string name) { _name = name; }
        public string Name
        {
        get {return _name;}
        }
    }

    class Animals : CollectionBase
    {
        private string dogname;
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public Animals() {  }

        public Animal this[int index]
        {
            get { return (Animal)List[index]; }
            set { List[index] = value; }
        }
    }

    class AnimalsDictionary : DictionaryBase
    {

    }

    class CountNumber
    {
        int [] p =  new int [4];

        public CountNumber()
        {
            p[0] = 0;
            p[1] = 1;
            p[2] = 2;
            p[3] = 3;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 4; i++)
            {
                yield return i;
            }
        }
    }

    public class Content : ICloneable
    {
        public int Val;
        public object Clone()
        {
            Content clc = new Content();
            clc.Val = Val;
            return clc;
        }
    }

    public class Cloner: ICloneable
    {
        public Content MyContent = new Content();

        public Cloner(int newVal)
        {
            MyContent.Val = newVal;
        }

        public Cloner()
        { }

        public object GetCopy()
        {
            return MemberwiseClone();
        }

        public object Clone()
        {
            Cloner clc = new Cloner();
            clc.MyContent = MyContent.Clone() as Content;
            return clc;
        }
    }


}
