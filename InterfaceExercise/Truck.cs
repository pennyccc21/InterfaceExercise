using InterfaceExercise;
using System;

public class Truck : IVehicle, ICompany 
{
	public Truck()
	{
	}

    public string CompanyName { get; set; } = "Ford";
    public string Motto { get; set; } = "Built Ford Tough";
    public double EngineSize { get; set; } = 4.6;
    public string Make { get; set; } = "Ford";
    public string Model { get; set; } = "F150";
    public int SeatCount { get; set; } = 4;
    public bool HasChangedGears { get; set; } 
    public bool HasFourWheelDrive { get; set; } = true;

    public void Drive()
    {
        if (HasFourWheelDrive == true)
        {

            Console.WriteLine($"4 wheel drive {GetType().Name} now driving foward...");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} is now driving foward...");
        }
    
    }

    public void Reverse()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now reversing ...");
            HasChangedGears = false;

        }
        else
        {
            Console.WriteLine("Cant reverse until we changed gears");
        }



    }

    public void Park()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now in Park...");
            HasChangedGears = false;

        }
        else
        {

            Console.WriteLine("Cant park until we changed gears");
        }


    }

    public void ChangedGears(bool ischanged)
    {

        HasChangedGears |= ischanged;

    }

    public void ChangedGears()
    {
        throw new NotImplementedException();
    }
}



































































}
