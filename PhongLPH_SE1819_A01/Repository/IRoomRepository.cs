using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using DataAccessLayer;

namespace Repository
{
    public interface IRoomRepository
    {
        IEnumerable<RoomInformation> GetAll();
        RoomInformation GetById(int id);
        public void Create(RoomInformation room);
        public void Update(RoomInformation room);
        public void Delete(int id);
        IEnumerable<RoomInformation> Search(string name);
    }
}
