namespace Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Matt", "Beans");
            Console.WriteLine(cat.ExplainMyself());

        }
    }
}
