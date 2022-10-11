using InterfaceExercise;
using System;

public class Car : IVehicle , ICompany
{
	public Car()
	{
	}

	public string CompanyName { get; set; } = "Dodge";
	public string Motto { get; set; } = "American Strong";
	public double EngineSize { get; set; } =   123;
	public string Make { get; set; } = "Charger";
	public string Model { get; set; } = "RTX";
	public int SeatCount { get; set; } = 2;
	public bool HasChangedGears { get;  set; } = true;

	public void Drive()
	{
	  
	  Console.WriteLine($"{GetType().Name} now driving foward...");

    }
	public void Reverse()
	{
		if(HasChangedGears == true)
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
