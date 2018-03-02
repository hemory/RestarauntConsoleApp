using System;

namespace RestaurantSampleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Restaurant obj = new Restaurant("Taco Bell", "123 Main Street", .15);

            Console.WriteLine("{0}", obj.Name );
            Console.WriteLine("{0}", obj.Address );

            obj.GenerateReceipt();
        }
    }
}
