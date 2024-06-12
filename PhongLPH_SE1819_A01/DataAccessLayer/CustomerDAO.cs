using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public static class CustomerDAO
    {
        public static IEnumerable<Customer> GetAll()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.Customers.ToList();
            }
        }

        public static Customer GetById(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.Customers.Find(id);
            }
        }

        public static void CreateAccount(Customer customer)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public static void UpdateAccount(Customer customer)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var existingCustomer = context.Customers.Find(customer.CustomerId);
                if (existingCustomer != null)
                {
                    context.Entry(existingCustomer).CurrentValues.SetValues(customer);
                    context.SaveChanges();
                }
            }
        }

        public static void DeleteAccount(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var customer = context.Customers.Find(id);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }
        }

        public static Customer GetAccountByEmail(string email)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.Customers.FirstOrDefault(c => c.EmailAddress == email);
            }
        }
    }
}
