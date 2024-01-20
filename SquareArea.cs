namespace AreaSquare
{
    class SquareArea
    {
        public static void AltMain()
        {
            // Square with starting with Radius 1
            double side, area;
            side = Convert.ToDouble(Console.ReadLine());
            area = (float) (side * side);
            Console.WriteLine("Side :" +side + "\tArea:" +area);            
        }           
            
    }
}
