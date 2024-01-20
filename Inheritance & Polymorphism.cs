// In C#, inheritance is a process in which one object acquires all the properties and behaviors of its parent object automatically. 
// In such way, you can reuse, extend or modify the attributes and behaviors which is defined in other class.

using System;  
   public class Car 
    {  
       public int CarSpeed = 50;  
   }  
   public class CarMake: Car
   {  
       public float CarPrice = 1000000;  
   }  
   class Inherited{  
       public static void Main(string[] args)  
        {  
            CarMake p1 = new CarMake();  
  
            Console.WriteLine("CarSpeed: " + p1.CarSpeed);  
            Console.WriteLine("CarPrice: " + p1.CarPrice);  
  
        }  
    }

// Polymorphism is a Greek word that means "many-shaped" and it has two distinct aspects:

//At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays. When this polymorphism occurs, the object's declared type is no longer identical to its run-time type.
//Base classes may define and implement virtual methods, and derived classes can override them, which means they provide their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type of the object, and invokes that override of the virtual method. 
class MLAlgorithms  // Base class (parent) 
{
  public void Classification() 
  {
    Console.WriteLine("The ML Algorithm makes a classification");
  }
}

class LR : MLAlgorithms  // Derived class (child) 
{
  public void Classification()  
  {
    Console.WriteLine("The LR Classifies the object: Sigmoid Function");
  }
}

class DT : MLAlgorithms  // Derived class (child) 
{
  public void Classification()
  {
    Console.WriteLine("The DT Classifies the object: CART Algorithm");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    MLAlgorithms myMLAlgorithms = new MLAlgorithms();  // Create a Animal object
    MLAlgorithms myLR = new LR();  // Create a Pig object
    MLAlgorithms myDT = new DT();  // Create a Dog object

    myMLAlgorithms.Classification();
    myLR.Classification();
    myDT.Classification();
  }
}