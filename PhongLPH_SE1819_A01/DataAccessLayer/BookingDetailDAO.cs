using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class BookingDetailDAO
    {
        public static IEnumerable<BookingDetail> GetAll()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.BookingDetails
                              .Include(bd => bd.RoomId)
                              .Include(bd => bd.BookingReservation)
                              .ToList();
            }
        }

        public static BookingDetail GetById(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.BookingDetails
                              .Include(bd => bd.RoomId)
                              .Include(bd => bd.BookingReservation)
                              .FirstOrDefault(bd => bd.BookingReservationId == id);
            }
        }

        public static void Create(BookingDetail bookingDetail)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                context.BookingDetails.Add(bookingDetail);
                context.SaveChanges();
            }
        }

        public static void Update(BookingDetail bookingDetail)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var existingBookingDetail = context.BookingDetails.Find(bookingDetail.BookingReservationId);
                if (existingBookingDetail != null)
                {
                    context.Entry(existingBookingDetail).CurrentValues.SetValues(bookingDetail);
                    context.SaveChanges();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var bookingDetail = context.BookingDetails.Find(id);
                if (bookingDetail != null)
                {
                    context.BookingDetails.Remove(bookingDetail);
                    context.SaveChanges();
                }
            }
        }
    }
}
