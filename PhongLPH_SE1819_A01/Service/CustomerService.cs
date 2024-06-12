using BussinessObject.Models;
using Microsoft.Identity.Client;
using Repository;

namespace Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerService iCustomerService;
        public CustomerService()
        {
            iCustomerService = new CustomerService();
        }

        public void CreateAccount(Customer customer)
        {
            iCustomerService.CreateAccount(customer);
        }

        public void DeleteAccount(int id)
        {
            iCustomerService.DeleteAccount(id);
        }

        public Customer GetAccountByEmail(string email)
        {
            return iCustomerService.GetAccountByEmail(email);
        }

        public IEnumerable<Customer> GetAll()
        {
            return iCustomerService.GetAll();
        }

        public Customer GetById(int id)
        {
            return iCustomerService.GetById(id);
        }

        public void UpdateAccount(Customer customer)
        {
            iCustomerService.UpdateAccount(customer);
        }
    }
}
