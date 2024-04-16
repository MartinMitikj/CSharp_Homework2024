using Cars.Domain.Helpers;
using Cars.Domain.Models;
using System.Linq;

ConsoleHelper.PrintInColor("LINQ Homework", ConsoleColor.Red);
Console.WriteLine();
ConsoleHelper.PrintInColor("Filter all cars that have origin from Europe:", ConsoleColor.Blue);
List<string> requirement1 = CarsData.Cars.Where(car => car.Origin == "Europe").Select(car => car.Model).ToList();
requirement1.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Find all unique cylinder values for cars:", ConsoleColor.Blue);
List<string> requirement2 = CarsData.Cars.DistinctBy(car => car.Cylinders).Select(car => $"{car.Cylinders} cylinders").ToList();
requirement2.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Select all car model names with their model names converted to uppercase:", ConsoleColor.Blue);
List<string> requirement3 = CarsData.Cars.Select(car => car.Model.ToUpper()).ToList();
requirement3.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Check if there are any cars with horsepower greater than 300:", ConsoleColor.Blue);
bool requirement4 = CarsData.Cars.Any(car => car.HorsePower > 300);
ConsoleHelper.PrintInColor($"{requirement4}", ConsoleColor.Red);

Console.WriteLine();

ConsoleHelper.PrintInColor("Find the car with the highest horsepower:", ConsoleColor.Blue);
Car requirement5 = CarsData.Cars.MaxBy(car => car.HorsePower);
ConsoleHelper.PrintInColor($"{requirement5.Model} Max hp", ConsoleColor.Red);

Console.WriteLine();

ConsoleHelper.PrintInColor("Filter all Chevrolet cars and order them by weight in descending order:", ConsoleColor.Blue);
List<string> requirement6 = CarsData.Cars.Where(car => car.Model.Contains("Chevrolet")).OrderBy(car => car.Weight).Select(car => $"Name: {car.Model} Weight: {car.Weight}").ToList();
requirement6.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Find the car with the longest model name:", ConsoleColor.Blue);
string requirement7 = CarsData.Cars.OrderByDescending(car => car.Model.Length).Select(car => car.Model).FirstOrDefault();
ConsoleHelper.PrintInColor(requirement7, ConsoleColor.Red);

Console.WriteLine();

ConsoleHelper.PrintInColor("Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.", ConsoleColor.Blue);
var requirement8 = CarsData.Cars.GroupBy(car => car.Origin).OrderBy(car => car.Count()).ToList();
foreach (var group in requirement8)
{
    Console.WriteLine($"Origin: {group.Key}, Number of Cars: {group.Count()}");
}

Console.WriteLine();

ConsoleHelper.PrintInColor("Find the first 5 cars with the highest horsepower.", ConsoleColor.Blue);
var requirement9 = CarsData.Cars.OrderByDescending(car => car.HorsePower).Take(5).ToList();
foreach (var car in requirement9)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} horsepower");
}

Console.WriteLine();

ConsoleHelper.PrintInColor("Find the car with the highest acceleration time.", ConsoleColor.Blue);
string requirement10 = CarsData.Cars.OrderByDescending(car => car.AccelerationTime).Select(car => $"Model: {car.Model} AccelerationTime: {car.AccelerationTime} ").FirstOrDefault();
ConsoleHelper.PrintInColor($"{requirement10}", ConsoleColor.Red);

Console.WriteLine();

ConsoleHelper.PrintInColor("Select only the model and horsepower of cars with horsepower greater than 200.", ConsoleColor.Blue);
List<string> requirement11 = CarsData.Cars.Where(car => car.HorsePower > 200).Select(car => $"Model: {car.Model} - HorsePower: {car.HorsePower}").ToList();
requirement11.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Select all unique origins of cars, ordered alphabetically", ConsoleColor.Blue);
List<string> requirement12 = CarsData.Cars.DistinctBy(car => car.Origin).OrderBy(car => car.Origin).Select(car => car.Origin).ToList();
requirement12.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.", ConsoleColor.Blue);
List<string> requirement13 = CarsData.Cars.Where(car => car.Cylinders > 4).OrderBy(car => car.Origin).ThenBy(car => car.HorsePower).Select(car => $"Origin: {car.Origin} Model: {car.Model} Horsepower: {car.HorsePower} Cylinders: {car.Cylinders}").ToList();
requirement13.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.", ConsoleColor.Blue);
List<Car> moreThen6 = CarsData.Cars.Where(car => car.Cylinders > 6).ToList();
List<Car> fourClyAndHP = CarsData.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110).ToList();
List<string> requirement14 = moreThen6.Concat(fourClyAndHP).Select(car => $"Model: {car.Model} Cylinders: {car.Cylinders}").ToList();
requirement14.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.", ConsoleColor.Blue);
List<string> requirement15 = CarsData.Cars.Where(car => car.HorsePower > 200).Select(car => $"Model: {car.Model} Horsepower: {car.HorsePower}").ToList();
Car lowest = CarsData.Cars.Where(car => car.HorsePower > 200).MinBy(car => car.MilesPerGalon);
Car higest = CarsData.Cars.Where(car => car.HorsePower > 200).MaxBy(car => car.MilesPerGalon);
double average = CarsData.Cars.Where(car => car.HorsePower > 200).Average(car => car.MilesPerGalon);
requirement15.PrintSimple();
Console.WriteLine($"Lowest Miles per Gallon: {lowest.MilesPerGalon}");
Console.WriteLine($"Highest Miles per Gallon: {higest.MilesPerGalon}");
Console.WriteLine($"Average Miles per Gallon: {average}");

Console.WriteLine();

ConsoleHelper.PrintInColor("Give me all cars and their weights that have origin for US,with 8 Cylinders from the car with the most weight to the least ",ConsoleColor.Blue);
List<string> requirement16 = CarsData.Cars.Where(car => car.Origin == "US" && car.Cylinders == 8).OrderByDescending(car => car.Weight).Select(car => $"Model: {car.Model} Weight: {car.Weight}").ToList();
requirement16.PrintSimple();

Console.WriteLine();

ConsoleHelper.PrintInColor("Give me all the names and acceleration time of cars that are not Ford, that have acceleration between 9 and 11,and order them by horsepower from the least to the most", ConsoleColor.Blue);
List<string> requirement17 = CarsData.Cars.Where(car => !car.Model.Contains("Ford") && car.AccelerationTime >= 9 && car.AccelerationTime <= 11).OrderBy(car => car.HorsePower).Select(car => $"Model: {car.Model} Acceleration time: {car.AccelerationTime}").ToList();
requirement17.PrintSimple();

