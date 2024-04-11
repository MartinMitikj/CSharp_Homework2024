


namespace Animal.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public Fish(string name, string type, int age,string color,int size) : base(name, type, age)
        {
            Size = size;
            Color = color;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name},Type: {Type},Age: {Age},Color: {Color},Size: {Size} cm");
        }
    }
}
