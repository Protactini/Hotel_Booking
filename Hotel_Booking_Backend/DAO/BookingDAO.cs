using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Booking_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_Backend.DAO
{
    public class BookingDAO : IBookingDAO
    {
        private readonly HotelBookingContext _context;

        public BookingDAO(HotelBookingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            // retrieve all bookings from the database
            return await _context.Bookings.ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsByHotelId(int hotelId)
        {
            // retrieve a booking by ID from the database
            return await _content.Bookings;
        }

        public async Task<Booking> GetBookingById(int id)
        {
            // retrieve a booking by ID from the database
            return null;
        }

        public async Task<Booking> CreateBooking(Booking booking)
        {
            // add a new booking to the database
            return null;
        }

        public async Task UpdateBooking(Booking booking)
        {
            // update a booking in the database
        }

        public async Task DeleteBooking(int id)
        {
            // delete a booking from the database
        }
    }
}
