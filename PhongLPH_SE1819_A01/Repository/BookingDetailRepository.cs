using DataAccessLayer;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookingDetailRepository :IBookingDetailRepository 
    {
        public IEnumerable<BookingDetail> GetAll()
            =>BookingDetailDAO.GetAll();
        public BookingDetail GetById(int id)
            =>BookingDetailDAO.GetById(id);
        public void Create(BookingDetail bookingDetail)
            =>BookingDetailDAO.Create(bookingDetail);
        public void Update(BookingDetail bookingDetail)
            =>BookingDetailDAO.Update(bookingDetail);
        public void Delete(int id)
            =>BookingDetailDAO.Delete(id);
    }
}
