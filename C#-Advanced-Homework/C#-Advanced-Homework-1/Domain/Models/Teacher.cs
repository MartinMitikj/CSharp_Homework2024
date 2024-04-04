

using Domain.Interface;

namespace Domain.Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; }
        public Teacher(int id, string name, string username, List<string> subjects) : base(id, name, username)
        {
            Subjects = subjects;
        }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine($"Number of subjects is : {Subjects.Count}");

        }
        public void PrintSubjects()
        {
            Console.WriteLine("Subjects:");
            foreach (string subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
