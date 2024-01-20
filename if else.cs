using System; 
  
class RR
{ 
      
static public void altMain() 
{ 
      
    // Declaring and initializing variables 
    double side; 
    Console.WriteLine("Please enter the side of the square");
    side = Convert.ToDouble(Console.ReadLine());
    // If statement 
    if (side <= 0) 
    { 
        Console.WriteLine("Input is invalid"); 
    } 
      
    // else statement 
   else
    { 
        double area = (float) (side * side);
        Console.WriteLine("Side :" +side + "\tArea:" +area);
    } 
} 
}