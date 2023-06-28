using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Booking_Backend.Models;
using Hotel_Booking_Backend.DAO;

namespace Hotel_Booking_Backend.Services
{
    public class RoomDAO
    {
        private readonly RoomDAO _roomDAO;

        public RoomDAO(RoomDAO roomDAO)
        {
            _roomDAO = roomDAO;
        }

        public async Task<IEnumerable<Room>> GetRoomByHotalIdAsync(int hotalId)
        {
            return await _roomDAO.GetRoomByHotalIdAsync(hotalId);
        }

        public async Task<Room> GetRoomByHotelIdAndRoomId(int hotelId, int roomId)
        {
            return await _roomDAO.GetRoomByHotelIdAndRoomId(hotelId, roomId);
        }

        public async Task<Room> AddRoomToHotel(int hotelId, Room room)
        {
            return await _roomDAO.AddRoomToHotel(hotelId, room);
        }

        public async Task UpdateRoomInHotel(int hotelId, Room room)
        {
            await _roomDAO.UpdateRoomInHotel(hotelId, room);
        }

        public async Task DeleteRoomFromHotel(int hotelId, int roomId)
        {
            await _roomDAO.DeleteRoomFromHotel(hotelId, roomId);
        }
    }
}
