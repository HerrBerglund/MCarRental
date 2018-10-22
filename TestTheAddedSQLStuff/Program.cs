using MCarRental.BuissnessLogic;
using MCarRental.Domain;
using System;

namespace TestTheAddedSQLStuff
{
    internal class Program
    {
        private static void AddCarsToServer()
        {
            var car = new CarService();
            var inputCar = new Car();
            bool putMoreCarsIntoTheDatabase = true;
            string textFromUser = "";
            while (putMoreCarsIntoTheDatabase)

            {
                textFromUser = "";
                Console.WriteLine("Please type EXIT to stop entering cars to database now");
                textFromUser = Console.ReadLine();
                if (textFromUser == "EXIT")
                {
                    putMoreCarsIntoTheDatabase = false;
                }
                else
                {
                    Console.WriteLine("Please enter the car Brand\n");
                    inputCar.Brand = Console.ReadLine();
                    Console.WriteLine("Please enter the car register number\n");
                    inputCar.RegistrationNumber = Console.ReadLine();
                    Console.WriteLine("Please enter the car Brands version of car");
                    inputCar.Mark = Console.ReadLine();
                    Console.WriteLine("Please enter the car production year \n");
                }
            }
        }

        private static void Main(string[] args)
        {
            AddCarsToServer();
        }
    }
}