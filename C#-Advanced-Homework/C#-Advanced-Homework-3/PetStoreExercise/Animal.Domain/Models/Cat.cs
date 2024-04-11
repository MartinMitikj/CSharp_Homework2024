

namespace Animal.Domain.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, string type, int age,bool lazy,int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name},Type: {Type},Age: {Age},Lazy: {Lazy},Lives left: {LivesLeft}");
        }
    }
}
