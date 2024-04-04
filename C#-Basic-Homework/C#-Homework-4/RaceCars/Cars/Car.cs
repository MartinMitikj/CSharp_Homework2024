
namespace RaceCars.Cars
{
    using RaceCars.Driver;

    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car()
        {

        }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }

        public static void RaceCars(Car firstCar, Car secondCar)
        {
            int raceCarOne = firstCar.CalculateSpeed();
            int raceCarTwo = secondCar.CalculateSpeed();
            if (raceCarOne > raceCarTwo)
            {
                Console.WriteLine($"The car {firstCar.Model} is the winner with driver {firstCar.Driver.Name} and the speed was {raceCarOne} Km/h!!");
            }
            else if (raceCarOne < raceCarTwo)
            {
                Console.WriteLine($"The car {secondCar.Model} is the winner with driver {secondCar.Driver.Name} and the speed was {raceCarTwo} Km/h!!");
            }
            else
            {
                Console.WriteLine("Both cars were the same speed");
            }
        }
    }
}
