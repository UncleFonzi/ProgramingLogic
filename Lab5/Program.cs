namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        string[] seasons = new string [4];
        seasons[0] = "Spring";
        seasons[1] = "Summer";
        seasons[2] = "Fall";
        seasons[3] = "Winter";

        foreach (string name in seasons)
        {
            Console.WriteLine(name);
        }

        string[] days =
        [
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
        ];
        Console.WriteLine("Enter a number (1–7): ");
        int day = Convert.ToInt32(Console.ReadLine());
        if (day >= 1 && day <= 7)
        {
            Console.WriteLine("That day is: " + days[day - 1]);
        }
        else 
        {
            Console.WriteLine("Invaild Day!");
        }
        
        string[] books = ["The Hobbit", "Charlotte's Web", "1984"];
        string[] authors = ["J.R.R. Tolkien", "E.B. White", "George Orwell"];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Book " + i + ": " + books[i] + " by " + authors[i]);
        }

        int[] temperatures = { 65, 72, 78, 70, 68 };
        
        Array.Sort(temperatures);

        Console.Write("Sorted Temperatures:");
        foreach (int temp in temperatures) 
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Highest Temperature: " + temperatures.Max());
        Console.WriteLine("Lowest Temperature: " + temperatures.Min());

        int[] countdown = { 5,4,3,2,1 };
        
        Array.Reverse(countdown);

        Console.Write("Countdown: ");
        foreach (int count in countdown)
        {
            Console.Write(count + " ");
        }
    }
}
