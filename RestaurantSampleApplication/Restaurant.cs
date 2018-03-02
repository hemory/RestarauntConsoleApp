using System;

namespace RestaurantSampleApplication
{
    public class Restaurant
    {
        private string name;
        private string address;
        private double gratuityRate;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double GratuityRate
        {
            get { return gratuityRate; }
            set
            {
                if (value > 0)
                {
                    gratuityRate = value;
                }
            }
        }

        public Restaurant(string name, string address, double gratuityRate)
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityRate;
        }

        public void GenerateReceipt()
        {
            double price = 0;
            double subtotal = 0;
            double gratuityAmount = 0;
            double grandTotal = 0;
            int people = 0;


            while(price != -1)
            {
                subtotal = subtotal + price;
                Console.Write("Enter the price of the food item: {-1 to quit}");
                price = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("How many people are in your party?: ");
            people = Convert.ToInt32(Console.ReadLine());

            if (people >= 6)
            {
                gratuityAmount = subtotal * gratuityRate;
            }

            grandTotal = subtotal + gratuityAmount;

            Console.WriteLine("Subtotal: {0:C}", subtotal);
            Console.WriteLine("{0:P} Gratuity: {1:C}", gratuityRate, gratuityAmount);
            Console.WriteLine("Grand Total: {0:C}", grandTotal);

        }
    }
}
