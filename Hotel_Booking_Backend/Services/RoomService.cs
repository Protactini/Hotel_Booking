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

        public async Task<IEnumerable<Room>> GetRoomsByHotelId(int hotelId)
        {
            return await _roomDAO.GetRoomsByHotelId(hotelId);
        }

        public async Task<Room> GetRoomById(int id)
        {
            return await _roomDAO.GetRoomById(id);
        }

        public async Task<Room> CreateRoom(Room room)
        {
            return await _roomDAO.CreateRoom(room);
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
