using MCarRental.Data;
using MCarRental.Domain;

namespace MCarRental.BuissnessLogic
{
    public class CarService
    {
        private MCarRentalContext inputUserData = new MCarRentalContext();

        public void Add(Car car)
        {
            inputUserData.Cars.Add(car);
            inputUserData.SaveChanges();
        }

        public void Remove(Car car)
        {
            inputUserData.Cars.Remove(car);
            inputUserData.SaveChanges();
        }
    }
}