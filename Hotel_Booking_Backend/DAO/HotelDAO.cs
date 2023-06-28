using System;
using System.Threading.Tasks;
using Hotel_Booking_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_Backend.DAO;


public class HotelDAO
{
    private readonly HotelBookingContext _context;

    public HotelDAO(HotelBookingContext context)
    {
        _context = context;
    }

    public async Task<List<Hotel>> GetAllHotelsAsync()
    {
        return await _context.Hotels.ToListAsync();
    }

    public async Task<Hotel> GetHotelByIdAsync(int id)
    {
        return await _context.Hotels.FindAsync(id);
    }

    public async Task<Hotel> AddHotelAsync(Hotel hotel)
    {
        System.Console.WriteLine("____`````____");
        _context.Hotels.Add(hotel);
        await _context.SaveChangesAsync();
        return hotel;
    }

    public async Task UpdateHotel(Hotel hotel)
    {
        _context.Entry(hotel).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteHotel(int id)
    {
        var hotel = await _context.Hotels.FindAsync(id);
        if (hotel != null)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }
    }

}

