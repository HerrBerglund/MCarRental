using MCarRental.Data;
using MCarRental.Domain;

namespace MCarRental.BuissnessLogic
{
    public class CarService
    {
        private MCarRentalContext inputUserData = new MCarRentalContext();

        public void Add(string brand, string model, int year, string registrationNumber)
        {
            Car car = new Car();
            car.Brand = brand;
            car.Model = model;
            car.Year = year;
            car.RegistrationNumber = registrationNumber;
            car.IsReturned = true;
            inputUserData.Cars.Add(car);
            inputUserData.SaveChanges();
        }

        /*
           public bool Remove(string carRegistrationNumber)
           {
               Car car = inputUserData.Find<Car>.

               inputUserData.Cars.Remove(car);
               inputUserData.SaveChanges();
           }
       */
    }
}