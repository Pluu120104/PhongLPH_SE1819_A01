using BussinessObject.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        public void Create(RoomType roomType)
            =>RoomTypeDAO.Create(roomType);

        public void Delete(int id)
            =>RoomTypeDAO.Delete(id);

        public IEnumerable<RoomType> GetAll()
            =>RoomTypeDAO.GetAll();

        public RoomType GetById(int id)
            =>RoomTypeDAO.GetById(id);

        public void Update(RoomType roomType)
            =>RoomTypeDAO.Update(roomType);
    }
}
