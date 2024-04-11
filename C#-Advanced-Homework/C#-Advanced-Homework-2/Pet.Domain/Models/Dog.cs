
namespace Pet.Domain.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static bool Validated(Dog dog)
        {
            if (dog == null)
            {
               return false;
            }
            if (dog.Id < 0 )
            {
                return false;
            }
            if (dog.Name.Length < 2)
            {
                return false;
            }
            return true;
        }
    }
}
