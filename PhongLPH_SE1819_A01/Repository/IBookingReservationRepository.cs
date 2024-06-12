using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using DataAccessLayer;

namespace Repository
{
    public interface IBookingReservationRepository
    {
        IEnumerable<BookingReservation> GetAll();
        BookingReservation GetById(int id);
        public void Create(BookingReservation bookingReservation);
        public void Update(BookingReservation bookingReservation);
        public void Delete(int id);
        IEnumerable<BookingReservation> GetByCustomerId(int customerId);
    }
}
