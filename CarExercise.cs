using System;

namespace CarExercise
{
public class Car
{
    // Properties
    string make;
    string model;
    int year;
    int speed;

    // Methods
    public void Accelerate()
    {
        speed += 30;
    }

    public void Brake()
    {
        speed -= 30;
    }
}
}