using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        /*
        Once you have the classes in place, write a program that creates at least one activity of each type. 
        Put each of these activities in the same list. Then iterate through this list and call the GetSummary 
        method on each item and display the results.
        */

        Running running = new Running(DateTime.Now, 30, 3.0);
        Cycling cycling = new Cycling(DateTime.Now.AddDays(2), 45, 25);
        Swimming swimming = new Swimming(DateTime.Now.AddDays(4), 50, 25);


        List <Activity> _activities = new List<Activity>();

        _activities.Add(running);
        _activities.Add(cycling);
        _activities.Add(swimming);


        foreach (Activity activity in _activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}