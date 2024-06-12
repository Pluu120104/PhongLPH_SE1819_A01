using BussinessObject.Models;
using DataAccessLayer;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetAccountByEmail(string email)
            => CustomerDAO.GetAccountByEmail(email);

        public void CreateAccount(Customer customer)
            => CustomerDAO.CreateAccount(customer);

        public void UpdateAccount(Customer customer)
            => CustomerDAO.UpdateAccount(customer);
        public void DeleteAccount(int id)
            => CustomerDAO.DeleteAccount(id);
        public IEnumerable<Customer> GetAll()
            => CustomerDAO.GetAll();
        public Customer GetById(int id)
            => CustomerDAO.GetById(id);
    }
}
