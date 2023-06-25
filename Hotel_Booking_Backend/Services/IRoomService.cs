using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Booking_Backend.DAO;
using Hotel_Booking_Backend.Models;

namespace Hotel_Booking_Backend.Services
{
    public class RoomService
    {
        private readonly RoomDAO _roomDAO;

        public RoomService(RoomDAO roomDAO)
        {
            _roomDAO = roomDAO;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _roomDAO.GetAllRoomsAsync();
        }

        public async Task<Room> GetRoomById(int id)
        {
            return await _roomDAO.GetRoomByIdAsync(id);
        }

        public async Task<Room> CreateRoom(Room room)
        {
            return await _roomDAO.AddRoomAsync(room);
        }

        public async Task UpdateRoom(Room room)
        {
            await _roomDAO.UpdateRoom(room);
        }

        public async Task DeleteRoom(int id)
        {
            await _roomDAO.DeleteRoom(id);
        }
    }
}
