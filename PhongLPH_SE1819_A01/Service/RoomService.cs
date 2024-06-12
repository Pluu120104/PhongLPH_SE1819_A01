using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomService iRoomService;
        public RoomService()
        {
            iRoomService = new RoomService();
        }
        public RoomInformation GetRoomInformation()
        {
            return iRoomService.GetRoomInformation();
        }
    }
}
