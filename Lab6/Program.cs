namespace Lab6;
using System;


class Car  
{  
  public string model;  
  public string color;  
  public int year;  

  public void Display()  
  {  
    Console.WriteLine("Car Details:");  
    Console.WriteLine("Model: " + model);  
    Console.WriteLine("Color: " + color);  
    Console.WriteLine("Year: " + year); 
  }  

  public void Start()  
  { 
    Console.WriteLine("The car is starting"); 
  } 

  public void Drive(int miles) 
  { 
    Console.WriteLine("The car drove " + miles + " miles"); 
  } 

  public int GetDescription(int a) 
  { 
    return a; 
  } 

  public string GetDescription(string b, string c) 
  { 
    return b + c; 
  } 

  public void Repaint(string newColor)
  {
    color = newColor;
  }
}  

class Program  
{  
  static void Main()  
  {  
    Car myCar = new Car();  
    myCar.model = "Civic";  
    myCar.color = "Black ";  
    myCar.year = 2020;  
  
    myCar.Display(); 
    myCar.Start(); 
    myCar.Drive(50); 

    int z = myCar.GetDescription(myCar.year); 
    string y = myCar.GetDescription(myCar.color, myCar.model); 
    Console.WriteLine(z + " " + y); 
    myCar.Repaint("red");
    Console.WriteLine("The car has been repainted to "+ myCar.color);
  }  

} 