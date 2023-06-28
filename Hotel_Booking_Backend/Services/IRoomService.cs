using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Booking_Backend.DAO;
using Hotel_Booking_Backend.Models;

namespace Hotel_Booking_Backend.Services
{
    public class IRoomService
    {
        private readonly RoomDAO _roomDAO;

        public IRoomService(RoomDAO roomDAO)
        {
            _roomDAO = roomDAO;
        }

        public async Task<IEnumerable<Room>> GetRoomsByHotelId(int hotalId)
        {
            return await _roomDAO.GetRoomByHotalIdAsync(hotalId);
        }

        public async Task<Room> GetRoomByHotelIdAndRoomId(int hotalId, int roomId)
        {
            return await _roomDAO.GetRoomByHotelIdAndRoomId(hotalId, roomId);
        }

        public async Task<Room> AddRoomToHotel(int hotalId, Room room)
        {
            return await _roomDAO.AddRoomToHotel(hotalId, room);
        }

        public async Task UpdateRoomInHotel(int hotalId, Room room)
        {
            await _roomDAO.UpdateRoomInHotel(hotalId, room);
        }

        public async Task DeleteRoomFromHotel(int hotalId, int roomId)
        {
            await _roomDAO.DeleteRoomFromHotel(hotalId, roomId);
        }
    }
}
