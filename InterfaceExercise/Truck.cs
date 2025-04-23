using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public string Color { get; set; }
    public string HornSound { get; set; }

    public string Logo { get; set; }
    public string Country { get; set; }
    
    public bool ExtendedCab { get; set; }
    public bool FullBed { get; set; }
    public void DisplayCarInfo()
    {
        Console.WriteLine($"This is a {Color} {Logo} from {Country}.");
        Console.WriteLine(($"This model has {NumberOfWheels} wheels and {NumberOfDoors} doors."));

        if (ExtendedCab)
        {
            if (FullBed)
            {
                Console.WriteLine("It has a full bed and an extended cab.");
            }
            else
            {
                Console.WriteLine("It has a half bed and an extended cab.");
            }
        }
        else
        {
            if (FullBed)
            {
                Console.WriteLine("It has a full bed and a standard cab.");
            }
            else
            {
                Console.WriteLine("It has a half bed and a standard cab.");
            }
        }
        Console.WriteLine($"Let's hear the horn: {HornSound}\n");
    }
}