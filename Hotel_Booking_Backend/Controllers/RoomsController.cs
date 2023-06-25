using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hotel_Booking_Backend.Models;
using Hotel_Booking_Backend.Services;

namespace Hotel_Booking_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        //// GET: /rooms
        //[HttpGet]
        //public async Task<IEnumerable<Room>> GetAllRooms()
        //{
        //    return await _roomService.GetAllRooms();
        //}

        //// GET: /rooms/{id}
        //[HttpGet("{id}")]
        //public async Task<Room> GetRoomById(int id)
        //{
        //    return await _roomService.GetRoomById(id);
        //}

        //// POST: /rooms
        //[HttpPost]
        //public async Task<Room> CreateRoom([FromBody] Room room)
        //{
        //    return await _roomService.CreateRoom(room);
        //}

        //// PUT: /rooms
        //[HttpPut]
        //public async Task UpdateRoom([FromBody] Room room)
        //{
        //    await _roomService.UpdateRoom(room);
        //}

        //// DELETE: /rooms/{id}
        //[HttpDelete("{id}")]
        //public async Task DeleteRoom(int id)
        //{
        //    await _roomService.DeleteRoom(id);
        //}
    }
}
