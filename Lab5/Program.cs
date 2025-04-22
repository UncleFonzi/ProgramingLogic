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

        string[] days = new string [8];
        days[1] = "Monday";
        days[2] = "Tuesday";
        days[3] = "Wednesday";
        days[4] = "Thursday";
        days[5] = "Friday";
        days[6] = "Saturday";
        days[7] = "Sunday";

        Console.WriteLine("Enter a number (1–7): ");
        int day = Convert.ToInt32(Console.ReadLine());
        if (day > 1 && day < 8)
        {
            Console.WriteLine("That day is: " + days[day]);
        }
        else 
        {
            Console.WriteLine("Invaild Day!");
        }
        
        string[] books = new string [4];
        books[1] = "The Hobbit";
        books[2] = "Charlotte's Web";
        books[3] = "1984";
        
        string[] authors = new string [4];
        authors[1] = "J.R.R. Tolkien";
        authors[2] = "E.B. White";
        authors[3] = "George Orwell";

        for (int i = 1; i < 4; i++)
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
