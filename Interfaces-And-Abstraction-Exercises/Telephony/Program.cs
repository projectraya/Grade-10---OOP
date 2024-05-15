namespace Interfaces_And_Abstraction_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            string[] urls = Console.ReadLine().Split().ToArray();
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationary = new StationaryPhone();

            foreach(string number in numbers)
            {
                if (number.Length == 7)
                {
                    stationary.PrintCalledNumber(number);
                }
                else if (number.Length == 10)
                {
                    smartphone.PrintCalledNumber(number);
                }
            }
            
            foreach(string url in urls)
            {
                smartphone.Browsing(url);
            }
            
            
        }
        
    }
}
