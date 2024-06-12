using BussinessObject.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        public void Create(BookingReservation bookingReservation)
            =>BookingReservationDAO.Create(bookingReservation);
        public void Delete(int id)
            =>BookingReservationDAO.Delete(id);
        public IEnumerable<BookingReservation> GetAll()
            =>BookingReservationDAO.GetAll();
        public IEnumerable<BookingReservation> GetByCustomerId(int customerId)
            =>BookingReservationDAO.GetByCustomerId(customerId);
        public BookingReservation GetById(int id)
            =>BookingReservationDAO.GetById(id);
        public void Update(BookingReservation bookingReservation)
            =>BookingReservationDAO.Update(bookingReservation);
    }
}
