namespace ParkingLotPricingSystem
{
    internal class Program
    {
        static string vehicleType;
        static int[] carPrice = { 5, 10, 20, 35 };
        static int[] motorcyclePrice = { 0, 3, 6, 12 };
        static int[] vanPrice = { 8, 16, 32, 45 };
        static int[] truckPrice = { 15, 30, 60, 100 };
        static int[] dailyPrice = { 20, 10, 25, 55 };
        static int price;
        static double hours;

        static void Main(string[] args)
        {
            MainMenu();
            VehicleTypeSelection();
            HoursEntry();
            PaymentCalculation();
        }

        static void MainMenu()
        {
            Console.WriteLine(" Please choose your vehicle type: ");
            Console.WriteLine(" Please press '1' for car. \n Please press '2' for motorcycle. \n Please press '3' for van. \n Please press '4' for truck and other heavy vehicles.");
        }

        static void VehicleTypeSelection()
        {
            vehicleType = Console.ReadLine();

            switch (vehicleType)
            {
                case "1":
                    Console.WriteLine("You have selected 'car' as vehicle type.");
                    break;

                case "2":
                    Console.WriteLine("You have selected 'motorcycle' as vehicle type");
                    break;

                case "3":
                    Console.WriteLine("You have selected 'van' as vehicle type");
                    break;

                case "4":
                    Console.WriteLine("You have selected 'truck or other heavy vehicles' as vehicle type");
                    break;

                default:
                    VehicleTypeSelection();
                    break;
            }
        }

        static void HoursEntry()
        {
            Console.WriteLine("How many hours did you stay at parking lot?");

            try
            {
                hours = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("You can not enter characters other than numbers!");
                HoursEntry();
            }
        }

        static void PaymentCalculation()
        {
            if (vehicleType == "1")
            {
                CarPaymentCalculation();
            }

            else if (vehicleType == "2")
            {
                MotorcyclePaymentCalculation();
            }

            else if (vehicleType == "3")
            {
                VanPaymentCalculation();
            }

            else if (vehicleType == "4")
            {
                TruckPaymentCalculation();
            }
        }

        static void CarPaymentCalculation()
        {
            if (hours > 0 && hours <= 2)
            {
                price = carPrice[0];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 2 && hours <= 6)
            {
                price = carPrice[1];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 6 && hours <= 12)
            {
                price = carPrice[2];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 12 && hours <= 24)
            {
                price = carPrice[3];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 24)
            {
                int day = Convert.ToInt32(Math.Floor(hours / 24));
                if (hours % 24 != 0)
                {
                    price = carPrice[3] + (day * dailyPrice[0]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }

                else
                {
                    price = carPrice[3] + ((day - 1) * dailyPrice[0]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }
            }
        }

        static void MotorcyclePaymentCalculation()
        {
            if (hours > 0 && hours <= 2)
            {
                price = motorcyclePrice[0];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 2 && hours <= 6)
            {
                price = motorcyclePrice[1];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 6 && hours <= 12)
            {
                price = motorcyclePrice[2];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 12 && hours <= 24)
            {
                price = motorcyclePrice[3];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 24)
            {
                int day = Convert.ToInt32(Math.Floor(hours / 24));
                if (hours % 24 != 0)
                {
                    price = motorcyclePrice[3] + (day * dailyPrice[1]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }

                else
                {
                    price = motorcyclePrice[3] + ((day - 1) * dailyPrice[1]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }
            }

        }

        static void VanPaymentCalculation()
        {
            if (hours > 0 && hours <= 2)
            {
                price = vanPrice[0];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 2 && hours <= 6)
            {
                price = vanPrice[1];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 6 && hours <= 12)
            {
                price = vanPrice[2];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 12 && hours <= 24)
            {
                price = vanPrice[3];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 24)
            {
                int day = Convert.ToInt32(Math.Floor(hours / 24));
                if (hours % 24 != 0)
                {
                    price = vanPrice[3] + (day * dailyPrice[2]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }

                else
                {
                    price = vanPrice[3] + ((day - 1) * dailyPrice[2]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }
            }
        }

        static void TruckPaymentCalculation()
        {
            if (hours > 0 && hours <= 2)
            {
                price = truckPrice[0];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 2 && hours <= 6)
            {
                price = truckPrice[1];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 6 && hours <= 12)
            {
                price = truckPrice[2];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 12 && hours <= 24)
            {
                price = truckPrice[3];
                Console.WriteLine("The amount you have to pay = {0:C2}", price);
            }

            else if (hours > 24)
            {
                int day = Convert.ToInt32(Math.Floor(hours / 24));
                if (hours % 24 != 0)
                {
                    price = truckPrice[3] + (day * dailyPrice[3]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }

                else
                {
                    price = truckPrice[3] + ((day - 1) * dailyPrice[3]);
                    Console.WriteLine("The amount you have to pay = {0:C2}", price);
                }
            }
        }
    }
}
