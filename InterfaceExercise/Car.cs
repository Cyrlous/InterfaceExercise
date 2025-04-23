using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public string Color { get; set; }
    public string HornSound { get; set; }
    public string Logo { get; set; }
    public string Country { get; set; }
    
    public bool HasTrunk { get; set; }
    public bool FrontEngine { get; set; }
    public void DisplayCarInfo()
    {
        Console.WriteLine($"This is a {Color} {Logo} from {Country}.");
        Console.WriteLine(($"This model has {NumberOfWheels} wheels and {NumberOfDoors} doors."));

        if (HasTrunk)
        {
            if (FrontEngine)
            {
                Console.WriteLine($"It has a front engine and a trunk in the rear.");
            }
            else
            {
                Console.WriteLine($"It has a rear engine and a trunk in the front.");
            }
        }
        else
        {
            if (FrontEngine)
            {
                Console.WriteLine($"It has a front engine but no trunk.");
            }
            else
            {
                Console.WriteLine($"It has a rear engine but no trunk.");
            }
        }
        Console.WriteLine($"Let's hear the horn: {HornSound}\n");
    }
}