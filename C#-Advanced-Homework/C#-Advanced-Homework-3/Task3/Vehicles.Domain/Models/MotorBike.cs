

namespace Vehicles.Domain.Models
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Im a motorbike and i drive on 2 wheels :)");
        }

        public void Wheelie()
        {
            Console.WriteLine("The motorbike is driving on one wheel");
        }
    }
}
