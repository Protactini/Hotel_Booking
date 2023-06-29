using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Booking_Backend.Models;

namespace Hotel_Booking_Backend.DAO
{
    public interface IRoomDAO
    {
        Task<IEnumerable<Room>> GetRoomByHotalIdAsync(int hotalId);
        Task<Room> GetRoomByHotalIdAndRoomId(int hotalId, int roomId);
        Task<Room> CreateRoom(Room room);
        Task UpdateRoom(Room room);
        Task DeleteRoom(int hotalId, int roomId);
    }
}
