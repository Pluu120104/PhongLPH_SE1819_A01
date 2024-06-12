using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class BookingReservationDAO
    {
        public static IEnumerable<BookingReservation> GetAll()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.BookingReservations
                              .Include(br => br.Customer)
                              .Include(br => br.BookingDetails)
                              .ToList();
            }
        }

        public static BookingReservation GetById(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.BookingReservations
                              .Include(br => br.Customer)
                              .Include(br => br.BookingDetails)
                              .FirstOrDefault(br => br.BookingReservationId == id);
            }
        }

        public static void Create(BookingReservation bookingReservation)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                context.BookingReservations.Add(bookingReservation);
                context.SaveChanges();
            }
        }

        public static void Update(BookingReservation bookingReservation)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var existingBookingReservation = context.BookingReservations.Find(bookingReservation.BookingReservationId);
                if (existingBookingReservation != null)
                {
                    context.Entry(existingBookingReservation).CurrentValues.SetValues(bookingReservation);
                    context.SaveChanges();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var bookingReservation = context.BookingReservations.Find(id);
                if (bookingReservation != null)
                {
                    context.BookingReservations.Remove(bookingReservation);
                    context.SaveChanges();
                }
            }
        }

        public static IEnumerable<BookingReservation> GetByCustomerId(int customerId)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.BookingReservations
                              .Where(br => br.CustomerId == customerId)
                              .Include(br => br.BookingDetails)
                              .ToList();
            }
        }
    }
}
