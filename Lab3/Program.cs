namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1: Simple for Loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        // Problem 2: Even Numbers from 1 to 20
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);

            }
        }
        //Problem 3: While Loop Countdown
        int Countdown = 5;
        while (Countdown >= 1)
        {
            Console.WriteLine(Countdown);
            Countdown--;
        }

        // Problem 4: Multiples of 10 from 10 to 1000
        int multiple = 10;
        while (multiple <= 1000)
        {
            Console.WriteLine(multiple);
            multiple += 10;
        }


        //Step 5: Seasons of the Year
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        // Step 6: Days of the Week
        Console.WriteLine("\nProblem 6: Days of the Week (1–7)");
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1–7): ");
        string input = Console.ReadLine();
        int dayNum;
        if (int.TryParse(input, out dayNum) && dayNum >= 1 && dayNum <= 7)
        {
            Console.WriteLine($"Day {dayNum}: {days[dayNum - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }

        // Problem 7: Favorite Books and Authors
        string[] books = { "The Hobbit", "American Babe", "The Girls of Atomic City" };
        string[] authors = { "J.R.R. Tolkien", "Babe Walker", "Denise Kierman" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        //Problem 8: Temperature Tracker
        int[] temperatures = { 72, 85, 64, 90, 78 };
        Array.Sort(temperatures);
        Console.WriteLine("Sorted Temperatures:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine($"Lowest Temperature: {temperatures[0]}");
        Console.WriteLine($"Highest Temperature: {temperatures[temperatures.Length - 1]}");

        // Problem 9: Reverse Countdown
        Console.WriteLine("\nProblem 9: Reverse Countdown");
        int[] countdownArray = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdownArray);
        for (int i = 0; i < countdownArray.Length; i++)
        {
            Console.WriteLine(countdownArray[i]);
        }
    }

}