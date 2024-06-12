using BussinessObject.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoomRepository : IRoomRepository
    {
        public void Create(RoomInformation room)
            =>RoomDAO.Create(room);
        public void Delete(int id)
            =>RoomDAO.Delete(id);
        public IEnumerable<RoomInformation> GetAll()
            =>RoomDAO.GetAll();
        public RoomInformation GetById(int id)
            =>RoomDAO.GetById(id);
        public IEnumerable<RoomInformation> Search(string name)
            =>RoomDAO.Search(name);
        public void Update(RoomInformation room)
            =>RoomDAO.Update(room);
    }
}
