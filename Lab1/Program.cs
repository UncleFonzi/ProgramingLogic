using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        Console.WriteLine("Denzel Walker IT 1050 Programing Logic");
        
        // Step 2
        /* Name: [Denzel Walker]
        Title: [IT-1050 - Lab 1]*/

        //Step 3
        int favNum = 18;
        string favProg = "Python";
        double numProg = 5.5D;
        bool myExp = true;

        Console.WriteLine("My favorite number is " + favNum);
        Console.WriteLine("My favorite programming language is "+ favProg);
        Console.WriteLine("I have written "+ numProg + " programs before this");
        Console.WriteLine("It is "+ myExp+ " that I have programming experience");

        // Step 5
        const string mySchool = "Tri-C";
        Console.WriteLine("My school's name is " + mySchool);

        // Part 6
        // All variables and constants have meaningful descriptive names
    }
}
