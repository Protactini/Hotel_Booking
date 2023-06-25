using System;
using Hotel_Booking_Backend.DAO;
using Hotel_Booking_Backend.Models;

namespace Hotel_Booking_Backend.Services;

//public interface IHotelService
//{
//    Task<IEnumerable<Hotel>> GetAllHotels();
//    Task<Hotel> GetHotelById(int id);
//    Task<Hotel> CreateHotel(Hotel hotel);
//    Task UpdateHotel(Hotel hotel);
//    Task DeleteHotel(int id);
//}

public class HotelService
{ 
    private readonly HotelDAO _hotelDAO;

    public HotelService(HotelDAO hotelDAO)
    {
        _hotelDAO = hotelDAO;
    }

    public async Task<IEnumerable<Hotel>> GetAllHotels()
    {
        return await _hotelDAO.GetAllHotelsAsync();
    }

    public async Task<Hotel> GetHotelById(int id)
    {
        return await _hotelDAO.GetHotelByIdAsync(id);
    }

    public async Task<Hotel> CreateHotel(Hotel hotel)
    {
        System.Console.WriteLine("____`````____");
        return await _hotelDAO.AddHotelAsync(hotel);
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