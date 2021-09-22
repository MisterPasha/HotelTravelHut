using System;
using System.Globalization;

namespace HomeWork_TravelHut
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine("Welcome to Travel Hut Hotel!\nPlease enter a day which you'd like to see a price for (MO, TU, WE, TH, FR, SA, SU)");
            string weekDay = myTI.ToUpper(Console.ReadLine());
            Console.WriteLine("Please enter 'D' for Double Room or 'F' for Family Room");
            string roomType = myTI.ToUpper(Console.ReadLine());
            Console.WriteLine("Please enter number of rooms you want to book");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
            double price = 0;

            if (weekDay == "MO" || weekDay == "SU")
            {
                price = 60;
                if (roomType == "F")
                {
                    price = 99;
                }
            }
            else if (weekDay == "TU" || weekDay == "WE" || weekDay == "TH")
            {
                price = 40;
                if (roomType == "F")
                {
                    price = 49;
                }
            }
            else if (weekDay == "FR" || weekDay == "SA")
            {
                price = 90;
                if (roomType == "F")
                {
                    price = 179;
                }
            }
            else
            {
                Console.WriteLine("You entered a wrong character, try again");
            }

            double totalPrice = price * roomNumber;
            double priceAfterDiscount = totalPrice - totalPrice * 0.1;
            double discount = totalPrice - priceAfterDiscount;

            if (roomNumber > 1)
            {
                Console.WriteLine($"Price per room is £{price}\n" +
                $"Total price before discount is £{totalPrice}\n" +
                $"The amount of the discount is £{discount:0.00}\n" +
                $"The total price after discount is £{priceAfterDiscount:0.00}");
            }
            else
            {
                Console.WriteLine($"Price for your room is {price}");
            }
        }
    }
}
