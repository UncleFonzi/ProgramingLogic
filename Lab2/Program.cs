using System.Diagnostics;
using System.Security.Authentication;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        int myNum = 18;               
        double myDoubleNum = 19.99D;  
        char myLetter = 'W';         
        bool myBool = false;          
        string myText = "Howdy";

        Console.WriteLine(myNum);
        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);

        double doubleValue = 9.78D;
        int intValue = (int) doubleValue;  
        int intString = 24;
        bool boolString = true;

        Convert.ToString(intString);
        Convert.ToString(boolString);

        Console.WriteLine("double: " + doubleValue);
        Console.WriteLine("int type casted from double: " + intValue);
        Console.WriteLine("int to string: " + intString);
        Console.WriteLine("boolean to string: " + boolString);

        Console.WriteLine("Enter your name:");
        string yourName = Console.ReadLine();
        Console.WriteLine("Enter your Age:");
        int yourAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your name is " + yourName + " and your age is "+ yourAge);

        int num1 = 24;
        int num2 = 17;

        int sum1 = num1 + 10;
        int sum2 = num2 + 10;
        int sub1 = num1 - 2;
        int sub2 = num2 - 2;
        int mult1 = num1 * 3;
        int mult2 = num2 * 3;
        int div1 = num1 / 2;
        int div2 = num2 / 2;
        int mod1 = num1 % 2;
        int mod2 = num2 % 2;

        Console.WriteLine("num1 is: " + num1);
        Console.WriteLine("num2 is: " + num2);
        Console.WriteLine("num1 + 10 is: " + sum1);
        Console.WriteLine("num2 + 10 is: " + sum2);
        Console.WriteLine("num1 - 2 is: " + sub1);
        Console.WriteLine("num2 - 2 is: " + sub2);
        Console.WriteLine("num1 * 3 is: " + mult1);
        Console.WriteLine("num2 * 3 is: " + mult2);
        Console.WriteLine("num1 / 2 is: " + div1);
        Console.WriteLine("num2 / 2 is: " + div2);
        Console.WriteLine("num1 % 2 is: " + mod1);
        Console.WriteLine("num2 % 2 is: " + mod2);

        float myPrec = 1.123456789F;
        double myDec = 1.123456789D;

        Console.WriteLine(myPrec);
        Console.WriteLine(myDec);
        Console.WriteLine("The float number only goes to 7 decimal spaces");

        int myInc = 10;
        myInc++;
        Console.WriteLine("myInc is now " + myInc);
        myInc--;
        Console.WriteLine("myInc is now " + myInc);
    }
}
