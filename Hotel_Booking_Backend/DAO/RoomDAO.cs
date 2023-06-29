using System.Collections.Generic;
using System.Threading.Tasks;
<<<<<<< HEAD
using HotelBookingService.Models;
using HotelBookingService.Data;

namespace HotelBookingService.DAO
{
    public class RoomDAO : IRoomDAO
    {
        private readonly ApplicationDbContext _context;

        public RoomDAO(ApplicationDbContext context)
=======
using Hotel_Booking_Backend.Models;
using Hotel_Booking_Backend.DAO;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_Backend.Services
{
    public class RoomDAO
    {
        private readonly HotelBookingContext _context;

        public RoomDAO(HotelBookingContext context)
>>>>>>> 2c8171b47e85fae5b6feb2a5032ec6870c9198f0
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetRoomByHotalIdAsync(int hotalId)
        {
<<<<<<< HEAD
            // Logic to retrieve all rooms from the database
=======
            return await _context.Rooms.Where(r => r.HotelId == hotalId).ToListAsync();
>>>>>>> 2c8171b47e85fae5b6feb2a5032ec6870c9198f0
        }

        public async Task<IEnumerable<Room>> GetRoomsByHotelId(int hotelId)
        {
<<<<<<< HEAD
            // Logic to retrieve rooms by hotel ID from the database
=======
            Room? room = await _context.Rooms.FirstOrDefaultAsync(r => r.HotelId == hotelId && r.Id == roomId);
            return room;
>>>>>>> 2c8171b47e85fae5b6feb2a5032ec6870c9198f0
        }

        public async Task<Room> GetRoomById(int id)
        {
<<<<<<< HEAD
            // Logic to retrieve a room by ID from the database
=======
            room.HotelId = hotelId;
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
>>>>>>> 2c8171b47e85fae5b6feb2a5032ec6870c9198f0
        }

        public async Task<Room> CreateRoom(Room room)
        {
<<<<<<< HEAD
            // Logic to add a new room to the database
=======
            room.HotelId = hotelId;
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
>>>>>>> 2c8171b47e85fae5b6feb2a5032ec6870c9198f0
        }

        public async Task UpdateRoom(Room room)
        {
<<<<<<< HEAD
            // Logic to update a room in the database
        }

        public async Task DeleteRoom(int id)
        {
            // Logic to delete a room from the database
=======
            var room = await _context.Rooms.FirstOrDefaultAsync(r => r.HotelId == hotelId && r.Id == roomId);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                await _context.SaveChangesAsync();
            }
>>>>>>> 2c8171b47e85fae5b6feb2a5032ec6870c9198f0
        }
    }
}
