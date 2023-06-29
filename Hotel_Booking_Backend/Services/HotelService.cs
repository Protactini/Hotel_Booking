using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingService.Models;
using HotelBookingService.DAO;

namespace HotelBookingService.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelDAO _hotelDAO;

        public HotelService(IHotelDAO hotelDAO)
        {
            _hotelDAO = hotelDAO;
        }

        public async Task<IEnumerable<Hotel>> GetAllHotels()
        {
            return await _hotelDAO.GetAllHotels();
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            return await _hotelDAO.GetHotelById(id);
        }

        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            return await _hotelDAO.CreateHotel(hotel);
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            await _hotelDAO.UpdateHotel(hotel);
        }

        public async Task DeleteHotel(int id)
        {
            await _hotelDAO.DeleteHotel(id);
        }
    }
}
