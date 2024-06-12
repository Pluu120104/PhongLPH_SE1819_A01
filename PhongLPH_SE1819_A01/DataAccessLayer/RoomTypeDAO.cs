using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class RoomTypeDAO
    {
        public static IEnumerable<RoomType> GetAll()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.RoomTypes.ToList();
            }
        }

        public static RoomType GetById(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.RoomTypes.Find(id);
            }
        }

        public static void Create(RoomType roomType)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                context.RoomTypes.Add(roomType);
                context.SaveChanges();
            }
        }

        public static void Update(RoomType roomType)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var existingRoomType = context.RoomTypes.Find(roomType.RoomTypeId);
                if (existingRoomType != null)
                {
                    context.Entry(existingRoomType).CurrentValues.SetValues(roomType);
                    context.SaveChanges();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var roomType = context.RoomTypes.Find(id);
                if (roomType != null)
                {
                    context.RoomTypes.Remove(roomType);
                    context.SaveChanges();
                }
            }
        }
    }
}
