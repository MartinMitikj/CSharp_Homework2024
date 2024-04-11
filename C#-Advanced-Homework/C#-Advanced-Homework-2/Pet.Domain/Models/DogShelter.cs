

namespace Pet.Domain.Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();


        public static void PrintAll()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"Id: {dog.Id} - Name: {dog.Name} - Color: {dog.Color}");
            }
        }

        public static void Add(Dog dog)
        {
            Dogs.Add(dog);
        }
    }
}
