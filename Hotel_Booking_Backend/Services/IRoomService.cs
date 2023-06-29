﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingService.Models;

namespace HotelBookingService.Services
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAllRooms();
        Task<IEnumerable<Room>> GetRoomsByHotelId(int hotelId);
        Task<Room> GetRoomById(int id);
        Task<Room> CreateRoom(Room room);
        Task UpdateRoom(Room room);
        Task DeleteRoom(int id);
    }
}
