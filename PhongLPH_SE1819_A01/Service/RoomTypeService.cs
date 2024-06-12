using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeService iRoomTypeService;
        public RoomTypeService()
        {
            iRoomTypeService = new RoomTypeService();
        }
        public RoomType GetRoomType()
        {
            return iRoomTypeService.GetRoomType();
        }
    }
}
