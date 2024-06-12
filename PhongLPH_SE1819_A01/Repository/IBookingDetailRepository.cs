using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBookingDetailRepository
    {
        IEnumerable<BookingDetail> GetAll();
        BookingDetail GetById(int id);
        void Create(BookingDetail bookingDetail);
        void Update(BookingDetail bookingDetail);
        void Delete(int id);
    }
}
