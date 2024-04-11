
using Animal.Domain.Models;

PetStore<Dog> dogStore = new PetStore<Dog>();
dogStore.Add(new Dog("Bob", "Dog", 4, true, "Beef"));
dogStore.Add(new Dog("Sparky", "Dog", 2, false, "Beef"));

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.Add(new Cat("Garfild", "Cat", 1, true, 5));
catStore.Add(new Cat("Tom", "Cat", 5, true, 8));

PetStore<Fish> fishStore = new PetStore<Fish>();
fishStore.Add(new Fish("Nemo", "Fish", 1, "Blue", 30));
fishStore.Add(new Fish("Will", "Fish", 1, "Yellow", 30));

dogStore.BuyPet("Bob");
dogStore.BuyPet("John");

catStore.BuyPet("Garfild");

dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();