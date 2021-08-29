using System;
using System.Threading;

class HelloWorld
{
    static void Main()
    {
        Console.Title = "Calculator Application";


        Console.WriteLine("Which operation would you like to use? --> Add, Subtract, Multiply, Divide <--");


        Calculator(Console.ReadLine());

        while(true)
        {
            ResetApplication();
        }
    }

    public static void Calculator(string operations)
    {
        switch(operations)
        {
            case "Add":
                Console.WriteLine("First number? ");
                int fn = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Second number? ");
                int sn = Int32.Parse(Console.ReadLine());
                int result = Add(fn, sn);
                Console.WriteLine($"The result is {result}");
                Console.WriteLine("Please wait..");
                Thread.Sleep(5000);
                break;
            case "Subtract":
                Console.WriteLine("First number? ");
                int fn2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Second number? ");
                int sn2 = Int32.Parse(Console.ReadLine());
                int result2 = Subtract(fn2, sn2);
                Console.WriteLine($"The result is {result2}");
                Console.WriteLine("Please wait..");
                Thread.Sleep(5000);
                break;
            case "Multiply":
                Console.WriteLine("First number? ");
                int fn3 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Second number? ");
                int sn3 = Int32.Parse(Console.ReadLine());
                int result3 = Multiply(fn3, sn3);
                Console.WriteLine($"The result is {result3}");
                Console.WriteLine("Please wait..");
                Thread.Sleep(5000);
                break;
            case "Divide":
                Console.WriteLine("First number? ");
                int fn4 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Second number? ");
                int sn4 = Int32.Parse(Console.ReadLine());
                int result4 = Divide(fn4, sn4);
                Console.WriteLine($"The result is {result4}");
                Console.WriteLine("Please wait..");
                Thread.Sleep(5000);
                break;

            default:
                Console.WriteLine("Error: Please try again!");

                int myDelay = 2000;
                Thread.Sleep(myDelay);

                Console.Clear();
                
                Console.WriteLine("Which operation would you like to use? --> Add, Subtract, Multiply, Divide <--");
                Calculator(Console.ReadLine());
                break;
        }
    }

    public static int Add(int fn, int sn)
    {
        return fn + sn;
    }

    public static int Subtract(int fn2, int sn2)
    {
        return fn2 - sn2;
    }

    public static int Multiply(int fn3, int sn3)
    {
        return fn3 * sn3;
    }

    public static int Divide(int fn4, int sn4)
    {
        return fn4 / sn4;
    }

    public static void ResetApplication()
    {
        Console.Clear();
        Console.WriteLine("Would you like to do another operation? (Yes/No)..");
        string redoApp = Console.ReadLine();

        switch (redoApp)
        {
            case "Yes":
                Console.WriteLine("Alright, performing another operation.. Please wait!");
                int myRedoDelay = 3500;
                Thread.Sleep(myRedoDelay);

                Console.Clear();
                Console.WriteLine("Which operation would you like to use? --> Add, Subtract, Multiply, Divide <--");
                Calculator(Console.ReadLine());
                break;
            case "No":
                Console.WriteLine("Okay, process ending!");
                Environment.Exit(0);

                break;

            default:
                Console.WriteLine("Please enter a valid answer! (Yes/No)");
                ResetApplication();
                break;
        }
     }
    }