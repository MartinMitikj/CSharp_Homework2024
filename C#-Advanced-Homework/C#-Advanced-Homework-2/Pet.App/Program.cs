
using Pet.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

Dog bob = new Dog(1,"Bob","Black");
Dog sparky = new Dog(2, "Sparky", "White");
Dog John = new Dog(3, "John", "Brown");

Console.WriteLine("Bob is okay " + Dog.Validated(bob));
Console.WriteLine("Sparky is okay " + Dog.Validated(sparky));
Console.WriteLine("John is okay " + Dog.Validated(John));

DogShelter.Add(bob);
DogShelter.Add(sparky);
DogShelter.Add(John);

Console.WriteLine("All dogs :");
DogShelter.PrintAll();