﻿using System;
using System.Threading;

namespace LearnThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Main execution starts here
            Console.WriteLine("Main thread starts here.");

            // This method takes 4 seconds to finish.
            //Program.DoSomeHeavyLifting();

            // Create a thread and call a background method
            Thread backgroundThread = new Thread(new ThreadStart(Program.DoSomeHeavyLifting));
            backgroundThread.Start();

            // This method doesn't take anytime at all.
            Program.DoSomething();

            // Execution ends here
            Console.WriteLine("Main thread ends here.");
            Console.ReadKey(); 
        }

        private static void DoSomeHeavyLifting()
        {
            Console.WriteLine("I'm lifting a truck!!");
            Thread.Sleep(1000);
            Console.WriteLine("Tired! Need a 3 sec nap.");
            Thread.Sleep(1000);
            Console.WriteLine("1....");
            Thread.Sleep(1000);
            Console.WriteLine("2....");
            Thread.Sleep(1000);
            Console.WriteLine("3....");
            Console.WriteLine("I'm awake.");
        }
        private static void DoSomething()
        {
            Console.WriteLine("Hey! DoSomething here!");
            for(int i = 0; i < 20; i++)
                Console.WriteLine($"{i}");

            Console.WriteLine();
            Console.WriteLine("I'm done.");
        }
    }
}
