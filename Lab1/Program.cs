using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1


        /* Name: [Stefanie Vlna]
           Title:[IT 1050-Lab1] */

        //Step 2
        Console.WriteLine("Stefanie Vlna");
        Console.WriteLine("IT-1050 - Lab 1");

        //Step 3
        int favnumber = 17;
        string favoriteLanguage = "C#";
        double programsWritten = 3;
        bool hasExperience = true;
        Console.WriteLine("Favorite number: " + favnumber);
        Console.WriteLine("Favorite programming language: " + favoriteLanguage);
        Console.WriteLine("Programs written before this: " + programsWritten);
        Console.WriteLine("Has programming experience: " + hasExperience);

        //Step 4
        const string schoolName = "Cuyahoga Community College";
        Console.WriteLine("School Name: " + schoolName);

        //Step 5
        double originalDouble = 9.78;
        int castedInt = (int)originalDouble;
        string intAsString = Convert.ToString(castedInt);
        string boolAsString = Convert.ToString(hasExperience);
        Console.WriteLine("originalDouble: " + originalDouble);
        Console.WriteLine("castedInt: " + castedInt);
        Console.WriteLine("intAsString: " + intAsString);
        Console.WriteLine("boolAsString: " + boolAsString);


        //Step 6
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine(); 
        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hello, {userName}. You are {userAge} years old.");
        
      
        
        

        //Step 7
        int num1 = 8;
        int num2 = 4;
        Console.WriteLine("num1 + 10 = " + (num1 + 10));
        Console.WriteLine("num2 - 2 = " + (num2 - 2));
        Console.WriteLine("num1 * 3 = " + (num1 * 3));
        Console.WriteLine("num2 / 2 = " + (num2 / 2));
        Console.WriteLine("num2 % 2 = " + (num2 % 2));

        //Step 8
        float floatVal = 1.123456789f;
        double doubleVal = 1.123456789;
        Console.WriteLine("floatVal: " + floatVal);
        Console.WriteLine("doubleVal: " + doubleVal);

        //Step 9
        int counter = 10;
        counter++;
        Console.WriteLine("After increment: " + counter);
        counter--;
        Console.WriteLine("After decrement: " + counter);
    }

}

