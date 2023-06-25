using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingService.Models;
using HotelBookingService.DAO;

namespace HotelBookingService.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomDAO _roomDAO;

        public RoomService(IRoomDAO roomDAO)
        {
            _roomDAO = roomDAO;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _roomDAO.GetAllRooms();
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
