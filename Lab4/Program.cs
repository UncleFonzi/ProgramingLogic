namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
    
        for (int i=1; i < 11; i++) 
        {
            Console.WriteLine(i);
        }
        
        
        int even = 1;
        while (even < 21)
        {
            if ((even % 2) == 0)
            {
                Console.WriteLine(even);
            }
            even++;
        }
        

        int down = 5;
        while (down > 0 )
        {
            Console.WriteLine(down);
            down--;
        }
        
        int num;
        do
        {
        Console.WriteLine("Enter a number greater than 100:");
        num = Convert.ToInt32(Console.ReadLine());
        }
        while (num < 100);
        

        int mult = 10;
        while (mult < 1001)
        {
            Console.WriteLine(mult);
            mult = mult + 10;
        }
        

        for (int s = 1; s <= 10; ++s)
        {
            for (int j = 1; j <= s; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
