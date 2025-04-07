namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b && a>c);
        Console.WriteLine(a > b || a > c);

        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining == true && haveUmbrella == false)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else 
        {
            Console.WriteLine("You're good to go!");
        }

        Console.WriteLine("Enter your Age:");
        int yourAge = Convert.ToInt32(Console.ReadLine());
        if (yourAge < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (yourAge >= 5 && yourAge <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (yourAge >= 13 && yourAge <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else if (yourAge >= 65)
        {
            Console.WriteLine("Senior ticket: $6");
        }

        Console.WriteLine("Enter what day of the week it is (1-7):");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day) 
        {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        }
        if (day < 1 || day > 7)
        {
            Console.WriteLine("Invalid day!");
        }

    }
}
