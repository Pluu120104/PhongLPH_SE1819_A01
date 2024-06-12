using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRoomTypeRepository
    {
        IEnumerable<RoomType> GetAll();
        RoomType GetById(int id);
        public void Create(RoomType roomType);
        public void Update(RoomType roomType);
        public void Delete(int id);
    }
}
