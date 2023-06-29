﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingService.Models;

namespace HotelBookingService.Services
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
