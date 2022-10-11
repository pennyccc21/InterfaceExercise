using InterfaceExercise;
using System;
using System.Collections.Generic;

var car = new Car();

var truck = new Truck();

var vehicles = new List<IVehicle>() { car, truck };

foreach (var vehicle in vehicles)
{
    vehicle.Drive();
    vehicle.ChangedGears();
    vehicles.Reverse();
}
