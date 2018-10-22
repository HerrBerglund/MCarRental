using MCarRental.Data;
using MCarRental.Domain;

namespace MCarRental.BuissnessLogic
{
    public class CustomerService
    {
        private MCarRentalContext inputUserData = new MCarRentalContext();

        public void Add(Customer customer)
        {
            inputUserData.Customers.Add(customer);
            inputUserData.SaveChanges();
        }

        public void Change(Customer customer)
        {
            inputUserData.Customers.Update(customer);
            inputUserData.SaveChanges();
        }

        public void Remove(Customer customer)
        {
            inputUserData.Customers.Remove(customer);
            inputUserData.SaveChanges();
        }
    }
}