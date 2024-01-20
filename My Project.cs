using System;
class forLoopAreaCircle
{
    public static void AltAltMain()
    {
        // for loop begins when radius=1
        // and runs till radius <=5
        double area;
        for (double radius = 1; radius <= 5; radius++)
        {
            area = (float) (Math.PI * Math.Pow(radius,2));
            Console.WriteLine("Radius:" +radius + " Area:" +area);
        }

    }
}

