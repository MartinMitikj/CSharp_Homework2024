﻿

namespace Vehicles.Domain.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Im a car and i drive on 4 wheels :)");
        }
    }
}
