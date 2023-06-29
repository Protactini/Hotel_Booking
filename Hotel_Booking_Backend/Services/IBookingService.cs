using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_Booking_Backend.Models;

namespace Hotel_Booking_Backend.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetAllBookings();
        Task<Booking> GetBookingById(int id);
        Task<Booking> CreateBooking(Booking booking);
        Task<bool> UpdateBooking(Booking booking);
        Task<bool> DeleteBooking(int id);
    }
}
