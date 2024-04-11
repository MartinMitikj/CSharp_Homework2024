using Vehicles.Domain.Models;

Car car = new Car();
MotorBike motorBike = new MotorBike();
Boat boat = new Boat();
Airplane airplane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
airplane.DisplayInfo();

car.Drive();
motorBike.Wheelie();
boat.Sail();
airplane.Fly();