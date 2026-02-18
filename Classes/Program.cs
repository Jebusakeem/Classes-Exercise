namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var wagon = new Cars();
            wagon.Make = "Volvo";
            wagon.Model = "XC60";
            wagon.Year = 2012;
            Console.WriteLine($"Hello, I drive a {wagon.Year} {wagon.Make} {wagon.Model}.");
        }
    }
}
