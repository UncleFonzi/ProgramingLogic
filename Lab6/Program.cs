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

public string GetDescription()
  {
    return $"{year} {color} {model}";
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

    
    string y = myCar.GetDescription(); 
    Console.WriteLine(y); 
    myCar.Repaint("red");
    Console.WriteLine("The car has been repainted to "+ myCar.color);
  }  

} 