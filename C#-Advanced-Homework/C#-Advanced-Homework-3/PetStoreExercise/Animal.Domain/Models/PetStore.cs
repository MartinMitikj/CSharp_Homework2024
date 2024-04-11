

namespace Animal.Domain.Models
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set; } = new List<T>();

        public void Add(T pet)
        {
            Pets.Add(pet);
        }
        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.Name);
            }
        }

        public void BuyPet(string name)
        {
            T petRemove = Pets.FirstOrDefault(x => x.Name == name);
            if (petRemove != null)
            {
                Pets.Remove(petRemove);
                Console.WriteLine($"You bought the pet by that name {name}");
            }
            else
            {
                Console.WriteLine($"Sorry ther is no pet named {name}");
            }
        }
    }
}
