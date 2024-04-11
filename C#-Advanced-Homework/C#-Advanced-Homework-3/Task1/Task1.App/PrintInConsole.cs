

namespace Print.Domain
{
    public class PrintInConsole<T>
    {
        public void Print(T item)
        {
            Console.WriteLine(item);
        }
        public void PrintCollection(List<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
