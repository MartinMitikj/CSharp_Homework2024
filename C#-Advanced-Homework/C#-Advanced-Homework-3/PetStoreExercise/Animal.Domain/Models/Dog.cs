

namespace Animal.Domain.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public Dog(string name, string type, int age,bool goodBoy,string favoriteFood) : base(name, type, age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name},Type: {Type},Age: {Age},Good boy: {GoodBoy},Favorite foood: {FavoriteFood}");
        }
    }
}
