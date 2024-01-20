using System;
namespace CircleArea1
{
    class Program
    {
        static void AltMain(string[] args)
        {
            
            

            // Circle with starting with Radius 1
            for(double radius = 1; radius <=5; radius++)
            {
            double area = (float) (Math.PI * radius * radius);
            Console.WriteLine("Radius : " +radius + "\tArea:" +area);            
            }           
            
        }
    }
}