using RaceCars.Driver;
using RaceCars.Cars;

Console.WriteLine("Hello, World!");

Driver[] fourDrivers = new Driver[]
{
    new Driver("Bob",9),
    new Driver("John",5),
    new Driver("Paul",10),
    new Driver("Vin",7)

};

Car[] fourCars = new Car[]
{
    new Car("Hyundai",5),
    new Car("Mazda",6),
    new Car("Ferrari",10),
    new Car("Porsche",8)
};


static void Repeat(Car[] fourCars, Driver[] fourDrivers)
{
    bool repeat = true;
    while (repeat)
    {
        Race(fourCars, fourDrivers);
        Console.WriteLine("Do you want to race again? (yes/no)");
        string input = Console.ReadLine();
        repeat = (input.ToLower() == "yes");
    }
}
static void Race(Car[] fourCars, Driver[] fourDrivers)
{
    bool repeat = false;
    while (!repeat)
    {
        Console.WriteLine("Welcome to the car race");
        Console.WriteLine("Please choose two drivers and two cars for race");
        Console.WriteLine("Please choose your first car :\r\nHyundai\r\nMazda\r\nFerrari\r\nPorsche");
        string firstCar = Console.ReadLine();
        Console.WriteLine("Please choose your first driver:\r\nBob\r\nJohn\r\nPaul\r\nVin");
        string firstDriver = Console.ReadLine();
        Console.WriteLine("Please choose your second car :\r\nHyundai\r\nMazda\r\nFerrari\r\nPorsche");
        string secondCar = Console.ReadLine();
        Console.WriteLine("Please choose your second driver:\r\nBob\r\nJohn\r\nPaul\r\nVin");
        string secondDriver = Console.ReadLine();


        Car carOne = null;
        Car carTwo = null;
        Driver driverOne = null;
        Driver driverTwo = null;
        foreach (Car car in fourCars)
        {
            if (firstCar == car.Model)
            {
                carOne = car;
            }
            if (secondCar == car.Model)
            {
                carTwo = car;
            }
        }
        foreach (Driver driver in fourDrivers)
        {
            if (firstDriver == driver.Name)
            {
                driverOne = driver;
            }
            if (secondDriver == driver.Name)
            {
                driverTwo = driver;
            }
        }
        carOne.Driver = driverOne;
        carTwo.Driver = driverTwo;

        Car.RaceCars(carOne, carTwo);



        if (((firstCar == null) == (secondCar == null)) || ((firstDriver == null) == (secondDriver == null)))
        {
            Console.WriteLine("You have selected invalid car or driver or duplicate car or driver!!");

        }


    }
}



Repeat(fourCars, fourDrivers);

// Ima problem so ne mozev da go resam koga ke povikam sve tocno prvin mi vlaga kaj  if so mi vraka invalid pa posle go pecati toa so treba