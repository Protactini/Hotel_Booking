using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Booking_Backend.Models;
using Hotel_Booking_Backend.DAO;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_Backend.Services
{
    public class RoomDAO
    {
        private readonly HotelBookingContext _context;

        public RoomDAO(HotelBookingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetRoomByHotalIdAsync(int hotalId)
        {
            return await _context.Rooms.Where(r => r.HotelId == hotalId).ToListAsync();
        }

        public async Task<Room> GetRoomByHotelIdAndRoomId(int hotelId, int roomId)
        {
            Room? room = await _context.Rooms.FirstOrDefaultAsync(r => r.HotelId == hotelId && r.Id == roomId);
            return room;
        }

        public async Task<Room> AddRoomToHotel(int hotelId, Room room)
        {
            room.HotelId = hotelId;
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task UpdateRoomInHotel(int hotelId, Room room)
        {
            room.HotelId = hotelId;
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomFromHotel(int hotelId, int roomId)
        {
            var room = await _context.Rooms.FirstOrDefaultAsync(r => r.HotelId == hotelId && r.Id == roomId);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                await _context.SaveChangesAsync();
            }
        }
    }
}
