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
    public string FullBed { get; set; }
}