using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class RoomDAO
    {
        public static IEnumerable<RoomInformation> GetAll()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.RoomInformations.Include(r => r.RoomType).ToList();
            }
        }

        public static RoomInformation GetById(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.RoomInformations.Find(id);
            }
        }

        public static void Create(RoomInformation room)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                context.RoomInformations.Add(room);
                context.SaveChanges();
            }
        }

        public static void Update(RoomInformation room)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var existingRoom = context.RoomInformations.Find(room.RoomId);
                if (existingRoom != null)
                {
                    context.Entry(existingRoom).CurrentValues.SetValues(room);
                    context.SaveChanges();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var room = context.RoomInformations.Find(id);
                if (room != null)
                {
                    context.RoomInformations.Remove(room);
                    context.SaveChanges();
                }
            }
        }

        public static IEnumerable<RoomInformation> Search(string name)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                return context.RoomInformations.Where(r => r.RoomNumber.Contains(name)).ToList();
            }
        }
    }
}
