using System;
using Hotel_Booking_Backend.Models;
using Hotel_Booking_Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingsController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingsController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    // GET: api/bookings
    [HttpGet]
    public IEnumerable<Booking> GetBookings()
    {
        return _bookingService.GetAll();
    }

    // GET: api/bookings/{id}
    [HttpGet("{id}")]
    public ActionResult<Booking> GetBooking(int id)
    {
        var booking = _bookingService.Get(id);

        if (booking == null)
        {
            return NotFound();
        }

        return booking;
    }

    // POST: api/bookings
    [HttpPost]
    public ActionResult<Booking> PostBooking(Booking booking)
    {
        _bookingService.Create(booking);

        return CreatedAtAction(nameof(GetBooking), new { id = booking.Id }, booking);
    }

    // PUT: api/bookings/{id}
    [HttpPut("{id}")]
    public IActionResult PutBooking(int id, Booking booking)
    {
        if (id != booking.Id)
        {
            return BadRequest();
        }

        _bookingService.Update(booking);

        return NoContent();
    }

    // DELETE: api/bookings/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteBooking(int id)
    {
        _bookingService.Delete(id);

        return NoContent();
    }
}
