using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public string Color { get; set; }
    public string HornSound { get; set; }

    public string Logo { get; set; }
    public string Country { get; set; }
    
    public bool FullSize { get; set; }
    public int NumberOfSeats { get; set; }
    public void DisplayCarInfo()
    {
        Console.WriteLine($"This is a {Color} {Logo} from {Country}.");
        Console.WriteLine(($"This model has {NumberOfWheels} wheels and {NumberOfDoors} doors."));

        if (FullSize)
        {
            Console.WriteLine($"This is a full size SUV with {NumberOfSeats} seats.");
        }
        else
        {
            Console.WriteLine($"This is a compact SUV with {NumberOfSeats} seats.");
        }
        Console.WriteLine($"Let's hear the horn: {HornSound}\n");
    }
}