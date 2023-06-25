using System;
using Hotel_Booking_Backend.Models;

namespace Hotel_Booking_Backend.Services;

public interface IBookingService
{
    IEnumerable<Booking> GetAll();
    // Other methods...

    Booking Get(int id);

    Booking Create(Booking booking);

    int Update(Booking booking);

    int Delete(int booking);
}
