using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace Repository
{
    public interface ICustomerRepository
    {
        Customer GetAccountByEmail (string email);
        void CreateAccount(Customer customer);
        void UpdateAccount(Customer customer);
        void DeleteAccount(int id);
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
    }
}
