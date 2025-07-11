namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine("Step 1");
        Console.WriteLine($"a>b:{a > b}");
        Console.WriteLine($"a<c:{a < c}");
        Console.WriteLine($"a>b && a>c:{a > b && a > c}");
        Console.Writeline($"a>b || a>c:{a > b || a > c}");

        //Part 2
        bool isRaining = true;
        bool haveUmbrella = false;

        Console.WriteLine("Step 2");
        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");

        }
        //Part 3
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }

        else if (age >= 5 && age <= 12) ;
        {
            Console.WriteLine("Child ticket:$5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket:$10");
        }
        else if ("age >=65")
        {
            Console.WriteLine("Senior ticket: $6");
        }

        //Part 4
        
    }
}
